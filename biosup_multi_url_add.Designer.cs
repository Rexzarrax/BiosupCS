namespace BiosupCS
{
    partial class Biosup_multi_url_add
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_str_admin_url_multi_add = new System.Windows.Forms.TextBox();
            this.comboBox_bridge_select = new System.Windows.Forms.ComboBox();
            this.label_number_of_url_to_add = new System.Windows.Forms.Label();
            this.btn_admin_url_remove_url = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Date_of_bios = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.checkBox_multi_del = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_str_admin_url_multi_add
            // 
            this.textBox_str_admin_url_multi_add.Location = new System.Drawing.Point(35, 33);
            this.textBox_str_admin_url_multi_add.Name = "textBox_str_admin_url_multi_add";
            this.textBox_str_admin_url_multi_add.Size = new System.Drawing.Size(315, 20);
            this.textBox_str_admin_url_multi_add.TabIndex = 0;
            // 
            // comboBox_bridge_select
            // 
            this.comboBox_bridge_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bridge_select.FormattingEnabled = true;
            this.comboBox_bridge_select.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.comboBox_bridge_select.Location = new System.Drawing.Point(402, 33);
            this.comboBox_bridge_select.Name = "comboBox_bridge_select";
            this.comboBox_bridge_select.Size = new System.Drawing.Size(50, 21);
            this.comboBox_bridge_select.TabIndex = 1;
            // 
            // label_number_of_url_to_add
            // 
            this.label_number_of_url_to_add.AutoSize = true;
            this.label_number_of_url_to_add.Location = new System.Drawing.Point(3, 36);
            this.label_number_of_url_to_add.Name = "label_number_of_url_to_add";
            this.label_number_of_url_to_add.Size = new System.Drawing.Size(32, 13);
            this.label_number_of_url_to_add.TabIndex = 2;
            this.label_number_of_url_to_add.Text = "URL:";
            // 
            // btn_admin_url_remove_url
            // 
            this.btn_admin_url_remove_url.Location = new System.Drawing.Point(462, 3);
            this.btn_admin_url_remove_url.Name = "btn_admin_url_remove_url";
            this.btn_admin_url_remove_url.Size = new System.Drawing.Size(28, 20);
            this.btn_admin_url_remove_url.TabIndex = 3;
            this.btn_admin_url_remove_url.Text = "X";
            this.btn_admin_url_remove_url.UseVisualStyleBackColor = true;
            this.btn_admin_url_remove_url.Click += new System.EventHandler(this.Btn_admin_url_remove_url_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // label_Date_of_bios
            // 
            this.label_Date_of_bios.AutoSize = true;
            this.label_Date_of_bios.Location = new System.Drawing.Point(7, 6);
            this.label_Date_of_bios.Name = "label_Date_of_bios";
            this.label_Date_of_bios.Size = new System.Drawing.Size(100, 13);
            this.label_Date_of_bios.TabIndex = 5;
            this.label_Date_of_bios.Text = "Date of Bios/UEFI: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bios Ver.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bridge:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(459, 40);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 13);
            this.label_id.TabIndex = 9;
            // 
            // checkBox_multi_del
            // 
            this.checkBox_multi_del.AutoSize = true;
            this.checkBox_multi_del.Location = new System.Drawing.Point(458, 35);
            this.checkBox_multi_del.Name = "checkBox_multi_del";
            this.checkBox_multi_del.Size = new System.Drawing.Size(42, 17);
            this.checkBox_multi_del.TabIndex = 10;
            this.checkBox_multi_del.Text = "Del";
            this.checkBox_multi_del.UseVisualStyleBackColor = true;
            // 
            // Biosup_multi_url_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_multi_del);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Date_of_bios);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_admin_url_remove_url);
            this.Controls.Add(this.label_number_of_url_to_add);
            this.Controls.Add(this.comboBox_bridge_select);
            this.Controls.Add(this.textBox_str_admin_url_multi_add);
            this.Name = "Biosup_multi_url_add";
            this.Size = new System.Drawing.Size(494, 62);
            this.Load += new System.EventHandler(this.Biosup_multi_url_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_str_admin_url_multi_add;
        private System.Windows.Forms.ComboBox comboBox_bridge_select;
        private System.Windows.Forms.Label label_number_of_url_to_add;
        private System.Windows.Forms.Button btn_admin_url_remove_url;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Date_of_bios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.CheckBox checkBox_multi_del;
    }
}
