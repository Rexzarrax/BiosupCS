using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace BiosupCS
{
    public partial class BIOSUP_GUI : Form
    {
        String str_working_dir;
        String str_database_credentials = "Server=tcp:biosup.database.windows.net,1433;Initial Catalog=firmware-info;Persist Security Info=False;User ID=jaycar-root;Password=F^e36d3f7d^Ukiozp@kp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        List<String> list_chipset_vendor = new List<String>() { "AMD", "INTEL" };
        List<String> list_points = new List<String>() { "Downloading", "Unzipping","Other" };
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

            str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("CWD: " + str_working_dir + "\n");
            toolStripStatusLabel_cwd.Text = "CWD: " + str_working_dir;
            textBox_log_config.AppendText("CWD: " + str_working_dir);

            if (!File.Exists(str_working_dir + "key.txt"))
            {
                tab_control.TabPages.Remove(tabPage_admin);
            }

            BIOSUP_CONFIG_LOAD_INTRUCTIONS();
            try
            {
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

        private void btn_run_Click(object sender, EventArgs e)
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


            String str_built_query = "Select * FROM motherboard_url mu INNER JOIN motherboard_data md ON mu.model_id = md.model_id INNER JOIN vendor_data vd ON md.vendor_id = vd.vendor_id;";

            DataTable Biosup_query_urls = Biosup_query.BIOSUP_SQL_GET(str_built_query);

            Application.DoEvents();
            loop_through(Biosup_query_urls);
        }
         void loop_through(DataTable Biosup_query_urls)
        {
            int int_count_mobo = Biosup_query_urls.Rows.Count;
            int int_progress = 0;
            progressBar_overall_progress.Maximum = int_count_mobo;
            progressBar_overall_progress.Value = int_progress;
            foreach (DataRow row in Biosup_query_urls.Rows)
            {
                int_progress++;
                label_current_progress_fraction.Text = int_count_mobo + "/" + int_progress;
                progressBar_overall_progress.Value = int_count_mobo;
                progressBar_current_progress.Value = int_count_mobo;



                textBox_log_running.AppendText("--------------------URL--------------------\r\n");
                current_mobo(row);
                textBox_log_running.AppendText(row["model_name"] + "\r\n" + row["url_str"]);
                change_point(list_points[0]);
                String str_filetree = "BIOSHERE/" + row["vendor_name"] + "/" + row["chipset"] + "/" + row["model_name"];
                String str_file_path = str_filetree+"/" + row["vendor_name"] +"-" + row["model_name"] + ".zip";
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
                        textBox_log_running.AppendText("\r\nDownloading...");                    
                        Thread.Sleep(500);
                        Application.DoEvents();
                    }
                    
                }
                textBox_log_running.AppendText("\r\nMoving to Next UEFI/BIOS...\r\n");
                MessageBox.Show("All Firmware have been attempted.\r\nPlease close Biosup");

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
            textBox_current_UEFI_info.AppendText("\r\nModel: "+ row["model_name"]);
            textBox_current_UEFI_info.AppendText("\r\nVendor: " + row["vendor_name"]);
            textBox_current_UEFI_info.AppendText("\r\nChipset: " + row["chipset"]);
            textBox_current_UEFI_info.AppendText("\r\nDate Added: " + row["url_date_collected"]);
            textBox_current_UEFI_info.AppendText("\r\nBridge: " + row["url_bridge"]);
            textBox_current_UEFI_info.AppendText("\r\nUEFI URL: " + row["url_str"]);
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
            if(textBox_admin_chipset_name.Text == "" || (String)comboBox_admin_chipset_vendor.SelectedItem == "")
            {
                textBox_admin_log.AppendText("Please make sure Both UI elements have values");
            }
            else
            {
                String str_query_var = "Variables: " + textBox_admin_chipset_name.Text + "," + comboBox_admin_chipset_vendor.SelectedItem;
                try
                {
                    List<SQL_Params> list_parameter = new List<SQL_Params>();
                    SQL_Params obj_paramater_chipset = new SQL_Params("@a_chipset_name", SqlDbType.VarChar, 10, textBox_admin_chipset_name.Text);
                    SQL_Params obj_paramater_vendor = new SQL_Params("@a_chipset_vendor", SqlDbType.VarChar, 10, textBox_admin_chipset_name.Text);
                    list_parameter.Add(obj_paramater_chipset);
                    list_parameter.Add(obj_paramater_vendor);
                    Biosup_query.BIOSUP_SQL_SET("ADD_CHIPSET", list_parameter);
                }
                catch (Exception e_run)
                {
                    textBox_admin_chipset_name.AppendText( e_run.ToString());
                }
                textBox_admin_chipset_name.Text = "";
                comboBox_admin_chipset_vendor.SelectedIndex = -1;
            }


        }
    }
}
