using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace BiosupCS
{
    public partial class BIOSUP_GUI : Form
    {
        readonly String str_working_dir;
        readonly String str_database_credentials = "Server=tcp:biosup.database.windows.net,1433;Initial Catalog=firmware-info;Persist Security Info=False;User ID=jaycar-root;Password=F^e36d3f7d^Ukiozp@kp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        readonly List<String> list_chipset_vendor = new List<String>() { "AMD", "INTEL" };
        readonly List<String> list_points = new List<String>() { "Downloading", "Unzipping","Other" };
        //Order is important for method set_how_much_to_dl
        readonly List<String> list_what_to_download= new List<String>() { "Latest Only", "Bridge + Latest", "All","Bridge Only" };
        Boolean bool_select_all = false;
        DataTable Biosup_query_chipsets;
        readonly BIOSUP_SQL Biosup_query;
        readonly BIOSUP_UNZIP OBJ_UNZIP;
        readonly BIOSUP_DL_FILE OBJ_DL_FILE;
        readonly BIOSUP_RM_FILE OBJ_RM_FILE;
        readonly BIOSUP_CONFIG Obj_CONFIG;
        public BIOSUP_GUI()
        {
            InitializeComponent();
            str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
            Biosup_query = new BIOSUP_SQL(this.str_database_credentials);
            OBJ_UNZIP = new BIOSUP_UNZIP();
            OBJ_DL_FILE = new BIOSUP_DL_FILE(progressBar_current_progress);
            OBJ_RM_FILE = new BIOSUP_RM_FILE();
            Obj_CONFIG = new BIOSUP_CONFIG(str_working_dir);
        }

        private void BIOSUP_CONFIG_Load(object sender, EventArgs e)
        {
            
            Console.WriteLine("CWD: " + str_working_dir + "\n");
            toolStripStatusLabel_cwd.Text = "CWD: " + str_working_dir;
            textBox_log_config.AppendText("CWD: " + str_working_dir);

            if (!File.Exists(str_working_dir + "key.txt"))
            {
                tab_control.TabPages.Remove(tabPage_admin);
                tab_control.TabPages.Remove(tabPage_stats);
            }

            textBox_admin_log.AppendText("Clearing UI...");
            textBox_current_UEFI_info.Text = "";
            comboBox_select_chipset_to_remove.Items.Clear();
            listbox_vendor.Items.Clear();
            comboBox_select_vendor.Items.Clear();
            comboBox_select_vendor_to_edit.Items.Clear();
            comboBox_admin_url_vendor.Items.Clear();
            comboBox_select_chipset.Items.Clear();
            comboBox_admin_url_chipset.Items.Clear();
            listbox_AMD_chipset.Items.Clear();
            listbox_INTEL_chipset.Items.Clear();
            comboBox_admin_chipset_vendor.Items.Clear();
            comboBox_admin_model_delete.Items.Clear();
            comboBox_select_vendor_to_edit.Items.Clear();
            comboBox_what_to_get.Items.Clear();

            BIOSUP_CONFIG_LOAD_INTRUCTIONS();

            try
            {
                Biosup_query_chipsets.Rows.Clear();
            }
            catch
            {
                textBox_log_config.AppendText("\r\nNot cleared");
            }


            DataTable Biosup_query_vendors = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.vendor_data");
            Biosup_query_chipsets = Biosup_query.BIOSUP_SQL_GET("SELECT chipset_name, chipset_vendor FROM dbo.chipset_check");
            DataTable Biosup_query_model = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.motherboard_data");

            foreach (String str_string in list_what_to_download)
            {
                Invoke(new Action(() => comboBox_what_to_get.Items.Add(str_string)));
            }

            Application.DoEvents();
            try
            {

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
            textBox_admin_log.AppendText("UI Loaded...");

        }

        private String Set_how_much_to_dl(int int_option)
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

        private String QueryBuilder()
        {
            String str_built_query = "Select * FROM motherboard_url mu INNER JOIN motherboard_data md ON mu.model_id = md.model_id INNER JOIN vendor_data vd ON md.vendor_id = vd.vendor_id";

            str_built_query += Set_how_much_to_dl(comboBox_what_to_get.SelectedIndex);

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
        private void Btn_run_Click(object sender, EventArgs e)
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

                DataTable Biosup_query_urls = Biosup_query.BIOSUP_SQL_GET(QueryBuilder());

                try
                {
                    foreach (DataRow row in Biosup_query_urls.Rows)
                    {
                        textBox_log_running.AppendText("\r\n" + row["model_name"] + "\r\n" + row["url_date_of_bios"] + "\r\n");
                    }
                    Loop_through(Biosup_query_urls);
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
         void Loop_through(DataTable Biosup_query_urls)
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
                    Current_mobo(row);
                    textBox_log_running.AppendText(row["model_name"] + "\r\n" + row["url_str"]);
                    Change_point(list_points[0]);
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
                            Change_point(list_points[1]);
                            textBox_log_running.AppendText("\r\nUnzipping...");
                            Application.DoEvents();
                            OBJ_UNZIP.Unzip(str_file_path, str_working_dir + str_filetree);
                            Change_point(list_points[2]);
                            textBox_log_running.AppendText("\r\nDeleting Zip...");
                            Application.DoEvents();
                            OBJ_RM_FILE.Remove(str_file_path);
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
        private void Change_point(String str_point)
        {
            label_current_point.Text = "Current Point: " + str_point;
        }
        private void Current_mobo(DataRow row)
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

        private void Btn_select_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bool_select_all)
                {
                    Method_bool_select_all(true);
                    btn_select_all.Text = "Deselect All";
                    bool_select_all = true;
                }
                else
                {
                    Method_bool_select_all(false);
                    btn_select_all.Text = "Select All";
                    bool_select_all = false;
                }
                
            }
            catch(Exception e3)
            {
                textBox_log_config.AppendText(e3.ToString());
            }


        }

        private void Method_bool_select_all(Boolean bool_set_bool)
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


        private void Btn_clear_config_Click(object sender, EventArgs e)
        {
            Method_bool_select_all(false);
        }

        private void CheckBox_intel_select_all_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox_INTEL_chipset.Items.Count; i++)
            {
                listbox_INTEL_chipset.SetItemChecked(i, checkBox_vendor_select_all.Checked);
            }
        }

        private void CheckBox_AMD_select_all_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox_AMD_chipset.Items.Count; i++)
            {
                listbox_AMD_chipset.SetItemChecked(i, checkBox_AMD_select_all.Checked);
            }
        }

        private void CheckBox_all_vendors_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox_vendor.Items.Count; i++)
            {
                listbox_vendor.SetItemChecked(i, checkBox_all_vendors.Checked);
            }
        }

        private void Btn_get_model_from_database_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < numericUpDown_admin_url_url_to_add.Value; i++)
            {
                flowLayoutPanel_add_url_str.Controls.Add(new Biosup_multi_url_add { Parent = flowLayoutPanel_add_url_str });
            }
        }

        private void Btn_add_chipset_Click(object sender, EventArgs e)
        {
            if(textBox_admin_chipset_name.Text == "" || comboBox_admin_chipset_vendor.SelectedIndex == -1)
            {
                textBox_admin_log.AppendText("Please make sure Both UI elements have values");
            }
            else
            {
                String str_query_var = "Variables: " + textBox_admin_chipset_name.Text + "," + comboBox_admin_chipset_vendor.SelectedItem;
                textBox_admin_log.AppendText(str_query_var);
                String str_query = "INSERT INTO dbo.chipset_check(chipset_name,chipset_vendor) VALUES('"+ textBox_admin_chipset_name.Text + "','"+ comboBox_admin_chipset_vendor.SelectedItem + "');" ;
                Execute_query_SET(sender, e, str_query, textBox_admin_chipset_name.Text);
                textBox_admin_chipset_name.Text = "";
                comboBox_admin_chipset_vendor.SelectedIndex = -1;
            }

            /*List<SQL_Params> list_parameter = new List<SQL_Params>();
SQL_Params obj_paramater_chipset = new SQL_Params("@a_chipset_name", SqlDbType.VarChar, 10, textBox_admin_chipset_name.Text);
SQL_Params obj_paramater_vendor = new SQL_Params("@a_chipset_vendor", SqlDbType.VarChar, 10, textBox_admin_chipset_name.Text.ToString());
list_parameter.Add(obj_paramater_chipset);
list_parameter.Add(obj_paramater_vendor);
Biosup_query.BIOSUP_SQL_SET("ADD_CHIPSET", list_parameter);
*/
        }

        private void ComboBox_admin_url_vendor_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComboBox_admin_url_chipset_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComboBox_select_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel_admin_url_edit.Controls.Clear();
                flowLayoutPanel_add_url_str.Controls.Clear();
                String str_model = comboBox_select_model.Text;
                DataTable Biosup_query_model = Biosup_query.BIOSUP_SQL_GET("SELECT model_id FROM dbo.motherboard_data where model_name = '" + str_model + "';");
                DataTable Biosup_query_url = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.motherboard_url where model_id = " + Biosup_query_model.Rows[0]["model_id"] + ";");
                label_admin_url_model.Text = str_model;
                int i = 0;
                flowLayoutPanel_admin_url_edit.Controls.Clear();
                foreach (DataRow row_url in Biosup_query_url.Rows)
                {
                    flowLayoutPanel_admin_url_edit.Controls.Add(new Biosup_multi_url_add { Parent = flowLayoutPanel_add_url_str });
                    flowLayoutPanel_admin_url_edit.Controls[i].Controls["textBox_str_admin_url_multi_add"].Text = row_url["url_str"].ToString();
                    flowLayoutPanel_admin_url_edit.Controls[i].Controls["dateTimePicker1"].Text = row_url["url_date_of_bios"].ToString();
                    flowLayoutPanel_admin_url_edit.Controls[i].Controls["textBox1"].Text = row_url["url_version"].ToString();
                    flowLayoutPanel_admin_url_edit.Controls[i].Controls["comboBox_bridge_select"].Text = row_url["url_bridge"].ToString();
                    flowLayoutPanel_admin_url_edit.Controls[i].Controls["label_id"].Text = row_url["url_id"].ToString();
                    i++;
                }
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText(e_run.ToString());
            }

        }

        private void Button_remove_chipset_Click(object sender, EventArgs e)
        {
            String str_chipset_to_remove = comboBox_select_chipset_to_remove.Text;
            String str_query = "DELETE FROM dbo.chipset_check WHERE chipset_name ='"+str_chipset_to_remove+"'";
            Execute_query_SET(sender, e, str_query, str_chipset_to_remove);

        }

        private void Btn_add_model_Click(object sender, EventArgs e)
        {
            String str_chipset = comboBox_select_chipset.Text;
            String str_vendor = comboBox_select_vendor.Text;
            String str_model_sku = textBox_admin_model_sku.Text;
            String str_bios_url = textBox_model_bios_url.Text;
            DataTable Biosup_query_vendor = Biosup_query.BIOSUP_SQL_GET("SELECT vendor_id FROM dbo.vendor_data where vendor_name ='" + str_vendor+"';");


            String str_query = "INSERT INTO dbo.motherboard_data(chipset, model_name, vendor_id, model_page) VALUES('"+str_chipset + "','"+ str_model_sku + "','" + Biosup_query_vendor.Rows[0]["vendor_id"] + "','" + str_bios_url + "');";
            textBox_admin_log.AppendText(str_query);
            Execute_query_SET(sender, e, str_query, str_model_sku);
            textBox_admin_model_sku.Text = "";
            textBox_model_bios_url.Text = "";


        }

        private void Btn_delete_model_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This action will delete all associated BIOS","",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                String str_model_to_remove = comboBox_admin_model_delete.Text;
                String str_query = "DELETE FROM dbo.motherboard_data WHERE model_name ='" + str_model_to_remove + "'";
                Console.WriteLine(str_query);
                Execute_query_SET(sender, e, str_query, str_model_to_remove);
            }
        }

        private void Btn_admin_url_add_url_Click_1(object sender, EventArgs e)
        {
            foreach(Biosup_multi_url_add url_control in flowLayoutPanel_add_url_str.Controls)
            {
                String str_url = url_control.Controls["textBox_str_admin_url_multi_add"].Text;
                String str_date = url_control.Controls["dateTimePicker1"].Text;
                String str_version = url_control.Controls["textBox1"].Text;
                String str_bridge = url_control.Controls["comboBox_bridge_select"].Text;
                String str_id = url_control.Controls["label_id"].Text;

                textBox_admin_log.AppendText("\r\n" + str_url);
                textBox_admin_log.AppendText("\r\n" + str_date);
                textBox_admin_log.AppendText("\r\n" + str_version);
                textBox_admin_log.AppendText("\r\n" + str_bridge);

                DateTime format_date = DateTime.Parse(str_date);
                str_date = format_date.ToString("yyyy-MM-dd");

                String str_query_get_model = "SELECT model_id from motherboard_data where model_name = '" + comboBox_select_model.Text+"'";

                try
                {
                    DataTable dt_query_get_model_id = Biosup_query.BIOSUP_SQL_GET(str_query_get_model);

                    String str_query = "INSERT INTO dbo.motherboard_url(model_id ,url_str, url_date_of_bios, url_version, url_bridge) VALUES("+dt_query_get_model_id.Rows[0]["model_id"] + ", '" + str_url + "','" + str_date + "','" + str_version + "','" + str_bridge+"')";

                    Execute_query_SET(sender, e, str_query, str_url);

                }
                catch (System.Data.SqlClient.SqlException e_run)
                {
                    textBox_admin_log.AppendText(e_run.ToString());
                    textBox_admin_log.AppendText("ERROR UPDATING VERSION " + str_version);
                    break;
                }
                catch (Exception e_run)
                {
                    textBox_admin_log.AppendText(e_run.ToString());
                    textBox_admin_log.AppendText("ERROR UPDATING VERSION " + str_version);
                    break;
                }

            
            }
            flowLayoutPanel_admin_url_edit.Controls.Clear();
        }


        private void Button_admin_url_save_del_Click(object sender, EventArgs e)
        {
            
            foreach (Biosup_multi_url_add url_control in flowLayoutPanel_admin_url_edit.Controls)
            {
                String str_url = url_control.Controls["textBox_str_admin_url_multi_add"].Text;
                String str_date = url_control.Controls["dateTimePicker1"].Text;
                String str_version = url_control.Controls["textBox1"].Text;
                String str_bridge = url_control.Controls["comboBox_bridge_select"].Text;
                String str_id = url_control.Controls["label_id"].Text;
                if (url_control.Controls["btn_admin_url_remove_url"].Enabled)
                {
                    textBox_admin_log.AppendText("\r\n" + str_url);
                    textBox_admin_log.AppendText("\r\n" + str_date);
                    textBox_admin_log.AppendText("\r\n" + str_version);
                    textBox_admin_log.AppendText("\r\n" + str_bridge);
                    DateTime format_date = DateTime.Parse(str_date);
                    str_date = format_date.ToString("yyyy-MM-dd");

                    String str_query = "UPDATE dbo.motherboard_url SET url_str = '" + str_url + "', url_date_of_bios = '" + str_date + "', url_version = '" + str_version + "', url_bridge = '" + str_bridge + "' WHERE url_id =" + str_id + ";";
                    Execute_query_SET(sender, e, str_query, str_url);
                }
                else
                {
                    Console.WriteLine("Deleteing " + url_control.Controls["textBox1"].Text);
                    String str_query = "DELETE dbo.motherboard_url WHERE url_str = '" + str_url + "';";
                    Execute_query_SET(sender, e, str_query, label_admin_model.Text);
                }
               

            }
            flowLayoutPanel_admin_url_edit.Controls.Clear();
        }

        private void ComboBox_admin_model_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str_query = "SELECT model_page,model_name from motherboard_data where model_name = '" + comboBox_admin_model_delete.Text + "'";
            try
            {
                DataTable dt_query_get_model_page = Biosup_query.BIOSUP_SQL_GET(str_query);
                label_admin_model.Text = dt_query_get_model_page.Rows[0]["model_name"].ToString();
                textBox_admin_model_url.Text = dt_query_get_model_page.Rows[0]["model_page"].ToString();
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText(e_run.ToString());
            }
        }

        private void Button_save_model_url_Click(object sender, EventArgs e)
        {
            String str_query = "UPDATE dbo.motherboard_data SET model_page = '" + textBox_admin_model_url.Text + "' WHERE model_name ='" + label_admin_model.Text + "';";
            Execute_query_SET(sender, e, str_query, label_admin_model.Text);
        }

        private void ComboBox_select_vendor_to_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Biosup_query_vendors = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.vendor_data where vendor_name = '"+ comboBox_select_vendor_to_edit .Text+ "'");
                textBox_admin_vendor_name.Text = Biosup_query_vendors.Rows[0]["vendor_name"].ToString();
                textBox_admin_vendor_sort_edit.Text = Biosup_query_vendors.Rows[0]["vendor_sort"].ToString();
                textBox_admin_vendor_base_edit.Text = Biosup_query_vendors.Rows[0]["vendor_dl_url_base"].ToString();
                textBox_admin_vendor_addon_edit.Text = Biosup_query_vendors.Rows[0]["vendor_url_addon"].ToString();
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText(e_run.ToString());
            }

        }

        private void Button_add_vendor_Click(object sender, EventArgs e)
        {
            
            String str_query = "INSERT INTO dbo.vendor_data VALUES('" + textBox_admin_vendor_name_add.Text + "','"+ textBox_admin_vendor_sort_add.Text + "','"+ textBox_admin_vendor_base_add.Text+"','"+ textBox_admin_vendor_addon_add.Text + "')";
            Execute_query_SET(sender, e, str_query, textBox_admin_vendor_name_add.Text);
        }

        private void Btn_save_edits_Click(object sender, EventArgs e)
        {
            String str_query = "UPDATE dbo.vendor_data SET vendor_name = '" + textBox_admin_vendor_name.Text + "',vendor_sort = '" + textBox_admin_vendor_sort_edit.Text + "', vendor_dl_url_base = '"+ textBox_admin_vendor_base_edit.Text + "', vendor_url_addon = '" + textBox_admin_vendor_addon_edit.Text + "'  WHERE vendor_name ='" + comboBox_select_vendor_to_edit.Text + "';";

            Execute_query_SET(sender, e, str_query, textBox_admin_vendor_name.Text);

            textBox_admin_log.AppendText("\r\n" + textBox_admin_vendor_name.Text);
            textBox_admin_log.AppendText("\r\n" + textBox_admin_vendor_sort_edit.Text);
            textBox_admin_log.AppendText("\r\n" + textBox_admin_vendor_base_edit.Text);
            textBox_admin_log.AppendText("\r\n" + textBox_admin_vendor_addon_edit.Text);
            textBox_admin_log.AppendText("\r\n" + comboBox_select_vendor_to_edit.Text);

           
        }

        private void Execute_query_SET(object sender, EventArgs e, String str_query, String str_changer)
        {
            try
            {
                Biosup_query.BIOSUP_SQL_SET(str_query);
                textBox_admin_log.AppendText("\r\n"+str_changer + "Successfull");
            }
            catch (System.Data.SqlClient.SqlException e_run)
            {
                textBox_admin_log.AppendText("\r\nERROR ADDING MODEL " + str_changer);
                if (e_run.Number == 2627)
                {
                    textBox_admin_log.AppendText("\r\n" + str_changer + " Already in Database");
                }
            }
            catch (Exception e_run)
            {
                textBox_admin_log.AppendText("\r\nERROR: " + str_changer);
                textBox_admin_log.AppendText(e_run.ToString());
            }
            System.Threading.Thread.Sleep(150);
            BIOSUP_CONFIG_Load(sender, e);
        }

        private void Button_get_models_Click(object sender, EventArgs e)
        {
            try
            {
                String str_filename = string.Empty;
                // Get the full name of the newly created Temporary file. 
                // Note that the GetTempFileName() method actually creates
                // a 0-byte file and returns the name of the created file.
                str_filename = Path.GetTempFileName();

                // Craete a FileInfo object to set the file's attributes
                FileInfo fileInfo = new FileInfo(str_filename);

                // Set the Attribute property of this file to Temporary. 
                // Although this is not completely necessary, the .NET Framework is able 
                // to optimize the use of Temporary files by keeping them cached in memory.
                fileInfo.Attributes = FileAttributes.Temporary;

                Console.WriteLine("TEMP file created at: " + str_filename);
                this.OBJ_DL_FILE.DL_FILE("https://raw.githubusercontent.com/Rexzarrax/Motherboard_Model_Names/master/motherboard_sku_data.txt", str_filename);
                int counter = 0;
                string line;

                while (true)
                {
                    if (!IsFileLocked(fileInfo))
                    {
                        // Read the file and display it line by line.  
                        System.IO.StreamReader file =
                            new System.IO.StreamReader(@str_filename);
                        while ((line = file.ReadLine()) != null)
                        {
                            textBox_admin_log.AppendText("\r\n------------------------------------------------");
                            textBox_admin_log.AppendText("\r\n"+ line);
                            String[] model_attributes = line.Split('-');
                            String str_chipset = "NF";
                            //x299x could be a issue, we will see
                            foreach (DataRow chipset in Biosup_query_chipsets.Rows)
                            {
                                if(line.Contains(chipset["chipset_name"].ToString())){
                                    str_chipset = chipset["chipset_name"].ToString();
                                    break;
                                }

                            }
                            String str_vendor = model_attributes[0];
                            String str_model = line.Replace(model_attributes[0]+"-","");
                            textBox_admin_log.AppendText("\r\n" + str_chipset);
                            textBox_admin_log.AppendText("\r\n" + str_vendor);
                            textBox_admin_log.AppendText("\r\n" + str_model);

                            DataTable Biosup_query_vendors = Biosup_query.BIOSUP_SQL_GET("SELECT * FROM dbo.vendor_data where vendor_name = '" + str_vendor + "'");

                            String str_query = "INSERT INTO dbo.motherboard_data(chipset,model_name,vendor_id) VALUES('" + str_chipset + "','" + str_model + "','" + Biosup_query_vendors.Rows[0]["vendor_id"] + "')";
                            Execute_query_SET(sender, e, str_query, str_model);

                            counter++;
                        }

                        file.Close();
                        textBox_admin_log.AppendText("\r\nThere were "+counter+" Models");
                        break;
                    }
                    else
                    {
                        Thread.Sleep(100);
                        Application.DoEvents();
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to create TEMP file or set its attributes: " + ex.Message);
            }
        }

        private void Button_admin_vendor_del_Click(object sender, EventArgs e)
        {

        }

        private void Button_admin_url_model_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_admin_url_model.Text);
            textBox_admin_log.AppendText("\n\rCopied!");
        }

        private void Button_admin_url_bulk_get_Click(object sender, EventArgs e)
        {
            BIOSUP_HTML HTML = new BIOSUP_HTML();
            String str_model = label_admin_url_model.Text;
            int int_url_to_get = Convert.ToInt32(numericUpDown_admin_url_url_to_add.Value);

            //URL check already occurs in DB upon insert, 
            try
            {
                //if url + version already in system(if it is, add to edit/save flow(leave sine it should already be there from previous select), if not, add to 'add new')

                HTML.get_webpage_ddg(str_model);

                for (int i = 1; i <= int_url_to_get; i++)
                {
                    String str_version = "x.x"+i;
                    String str_url = "https/xxxxxxxx" + i;
                    String str_date = "04/12/2019";

                    Biosup_multi_url_add control_to_add = new Biosup_multi_url_add { Parent = flowLayoutPanel_add_url_str };

                    control_to_add.Controls["textBox1"].Text = str_version;
                    control_to_add.Controls["textBox_str_admin_url_multi_add"].Text = str_url;

                    try
                    {
                        control_to_add.Controls["dateTimePicker1"].Text = str_date;
                    }
                    catch
                    {
                        textBox_admin_log.AppendText("\r\nInvalid date format for Version: " + str_version);
                        textBox_admin_log.AppendText("\r\nShowing today's date instead...");
                    }
                    
                    flowLayoutPanel_add_url_str.Controls.Add(control_to_add);

                }
            }
            catch
            {

            }
            
            //need to check: 
                 
            //if there are extra bits required to get url

        }

        private void Button_admin_model_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_admin_model.Text);
            textBox_admin_log.AppendText("\n\rCopied!");
        }

        private void Load_config_to_gui(CheckedListBox Listbox, List<String> checklist)
        {
            for (int i = 0; i < Listbox.Items.Count; i++)
            {
                if (checklist.Contains(Listbox.Items[i].ToString()))
                {
                    Console.WriteLine(Listbox.Items[i].ToString());
                    textBox_log_config.AppendText("\r\nChecking: " + Listbox.Items[i].ToString());
                    Listbox.SetItemChecked(i, true);
                }
                else
                {
                    Console.WriteLine("\r\nNot Checking: " + Listbox.Items[i].ToString());
                    textBox_log_config.AppendText("\r\nNot Checking: " + Listbox.Items[i].ToString());
                    Listbox.SetItemChecked(i, false);
                }
                

            }
        }
            private void Button_load_config_Click(object sender, EventArgs e)
        {
            this.Obj_CONFIG.load_config();

            Load_config_to_gui(listbox_AMD_chipset, this.Obj_CONFIG.List_amd_chipsets);

            Load_config_to_gui(listbox_INTEL_chipset, this.Obj_CONFIG.List_intel_chipsets);

            Load_config_to_gui(listbox_vendor, this.Obj_CONFIG.List_vendors);

            comboBox_what_to_get.SelectedIndex = Int32.Parse(this.Obj_CONFIG.Str_option);

        }

        private List<String> collect_config(CheckedListBox Listbox)
        {
            List<String> list_temp = new List<String>();
            for (int i = 0; i < Listbox.CheckedItems.Count; i++)
            {
                list_temp.Add(Listbox.CheckedItems[i].ToString());
                textBox_log_config.AppendText("\r\nAdding: " + Listbox.CheckedItems[i].ToString());
            }

            return list_temp;
        }

        private void Button_save_config_Click(object sender, EventArgs e)
        {
            textBox_log_config.AppendText("\r\nSaving...");
            List<List<String>> list_of_lists_string = new List<List<string>>
            {
                collect_config(listbox_AMD_chipset),
                collect_config(listbox_INTEL_chipset),
                collect_config(listbox_vendor)
            };

            this.Obj_CONFIG.set_config(list_of_lists_string, comboBox_what_to_get.SelectedIndex);
            textBox_log_config.AppendText("\r\nSave Complete...");
        }

        private void Button_get_next_10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_admin_scripts.Controls.Clear();
            for( int i = 0; i <= 3; i++)
            {
                flowLayoutPanel_admin_scripts.Controls.Add(new Biosup_multi_url_add { Parent = flowLayoutPanel_add_url_str });
            }

        }
    }
}
