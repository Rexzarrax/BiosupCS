﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BiosupCS
{
    public partial class BIOSUP_GUI : Form
    {
        String str_working_dir;
        String str_database_credentials;
        Boolean bool_select_all = false;
        public BIOSUP_GUI()
        {
            InitializeComponent();
        }

        private void BIOSUP_CONFIG_Load(object sender, EventArgs e)
        {
            str_database_credentials = "Server=tcp:biosup.database.windows.net,1433;Initial Catalog=firmware-info;Persist Security Info=False;User ID=jaycar-root;Password=F^e36d3f7d^Ukiozp@kp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            BIOSUP_SQL Biosup_query_vendors = new BIOSUP_SQL("SELECT * FROM dbo.vendor_data", str_database_credentials);
            BIOSUP_SQL Biosup_query_chipsets = new BIOSUP_SQL("SELECT chipset_name,chipset_vendor FROM dbo.chipset_check", str_database_credentials);


            str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("CWD: " + str_working_dir + "\n");
            toolStripStatusLabel_cwd.Text = "CWD: "+ str_working_dir;
            textBox_log_config.AppendText("CWD: " + str_working_dir);
            BIOSUP_CONFIG_LOAD_INTRUCTIONS();
            try
            {
                textBox_log_config.AppendText("\r\n Vendors Found:");
                foreach (DataRow row in Biosup_query_vendors.my_table.Rows)
                {
                    textBox_log_config.AppendText("\n\r" + row["vendor_name"] + "...");
                    Invoke(new Action(() => listbox_vendor.Items.Add(row["vendor_name"])));
                }

                textBox_log_config.AppendText("\r\n Chipsets Found:");
                foreach (DataRow row in Biosup_query_chipsets.my_table.Rows)
                {
                    textBox_log_config.AppendText("\n\r" + row["chipset_vendor"] + ", " + row["chipset_name"]+"...");
                    //Need to update below to better method    
                    if (row["chipset_vendor"].ToString() == "AMD")
                   {                    
                        Invoke(new Action(() => listbox_AMD_chipset.Items.Add(row["chipset_name"])));
                   }
                   else if(row["chipset_vendor"].ToString() == "INTEL") 
                   {
                        Invoke(new Action(() => listbox_INTEL_chipset.Items.Add(row["chipset_name"])));
                    }
                   else
                   {
                        textBox_log_config.AppendText("Error Sorting!");
                   }
                    
                }
                    
            }
            catch (Exception e2)
            {
                textBox_log_config.AppendText(e2.ToString());
            }
            
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            String BIOSHERE = str_working_dir + "/BIOSHERE/";
            tab_control.SelectedTab = tabPage_Current_Run;
            if (!File.Exists(BIOSHERE))
            {
                System.IO.Directory.CreateDirectory(BIOSHERE);
                textBox_log_running.AppendText("Directory Created: ../BIOSHERE/");
            }
            else
            {
                textBox_log_running.AppendText("Directory Already Exists: ../BIOSHERE/");
            }
            
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
                }
                else
                {
                    method_bool_select_all(false);
                    btn_select_all.Text = "Select All";
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
            bool_select_all = bool_set_bool;
            for (int i = 0; i < listbox_vendor.Items.Count; i++)
            {
                listbox_vendor.SetItemChecked(i, bool_set_bool);
            }
            checkBox_AMD_select_all.Checked = bool_set_bool;
            for (int i = 0; i < listbox_AMD_chipset.Items.Count; i++)
            {
                listbox_AMD_chipset.SetItemChecked(i, bool_set_bool);
            }
            checkBox_intel_select_all.Checked = bool_set_bool;
            for (int i = 0; i < listbox_INTEL_chipset.Items.Count; i++)
            {
                listbox_INTEL_chipset.SetItemChecked(i, bool_set_bool);
            }
        }


        private void btn_clear_config_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_last_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_intel_select_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_AMD_select_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_all_vendors_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
