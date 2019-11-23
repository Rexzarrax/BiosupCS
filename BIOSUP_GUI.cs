using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiosupCS
{
    public partial class BIOSUP_GUI : Form
    {
        public BIOSUP_GUI()
        {
            InitializeComponent();
        }

        private void BIOSUP_CONFIG_Load(object sender, EventArgs e)
        {
            String str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Working Dir: " + str_working_dir + "\n");
            toolStripStatusLabel_cwd.Text = "Working Directory: "+ str_working_dir;
            textBox_instructions.AppendText("1. \r\n");
            textBox_instructions.AppendText("2. \r\n");
            textBox_instructions.AppendText("3. \r\n");
            textBox_instructions.AppendText("4. \r\n");
            textBox_instructions.AppendText("5. \r\n");

        }
    }
}
