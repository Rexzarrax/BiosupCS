using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiosupCS
{
    public partial class Biosup_multi_url_add : UserControl
    {
        public Biosup_multi_url_add()
        {
            InitializeComponent();
        }

        private void Btn_admin_url_remove_url_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //create delete statements here
        }

        private void Biosup_multi_url_add_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
                {
                    dateTimePicker1.Value = DateTime.Parse(Clipboard.GetText());
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter Valid Date!");
            }

        }

        private void CheckBox_multi_del_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_multi_del.Checked)
            {
                btn_admin_url_remove_url.Enabled = false;
            }

            if (!checkBox_multi_del.Checked)
            {
                btn_admin_url_remove_url.Enabled = true;
            }
        }
    }
}
