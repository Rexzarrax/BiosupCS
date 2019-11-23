using System;
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
        public BIOSUP_GUI()
        {
            InitializeComponent();
        }

        private void BIOSUP_CONFIG_Load(object sender, EventArgs e)
        {
            BIOSUP_SQL Biosup_query = new BIOSUP_SQL("Server=tcp:biosup.database.windows.net,1433;Initial Catalog=firmware-info;Persist Security Info=False;User ID=jaycar-root;Password=F^e36d3f7d^Ukiozp@kp;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("CWD: " + str_working_dir + "\n");
            toolStripStatusLabel_cwd.Text = "CWD: "+ str_working_dir;
            BIOSUP_CONFIG_LOAD_INTRUCTIONS();
            try
            {
                textBox_log_config.AppendText(Biosup_query.main().ToString());
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
