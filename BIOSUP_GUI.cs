﻿using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace BiosupCS
{
    public partial class BIOSUP_GUI : Form
    {
        String str_working_dir;
        private String str_database_credentials = "Server=tcp:biosup.database.windows.net,1433;Initial Catalog=firmware-info;Persist Security Info=False;User ID=jaycar-root;Password=F^e36d3f7d^Ukiozp@kp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        List<String> list_chipset_vendor = new List<String>() { "AMD", "INTEL" };
        List<String> list_points = new List<String>() { "Downloading", "Unzipping","Other" };
        //Order is important for method set_how_much_to_dl
        List<String> list_what_to_download= new List<String>() { "Latest Only", "Bridge + Latest", "All","Bridge Only" };
        Boolean bool_select_all = false;
        BIOSUP_SQL Biosup_query;
        BIOSUP_UNZIP OBJ_UNZIP;
        BIOSUP_DL_FILE OBJ_DL_FILE;
        BIOSUP_RM_FILE OBJ_RM_FILE;
        public BIOSUP_GUI()
        {
            InitializeComponent();
            Biosup_query = new BIOSUP_SQL(this.str_database_credentials);
            OBJ_UNZIP = new BIOSUP_UNZIP();
            OBJ_DL_FILE = new BIOSUP_DL_FILE(progressBar_current_progress);
            OBJ_RM_FILE = new BIOSUP_RM_FILE();

        }

        private void BIOSUP_CONFIG_Load(object sender, EventArgs e)
        {

            DataTable Biosup_query_vendors = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.vendor_data");
            DataTable Biosup_query_chipsets = Biosup_query.BIOSUP_SQL_GET("SELECT chipset_name, chipset_vendor FROM dbo.chipset_check");
            DataTable Biosup_query_model = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.motherboard_data");

            str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("CWD: " + str_working_dir + "\n");
            toolStripStatusLabel_cwd.Text = "CWD: " + str_working_dir;
            textBox_log_config.AppendText("CWD: " + str_working_dir);

            if (!File.Exists(str_working_dir + "key.txt"))
            {
                tab_control.TabPages.Remove(tabPage_admin);
            }

            BIOSUP_CONFIG_LOAD_INTRUCTIONS();

            
            foreach(String str_string in list_what_to_download)
            {
                Invoke(new Action(() => comboBox_what_to_get.Items.Add(str_string)));
            }

            Application.DoEvents();
            try
            {
                comboBox_select_chipset_to_remove.Items.Clear();
                listbox_vendor.Items.Clear();
                comboBox_select_vendor.Items.Clear();
                comboBox_select_vendor_to_edit.Items.Clear();
                comboBox_admin_url_vendor.Items.Clear();
                comboBox_select_chipset.Items.Clear();
                comboBox_admin_url_chipset.Items.Clear();
                comboBox_select_chipset_to_remove.Items.Clear();
                listbox_AMD_chipset.Items.Clear();
                listbox_INTEL_chipset.Items.Clear();
                comboBox_admin_chipset_vendor.Items.Clear();
                comboBox_admin_model_delete.Items.Clear();

                foreach (DataRow row in Biosup_query_model.Rows)
                {
                    Invoke(new Action(() => comboBox_admin_model_delete.Items.Add(row["model_name"]))); 
                }

                textBox_log_config.AppendText("\r\n Vendors Found:");
                foreach (DataRow row in Biosup_query_vendors.Rows)
                {
                    textBox_log_config.AppendText("\n\r" + row["vendor_name"] + "...");
                    Invoke(new Action(() => listbox_vendor.Items.Add(row["vendor_name"])));
                    Invoke(new Action(() => comboBox_select_vendor.Items.Add(row["vendor_name"])));
                    Invoke(new Action(() => comboBox_select_vendor_to_edit.Items.Add(row["vendor_name"])));
                    Invoke(new Action(() => comboBox_admin_url_vendor.Items.Add(row["vendor_name"])));
                }

                textBox_log_config.AppendText("\r\n Chipsets Found:");
                foreach (DataRow row in Biosup_query_chipsets.Rows)
                {
                    textBox_log_config.AppendText("\n\r" + row["chipset_vendor"] + ", " + row["chipset_name"] + "...");
                    Invoke(new Action(() => comboBox_select_chipset.Items.Add(row["chipset_name"])));
                    Invoke(new Action(() => comboBox_admin_url_chipset.Items.Add(row["chipset_name"])));
                    Invoke(new Action(() => comboBox_select_chipset_to_remove.Items.Add(row["chipset_name"])));

                    //Need to update below to better method    
                    if (row["chipset_vendor"].ToString() == list_chipset_vendor[0])
                    {
                        Invoke(new Action(() => listbox_AMD_chipset.Items.Add(row["chipset_name"])));
                    }
                    else if (row["chipset_vendor"].ToString() == list_chipset_vendor[1])
                    {
                        Invoke(new Action(() => listbox_INTEL_chipset.Items.Add(row["chipset_name"])));
                    }
                    else
                    {
                        textBox_log_config.AppendText("Error Sorting!");
                    }

                }
                foreach (String str_vendor in list_chipset_vendor)
                {
                    Invoke(new Action(() => comboBox_admin_chipset_vendor.Items.Add(str_vendor)));
                }

            }
            catch (Exception e2)
            {
                textBox_log_config.AppendText(e2.ToString());
            }

        }

        private String set_how_much_to_dl(int int_option)
        {
            //textBox_log_running.AppendText("case: " + int_option);
            switch (int_option)
            {
                case 0:
                    return " WHERE (mu.url_date_of_bios IN (SELECT MAX(mu.url_date_of_bios) AS 'Latest' FROM motherboard_url mu Group By mu.model_id) AND";
                case 1:
                    return " WHERE (((mu.url_bridge = 'Y') OR (mu.url_date_of_bios IN (SELECT MAX(mu.url_date_of_bios) AS 'Latest' FROM motherboard_url mu Group By mu.model_id))) AND ";
                case 2:
                    return " WHERE (";
                case 3:
                    return " WHERE ((mu.url_bridge = 'Y') AND ";
                default:
                    return "ERROR";
            }
        }

        private String queryBuilder()
        {
            String str_built_query = "Select * FROM motherboard_url mu INNER JOIN motherboard_data md ON mu.model_id = md.model_id INNER JOIN vendor_data vd ON md.vendor_id = vd.vendor_id";

            str_built_query += set_how_much_to_dl(comboBox_what_to_get.SelectedIndex);

            Application.DoEvents();

            str_built_query += "(vd.vendor_name in (";
            for (int i = 0; i < this.listbox_vendor.CheckedItems.Count; i++)
            {
                textBox_log_running.AppendText("\r\nIncluding All: " + this.listbox_vendor.CheckedItems[i].ToString());
                String str_addon = "'" + this.listbox_vendor.CheckedItems[i].ToString() + "'";
                if (i != this.listbox_vendor.CheckedItems.Count-1)
                {
                    str_addon += ",";
                }
                str_built_query += str_addon;
            }
            str_built_query += ")) AND (md.chipset in (";
            for (int i = 0; i < this.listbox_AMD_chipset.CheckedItems.Count; i++)
            {
                textBox_log_running.AppendText("\r\nIncluding All: " + this.listbox_AMD_chipset.CheckedItems[i].ToString());
                String str_addon = "'" + this.listbox_AMD_chipset.CheckedItems[i].ToString() + "'";
                if (i != this.listbox_AMD_chipset.CheckedItems.Count-1)
                {
                    str_addon += ",";
                }
                str_built_query += str_addon;
            }

            for (int i = 0; i < this.listbox_INTEL_chipset.CheckedItems.Count; i++)
            {
                textBox_log_running.AppendText("\r\nIncluding All: " + this.listbox_INTEL_chipset.CheckedItems[i].ToString());
                String str_addon = "'" + this.listbox_INTEL_chipset.CheckedItems[i].ToString() + "'";
                if (i != this.listbox_INTEL_chipset.CheckedItems.Count - 1)
                {
                    str_addon += ",";
                }
                str_built_query += str_addon;

            }
            str_built_query += ",'')));";
            return str_built_query;
        }
        private void btn_run_Click(object sender, EventArgs e)
        {
            if (comboBox_what_to_get.Text == "")
            {
                MessageBox.Show("Please Select a 'What to get'");
                
            }
            else
            {
                String BIOSHERE = str_working_dir + "BIOSHERE";
                tab_control.SelectedTab = tabPage_Current_Run;
                if (!Directory.Exists(BIOSHERE))
                {
                    System.IO.Directory.CreateDirectory(BIOSHERE);
                    textBox_log_running.AppendText("Directory Created: ../BIOSHERE/\r\n");
                }
                else
                {
                    textBox_log_running.AppendText("Directory Already Exists: ../BIOSHERE/\r\n");
                }

                textBox_log_running.AppendText("What to collect: " + comboBox_what_to_get.SelectedItem);


                Application.DoEvents();

                DataTable Biosup_query_urls = Biosup_query.BIOSUP_SQL_GET(queryBuilder());

                try
                {
                    foreach (DataRow row in Biosup_query_urls.Rows)
                    {
                        textBox_log_running.AppendText("\r\n" + row["model_name"] + "\r\n" + row["url_date_of_bios"] + "\r\n");
                    }
                    loop_through(Biosup_query_urls);
                }
                catch (System.NullReferenceException)
                {
                    textBox_log_running.AppendText("\r\n No Bios/UEFI found, please try a different selection of chipsets");
                }
                catch (Exception e5)
                {
                    textBox_log_running.AppendText(e5.ToString());
                }
            }
            


        }
         void loop_through(DataTable Biosup_query_urls)
        {
            int int_count_mobo = Biosup_query_urls.Rows.Count;
            int int_progress = 0;
            progressBar_overall_progress.Maximum = int_count_mobo;
            progressBar_overall_progress.Value = int_progress;
            if (Biosup_query_urls.Rows.Count != 0)
            {
                foreach (DataRow row in Biosup_query_urls.Rows)
                {
                    int_progress++;
                    label_current_progress_fraction.Text = int_progress + "/" + int_count_mobo;
                    progressBar_overall_progress.Value = int_progress;
                    progressBar_current_progress.Value = int_progress;

                    textBox_log_running.AppendText("\n\r--------------------URL--------------------\r\n");
                    textBox_current_UEFI_info.Text = "";
                    current_mobo(row);
                    textBox_log_running.AppendText(row["model_name"] + "\r\n" + row["url_str"]);
                    change_point(list_points[0]);
                    String str_filetree = "BIOSHERE/" + row["vendor_name"] + "/" + row["chipset"] + "/" + row["model_name"];
                    String str_file_path = str_filetree + "/" + row["vendor_name"] + "-" + row["model_name"] + ".zip";
                    textBox_log_running.AppendText("\r\n" + row["url_date_of_bios"]);
                    FileInfo FI_file_path = new FileInfo(str_file_path);

                    if (!File.Exists(str_filetree))
                    {
                        System.IO.Directory.CreateDirectory(str_filetree);
                    }
                    OBJ_DL_FILE.DL_FILE(row["url_str"].ToString(), str_file_path);

                    Boolean bool_wait_for_file_freed = true;

                    while (bool_wait_for_file_freed)
                    {
                        if (!IsFileLocked(FI_file_path))
                        {
                            change_point(list_points[1]);
                            textBox_log_running.AppendText("\r\nUnzipping...");
                            Application.DoEvents();
                            OBJ_UNZIP.unzip(str_file_path, str_working_dir + str_filetree);
                            change_point(list_points[2]);
                            textBox_log_running.AppendText("\r\nDeleting Zip...");
                            Application.DoEvents();
                            OBJ_RM_FILE.remove(str_file_path);
                            break;
                        }
                        else
                        {
                            Thread.Sleep(100);
                            Application.DoEvents();
                        }

                    }
                    textBox_log_running.AppendText("\r\nMoving to Next UEFI/BIOS...\r\n");


                }
                MessageBox.Show("All Firmware have been attempted.\r\nPlease close Biosup");

            }
            else
            {
                MessageBox.Show("Error!\r\nPlease see Log for Issue");
                textBox_log_running.AppendText("\r\n No Bios/UEFI found, please select Some from the config menu");
                textBox_log_config.AppendText("\r\n No Bios/UEFI found, please select Some from the config menu");
            }
           
        }
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
        private void change_point(String str_point)
        {
            label_current_point.Text = "Current Point: " + str_point;
        }
        private void current_mobo(DataRow row)
        {
            textBox_current_UEFI_info.AppendText("Model:\r\n" + row["model_name"]);
            textBox_current_UEFI_info.AppendText("\r\n\r\nVendor:\r\n" + row["vendor_name"]);
            textBox_current_UEFI_info.AppendText("\r\n\r\nChipset:\r\n" + row["chipset"]);
            textBox_current_UEFI_info.AppendText("\r\n\r\nDate of Bios/UEFI:\r\n" + row["url_date_of_bios"]);
            textBox_current_UEFI_info.AppendText("\r\n\r\nBridge:\r\n" + row["url_bridge"]);
            textBox_current_UEFI_info.AppendText("\r\n\r\nUEFI URL:\r\n" + row["url_str"]);
            textBox_current_UEFI_info.AppendText("\r\n\r\nDate Added:\r\n" + row["url_date_collected"]);
        }
        private void BIOSUP_CONFIG_LOAD_INTRUCTIONS()
        {
            textBox_instructions.AppendText("1. Select the Chipsets/vendors\r\n");
            textBox_instructions.AppendText("\r\n2. Click the 'Run' Button\r\n");
            textBox_instructions.AppendText("\r\n3. Wait until all UEFI have downloaded(you can do other things in this time)\r\n");
            textBox_instructions.AppendText("\r\n4. Close the GUI\r\n");
        }

        private void btn_select_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bool_select_all)
                {
                    method_bool_select_all(true);
                    btn_select_all.Text = "Deselect All";
                    bool_select_all = true;
                }
                else
                {
                    method_bool_select_all(false);
                    btn_select_all.Text = "Select All";
                    bool_select_all = false;
                }
                
            }
            catch(Exception e3)
            {
                textBox_log_config.AppendText(e3.ToString());
            }


        }

        private void method_bool_select_all(Boolean bool_set_bool)
        {
            checkBox_all_vendors.Checked = bool_set_bool;
            for (int i = 0; i < listbox_vendor.Items.Count; i++)
            {
                listbox_vendor.SetItemChecked(i, bool_set_bool);
            }
            checkBox_AMD_select_all.Checked = bool_set_bool;
            for (int i = 0; i < listbox_AMD_chipset.Items.Count; i++)
            {
                listbox_AMD_chipset.SetItemChecked(i, bool_set_bool);
            }
            checkBox_vendor_select_all.Checked = bool_set_bool;
            for (int i = 0; i < listbox_INTEL_chipset.Items.Count; i++)
            {
                listbox_INTEL_chipset.SetItemChecked(i, bool_set_bool);
            }
        }


        private void btn_clear_config_Click(object sender, EventArgs e)
        {
            method_bool_select_all(false);
        }

        private void btn_load_last_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_intel_select_all_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox_INTEL_chipset.Items.Count; i++)
            {
                listbox_INTEL_chipset.SetItemChecked(i, checkBox_vendor_select_all.Checked);
            }
        }

        private void checkBox_AMD_select_all_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox_AMD_chipset.Items.Count; i++)
            {
                listbox_AMD_chipset.SetItemChecked(i, checkBox_AMD_select_all.Checked);
            }
        }

        private void checkBox_all_vendors_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox_vendor.Items.Count; i++)
            {
                listbox_vendor.SetItemChecked(i, checkBox_all_vendors.Checked);
            }
        }

        private void btn_get_model_from_database_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < numericUpDown_admin_url_url_to_add.Value; i++)
            {
                flowLayoutPanel_add_url_str.Controls.Add(new biosup_multi_url_add { Parent = flowLayoutPanel_add_url_str });
            }
        }

        private void btn_add_chipset_Click(object sender, EventArgs e)
        {
            if(textBox_admin_chipset_name.Text == "" || comboBox_admin_chipset_vendor.SelectedIndex == -1)
            {
                textBox_admin_log.AppendText("Please make sure Both UI elements have values");
            }
            else
            {
                String str_query_var = "Variables: " + textBox_admin_chipset_name.Text + "," + comboBox_admin_chipset_vendor.SelectedItem;
                textBox_admin_log.AppendText(str_query_var);
                String str_query = "INSERT INTO dbo.chipset_check(chipset_id,chipset_name,chipset_vendor) VALUES(NEXT VALUE FOR seq_chipset_id, '"+ textBox_admin_chipset_name.Text + "','"+ comboBox_admin_chipset_vendor.SelectedItem + "');" ;
                try
                {
                    Biosup_query.BIOSUP_SQL_GET(str_query);
                    textBox_admin_log.AppendText(" Added Successfully");
                    BIOSUP_CONFIG_Load(sender, e);
                    /*List<SQL_Params> list_parameter = new List<SQL_Params>();
                    SQL_Params obj_paramater_chipset = new SQL_Params("@a_chipset_name", SqlDbType.VarChar, 10, textBox_admin_chipset_name.Text);
                    SQL_Params obj_paramater_vendor = new SQL_Params("@a_chipset_vendor", SqlDbType.VarChar, 10, textBox_admin_chipset_name.Text.ToString());
                    list_parameter.Add(obj_paramater_chipset);
                    list_parameter.Add(obj_paramater_vendor);
                    Biosup_query.BIOSUP_SQL_SET("ADD_CHIPSET", list_parameter);
                    */

                }
                catch (Exception e_run)
                {
                    textBox_admin_log.AppendText( e_run.ToString());
                }
                textBox_admin_chipset_name.Text = "";
                comboBox_admin_chipset_vendor.SelectedIndex = -1;
            }


        }

        private void comboBox_admin_url_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str_vendor = comboBox_admin_url_vendor.Text;
            comboBox_select_model.Items.Clear();
            try
            {
                DataTable Biosup_query_vendor = Biosup_query.BIOSUP_SQL_GET("SELECT vendor_id FROM dbo.vendor_data where vendor_name ='" + str_vendor + "';");

                DataTable Biosup_query_model = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.motherboard_data where vendor_id = " + Biosup_query_vendor.Rows[0]["vendor_id"]);
                foreach (DataRow row in Biosup_query_model.Rows)
                {
                    Invoke(new Action(() => comboBox_select_model.Items.Add(row["model_name"])));
                }
            }
            catch
            {
                textBox_admin_log.AppendText("No Model Found");
            }

        }

        private void comboBox_admin_url_chipset_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str_vendor = comboBox_admin_url_vendor.Text;
            String str_chipset = comboBox_admin_url_chipset.Text;
            comboBox_select_model.Items.Clear();
            try
            {
                DataTable Biosup_query_vendor = Biosup_query.BIOSUP_SQL_GET("SELECT vendor_id FROM dbo.vendor_data where vendor_name ='" + str_vendor + "';");

                DataTable Biosup_query_model = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.motherboard_data where vendor_id = " + Biosup_query_vendor.Rows[0]["vendor_id"] + " AND chipset = '" + str_chipset + "';");
                foreach (DataRow row in Biosup_query_model.Rows)
                {
                    Invoke(new Action(() => comboBox_select_model.Items.Add(row["model_name"])));
                }
            }
            catch
            {
                textBox_admin_log.AppendText("No Model Found");
            }

        }

        private void comboBox_select_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String str_model = comboBox_select_model.Text;
                DataTable Biosup_query_model = Biosup_query.BIOSUP_SQL_GET("SELECT model_id FROM dbo.motherboard_data where model_name = '" + str_model + "';");
                DataTable Biosup_query_url = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.motherboard_url where model_id = " + Biosup_query_model.Rows[0]["model_id"] + ";");
                DataRow row = Biosup_query_model.Rows[0];
                flowLayoutPanel_admin_url_edit.Controls.Add(new biosup_multi_url_add { Parent = flowLayoutPanel_add_url_str });
                flowLayoutPanel_admin_url_edit.Controls[0].Controls["textBox_str_admin_url_multi_add"].Text = row["url_str"].ToString();
                flowLayoutPanel_admin_url_edit.Controls[0].Controls["comboBox_bridge_select"].Text = row["url_bridge"].ToString();
                // flowLayoutPanel_admin_url_edit.Controls[i].Controls["dateTimePicker1"] = row["url_date_of_bios"];
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText(e_run.ToString());
            }

        }

        private void button_remvoe_chipset_Click(object sender, EventArgs e)
        {
            String str_chipset_to_remove = comboBox_select_chipset_to_remove.Text;
            String str_query = "DELETE FROM dbo.chipset_check WHERE chipset_name ='"+str_chipset_to_remove+"'";
            Console.WriteLine(str_query);
            try
            {
                Biosup_query.BIOSUP_SQL_GET(str_query);
                textBox_admin_log.AppendText(str_chipset_to_remove + " Deleted Successfully");
                BIOSUP_CONFIG_Load(sender, e);
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText(e_run.ToString());
            }

        }

        private void btn_add_model_Click(object sender, EventArgs e)
        {
            String str_chipset = comboBox_select_chipset.Text;
            String str_vendor = comboBox_select_vendor.Text;
            String str_model_sku = textBox_admin_model_sku.Text;
            String str_bios_url = textBox_model_bios_url.Text;
            DataTable Biosup_query_vendor = Biosup_query.BIOSUP_SQL_GET("SELECT vendor_id FROM dbo.vendor_data where vendor_name ='" + str_vendor+"';");


            String str_query = "INSERT INTO dbo.motherboard_data(model_id, chipset, model_name, vendor_id, model_page) VALUES(NEXT VALUE FOR seq_model_id, '"+str_chipset + "','"+ str_model_sku + "','" + Biosup_query_vendor.Rows[0]["vendor_id"] + "','" + str_bios_url + "');";
            textBox_admin_log.AppendText(str_query);
            try
            {
                Biosup_query.BIOSUP_SQL_GET(str_query);
                textBox_admin_log.AppendText(str_model_sku + " Added Successfully");
                BIOSUP_CONFIG_Load(sender, e);
                textBox_admin_model_sku.Text = "";
                textBox_model_bios_url.Text = "";
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText(e_run.ToString());
            }

        }

        private void btn_delete_model_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This action will delete all associated BIOS","",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                String str_model_to_remove = comboBox_admin_model_delete.Text;
                String str_query = "DELETE FROM dbo.motherboard_data WHERE model_name ='" + str_model_to_remove + "'";
                Console.WriteLine(str_query);
                try
                {
                    Biosup_query.BIOSUP_SQL_GET(str_query);
                    textBox_admin_log.AppendText(str_model_to_remove + " Deleted Successfully");
                    BIOSUP_CONFIG_Load(sender, e);
                }
                catch (Exception e_run)
                {
                    textBox_admin_log.AppendText(e_run.ToString());
                }
            }
        }

        private void btn_admin_url_add_url_Click_1(object sender, EventArgs e)
        {
            foreach(biosup_multi_url_add url_control in flowLayoutPanel_add_url_str.Controls)
            {
                textBox_admin_log.AppendText(url_control.Controls["textBox_str_admin_url_multi_add"].Text);
            }
        }
    }
}
