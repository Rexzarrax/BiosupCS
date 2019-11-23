namespace BiosupCS
{
    partial class BIOSUP_GUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIOSUP_GUI));
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_load_last = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox_instructions = new System.Windows.Forms.TextBox();
            this.grpBox_vendor = new System.Windows.Forms.GroupBox();
            this.listbox_vendor = new System.Windows.Forms.CheckedListBox();
            this.grpBox_Chipsets = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox_intel_select_all = new System.Windows.Forms.CheckBox();
            this.listbox_INTEL_chipset = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox_AMD_select_all = new System.Windows.Forms.CheckBox();
            this.listbox_AMD_chipset = new System.Windows.Forms.CheckedListBox();
            this.btn_select_all = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_clear_config = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_overall_progress = new System.Windows.Forms.ProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip_err_or_cwd = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_cwd = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.grpBox_vendor.SuspendLayout();
            this.grpBox_Chipsets.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip_err_or_cwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.Controls.Add(this.tabPage2);
            this.tab_control.Controls.Add(this.tabPage3);
            this.tab_control.Location = new System.Drawing.Point(0, -1);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(587, 537);
            this.tab_control.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.btn_load_last);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.grpBox_vendor);
            this.tabPage1.Controls.Add(this.grpBox_Chipsets);
            this.tabPage1.Controls.Add(this.btn_select_all);
            this.tabPage1.Controls.Add(this.btn_run);
            this.tabPage1.Controls.Add(this.btn_clear_config);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configurator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 398);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(564, 78);
            this.textBox3.TabIndex = 11;
            // 
            // btn_load_last
            // 
            this.btn_load_last.Location = new System.Drawing.Point(6, 482);
            this.btn_load_last.Name = "btn_load_last";
            this.btn_load_last.Size = new System.Drawing.Size(75, 23);
            this.btn_load_last.TabIndex = 10;
            this.btn_load_last.Text = "Load Last";
            this.btn_load_last.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox_instructions);
            this.groupBox9.Location = new System.Drawing.Point(376, 264);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(195, 127);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Intructions";
            // 
            // textBox_instructions
            // 
            this.textBox_instructions.AcceptsReturn = true;
            this.textBox_instructions.Location = new System.Drawing.Point(7, 20);
            this.textBox_instructions.Multiline = true;
            this.textBox_instructions.Name = "textBox_instructions";
            this.textBox_instructions.ReadOnly = true;
            this.textBox_instructions.Size = new System.Drawing.Size(182, 101);
            this.textBox_instructions.TabIndex = 0;
            // 
            // grpBox_vendor
            // 
            this.grpBox_vendor.Controls.Add(this.listbox_vendor);
            this.grpBox_vendor.Location = new System.Drawing.Point(376, 3);
            this.grpBox_vendor.Name = "grpBox_vendor";
            this.grpBox_vendor.Size = new System.Drawing.Size(195, 255);
            this.grpBox_vendor.TabIndex = 8;
            this.grpBox_vendor.TabStop = false;
            this.grpBox_vendor.Text = "Vendor";
            // 
            // listbox_vendor
            // 
            this.listbox_vendor.FormattingEnabled = true;
            this.listbox_vendor.Location = new System.Drawing.Point(6, 17);
            this.listbox_vendor.Name = "listbox_vendor";
            this.listbox_vendor.Size = new System.Drawing.Size(183, 229);
            this.listbox_vendor.TabIndex = 5;
            // 
            // grpBox_Chipsets
            // 
            this.grpBox_Chipsets.Controls.Add(this.groupBox8);
            this.grpBox_Chipsets.Controls.Add(this.groupBox6);
            this.grpBox_Chipsets.Location = new System.Drawing.Point(0, 3);
            this.grpBox_Chipsets.Name = "grpBox_Chipsets";
            this.grpBox_Chipsets.Size = new System.Drawing.Size(370, 388);
            this.grpBox_Chipsets.TabIndex = 7;
            this.grpBox_Chipsets.TabStop = false;
            this.grpBox_Chipsets.Text = "Chipsets";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox_intel_select_all);
            this.groupBox8.Controls.Add(this.listbox_INTEL_chipset);
            this.groupBox8.Location = new System.Drawing.Point(197, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(167, 365);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "INTEL";
            // 
            // checkBox_intel_select_all
            // 
            this.checkBox_intel_select_all.AutoSize = true;
            this.checkBox_intel_select_all.Location = new System.Drawing.Point(6, 339);
            this.checkBox_intel_select_all.Name = "checkBox_intel_select_all";
            this.checkBox_intel_select_all.Size = new System.Drawing.Size(70, 17);
            this.checkBox_intel_select_all.TabIndex = 5;
            this.checkBox_intel_select_all.Text = "Select All";
            this.checkBox_intel_select_all.UseVisualStyleBackColor = true;
            // 
            // listbox_INTEL_chipset
            // 
            this.listbox_INTEL_chipset.FormattingEnabled = true;
            this.listbox_INTEL_chipset.Location = new System.Drawing.Point(6, 14);
            this.listbox_INTEL_chipset.Name = "listbox_INTEL_chipset";
            this.listbox_INTEL_chipset.Size = new System.Drawing.Size(152, 319);
            this.listbox_INTEL_chipset.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox_AMD_select_all);
            this.groupBox6.Controls.Add(this.listbox_AMD_chipset);
            this.groupBox6.Location = new System.Drawing.Point(19, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 365);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AMD";
            // 
            // checkBox_AMD_select_all
            // 
            this.checkBox_AMD_select_all.AutoSize = true;
            this.checkBox_AMD_select_all.Location = new System.Drawing.Point(6, 338);
            this.checkBox_AMD_select_all.Name = "checkBox_AMD_select_all";
            this.checkBox_AMD_select_all.Size = new System.Drawing.Size(70, 17);
            this.checkBox_AMD_select_all.TabIndex = 4;
            this.checkBox_AMD_select_all.Text = "Select All";
            this.checkBox_AMD_select_all.UseVisualStyleBackColor = true;
            // 
            // listbox_AMD_chipset
            // 
            this.listbox_AMD_chipset.FormattingEnabled = true;
            this.listbox_AMD_chipset.Location = new System.Drawing.Point(6, 13);
            this.listbox_AMD_chipset.Name = "listbox_AMD_chipset";
            this.listbox_AMD_chipset.Size = new System.Drawing.Size(152, 319);
            this.listbox_AMD_chipset.TabIndex = 3;
            // 
            // btn_select_all
            // 
            this.btn_select_all.Location = new System.Drawing.Point(376, 482);
            this.btn_select_all.Name = "btn_select_all";
            this.btn_select_all.Size = new System.Drawing.Size(75, 23);
            this.btn_select_all.TabIndex = 2;
            this.btn_select_all.Text = "Select All";
            this.btn_select_all.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(496, 482);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            // 
            // btn_clear_config
            // 
            this.btn_clear_config.Location = new System.Drawing.Point(135, 482);
            this.btn_clear_config.Name = "btn_clear_config";
            this.btn_clear_config.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_config.TabIndex = 0;
            this.btn_clear_config.Text = "Clear Config";
            this.btn_clear_config.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Run";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(227, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 344);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Run Log";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 323);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 344);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current UEFI Infomation";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 15);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 323);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(3, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Point: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(540, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBar_overall_progress);
            this.groupBox1.Location = new System.Drawing.Point(3, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overall Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NA/NA";
            // 
            // progressBar_overall_progress
            // 
            this.progressBar_overall_progress.Location = new System.Drawing.Point(10, 36);
            this.progressBar_overall_progress.Name = "progressBar_overall_progress";
            this.progressBar_overall_progress.Size = new System.Drawing.Size(540, 23);
            this.progressBar_overall_progress.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(579, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip_err_or_cwd
            // 
            this.statusStrip_err_or_cwd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_cwd});
            this.statusStrip_err_or_cwd.Location = new System.Drawing.Point(0, 539);
            this.statusStrip_err_or_cwd.Name = "statusStrip_err_or_cwd";
            this.statusStrip_err_or_cwd.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip_err_or_cwd.Size = new System.Drawing.Size(587, 22);
            this.statusStrip_err_or_cwd.TabIndex = 2;
            this.statusStrip_err_or_cwd.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_cwd
            // 
            this.toolStripStatusLabel_cwd.Name = "toolStripStatusLabel_cwd";
            this.toolStripStatusLabel_cwd.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel_cwd.Text = "[Not Available]";
            // 
            // BIOSUP_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(587, 561);
            this.Controls.Add(this.statusStrip_err_or_cwd);
            this.Controls.Add(this.tab_control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(603, 600);
            this.MinimumSize = new System.Drawing.Size(603, 600);
            this.Name = "BIOSUP_GUI";
            this.Text = "Biosup";
            this.Load += new System.EventHandler(this.BIOSUP_CONFIG_Load);
            this.tab_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.grpBox_vendor.ResumeLayout(false);
            this.grpBox_Chipsets.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.statusStrip_err_or_cwd.ResumeLayout(false);
            this.statusStrip_err_or_cwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_clear_config;
        private System.Windows.Forms.StatusStrip statusStrip_err_or_cwd;
        private System.Windows.Forms.ProgressBar progressBar_overall_progress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_select_all;
        private System.Windows.Forms.CheckedListBox listbox_vendor;
        private System.Windows.Forms.CheckedListBox listbox_INTEL_chipset;
        private System.Windows.Forms.CheckedListBox listbox_AMD_chipset;
        private System.Windows.Forms.GroupBox grpBox_vendor;
        private System.Windows.Forms.GroupBox grpBox_Chipsets;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_load_last;
        private System.Windows.Forms.CheckBox checkBox_intel_select_all;
        private System.Windows.Forms.CheckBox checkBox_AMD_select_all;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_cwd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_instructions;
    }
}

