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
            this.statusStrip_err_or_cwd = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_cwd = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage_stats = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_Current_Run = new System.Windows.Forms.TabPage();
            this.grpBox_log_history = new System.Windows.Forms.GroupBox();
            this.textBox_log_running = new System.Windows.Forms.TextBox();
            this.grpBox_current_run = new System.Windows.Forms.GroupBox();
            this.textBox_current_UEFI_info = new System.Windows.Forms.TextBox();
            this.grpBox_current_progress = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpBox_Overall_progress = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_overall_progress = new System.Windows.Forms.ProgressBar();
            this.tabPage_config = new System.Windows.Forms.TabPage();
            this.textBox_log_config = new System.Windows.Forms.TextBox();
            this.btn_load_last = new System.Windows.Forms.Button();
            this.grpBox_vendor = new System.Windows.Forms.GroupBox();
            this.checkBox_all_vendors = new System.Windows.Forms.CheckBox();
            this.listbox_vendor = new System.Windows.Forms.CheckedListBox();
            this.grpBox_Chipsets = new System.Windows.Forms.GroupBox();
            this.grpBox_chipset_intel = new System.Windows.Forms.GroupBox();
            this.checkBox_intel_select_all = new System.Windows.Forms.CheckBox();
            this.listbox_INTEL_chipset = new System.Windows.Forms.CheckedListBox();
            this.grpBox_chipset_amd = new System.Windows.Forms.GroupBox();
            this.checkBox_AMD_select_all = new System.Windows.Forms.CheckBox();
            this.listbox_AMD_chipset = new System.Windows.Forms.CheckedListBox();
            this.btn_select_all = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_clear_config = new System.Windows.Forms.Button();
            this.grpBox_Intructions = new System.Windows.Forms.GroupBox();
            this.textBox_instructions = new System.Windows.Forms.TextBox();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tabPage_admin = new System.Windows.Forms.TabPage();
            this.statusStrip_err_or_cwd.SuspendLayout();
            this.tabPage_stats.SuspendLayout();
            this.tabPage_Current_Run.SuspendLayout();
            this.grpBox_log_history.SuspendLayout();
            this.grpBox_current_run.SuspendLayout();
            this.grpBox_current_progress.SuspendLayout();
            this.grpBox_Overall_progress.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.grpBox_vendor.SuspendLayout();
            this.grpBox_Chipsets.SuspendLayout();
            this.grpBox_chipset_intel.SuspendLayout();
            this.grpBox_chipset_amd.SuspendLayout();
            this.grpBox_Intructions.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.SuspendLayout();
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
            // tabPage_stats
            // 
            this.tabPage_stats.Controls.Add(this.button1);
            this.tabPage_stats.Location = new System.Drawing.Point(4, 22);
            this.tabPage_stats.Name = "tabPage_stats";
            this.tabPage_stats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_stats.Size = new System.Drawing.Size(579, 511);
            this.tabPage_stats.TabIndex = 2;
            this.tabPage_stats.Text = "Statistics";
            this.tabPage_stats.UseVisualStyleBackColor = true;
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
            // tabPage_Current_Run
            // 
            this.tabPage_Current_Run.Controls.Add(this.grpBox_log_history);
            this.tabPage_Current_Run.Controls.Add(this.grpBox_current_run);
            this.tabPage_Current_Run.Controls.Add(this.grpBox_current_progress);
            this.tabPage_Current_Run.Controls.Add(this.grpBox_Overall_progress);
            this.tabPage_Current_Run.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Current_Run.Name = "tabPage_Current_Run";
            this.tabPage_Current_Run.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Current_Run.Size = new System.Drawing.Size(579, 511);
            this.tabPage_Current_Run.TabIndex = 1;
            this.tabPage_Current_Run.Text = "Current Run";
            this.tabPage_Current_Run.UseVisualStyleBackColor = true;
            // 
            // grpBox_log_history
            // 
            this.grpBox_log_history.Controls.Add(this.textBox_log_running);
            this.grpBox_log_history.Location = new System.Drawing.Point(227, 3);
            this.grpBox_log_history.Name = "grpBox_log_history";
            this.grpBox_log_history.Size = new System.Drawing.Size(344, 344);
            this.grpBox_log_history.TabIndex = 7;
            this.grpBox_log_history.TabStop = false;
            this.grpBox_log_history.Text = "Run Log";
            // 
            // textBox_log_running
            // 
            this.textBox_log_running.Location = new System.Drawing.Point(6, 15);
            this.textBox_log_running.Multiline = true;
            this.textBox_log_running.Name = "textBox_log_running";
            this.textBox_log_running.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log_running.Size = new System.Drawing.Size(332, 323);
            this.textBox_log_running.TabIndex = 4;
            // 
            // grpBox_current_run
            // 
            this.grpBox_current_run.Controls.Add(this.textBox_current_UEFI_info);
            this.grpBox_current_run.Location = new System.Drawing.Point(3, 3);
            this.grpBox_current_run.Name = "grpBox_current_run";
            this.grpBox_current_run.Size = new System.Drawing.Size(217, 344);
            this.grpBox_current_run.TabIndex = 6;
            this.grpBox_current_run.TabStop = false;
            this.grpBox_current_run.Text = "Current UEFI Infomation";
            // 
            // textBox_current_UEFI_info
            // 
            this.textBox_current_UEFI_info.Location = new System.Drawing.Point(6, 15);
            this.textBox_current_UEFI_info.Multiline = true;
            this.textBox_current_UEFI_info.Name = "textBox_current_UEFI_info";
            this.textBox_current_UEFI_info.Size = new System.Drawing.Size(206, 323);
            this.textBox_current_UEFI_info.TabIndex = 5;
            // 
            // grpBox_current_progress
            // 
            this.grpBox_current_progress.Controls.Add(this.label2);
            this.grpBox_current_progress.Controls.Add(this.progressBar1);
            this.grpBox_current_progress.Location = new System.Drawing.Point(3, 353);
            this.grpBox_current_progress.Name = "grpBox_current_progress";
            this.grpBox_current_progress.Size = new System.Drawing.Size(573, 73);
            this.grpBox_current_progress.TabIndex = 3;
            this.grpBox_current_progress.TabStop = false;
            this.grpBox_current_progress.Text = "Current Progress";
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
            // grpBox_Overall_progress
            // 
            this.grpBox_Overall_progress.Controls.Add(this.label1);
            this.grpBox_Overall_progress.Controls.Add(this.progressBar_overall_progress);
            this.grpBox_Overall_progress.Location = new System.Drawing.Point(3, 432);
            this.grpBox_Overall_progress.Name = "grpBox_Overall_progress";
            this.grpBox_Overall_progress.Size = new System.Drawing.Size(573, 73);
            this.grpBox_Overall_progress.TabIndex = 2;
            this.grpBox_Overall_progress.TabStop = false;
            this.grpBox_Overall_progress.Text = "Overall Progress";
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
            // tabPage_config
            // 
            this.tabPage_config.Controls.Add(this.textBox_log_config);
            this.tabPage_config.Controls.Add(this.btn_load_last);
            this.tabPage_config.Controls.Add(this.grpBox_vendor);
            this.tabPage_config.Controls.Add(this.grpBox_Chipsets);
            this.tabPage_config.Controls.Add(this.btn_select_all);
            this.tabPage_config.Controls.Add(this.btn_run);
            this.tabPage_config.Controls.Add(this.btn_clear_config);
            this.tabPage_config.Controls.Add(this.grpBox_Intructions);
            this.tabPage_config.Location = new System.Drawing.Point(4, 22);
            this.tabPage_config.Name = "tabPage_config";
            this.tabPage_config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_config.Size = new System.Drawing.Size(579, 511);
            this.tabPage_config.TabIndex = 0;
            this.tabPage_config.Text = "Configurator";
            this.tabPage_config.UseVisualStyleBackColor = true;
            // 
            // textBox_log_config
            // 
            this.textBox_log_config.Location = new System.Drawing.Point(7, 398);
            this.textBox_log_config.Multiline = true;
            this.textBox_log_config.Name = "textBox_log_config";
            this.textBox_log_config.ReadOnly = true;
            this.textBox_log_config.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log_config.Size = new System.Drawing.Size(564, 78);
            this.textBox_log_config.TabIndex = 11;
            // 
            // btn_load_last
            // 
            this.btn_load_last.Location = new System.Drawing.Point(6, 482);
            this.btn_load_last.Name = "btn_load_last";
            this.btn_load_last.Size = new System.Drawing.Size(75, 23);
            this.btn_load_last.TabIndex = 10;
            this.btn_load_last.Text = "Load Last";
            this.btn_load_last.UseVisualStyleBackColor = true;
            this.btn_load_last.Click += new System.EventHandler(this.btn_load_last_Click);
            // 
            // grpBox_vendor
            // 
            this.grpBox_vendor.Controls.Add(this.checkBox_all_vendors);
            this.grpBox_vendor.Controls.Add(this.listbox_vendor);
            this.grpBox_vendor.Location = new System.Drawing.Point(376, 3);
            this.grpBox_vendor.Name = "grpBox_vendor";
            this.grpBox_vendor.Size = new System.Drawing.Size(195, 255);
            this.grpBox_vendor.TabIndex = 8;
            this.grpBox_vendor.TabStop = false;
            this.grpBox_vendor.Text = "Vendor";
            // 
            // checkBox_all_vendors
            // 
            this.checkBox_all_vendors.AutoSize = true;
            this.checkBox_all_vendors.Location = new System.Drawing.Point(7, 222);
            this.checkBox_all_vendors.Name = "checkBox_all_vendors";
            this.checkBox_all_vendors.Size = new System.Drawing.Size(70, 17);
            this.checkBox_all_vendors.TabIndex = 6;
            this.checkBox_all_vendors.Text = "Select All";
            this.checkBox_all_vendors.UseVisualStyleBackColor = true;
            this.checkBox_all_vendors.CheckedChanged += new System.EventHandler(this.checkBox_all_vendors_CheckedChanged);
            // 
            // listbox_vendor
            // 
            this.listbox_vendor.FormattingEnabled = true;
            this.listbox_vendor.Location = new System.Drawing.Point(6, 17);
            this.listbox_vendor.Name = "listbox_vendor";
            this.listbox_vendor.Size = new System.Drawing.Size(183, 199);
            this.listbox_vendor.TabIndex = 5;
            // 
            // grpBox_Chipsets
            // 
            this.grpBox_Chipsets.Controls.Add(this.grpBox_chipset_intel);
            this.grpBox_Chipsets.Controls.Add(this.grpBox_chipset_amd);
            this.grpBox_Chipsets.Location = new System.Drawing.Point(0, 3);
            this.grpBox_Chipsets.Name = "grpBox_Chipsets";
            this.grpBox_Chipsets.Size = new System.Drawing.Size(370, 388);
            this.grpBox_Chipsets.TabIndex = 7;
            this.grpBox_Chipsets.TabStop = false;
            this.grpBox_Chipsets.Text = "Chipsets";
            // 
            // grpBox_chipset_intel
            // 
            this.grpBox_chipset_intel.Controls.Add(this.checkBox_intel_select_all);
            this.grpBox_chipset_intel.Controls.Add(this.listbox_INTEL_chipset);
            this.grpBox_chipset_intel.Location = new System.Drawing.Point(197, 17);
            this.grpBox_chipset_intel.Name = "grpBox_chipset_intel";
            this.grpBox_chipset_intel.Size = new System.Drawing.Size(167, 365);
            this.grpBox_chipset_intel.TabIndex = 4;
            this.grpBox_chipset_intel.TabStop = false;
            this.grpBox_chipset_intel.Text = "INTEL";
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
            this.checkBox_intel_select_all.CheckedChanged += new System.EventHandler(this.checkBox_intel_select_all_CheckedChanged);
            // 
            // listbox_INTEL_chipset
            // 
            this.listbox_INTEL_chipset.FormattingEnabled = true;
            this.listbox_INTEL_chipset.Location = new System.Drawing.Point(6, 14);
            this.listbox_INTEL_chipset.Name = "listbox_INTEL_chipset";
            this.listbox_INTEL_chipset.Size = new System.Drawing.Size(152, 319);
            this.listbox_INTEL_chipset.TabIndex = 4;
            // 
            // grpBox_chipset_amd
            // 
            this.grpBox_chipset_amd.Controls.Add(this.checkBox_AMD_select_all);
            this.grpBox_chipset_amd.Controls.Add(this.listbox_AMD_chipset);
            this.grpBox_chipset_amd.Location = new System.Drawing.Point(19, 17);
            this.grpBox_chipset_amd.Name = "grpBox_chipset_amd";
            this.grpBox_chipset_amd.Size = new System.Drawing.Size(161, 365);
            this.grpBox_chipset_amd.TabIndex = 0;
            this.grpBox_chipset_amd.TabStop = false;
            this.grpBox_chipset_amd.Text = "AMD";
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
            this.checkBox_AMD_select_all.CheckedChanged += new System.EventHandler(this.checkBox_AMD_select_all_CheckedChanged);
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
            this.btn_select_all.Click += new System.EventHandler(this.btn_select_all_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(496, 482);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_clear_config
            // 
            this.btn_clear_config.Location = new System.Drawing.Point(135, 482);
            this.btn_clear_config.Name = "btn_clear_config";
            this.btn_clear_config.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_config.TabIndex = 0;
            this.btn_clear_config.Text = "Clear Config";
            this.btn_clear_config.UseVisualStyleBackColor = true;
            this.btn_clear_config.Click += new System.EventHandler(this.btn_clear_config_Click);
            // 
            // grpBox_Intructions
            // 
            this.grpBox_Intructions.Controls.Add(this.textBox_instructions);
            this.grpBox_Intructions.Location = new System.Drawing.Point(376, 264);
            this.grpBox_Intructions.Name = "grpBox_Intructions";
            this.grpBox_Intructions.Size = new System.Drawing.Size(195, 127);
            this.grpBox_Intructions.TabIndex = 9;
            this.grpBox_Intructions.TabStop = false;
            this.grpBox_Intructions.Text = "GUI Intructions";
            // 
            // textBox_instructions
            // 
            this.textBox_instructions.AcceptsReturn = true;
            this.textBox_instructions.Location = new System.Drawing.Point(7, 20);
            this.textBox_instructions.Multiline = true;
            this.textBox_instructions.Name = "textBox_instructions";
            this.textBox_instructions.ReadOnly = true;
            this.textBox_instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_instructions.Size = new System.Drawing.Size(182, 101);
            this.textBox_instructions.TabIndex = 0;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tabPage_config);
            this.tab_control.Controls.Add(this.tabPage_Current_Run);
            this.tab_control.Controls.Add(this.tabPage_stats);
            this.tab_control.Controls.Add(this.tabPage_admin);
            this.tab_control.Location = new System.Drawing.Point(0, -1);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(587, 537);
            this.tab_control.TabIndex = 1;
            // 
            // tabPage_admin
            // 
            this.tabPage_admin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin.Name = "tabPage_admin";
            this.tabPage_admin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin.Size = new System.Drawing.Size(579, 511);
            this.tabPage_admin.TabIndex = 3;
            this.tabPage_admin.Text = "Administrator";
            this.tabPage_admin.UseVisualStyleBackColor = true;
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
            this.statusStrip_err_or_cwd.ResumeLayout(false);
            this.statusStrip_err_or_cwd.PerformLayout();
            this.tabPage_stats.ResumeLayout(false);
            this.tabPage_Current_Run.ResumeLayout(false);
            this.grpBox_log_history.ResumeLayout(false);
            this.grpBox_log_history.PerformLayout();
            this.grpBox_current_run.ResumeLayout(false);
            this.grpBox_current_run.PerformLayout();
            this.grpBox_current_progress.ResumeLayout(false);
            this.grpBox_current_progress.PerformLayout();
            this.grpBox_Overall_progress.ResumeLayout(false);
            this.grpBox_Overall_progress.PerformLayout();
            this.tabPage_config.ResumeLayout(false);
            this.tabPage_config.PerformLayout();
            this.grpBox_vendor.ResumeLayout(false);
            this.grpBox_vendor.PerformLayout();
            this.grpBox_Chipsets.ResumeLayout(false);
            this.grpBox_chipset_intel.ResumeLayout(false);
            this.grpBox_chipset_intel.PerformLayout();
            this.grpBox_chipset_amd.ResumeLayout(false);
            this.grpBox_chipset_amd.PerformLayout();
            this.grpBox_Intructions.ResumeLayout(false);
            this.grpBox_Intructions.PerformLayout();
            this.tab_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip_err_or_cwd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_cwd;
        private System.Windows.Forms.TabPage tabPage_stats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage_Current_Run;
        private System.Windows.Forms.GroupBox grpBox_log_history;
        private System.Windows.Forms.TextBox textBox_log_running;
        private System.Windows.Forms.GroupBox grpBox_current_run;
        private System.Windows.Forms.TextBox textBox_current_UEFI_info;
        private System.Windows.Forms.GroupBox grpBox_current_progress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grpBox_Overall_progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_overall_progress;
        private System.Windows.Forms.TabPage tabPage_config;
        private System.Windows.Forms.TextBox textBox_log_config;
        private System.Windows.Forms.Button btn_load_last;
        private System.Windows.Forms.GroupBox grpBox_vendor;
        private System.Windows.Forms.CheckedListBox listbox_vendor;
        private System.Windows.Forms.GroupBox grpBox_Chipsets;
        private System.Windows.Forms.GroupBox grpBox_chipset_intel;
        private System.Windows.Forms.CheckBox checkBox_intel_select_all;
        private System.Windows.Forms.CheckedListBox listbox_INTEL_chipset;
        private System.Windows.Forms.GroupBox grpBox_chipset_amd;
        private System.Windows.Forms.CheckBox checkBox_AMD_select_all;
        private System.Windows.Forms.CheckedListBox listbox_AMD_chipset;
        private System.Windows.Forms.Button btn_select_all;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_clear_config;
        private System.Windows.Forms.GroupBox grpBox_Intructions;
        private System.Windows.Forms.TextBox textBox_instructions;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.CheckBox checkBox_all_vendors;
        private System.Windows.Forms.TabPage tabPage_admin;
    }
}

