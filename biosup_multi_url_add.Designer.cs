namespace BiosupCS
{
    partial class biosup_multi_url_add
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
            this.SuspendLayout();
            // 
            // textBox_str_admin_url_multi_add
            // 
            this.textBox_str_admin_url_multi_add.Location = new System.Drawing.Point(3, 16);
            this.textBox_str_admin_url_multi_add.Name = "textBox_str_admin_url_multi_add";
            this.textBox_str_admin_url_multi_add.Size = new System.Drawing.Size(397, 20);
            this.textBox_str_admin_url_multi_add.TabIndex = 0;
            // 
            // comboBox_bridge_select
            // 
            this.comboBox_bridge_select.FormattingEnabled = true;
            this.comboBox_bridge_select.Location = new System.Drawing.Point(406, 16);
            this.comboBox_bridge_select.Name = "comboBox_bridge_select";
            this.comboBox_bridge_select.Size = new System.Drawing.Size(50, 21);
            this.comboBox_bridge_select.TabIndex = 1;
            // 
            // label_number_of_url_to_add
            // 
            this.label_number_of_url_to_add.AutoSize = true;
            this.label_number_of_url_to_add.Location = new System.Drawing.Point(3, 0);
            this.label_number_of_url_to_add.Name = "label_number_of_url_to_add";
            this.label_number_of_url_to_add.Size = new System.Drawing.Size(39, 13);
            this.label_number_of_url_to_add.TabIndex = 2;
            this.label_number_of_url_to_add.Text = "URL #";
            // 
            // btn_admin_url_remove_url
            // 
            this.btn_admin_url_remove_url.Location = new System.Drawing.Point(463, 16);
            this.btn_admin_url_remove_url.Name = "btn_admin_url_remove_url";
            this.btn_admin_url_remove_url.Size = new System.Drawing.Size(28, 20);
            this.btn_admin_url_remove_url.TabIndex = 3;
            this.btn_admin_url_remove_url.Text = "X";
            this.btn_admin_url_remove_url.UseVisualStyleBackColor = true;
            this.btn_admin_url_remove_url.Click += new System.EventHandler(this.btn_admin_url_remove_url_Click);
            // 
            // biosup_multi_url_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_admin_url_remove_url);
            this.Controls.Add(this.label_number_of_url_to_add);
            this.Controls.Add(this.comboBox_bridge_select);
            this.Controls.Add(this.textBox_str_admin_url_multi_add);
            this.Name = "biosup_multi_url_add";
            this.Size = new System.Drawing.Size(494, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_str_admin_url_multi_add;
        private System.Windows.Forms.ComboBox comboBox_bridge_select;
        private System.Windows.Forms.Label label_number_of_url_to_add;
        private System.Windows.Forms.Button btn_admin_url_remove_url;
    }
}
