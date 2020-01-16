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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIOSUP_GUI));
            this.statusStrip_err_or_cwd = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_cwd = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage_stats = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_Current_Run = new System.Windows.Forms.TabPage();
            this.grpBox_log_history = new System.Windows.Forms.GroupBox();
            this.textBox_log_running = new System.Windows.Forms.TextBox();
            this.grpBox_current_run = new System.Windows.Forms.GroupBox();
            this.textBox_current_UEFI_info = new System.Windows.Forms.TextBox();
            this.grpBox_current_progress = new System.Windows.Forms.GroupBox();
            this.label_current_point = new System.Windows.Forms.Label();
            this.progressBar_current_progress = new System.Windows.Forms.ProgressBar();
            this.grpBox_Overall_progress = new System.Windows.Forms.GroupBox();
            this.label_current_progress_fraction = new System.Windows.Forms.Label();
            this.progressBar_overall_progress = new System.Windows.Forms.ProgressBar();
            this.tabPage_config = new System.Windows.Forms.TabPage();
            this.button_save_config = new System.Windows.Forms.Button();
            this.button_load_config = new System.Windows.Forms.Button();
            this.groupBox_what_to_get = new System.Windows.Forms.GroupBox();
            this.comboBox_what_to_get = new System.Windows.Forms.ComboBox();
            this.textBox_log_config = new System.Windows.Forms.TextBox();
            this.grpBox_vendor = new System.Windows.Forms.GroupBox();
            this.checkBox_all_vendors = new System.Windows.Forms.CheckBox();
            this.listbox_vendor = new System.Windows.Forms.CheckedListBox();
            this.grpBox_Chipsets = new System.Windows.Forms.GroupBox();
            this.grpBox_chipset_intel = new System.Windows.Forms.GroupBox();
            this.checkBox_vendor_select_all = new System.Windows.Forms.CheckBox();
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
            this.textBox_admin_log = new System.Windows.Forms.TextBox();
            this.tabControl_admin = new System.Windows.Forms.TabControl();
            this.tabPage_admin_url = new System.Windows.Forms.TabPage();
            this.groupBox_admin_url_contain_url = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_admin_url_urls_add = new System.Windows.Forms.TabPage();
            this.button_admin_url_bulk_get = new System.Windows.Forms.Button();
            this.button_admin_url_model_copy = new System.Windows.Forms.Button();
            this.label_admin_url_model = new System.Windows.Forms.Label();
            this.btn_admin_url_add_url = new System.Windows.Forms.Button();
            this.flowLayoutPanel_add_url_str = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage_admin_url_urls_edit = new System.Windows.Forms.TabPage();
            this.button_admin_url_save_del = new System.Windows.Forms.Button();
            this.flowLayoutPanel_admin_url_edit = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_select_model = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_admin_url_chipset = new System.Windows.Forms.ComboBox();
            this.comboBox_admin_url_vendor = new System.Windows.Forms.ComboBox();
            this.label_no_url_to_add = new System.Windows.Forms.Label();
            this.comboBox_select_model = new System.Windows.Forms.ComboBox();
            this.btn_get_model_from_database = new System.Windows.Forms.Button();
            this.numericUpDown_admin_url_url_to_add = new System.Windows.Forms.NumericUpDown();
            this.btn_add_url = new System.Windows.Forms.Button();
            this.tabPage_admin_model = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_admin_model_copy = new System.Windows.Forms.Button();
            this.label_admin_model = new System.Windows.Forms.Label();
            this.button_save_model_url = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_admin_model_url = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_admin_model_delete = new System.Windows.Forms.ComboBox();
            this.btn_delete_model = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_chipset_select = new System.Windows.Forms.GroupBox();
            this.comboBox_select_chipset = new System.Windows.Forms.ComboBox();
            this.groupBox_vendor_select = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_select_vendor = new System.Windows.Forms.ComboBox();
            this.groupBox_model_name = new System.Windows.Forms.GroupBox();
            this.textBox_admin_model_sku = new System.Windows.Forms.TextBox();
            this.btn_add_model = new System.Windows.Forms.Button();
            this.groupBox_model_bios_url = new System.Windows.Forms.GroupBox();
            this.textBox_model_bios_url = new System.Windows.Forms.TextBox();
            this.tabPage_admin_vendor = new System.Windows.Forms.TabPage();
            this.groupBox_edit_existing = new System.Windows.Forms.GroupBox();
            this.button_admin_vendor_del = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_addon_edit = new System.Windows.Forms.TextBox();
            this.groupBox_admin_vendor_edit_base = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_base_edit = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_sort_edit = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_name = new System.Windows.Forms.TextBox();
            this.btn_save_edits = new System.Windows.Forms.Button();
            this.comboBox_select_vendor_to_edit = new System.Windows.Forms.ComboBox();
            this.groupBox_add_vendor = new System.Windows.Forms.GroupBox();
            this.button_add_vendor = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_addon_add = new System.Windows.Forms.TextBox();
            this.groupBox_admin_vendor_add_base = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_base_add = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_sort_add = new System.Windows.Forms.TextBox();
            this.groupBox_admin_vendor_vendor_name = new System.Windows.Forms.GroupBox();
            this.textBox_admin_vendor_name_add = new System.Windows.Forms.TextBox();
            this.btn_add_vendor = new System.Windows.Forms.Button();
            this.tabPage_chipset_add = new System.Windows.Forms.TabPage();
            this.groupBox_remove_chipset = new System.Windows.Forms.GroupBox();
            this.comboBox_select_chipset_to_remove = new System.Windows.Forms.ComboBox();
            this.button_remvoe_chipset = new System.Windows.Forms.Button();
            this.groupBox_add_shipset = new System.Windows.Forms.GroupBox();
            this.btn_add_chipset = new System.Windows.Forms.Button();
            this.comboBox_admin_chipset_vendor = new System.Windows.Forms.ComboBox();
            this.textBox_admin_chipset_name = new System.Windows.Forms.TextBox();
            this.label_admin_chispset_vendor = new System.Windows.Forms.Label();
            this.label_admin_chipset_name = new System.Windows.Forms.Label();
            this.tabPage_admin_scripts = new System.Windows.Forms.TabPage();
            this.groupBox_script_buttons = new System.Windows.Forms.GroupBox();
            this.button_get_models = new System.Windows.Forms.Button();
            this.tabPage_feed = new System.Windows.Forms.TabPage();
            this.tabControl_admin_feed = new System.Windows.Forms.TabControl();
            this.tabPage_admin_feed_url = new System.Windows.Forms.TabPage();
            this.groupBox_feed = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_admin_scripts = new System.Windows.Forms.FlowLayoutPanel();
            this.button_get_next_10 = new System.Windows.Forms.Button();
            this.tabPage_admin_feed_model = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider_admin_model_validator = new System.Windows.Forms.ErrorProvider(this.components);
            this.pull_link_ddg = new System.Windows.Forms.Button();
            this.button_goto_url = new System.Windows.Forms.Button();
            this.admin_url_url_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip_err_or_cwd.SuspendLayout();
            this.tabPage_stats.SuspendLayout();
            this.tabPage_Current_Run.SuspendLayout();
            this.grpBox_log_history.SuspendLayout();
            this.grpBox_current_run.SuspendLayout();
            this.grpBox_current_progress.SuspendLayout();
            this.grpBox_Overall_progress.SuspendLayout();
            this.tabPage_config.SuspendLayout();
            this.groupBox_what_to_get.SuspendLayout();
            this.grpBox_vendor.SuspendLayout();
            this.grpBox_Chipsets.SuspendLayout();
            this.grpBox_chipset_intel.SuspendLayout();
            this.grpBox_chipset_amd.SuspendLayout();
            this.grpBox_Intructions.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.tabPage_admin.SuspendLayout();
            this.tabControl_admin.SuspendLayout();
            this.tabPage_admin_url.SuspendLayout();
            this.groupBox_admin_url_contain_url.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_admin_url_urls_add.SuspendLayout();
            this.tabPage_admin_url_urls_edit.SuspendLayout();
            this.groupBox_select_model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_admin_url_url_to_add)).BeginInit();
            this.tabPage_admin_model.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_chipset_select.SuspendLayout();
            this.groupBox_vendor_select.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_model_name.SuspendLayout();
            this.groupBox_model_bios_url.SuspendLayout();
            this.tabPage_admin_vendor.SuspendLayout();
            this.groupBox_edit_existing.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox_admin_vendor_edit_base.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox_add_vendor.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox_admin_vendor_add_base.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox_admin_vendor_vendor_name.SuspendLayout();
            this.tabPage_chipset_add.SuspendLayout();
            this.groupBox_remove_chipset.SuspendLayout();
            this.groupBox_add_shipset.SuspendLayout();
            this.tabPage_admin_scripts.SuspendLayout();
            this.groupBox_script_buttons.SuspendLayout();
            this.tabPage_feed.SuspendLayout();
            this.tabControl_admin_feed.SuspendLayout();
            this.tabPage_admin_feed_url.SuspendLayout();
            this.groupBox_feed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_admin_model_validator)).BeginInit();
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
            this.tabPage_stats.Controls.Add(this.label1);
            this.tabPage_stats.Controls.Add(this.button1);
            this.tabPage_stats.Location = new System.Drawing.Point(4, 22);
            this.tabPage_stats.Name = "tabPage_stats";
            this.tabPage_stats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_stats.Size = new System.Drawing.Size(579, 511);
            this.tabPage_stats.TabIndex = 2;
            this.tabPage_stats.Text = "Statistics";
            this.tabPage_stats.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WIP";
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
            this.textBox_log_running.ReadOnly = true;
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
            this.textBox_current_UEFI_info.Location = new System.Drawing.Point(6, 19);
            this.textBox_current_UEFI_info.Multiline = true;
            this.textBox_current_UEFI_info.Name = "textBox_current_UEFI_info";
            this.textBox_current_UEFI_info.ReadOnly = true;
            this.textBox_current_UEFI_info.Size = new System.Drawing.Size(206, 319);
            this.textBox_current_UEFI_info.TabIndex = 5;
            // 
            // grpBox_current_progress
            // 
            this.grpBox_current_progress.Controls.Add(this.label_current_point);
            this.grpBox_current_progress.Controls.Add(this.progressBar_current_progress);
            this.grpBox_current_progress.Location = new System.Drawing.Point(3, 353);
            this.grpBox_current_progress.Name = "grpBox_current_progress";
            this.grpBox_current_progress.Size = new System.Drawing.Size(573, 73);
            this.grpBox_current_progress.TabIndex = 3;
            this.grpBox_current_progress.TabStop = false;
            this.grpBox_current_progress.Text = "Current Progress";
            // 
            // label_current_point
            // 
            this.label_current_point.AutoSize = true;
            this.label_current_point.Location = new System.Drawing.Point(7, 20);
            this.label_current_point.Name = "label_current_point";
            this.label_current_point.Size = new System.Drawing.Size(74, 13);
            this.label_current_point.TabIndex = 2;
            this.label_current_point.Text = "Current Point: ";
            // 
            // progressBar_current_progress
            // 
            this.progressBar_current_progress.Location = new System.Drawing.Point(10, 36);
            this.progressBar_current_progress.Name = "progressBar_current_progress";
            this.progressBar_current_progress.Size = new System.Drawing.Size(540, 23);
            this.progressBar_current_progress.TabIndex = 1;
            // 
            // grpBox_Overall_progress
            // 
            this.grpBox_Overall_progress.Controls.Add(this.label_current_progress_fraction);
            this.grpBox_Overall_progress.Controls.Add(this.progressBar_overall_progress);
            this.grpBox_Overall_progress.Location = new System.Drawing.Point(3, 432);
            this.grpBox_Overall_progress.Name = "grpBox_Overall_progress";
            this.grpBox_Overall_progress.Size = new System.Drawing.Size(573, 73);
            this.grpBox_Overall_progress.TabIndex = 2;
            this.grpBox_Overall_progress.TabStop = false;
            this.grpBox_Overall_progress.Text = "Overall Progress";
            // 
            // label_current_progress_fraction
            // 
            this.label_current_progress_fraction.AutoSize = true;
            this.label_current_progress_fraction.Location = new System.Drawing.Point(7, 20);
            this.label_current_progress_fraction.Name = "label_current_progress_fraction";
            this.label_current_progress_fraction.Size = new System.Drawing.Size(42, 13);
            this.label_current_progress_fraction.TabIndex = 2;
            this.label_current_progress_fraction.Text = "NA/NA";
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
            this.tabPage_config.Controls.Add(this.button_save_config);
            this.tabPage_config.Controls.Add(this.button_load_config);
            this.tabPage_config.Controls.Add(this.groupBox_what_to_get);
            this.tabPage_config.Controls.Add(this.textBox_log_config);
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
            // button_save_config
            // 
            this.button_save_config.Location = new System.Drawing.Point(165, 482);
            this.button_save_config.Name = "button_save_config";
            this.button_save_config.Size = new System.Drawing.Size(75, 23);
            this.button_save_config.TabIndex = 15;
            this.button_save_config.Text = "Save Config";
            this.button_save_config.UseVisualStyleBackColor = true;
            this.button_save_config.Click += new System.EventHandler(this.Button_save_config_Click);
            // 
            // button_load_config
            // 
            this.button_load_config.Location = new System.Drawing.Point(84, 482);
            this.button_load_config.Name = "button_load_config";
            this.button_load_config.Size = new System.Drawing.Size(75, 23);
            this.button_load_config.TabIndex = 14;
            this.button_load_config.Text = "Load Config";
            this.button_load_config.UseVisualStyleBackColor = true;
            this.button_load_config.Click += new System.EventHandler(this.Button_load_config_Click);
            // 
            // groupBox_what_to_get
            // 
            this.groupBox_what_to_get.Controls.Add(this.comboBox_what_to_get);
            this.groupBox_what_to_get.Location = new System.Drawing.Point(377, 265);
            this.groupBox_what_to_get.Name = "groupBox_what_to_get";
            this.groupBox_what_to_get.Size = new System.Drawing.Size(200, 51);
            this.groupBox_what_to_get.TabIndex = 13;
            this.groupBox_what_to_get.TabStop = false;
            this.groupBox_what_to_get.Text = "What to get";
            // 
            // comboBox_what_to_get
            // 
            this.comboBox_what_to_get.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_what_to_get.FormattingEnabled = true;
            this.comboBox_what_to_get.Location = new System.Drawing.Point(6, 19);
            this.comboBox_what_to_get.Name = "comboBox_what_to_get";
            this.comboBox_what_to_get.Size = new System.Drawing.Size(182, 21);
            this.comboBox_what_to_get.TabIndex = 12;
            // 
            // textBox_log_config
            // 
            this.textBox_log_config.Location = new System.Drawing.Point(7, 398);
            this.textBox_log_config.Multiline = true;
            this.textBox_log_config.Name = "textBox_log_config";
            this.textBox_log_config.ReadOnly = true;
            this.textBox_log_config.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log_config.Size = new System.Drawing.Size(363, 78);
            this.textBox_log_config.TabIndex = 11;
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
            this.checkBox_all_vendors.CheckedChanged += new System.EventHandler(this.CheckBox_all_vendors_CheckedChanged);
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
            this.grpBox_chipset_intel.Controls.Add(this.checkBox_vendor_select_all);
            this.grpBox_chipset_intel.Controls.Add(this.listbox_INTEL_chipset);
            this.grpBox_chipset_intel.Location = new System.Drawing.Point(197, 17);
            this.grpBox_chipset_intel.Name = "grpBox_chipset_intel";
            this.grpBox_chipset_intel.Size = new System.Drawing.Size(167, 365);
            this.grpBox_chipset_intel.TabIndex = 4;
            this.grpBox_chipset_intel.TabStop = false;
            this.grpBox_chipset_intel.Text = "INTEL";
            // 
            // checkBox_vendor_select_all
            // 
            this.checkBox_vendor_select_all.AutoSize = true;
            this.checkBox_vendor_select_all.Location = new System.Drawing.Point(6, 339);
            this.checkBox_vendor_select_all.Name = "checkBox_vendor_select_all";
            this.checkBox_vendor_select_all.Size = new System.Drawing.Size(70, 17);
            this.checkBox_vendor_select_all.TabIndex = 5;
            this.checkBox_vendor_select_all.Text = "Select All";
            this.checkBox_vendor_select_all.UseVisualStyleBackColor = true;
            this.checkBox_vendor_select_all.CheckedChanged += new System.EventHandler(this.CheckBox_intel_select_all_CheckedChanged);
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
            this.checkBox_AMD_select_all.CheckedChanged += new System.EventHandler(this.CheckBox_AMD_select_all_CheckedChanged);
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
            this.btn_select_all.Click += new System.EventHandler(this.Btn_select_all_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(496, 482);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.Btn_run_Click);
            // 
            // btn_clear_config
            // 
            this.btn_clear_config.Location = new System.Drawing.Point(3, 482);
            this.btn_clear_config.Name = "btn_clear_config";
            this.btn_clear_config.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_config.TabIndex = 0;
            this.btn_clear_config.Text = "Clear Config";
            this.btn_clear_config.UseVisualStyleBackColor = true;
            this.btn_clear_config.Click += new System.EventHandler(this.Btn_clear_config_Click);
            // 
            // grpBox_Intructions
            // 
            this.grpBox_Intructions.Controls.Add(this.textBox_instructions);
            this.grpBox_Intructions.Location = new System.Drawing.Point(376, 322);
            this.grpBox_Intructions.Name = "grpBox_Intructions";
            this.grpBox_Intructions.Size = new System.Drawing.Size(195, 154);
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
            this.textBox_instructions.Size = new System.Drawing.Size(182, 128);
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
            this.tabPage_admin.Controls.Add(this.textBox_admin_log);
            this.tabPage_admin.Controls.Add(this.tabControl_admin);
            this.tabPage_admin.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin.Name = "tabPage_admin";
            this.tabPage_admin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin.Size = new System.Drawing.Size(579, 511);
            this.tabPage_admin.TabIndex = 3;
            this.tabPage_admin.Text = "Administrator";
            // 
            // textBox_admin_log
            // 
            this.textBox_admin_log.Location = new System.Drawing.Point(4, 403);
            this.textBox_admin_log.Multiline = true;
            this.textBox_admin_log.Name = "textBox_admin_log";
            this.textBox_admin_log.ReadOnly = true;
            this.textBox_admin_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_admin_log.Size = new System.Drawing.Size(572, 108);
            this.textBox_admin_log.TabIndex = 1;
            // 
            // tabControl_admin
            // 
            this.tabControl_admin.Controls.Add(this.tabPage_admin_url);
            this.tabControl_admin.Controls.Add(this.tabPage_admin_model);
            this.tabControl_admin.Controls.Add(this.tabPage_admin_vendor);
            this.tabControl_admin.Controls.Add(this.tabPage_chipset_add);
            this.tabControl_admin.Controls.Add(this.tabPage_admin_scripts);
            this.tabControl_admin.Controls.Add(this.tabPage_feed);
            this.tabControl_admin.Location = new System.Drawing.Point(4, 4);
            this.tabControl_admin.Name = "tabControl_admin";
            this.tabControl_admin.SelectedIndex = 0;
            this.tabControl_admin.Size = new System.Drawing.Size(572, 397);
            this.tabControl_admin.TabIndex = 0;
            // 
            // tabPage_admin_url
            // 
            this.tabPage_admin_url.Controls.Add(this.groupBox_admin_url_contain_url);
            this.tabPage_admin_url.Controls.Add(this.groupBox_select_model);
            this.tabPage_admin_url.Controls.Add(this.btn_add_url);
            this.tabPage_admin_url.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_url.Name = "tabPage_admin_url";
            this.tabPage_admin_url.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_url.Size = new System.Drawing.Size(564, 371);
            this.tabPage_admin_url.TabIndex = 0;
            this.tabPage_admin_url.Text = "BIOS URL";
            this.tabPage_admin_url.UseVisualStyleBackColor = true;
            // 
            // groupBox_admin_url_contain_url
            // 
            this.groupBox_admin_url_contain_url.Controls.Add(this.tabControl1);
            this.groupBox_admin_url_contain_url.Location = new System.Drawing.Point(6, 112);
            this.groupBox_admin_url_contain_url.Name = "groupBox_admin_url_contain_url";
            this.groupBox_admin_url_contain_url.Size = new System.Drawing.Size(552, 263);
            this.groupBox_admin_url_contain_url.TabIndex = 7;
            this.groupBox_admin_url_contain_url.TabStop = false;
            this.groupBox_admin_url_contain_url.Text = "URL\'s";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_admin_url_urls_add);
            this.tabControl1.Controls.Add(this.tabPage_admin_url_urls_edit);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 237);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage_admin_url_urls_add
            // 
            this.tabPage_admin_url_urls_add.Controls.Add(this.button2);
            this.tabPage_admin_url_urls_add.Controls.Add(this.admin_url_url_label);
            this.tabPage_admin_url_urls_add.Controls.Add(this.button_admin_url_bulk_get);
            this.tabPage_admin_url_urls_add.Controls.Add(this.button_admin_url_model_copy);
            this.tabPage_admin_url_urls_add.Controls.Add(this.label_admin_url_model);
            this.tabPage_admin_url_urls_add.Controls.Add(this.btn_admin_url_add_url);
            this.tabPage_admin_url_urls_add.Controls.Add(this.flowLayoutPanel_add_url_str);
            this.tabPage_admin_url_urls_add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_url_urls_add.Name = "tabPage_admin_url_urls_add";
            this.tabPage_admin_url_urls_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_url_urls_add.Size = new System.Drawing.Size(538, 211);
            this.tabPage_admin_url_urls_add.TabIndex = 0;
            this.tabPage_admin_url_urls_add.Text = "Add";
            this.tabPage_admin_url_urls_add.UseVisualStyleBackColor = true;
            // 
            // button_admin_url_bulk_get
            // 
            this.button_admin_url_bulk_get.Location = new System.Drawing.Point(413, 172);
            this.button_admin_url_bulk_get.Name = "button_admin_url_bulk_get";
            this.button_admin_url_bulk_get.Size = new System.Drawing.Size(51, 23);
            this.button_admin_url_bulk_get.TabIndex = 10;
            this.button_admin_url_bulk_get.Text = "Pull";
            this.button_admin_url_bulk_get.UseVisualStyleBackColor = true;
            this.button_admin_url_bulk_get.Click += new System.EventHandler(this.Button_admin_url_bulk_get_Click);
            // 
            // button_admin_url_model_copy
            // 
            this.button_admin_url_model_copy.Location = new System.Drawing.Point(332, 172);
            this.button_admin_url_model_copy.Name = "button_admin_url_model_copy";
            this.button_admin_url_model_copy.Size = new System.Drawing.Size(75, 23);
            this.button_admin_url_model_copy.TabIndex = 9;
            this.button_admin_url_model_copy.Text = "Copy Model";
            this.button_admin_url_model_copy.UseVisualStyleBackColor = true;
            this.button_admin_url_model_copy.Click += new System.EventHandler(this.Button_admin_url_model_copy_Click);
            // 
            // label_admin_url_model
            // 
            this.label_admin_url_model.AutoSize = true;
            this.label_admin_url_model.Location = new System.Drawing.Point(6, 172);
            this.label_admin_url_model.Name = "label_admin_url_model";
            this.label_admin_url_model.Size = new System.Drawing.Size(98, 13);
            this.label_admin_url_model.TabIndex = 8;
            this.label_admin_url_model.Text = "[MOTHERBOARD]";
            // 
            // btn_admin_url_add_url
            // 
            this.btn_admin_url_add_url.Location = new System.Drawing.Point(470, 172);
            this.btn_admin_url_add_url.Name = "btn_admin_url_add_url";
            this.btn_admin_url_add_url.Size = new System.Drawing.Size(62, 23);
            this.btn_admin_url_add_url.TabIndex = 7;
            this.btn_admin_url_add_url.Text = "Add";
            this.btn_admin_url_add_url.UseVisualStyleBackColor = true;
            this.btn_admin_url_add_url.Click += new System.EventHandler(this.Btn_admin_url_add_url_Click_1);
            // 
            // flowLayoutPanel_add_url_str
            // 
            this.flowLayoutPanel_add_url_str.AutoScroll = true;
            this.flowLayoutPanel_add_url_str.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel_add_url_str.Name = "flowLayoutPanel_add_url_str";
            this.flowLayoutPanel_add_url_str.Size = new System.Drawing.Size(526, 160);
            this.flowLayoutPanel_add_url_str.TabIndex = 6;
            // 
            // tabPage_admin_url_urls_edit
            // 
            this.tabPage_admin_url_urls_edit.Controls.Add(this.button_admin_url_save_del);
            this.tabPage_admin_url_urls_edit.Controls.Add(this.flowLayoutPanel_admin_url_edit);
            this.tabPage_admin_url_urls_edit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_url_urls_edit.Name = "tabPage_admin_url_urls_edit";
            this.tabPage_admin_url_urls_edit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_url_urls_edit.Size = new System.Drawing.Size(538, 201);
            this.tabPage_admin_url_urls_edit.TabIndex = 1;
            this.tabPage_admin_url_urls_edit.Text = "Edit/Delete";
            this.tabPage_admin_url_urls_edit.UseVisualStyleBackColor = true;
            // 
            // button_admin_url_save_del
            // 
            this.button_admin_url_save_del.Location = new System.Drawing.Point(438, 172);
            this.button_admin_url_save_del.Name = "button_admin_url_save_del";
            this.button_admin_url_save_del.Size = new System.Drawing.Size(84, 23);
            this.button_admin_url_save_del.TabIndex = 14;
            this.button_admin_url_save_del.Text = "Save/Delete";
            this.button_admin_url_save_del.UseVisualStyleBackColor = true;
            this.button_admin_url_save_del.Click += new System.EventHandler(this.Button_admin_url_save_del_Click);
            // 
            // flowLayoutPanel_admin_url_edit
            // 
            this.flowLayoutPanel_admin_url_edit.AutoScroll = true;
            this.flowLayoutPanel_admin_url_edit.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel_admin_url_edit.Name = "flowLayoutPanel_admin_url_edit";
            this.flowLayoutPanel_admin_url_edit.Size = new System.Drawing.Size(516, 160);
            this.flowLayoutPanel_admin_url_edit.TabIndex = 13;
            // 
            // groupBox_select_model
            // 
            this.groupBox_select_model.Controls.Add(this.label5);
            this.groupBox_select_model.Controls.Add(this.label4);
            this.groupBox_select_model.Controls.Add(this.label3);
            this.groupBox_select_model.Controls.Add(this.comboBox_admin_url_chipset);
            this.groupBox_select_model.Controls.Add(this.comboBox_admin_url_vendor);
            this.groupBox_select_model.Controls.Add(this.label_no_url_to_add);
            this.groupBox_select_model.Controls.Add(this.comboBox_select_model);
            this.groupBox_select_model.Controls.Add(this.btn_get_model_from_database);
            this.groupBox_select_model.Controls.Add(this.numericUpDown_admin_url_url_to_add);
            this.groupBox_select_model.Location = new System.Drawing.Point(6, 6);
            this.groupBox_select_model.Name = "groupBox_select_model";
            this.groupBox_select_model.Size = new System.Drawing.Size(552, 100);
            this.groupBox_select_model.TabIndex = 4;
            this.groupBox_select_model.TabStop = false;
            this.groupBox_select_model.Text = "Select Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter by Chipset: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter by Vendor: ";
            // 
            // comboBox_admin_url_chipset
            // 
            this.comboBox_admin_url_chipset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_admin_url_chipset.FormattingEnabled = true;
            this.comboBox_admin_url_chipset.Location = new System.Drawing.Point(99, 41);
            this.comboBox_admin_url_chipset.Name = "comboBox_admin_url_chipset";
            this.comboBox_admin_url_chipset.Size = new System.Drawing.Size(239, 21);
            this.comboBox_admin_url_chipset.TabIndex = 6;
            this.comboBox_admin_url_chipset.SelectedIndexChanged += new System.EventHandler(this.ComboBox_admin_url_chipset_SelectedIndexChanged);
            // 
            // comboBox_admin_url_vendor
            // 
            this.comboBox_admin_url_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_admin_url_vendor.FormattingEnabled = true;
            this.comboBox_admin_url_vendor.Location = new System.Drawing.Point(99, 16);
            this.comboBox_admin_url_vendor.Name = "comboBox_admin_url_vendor";
            this.comboBox_admin_url_vendor.Size = new System.Drawing.Size(239, 21);
            this.comboBox_admin_url_vendor.TabIndex = 5;
            this.comboBox_admin_url_vendor.SelectedIndexChanged += new System.EventHandler(this.ComboBox_admin_url_vendor_SelectedIndexChanged);
            // 
            // label_no_url_to_add
            // 
            this.label_no_url_to_add.AutoSize = true;
            this.label_no_url_to_add.Location = new System.Drawing.Point(468, 16);
            this.label_no_url_to_add.Name = "label_no_url_to_add";
            this.label_no_url_to_add.Size = new System.Drawing.Size(78, 13);
            this.label_no_url_to_add.TabIndex = 4;
            this.label_no_url_to_add.Text = "Number to Add";
            // 
            // comboBox_select_model
            // 
            this.comboBox_select_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_model.FormattingEnabled = true;
            this.comboBox_select_model.Location = new System.Drawing.Point(99, 66);
            this.comboBox_select_model.Name = "comboBox_select_model";
            this.comboBox_select_model.Size = new System.Drawing.Size(239, 21);
            this.comboBox_select_model.TabIndex = 1;
            this.comboBox_select_model.SelectedIndexChanged += new System.EventHandler(this.ComboBox_select_model_SelectedIndexChanged);
            // 
            // btn_get_model_from_database
            // 
            this.btn_get_model_from_database.Location = new System.Drawing.Point(471, 71);
            this.btn_get_model_from_database.Name = "btn_get_model_from_database";
            this.btn_get_model_from_database.Size = new System.Drawing.Size(75, 23);
            this.btn_get_model_from_database.TabIndex = 3;
            this.btn_get_model_from_database.Text = "Add Slot";
            this.btn_get_model_from_database.UseVisualStyleBackColor = true;
            this.btn_get_model_from_database.Click += new System.EventHandler(this.Btn_get_model_from_database_Click);
            // 
            // numericUpDown_admin_url_url_to_add
            // 
            this.numericUpDown_admin_url_url_to_add.Location = new System.Drawing.Point(471, 33);
            this.numericUpDown_admin_url_url_to_add.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_admin_url_url_to_add.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_admin_url_url_to_add.Name = "numericUpDown_admin_url_url_to_add";
            this.numericUpDown_admin_url_url_to_add.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_admin_url_url_to_add.TabIndex = 0;
            this.numericUpDown_admin_url_url_to_add.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_add_url
            // 
            this.btn_add_url.Location = new System.Drawing.Point(486, 446);
            this.btn_add_url.Name = "btn_add_url";
            this.btn_add_url.Size = new System.Drawing.Size(75, 23);
            this.btn_add_url.TabIndex = 2;
            this.btn_add_url.Text = "Add URL";
            this.btn_add_url.UseVisualStyleBackColor = true;
            // 
            // tabPage_admin_model
            // 
            this.tabPage_admin_model.Controls.Add(this.groupBox4);
            this.tabPage_admin_model.Controls.Add(this.groupBox3);
            this.tabPage_admin_model.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_model.Name = "tabPage_admin_model";
            this.tabPage_admin_model.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_model.Size = new System.Drawing.Size(564, 371);
            this.tabPage_admin_model.TabIndex = 1;
            this.tabPage_admin_model.Text = "Model";
            this.tabPage_admin_model.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_goto_url);
            this.groupBox4.Controls.Add(this.pull_link_ddg);
            this.groupBox4.Controls.Add(this.button_admin_model_copy);
            this.groupBox4.Controls.Add(this.label_admin_model);
            this.groupBox4.Controls.Add(this.button_save_model_url);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btn_delete_model);
            this.groupBox4.Location = new System.Drawing.Point(282, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 359);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // button_admin_model_copy
            // 
            this.button_admin_model_copy.Location = new System.Drawing.Point(195, 245);
            this.button_admin_model_copy.Name = "button_admin_model_copy";
            this.button_admin_model_copy.Size = new System.Drawing.Size(75, 23);
            this.button_admin_model_copy.TabIndex = 12;
            this.button_admin_model_copy.Text = "Copy Model";
            this.button_admin_model_copy.UseVisualStyleBackColor = true;
            this.button_admin_model_copy.Click += new System.EventHandler(this.Button_admin_model_copy_Click);
            // 
            // label_admin_model
            // 
            this.label_admin_model.AutoSize = true;
            this.label_admin_model.Location = new System.Drawing.Point(12, 255);
            this.label_admin_model.Name = "label_admin_model";
            this.label_admin_model.Size = new System.Drawing.Size(41, 13);
            this.label_admin_model.TabIndex = 11;
            this.label_admin_model.Text = "[model]";
            // 
            // button_save_model_url
            // 
            this.button_save_model_url.Location = new System.Drawing.Point(195, 330);
            this.button_save_model_url.Name = "button_save_model_url";
            this.button_save_model_url.Size = new System.Drawing.Size(75, 23);
            this.button_save_model_url.TabIndex = 10;
            this.button_save_model_url.Text = "Save";
            this.button_save_model_url.UseVisualStyleBackColor = true;
            this.button_save_model_url.Click += new System.EventHandler(this.Button_save_model_url_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_admin_model_url);
            this.groupBox5.Location = new System.Drawing.Point(6, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 50);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "URL of model\'s BIOS page";
            // 
            // textBox_admin_model_url
            // 
            this.textBox_admin_model_url.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_model_url.Name = "textBox_admin_model_url";
            this.textBox_admin_model_url.Size = new System.Drawing.Size(258, 20);
            this.textBox_admin_model_url.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_admin_model_delete);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model Select";
            // 
            // comboBox_admin_model_delete
            // 
            this.comboBox_admin_model_delete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_admin_model_delete.FormattingEnabled = true;
            this.comboBox_admin_model_delete.Location = new System.Drawing.Point(6, 19);
            this.comboBox_admin_model_delete.Name = "comboBox_admin_model_delete";
            this.comboBox_admin_model_delete.Size = new System.Drawing.Size(252, 21);
            this.comboBox_admin_model_delete.Sorted = true;
            this.comboBox_admin_model_delete.TabIndex = 1;
            this.comboBox_admin_model_delete.SelectedIndexChanged += new System.EventHandler(this.ComboBox_admin_model_delete_SelectedIndexChanged);
            // 
            // btn_delete_model
            // 
            this.btn_delete_model.Location = new System.Drawing.Point(195, 72);
            this.btn_delete_model.Name = "btn_delete_model";
            this.btn_delete_model.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_model.TabIndex = 8;
            this.btn_delete_model.Text = "Remove Model";
            this.btn_delete_model.UseVisualStyleBackColor = true;
            this.btn_delete_model.Click += new System.EventHandler(this.Btn_delete_model_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox_chipset_select);
            this.groupBox3.Controls.Add(this.groupBox_vendor_select);
            this.groupBox3.Controls.Add(this.groupBox_model_name);
            this.groupBox3.Controls.Add(this.btn_add_model);
            this.groupBox3.Controls.Add(this.groupBox_model_bios_url);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 359);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Model";
            // 
            // groupBox_chipset_select
            // 
            this.groupBox_chipset_select.Controls.Add(this.comboBox_select_chipset);
            this.groupBox_chipset_select.Location = new System.Drawing.Point(6, 19);
            this.groupBox_chipset_select.Name = "groupBox_chipset_select";
            this.groupBox_chipset_select.Size = new System.Drawing.Size(140, 47);
            this.groupBox_chipset_select.TabIndex = 4;
            this.groupBox_chipset_select.TabStop = false;
            this.groupBox_chipset_select.Text = "Chipset Select";
            // 
            // comboBox_select_chipset
            // 
            this.comboBox_select_chipset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_chipset.FormattingEnabled = true;
            this.comboBox_select_chipset.Location = new System.Drawing.Point(6, 19);
            this.comboBox_select_chipset.Name = "comboBox_select_chipset";
            this.comboBox_select_chipset.Size = new System.Drawing.Size(128, 21);
            this.comboBox_select_chipset.Sorted = true;
            this.comboBox_select_chipset.TabIndex = 1;
            // 
            // groupBox_vendor_select
            // 
            this.groupBox_vendor_select.Controls.Add(this.groupBox1);
            this.groupBox_vendor_select.Controls.Add(this.comboBox_select_vendor);
            this.groupBox_vendor_select.Location = new System.Drawing.Point(6, 72);
            this.groupBox_vendor_select.Name = "groupBox_vendor_select";
            this.groupBox_vendor_select.Size = new System.Drawing.Size(140, 47);
            this.groupBox_vendor_select.TabIndex = 5;
            this.groupBox_vendor_select.TabStop = false;
            this.groupBox_vendor_select.Text = "Vendor Select";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL of model\'s BIOS page";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox_select_vendor
            // 
            this.comboBox_select_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_vendor.FormattingEnabled = true;
            this.comboBox_select_vendor.Location = new System.Drawing.Point(6, 19);
            this.comboBox_select_vendor.Name = "comboBox_select_vendor";
            this.comboBox_select_vendor.Size = new System.Drawing.Size(128, 21);
            this.comboBox_select_vendor.TabIndex = 2;
            // 
            // groupBox_model_name
            // 
            this.groupBox_model_name.Controls.Add(this.textBox_admin_model_sku);
            this.groupBox_model_name.Location = new System.Drawing.Point(4, 125);
            this.groupBox_model_name.Name = "groupBox_model_name";
            this.groupBox_model_name.Size = new System.Drawing.Size(260, 50);
            this.groupBox_model_name.TabIndex = 7;
            this.groupBox_model_name.TabStop = false;
            this.groupBox_model_name.Text = "Model Name(sku)";
            // 
            // textBox_admin_model_sku
            // 
            this.textBox_admin_model_sku.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_admin_model_sku.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_model_sku.Name = "textBox_admin_model_sku";
            this.textBox_admin_model_sku.Size = new System.Drawing.Size(237, 20);
            this.textBox_admin_model_sku.TabIndex = 3;
            // 
            // btn_add_model
            // 
            this.btn_add_model.Location = new System.Drawing.Point(192, 330);
            this.btn_add_model.Name = "btn_add_model";
            this.btn_add_model.Size = new System.Drawing.Size(75, 23);
            this.btn_add_model.TabIndex = 0;
            this.btn_add_model.Text = "Add Model";
            this.btn_add_model.UseVisualStyleBackColor = true;
            this.btn_add_model.Click += new System.EventHandler(this.Btn_add_model_Click);
            // 
            // groupBox_model_bios_url
            // 
            this.groupBox_model_bios_url.Controls.Add(this.textBox_model_bios_url);
            this.groupBox_model_bios_url.Location = new System.Drawing.Point(4, 181);
            this.groupBox_model_bios_url.Name = "groupBox_model_bios_url";
            this.groupBox_model_bios_url.Size = new System.Drawing.Size(260, 50);
            this.groupBox_model_bios_url.TabIndex = 6;
            this.groupBox_model_bios_url.TabStop = false;
            this.groupBox_model_bios_url.Text = "URL of model\'s BIOS page";
            // 
            // textBox_model_bios_url
            // 
            this.textBox_model_bios_url.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox_model_bios_url.Location = new System.Drawing.Point(6, 19);
            this.textBox_model_bios_url.Name = "textBox_model_bios_url";
            this.textBox_model_bios_url.Size = new System.Drawing.Size(237, 20);
            this.textBox_model_bios_url.TabIndex = 3;
            // 
            // tabPage_admin_vendor
            // 
            this.tabPage_admin_vendor.Controls.Add(this.groupBox_edit_existing);
            this.tabPage_admin_vendor.Controls.Add(this.groupBox_add_vendor);
            this.tabPage_admin_vendor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_vendor.Name = "tabPage_admin_vendor";
            this.tabPage_admin_vendor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_vendor.Size = new System.Drawing.Size(564, 371);
            this.tabPage_admin_vendor.TabIndex = 2;
            this.tabPage_admin_vendor.Text = "Vendor";
            this.tabPage_admin_vendor.UseVisualStyleBackColor = true;
            // 
            // groupBox_edit_existing
            // 
            this.groupBox_edit_existing.Controls.Add(this.button_admin_vendor_del);
            this.groupBox_edit_existing.Controls.Add(this.groupBox10);
            this.groupBox_edit_existing.Controls.Add(this.groupBox_admin_vendor_edit_base);
            this.groupBox_edit_existing.Controls.Add(this.groupBox8);
            this.groupBox_edit_existing.Controls.Add(this.groupBox6);
            this.groupBox_edit_existing.Controls.Add(this.btn_save_edits);
            this.groupBox_edit_existing.Controls.Add(this.comboBox_select_vendor_to_edit);
            this.groupBox_edit_existing.Location = new System.Drawing.Point(7, 169);
            this.groupBox_edit_existing.Name = "groupBox_edit_existing";
            this.groupBox_edit_existing.Size = new System.Drawing.Size(551, 201);
            this.groupBox_edit_existing.TabIndex = 3;
            this.groupBox_edit_existing.TabStop = false;
            this.groupBox_edit_existing.Text = "Edit Exisitng Vendor";
            // 
            // button_admin_vendor_del
            // 
            this.button_admin_vendor_del.Location = new System.Drawing.Point(373, 172);
            this.button_admin_vendor_del.Name = "button_admin_vendor_del";
            this.button_admin_vendor_del.Size = new System.Drawing.Size(83, 23);
            this.button_admin_vendor_del.TabIndex = 10;
            this.button_admin_vendor_del.Text = "Delete Vendor";
            this.button_admin_vendor_del.UseVisualStyleBackColor = true;
            this.button_admin_vendor_del.Click += new System.EventHandler(this.Button_admin_vendor_del_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_admin_vendor_addon_edit);
            this.groupBox10.Location = new System.Drawing.Point(241, 100);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(215, 48);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Addon";
            // 
            // textBox_admin_vendor_addon_edit
            // 
            this.textBox_admin_vendor_addon_edit.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_addon_edit.Name = "textBox_admin_vendor_addon_edit";
            this.textBox_admin_vendor_addon_edit.Size = new System.Drawing.Size(203, 20);
            this.textBox_admin_vendor_addon_edit.TabIndex = 4;
            // 
            // groupBox_admin_vendor_edit_base
            // 
            this.groupBox_admin_vendor_edit_base.Controls.Add(this.textBox_admin_vendor_base_edit);
            this.groupBox_admin_vendor_edit_base.Location = new System.Drawing.Point(184, 46);
            this.groupBox_admin_vendor_edit_base.Name = "groupBox_admin_vendor_edit_base";
            this.groupBox_admin_vendor_edit_base.Size = new System.Drawing.Size(215, 48);
            this.groupBox_admin_vendor_edit_base.TabIndex = 8;
            this.groupBox_admin_vendor_edit_base.TabStop = false;
            this.groupBox_admin_vendor_edit_base.Text = "Base";
            // 
            // textBox_admin_vendor_base_edit
            // 
            this.textBox_admin_vendor_base_edit.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_base_edit.Name = "textBox_admin_vendor_base_edit";
            this.textBox_admin_vendor_base_edit.Size = new System.Drawing.Size(203, 20);
            this.textBox_admin_vendor_base_edit.TabIndex = 4;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox_admin_vendor_sort_edit);
            this.groupBox8.Location = new System.Drawing.Point(6, 100);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(215, 48);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sort";
            // 
            // textBox_admin_vendor_sort_edit
            // 
            this.textBox_admin_vendor_sort_edit.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_sort_edit.Name = "textBox_admin_vendor_sort_edit";
            this.textBox_admin_vendor_sort_edit.Size = new System.Drawing.Size(203, 20);
            this.textBox_admin_vendor_sort_edit.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_admin_vendor_name);
            this.groupBox6.Location = new System.Drawing.Point(6, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 48);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Name";
            // 
            // textBox_admin_vendor_name
            // 
            this.textBox_admin_vendor_name.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_name.Name = "textBox_admin_vendor_name";
            this.textBox_admin_vendor_name.Size = new System.Drawing.Size(147, 20);
            this.textBox_admin_vendor_name.TabIndex = 3;
            // 
            // btn_save_edits
            // 
            this.btn_save_edits.Location = new System.Drawing.Point(462, 172);
            this.btn_save_edits.Name = "btn_save_edits";
            this.btn_save_edits.Size = new System.Drawing.Size(83, 23);
            this.btn_save_edits.TabIndex = 1;
            this.btn_save_edits.Text = "Save Vendor";
            this.btn_save_edits.UseVisualStyleBackColor = true;
            this.btn_save_edits.Click += new System.EventHandler(this.Btn_save_edits_Click);
            // 
            // comboBox_select_vendor_to_edit
            // 
            this.comboBox_select_vendor_to_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_vendor_to_edit.FormattingEnabled = true;
            this.comboBox_select_vendor_to_edit.Location = new System.Drawing.Point(6, 19);
            this.comboBox_select_vendor_to_edit.Name = "comboBox_select_vendor_to_edit";
            this.comboBox_select_vendor_to_edit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_select_vendor_to_edit.TabIndex = 1;
            this.comboBox_select_vendor_to_edit.SelectedIndexChanged += new System.EventHandler(this.ComboBox_select_vendor_to_edit_SelectedIndexChanged);
            // 
            // groupBox_add_vendor
            // 
            this.groupBox_add_vendor.Controls.Add(this.button_add_vendor);
            this.groupBox_add_vendor.Controls.Add(this.groupBox9);
            this.groupBox_add_vendor.Controls.Add(this.groupBox_admin_vendor_add_base);
            this.groupBox_add_vendor.Controls.Add(this.groupBox7);
            this.groupBox_add_vendor.Controls.Add(this.groupBox_admin_vendor_vendor_name);
            this.groupBox_add_vendor.Controls.Add(this.btn_add_vendor);
            this.groupBox_add_vendor.Location = new System.Drawing.Point(7, 7);
            this.groupBox_add_vendor.Name = "groupBox_add_vendor";
            this.groupBox_add_vendor.Size = new System.Drawing.Size(551, 156);
            this.groupBox_add_vendor.TabIndex = 2;
            this.groupBox_add_vendor.TabStop = false;
            this.groupBox_add_vendor.Text = "Add Vendor";
            // 
            // button_add_vendor
            // 
            this.button_add_vendor.Location = new System.Drawing.Point(462, 127);
            this.button_add_vendor.Name = "button_add_vendor";
            this.button_add_vendor.Size = new System.Drawing.Size(83, 23);
            this.button_add_vendor.TabIndex = 10;
            this.button_add_vendor.Text = "Add Vendor";
            this.button_add_vendor.UseVisualStyleBackColor = true;
            this.button_add_vendor.Click += new System.EventHandler(this.Button_add_vendor_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox_admin_vendor_addon_add);
            this.groupBox9.Location = new System.Drawing.Point(241, 73);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 48);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Addon";
            // 
            // textBox_admin_vendor_addon_add
            // 
            this.textBox_admin_vendor_addon_add.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_addon_add.Name = "textBox_admin_vendor_addon_add";
            this.textBox_admin_vendor_addon_add.Size = new System.Drawing.Size(203, 20);
            this.textBox_admin_vendor_addon_add.TabIndex = 4;
            // 
            // groupBox_admin_vendor_add_base
            // 
            this.groupBox_admin_vendor_add_base.Controls.Add(this.textBox_admin_vendor_base_add);
            this.groupBox_admin_vendor_add_base.Location = new System.Drawing.Point(184, 19);
            this.groupBox_admin_vendor_add_base.Name = "groupBox_admin_vendor_add_base";
            this.groupBox_admin_vendor_add_base.Size = new System.Drawing.Size(215, 48);
            this.groupBox_admin_vendor_add_base.TabIndex = 7;
            this.groupBox_admin_vendor_add_base.TabStop = false;
            this.groupBox_admin_vendor_add_base.Text = "Base";
            // 
            // textBox_admin_vendor_base_add
            // 
            this.textBox_admin_vendor_base_add.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_base_add.Name = "textBox_admin_vendor_base_add";
            this.textBox_admin_vendor_base_add.Size = new System.Drawing.Size(203, 20);
            this.textBox_admin_vendor_base_add.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_admin_vendor_sort_add);
            this.groupBox7.Location = new System.Drawing.Point(6, 73);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 48);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sort";
            // 
            // textBox_admin_vendor_sort_add
            // 
            this.textBox_admin_vendor_sort_add.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_sort_add.Name = "textBox_admin_vendor_sort_add";
            this.textBox_admin_vendor_sort_add.Size = new System.Drawing.Size(203, 20);
            this.textBox_admin_vendor_sort_add.TabIndex = 4;
            // 
            // groupBox_admin_vendor_vendor_name
            // 
            this.groupBox_admin_vendor_vendor_name.Controls.Add(this.textBox_admin_vendor_name_add);
            this.groupBox_admin_vendor_vendor_name.Location = new System.Drawing.Point(6, 19);
            this.groupBox_admin_vendor_vendor_name.Name = "groupBox_admin_vendor_vendor_name";
            this.groupBox_admin_vendor_vendor_name.Size = new System.Drawing.Size(161, 48);
            this.groupBox_admin_vendor_vendor_name.TabIndex = 5;
            this.groupBox_admin_vendor_vendor_name.TabStop = false;
            this.groupBox_admin_vendor_vendor_name.Text = "Name";
            // 
            // textBox_admin_vendor_name_add
            // 
            this.textBox_admin_vendor_name_add.Location = new System.Drawing.Point(6, 19);
            this.textBox_admin_vendor_name_add.Name = "textBox_admin_vendor_name_add";
            this.textBox_admin_vendor_name_add.Size = new System.Drawing.Size(147, 20);
            this.textBox_admin_vendor_name_add.TabIndex = 4;
            // 
            // btn_add_vendor
            // 
            this.btn_add_vendor.Location = new System.Drawing.Point(470, 205);
            this.btn_add_vendor.Name = "btn_add_vendor";
            this.btn_add_vendor.Size = new System.Drawing.Size(75, 23);
            this.btn_add_vendor.TabIndex = 0;
            this.btn_add_vendor.Text = "Add Vendor";
            this.btn_add_vendor.UseVisualStyleBackColor = true;
            // 
            // tabPage_chipset_add
            // 
            this.tabPage_chipset_add.Controls.Add(this.groupBox_remove_chipset);
            this.tabPage_chipset_add.Controls.Add(this.groupBox_add_shipset);
            this.tabPage_chipset_add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_chipset_add.Name = "tabPage_chipset_add";
            this.tabPage_chipset_add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_chipset_add.Size = new System.Drawing.Size(564, 371);
            this.tabPage_chipset_add.TabIndex = 3;
            this.tabPage_chipset_add.Text = "Chipset";
            this.tabPage_chipset_add.UseVisualStyleBackColor = true;
            // 
            // groupBox_remove_chipset
            // 
            this.groupBox_remove_chipset.Controls.Add(this.comboBox_select_chipset_to_remove);
            this.groupBox_remove_chipset.Controls.Add(this.button_remvoe_chipset);
            this.groupBox_remove_chipset.Location = new System.Drawing.Point(292, 6);
            this.groupBox_remove_chipset.Name = "groupBox_remove_chipset";
            this.groupBox_remove_chipset.Size = new System.Drawing.Size(266, 169);
            this.groupBox_remove_chipset.TabIndex = 8;
            this.groupBox_remove_chipset.TabStop = false;
            this.groupBox_remove_chipset.Text = "Remove Chipset";
            // 
            // comboBox_select_chipset_to_remove
            // 
            this.comboBox_select_chipset_to_remove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_chipset_to_remove.FormattingEnabled = true;
            this.comboBox_select_chipset_to_remove.Location = new System.Drawing.Point(40, 69);
            this.comboBox_select_chipset_to_remove.Name = "comboBox_select_chipset_to_remove";
            this.comboBox_select_chipset_to_remove.Size = new System.Drawing.Size(188, 21);
            this.comboBox_select_chipset_to_remove.Sorted = true;
            this.comboBox_select_chipset_to_remove.TabIndex = 6;
            // 
            // button_remvoe_chipset
            // 
            this.button_remvoe_chipset.Location = new System.Drawing.Point(185, 140);
            this.button_remvoe_chipset.Name = "button_remvoe_chipset";
            this.button_remvoe_chipset.Size = new System.Drawing.Size(75, 23);
            this.button_remvoe_chipset.TabIndex = 5;
            this.button_remvoe_chipset.Text = "Remove Chipset";
            this.button_remvoe_chipset.UseVisualStyleBackColor = true;
            this.button_remvoe_chipset.Click += new System.EventHandler(this.Button_remove_chipset_Click);
            // 
            // groupBox_add_shipset
            // 
            this.groupBox_add_shipset.Controls.Add(this.btn_add_chipset);
            this.groupBox_add_shipset.Controls.Add(this.comboBox_admin_chipset_vendor);
            this.groupBox_add_shipset.Controls.Add(this.textBox_admin_chipset_name);
            this.groupBox_add_shipset.Controls.Add(this.label_admin_chispset_vendor);
            this.groupBox_add_shipset.Controls.Add(this.label_admin_chipset_name);
            this.groupBox_add_shipset.Location = new System.Drawing.Point(6, 6);
            this.groupBox_add_shipset.Name = "groupBox_add_shipset";
            this.groupBox_add_shipset.Size = new System.Drawing.Size(269, 169);
            this.groupBox_add_shipset.TabIndex = 7;
            this.groupBox_add_shipset.TabStop = false;
            this.groupBox_add_shipset.Text = "Add Chipset";
            // 
            // btn_add_chipset
            // 
            this.btn_add_chipset.Location = new System.Drawing.Point(188, 140);
            this.btn_add_chipset.Name = "btn_add_chipset";
            this.btn_add_chipset.Size = new System.Drawing.Size(75, 23);
            this.btn_add_chipset.TabIndex = 0;
            this.btn_add_chipset.Text = "Add Chipset";
            this.btn_add_chipset.UseVisualStyleBackColor = true;
            this.btn_add_chipset.Click += new System.EventHandler(this.Btn_add_chipset_Click);
            // 
            // comboBox_admin_chipset_vendor
            // 
            this.comboBox_admin_chipset_vendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_admin_chipset_vendor.FormattingEnabled = true;
            this.comboBox_admin_chipset_vendor.Location = new System.Drawing.Point(6, 85);
            this.comboBox_admin_chipset_vendor.Name = "comboBox_admin_chipset_vendor";
            this.comboBox_admin_chipset_vendor.Size = new System.Drawing.Size(257, 21);
            this.comboBox_admin_chipset_vendor.TabIndex = 2;
            // 
            // textBox_admin_chipset_name
            // 
            this.textBox_admin_chipset_name.Location = new System.Drawing.Point(6, 32);
            this.textBox_admin_chipset_name.Name = "textBox_admin_chipset_name";
            this.textBox_admin_chipset_name.Size = new System.Drawing.Size(257, 20);
            this.textBox_admin_chipset_name.TabIndex = 1;
            // 
            // label_admin_chispset_vendor
            // 
            this.label_admin_chispset_vendor.AutoSize = true;
            this.label_admin_chispset_vendor.Location = new System.Drawing.Point(6, 69);
            this.label_admin_chispset_vendor.Name = "label_admin_chispset_vendor";
            this.label_admin_chispset_vendor.Size = new System.Drawing.Size(41, 13);
            this.label_admin_chispset_vendor.TabIndex = 4;
            this.label_admin_chispset_vendor.Text = "Vendor";
            // 
            // label_admin_chipset_name
            // 
            this.label_admin_chipset_name.AutoSize = true;
            this.label_admin_chipset_name.Location = new System.Drawing.Point(6, 16);
            this.label_admin_chipset_name.Name = "label_admin_chipset_name";
            this.label_admin_chipset_name.Size = new System.Drawing.Size(73, 13);
            this.label_admin_chipset_name.TabIndex = 3;
            this.label_admin_chipset_name.Text = "Chipset Name";
            // 
            // tabPage_admin_scripts
            // 
            this.tabPage_admin_scripts.Controls.Add(this.groupBox_script_buttons);
            this.tabPage_admin_scripts.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_scripts.Name = "tabPage_admin_scripts";
            this.tabPage_admin_scripts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_scripts.Size = new System.Drawing.Size(564, 371);
            this.tabPage_admin_scripts.TabIndex = 4;
            this.tabPage_admin_scripts.Text = "Scripts";
            this.tabPage_admin_scripts.UseVisualStyleBackColor = true;
            // 
            // groupBox_script_buttons
            // 
            this.groupBox_script_buttons.Controls.Add(this.button_get_models);
            this.groupBox_script_buttons.Location = new System.Drawing.Point(-2, 6);
            this.groupBox_script_buttons.Name = "groupBox_script_buttons";
            this.groupBox_script_buttons.Size = new System.Drawing.Size(560, 359);
            this.groupBox_script_buttons.TabIndex = 1;
            this.groupBox_script_buttons.TabStop = false;
            this.groupBox_script_buttons.Text = "Scripts";
            // 
            // button_get_models
            // 
            this.button_get_models.Location = new System.Drawing.Point(8, 19);
            this.button_get_models.Name = "button_get_models";
            this.button_get_models.Size = new System.Drawing.Size(108, 23);
            this.button_get_models.TabIndex = 0;
            this.button_get_models.Text = "Mass Get Models";
            this.button_get_models.UseVisualStyleBackColor = true;
            this.button_get_models.Click += new System.EventHandler(this.Button_get_models_Click);
            // 
            // tabPage_feed
            // 
            this.tabPage_feed.Controls.Add(this.tabControl_admin_feed);
            this.tabPage_feed.Location = new System.Drawing.Point(4, 22);
            this.tabPage_feed.Name = "tabPage_feed";
            this.tabPage_feed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_feed.Size = new System.Drawing.Size(564, 371);
            this.tabPage_feed.TabIndex = 5;
            this.tabPage_feed.Text = "The Feed";
            this.tabPage_feed.UseVisualStyleBackColor = true;
            // 
            // tabControl_admin_feed
            // 
            this.tabControl_admin_feed.Controls.Add(this.tabPage_admin_feed_url);
            this.tabControl_admin_feed.Controls.Add(this.tabPage_admin_feed_model);
            this.tabControl_admin_feed.Location = new System.Drawing.Point(9, 7);
            this.tabControl_admin_feed.Name = "tabControl_admin_feed";
            this.tabControl_admin_feed.SelectedIndex = 0;
            this.tabControl_admin_feed.Size = new System.Drawing.Size(549, 358);
            this.tabControl_admin_feed.TabIndex = 4;
            // 
            // tabPage_admin_feed_url
            // 
            this.tabPage_admin_feed_url.Controls.Add(this.groupBox_feed);
            this.tabPage_admin_feed_url.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_feed_url.Name = "tabPage_admin_feed_url";
            this.tabPage_admin_feed_url.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_feed_url.Size = new System.Drawing.Size(541, 332);
            this.tabPage_admin_feed_url.TabIndex = 0;
            this.tabPage_admin_feed_url.Text = "URL";
            this.tabPage_admin_feed_url.UseVisualStyleBackColor = true;
            // 
            // groupBox_feed
            // 
            this.groupBox_feed.Controls.Add(this.flowLayoutPanel_admin_scripts);
            this.groupBox_feed.Controls.Add(this.button_get_next_10);
            this.groupBox_feed.Location = new System.Drawing.Point(4, 6);
            this.groupBox_feed.Name = "groupBox_feed";
            this.groupBox_feed.Size = new System.Drawing.Size(534, 320);
            this.groupBox_feed.TabIndex = 3;
            this.groupBox_feed.TabStop = false;
            this.groupBox_feed.Text = "The Feed";
            // 
            // flowLayoutPanel_admin_scripts
            // 
            this.flowLayoutPanel_admin_scripts.AutoScroll = true;
            this.flowLayoutPanel_admin_scripts.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel_admin_scripts.Name = "flowLayoutPanel_admin_scripts";
            this.flowLayoutPanel_admin_scripts.Size = new System.Drawing.Size(522, 266);
            this.flowLayoutPanel_admin_scripts.TabIndex = 7;
            // 
            // button_get_next_10
            // 
            this.button_get_next_10.Location = new System.Drawing.Point(453, 291);
            this.button_get_next_10.Name = "button_get_next_10";
            this.button_get_next_10.Size = new System.Drawing.Size(75, 23);
            this.button_get_next_10.TabIndex = 0;
            this.button_get_next_10.Text = "Get Next 10";
            this.button_get_next_10.UseVisualStyleBackColor = true;
            // 
            // tabPage_admin_feed_model
            // 
            this.tabPage_admin_feed_model.Location = new System.Drawing.Point(4, 22);
            this.tabPage_admin_feed_model.Name = "tabPage_admin_feed_model";
            this.tabPage_admin_feed_model.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_admin_feed_model.Size = new System.Drawing.Size(541, 332);
            this.tabPage_admin_feed_model.TabIndex = 1;
            this.tabPage_admin_feed_model.Text = "Model";
            this.tabPage_admin_feed_model.UseVisualStyleBackColor = true;
            // 
            // errorProvider_admin_model_validator
            // 
            this.errorProvider_admin_model_validator.ContainerControl = this;
            // 
            // pull_link_ddg
            // 
            this.pull_link_ddg.Location = new System.Drawing.Point(104, 330);
            this.pull_link_ddg.Name = "pull_link_ddg";
            this.pull_link_ddg.Size = new System.Drawing.Size(75, 23);
            this.pull_link_ddg.TabIndex = 13;
            this.pull_link_ddg.Text = "Pull";
            this.pull_link_ddg.UseVisualStyleBackColor = true;
            this.pull_link_ddg.Click += new System.EventHandler(this.pull_link_ddg_Click);
            // 
            // button_goto_url
            // 
            this.button_goto_url.Location = new System.Drawing.Point(12, 330);
            this.button_goto_url.Name = "button_goto_url";
            this.button_goto_url.Size = new System.Drawing.Size(75, 23);
            this.button_goto_url.TabIndex = 14;
            this.button_goto_url.Text = "Goto";
            this.button_goto_url.UseVisualStyleBackColor = true;
            this.button_goto_url.Click += new System.EventHandler(this.button_goto_url_Click);
            // 
            // admin_url_url_label
            // 
            this.admin_url_url_label.AutoSize = true;
            this.admin_url_url_label.Location = new System.Drawing.Point(3, 198);
            this.admin_url_url_label.Name = "admin_url_url_label";
            this.admin_url_url_label.Size = new System.Drawing.Size(126, 13);
            this.admin_url_url_label.TabIndex = 11;
            this.admin_url_url_label.Text = "[MOTHERBOARD_URL]";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Goto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.tabPage_stats.PerformLayout();
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
            this.groupBox_what_to_get.ResumeLayout(false);
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
            this.tabPage_admin.ResumeLayout(false);
            this.tabPage_admin.PerformLayout();
            this.tabControl_admin.ResumeLayout(false);
            this.tabPage_admin_url.ResumeLayout(false);
            this.groupBox_admin_url_contain_url.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_admin_url_urls_add.ResumeLayout(false);
            this.tabPage_admin_url_urls_add.PerformLayout();
            this.tabPage_admin_url_urls_edit.ResumeLayout(false);
            this.groupBox_select_model.ResumeLayout(false);
            this.groupBox_select_model.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_admin_url_url_to_add)).EndInit();
            this.tabPage_admin_model.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox_chipset_select.ResumeLayout(false);
            this.groupBox_vendor_select.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_model_name.ResumeLayout(false);
            this.groupBox_model_name.PerformLayout();
            this.groupBox_model_bios_url.ResumeLayout(false);
            this.groupBox_model_bios_url.PerformLayout();
            this.tabPage_admin_vendor.ResumeLayout(false);
            this.groupBox_edit_existing.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox_admin_vendor_edit_base.ResumeLayout(false);
            this.groupBox_admin_vendor_edit_base.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox_add_vendor.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox_admin_vendor_add_base.ResumeLayout(false);
            this.groupBox_admin_vendor_add_base.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox_admin_vendor_vendor_name.ResumeLayout(false);
            this.groupBox_admin_vendor_vendor_name.PerformLayout();
            this.tabPage_chipset_add.ResumeLayout(false);
            this.groupBox_remove_chipset.ResumeLayout(false);
            this.groupBox_add_shipset.ResumeLayout(false);
            this.groupBox_add_shipset.PerformLayout();
            this.tabPage_admin_scripts.ResumeLayout(false);
            this.groupBox_script_buttons.ResumeLayout(false);
            this.tabPage_feed.ResumeLayout(false);
            this.tabControl_admin_feed.ResumeLayout(false);
            this.tabPage_admin_feed_url.ResumeLayout(false);
            this.groupBox_feed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_admin_model_validator)).EndInit();
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
        private System.Windows.Forms.Label label_current_point;
        private System.Windows.Forms.ProgressBar progressBar_current_progress;
        private System.Windows.Forms.GroupBox grpBox_Overall_progress;
        private System.Windows.Forms.Label label_current_progress_fraction;
        private System.Windows.Forms.ProgressBar progressBar_overall_progress;
        private System.Windows.Forms.TabPage tabPage_config;
        private System.Windows.Forms.TextBox textBox_log_config;
        private System.Windows.Forms.GroupBox grpBox_vendor;
        private System.Windows.Forms.CheckedListBox listbox_vendor;
        private System.Windows.Forms.GroupBox grpBox_Chipsets;
        private System.Windows.Forms.GroupBox grpBox_chipset_intel;
        private System.Windows.Forms.CheckBox checkBox_vendor_select_all;
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
        private System.Windows.Forms.TabControl tabControl_admin;
        private System.Windows.Forms.TabPage tabPage_admin_url;
        private System.Windows.Forms.TabPage tabPage_admin_model;
        private System.Windows.Forms.TabPage tabPage_admin_vendor;
        private System.Windows.Forms.ComboBox comboBox_select_model;
        private System.Windows.Forms.NumericUpDown numericUpDown_admin_url_url_to_add;
        private System.Windows.Forms.Button btn_add_url;
        private System.Windows.Forms.Button btn_add_model;
        private System.Windows.Forms.Button btn_add_vendor;
        private System.Windows.Forms.Button btn_get_model_from_database;
        private System.Windows.Forms.TabPage tabPage_chipset_add;
        private System.Windows.Forms.Button btn_add_chipset;
        private System.Windows.Forms.TextBox textBox_model_bios_url;
        private System.Windows.Forms.ComboBox comboBox_select_vendor;
        private System.Windows.Forms.ComboBox comboBox_select_chipset;
        private System.Windows.Forms.ComboBox comboBox_select_vendor_to_edit;
        private System.Windows.Forms.GroupBox groupBox_vendor_select;
        private System.Windows.Forms.GroupBox groupBox_chipset_select;
        private System.Windows.Forms.GroupBox groupBox_model_bios_url;
        private System.Windows.Forms.GroupBox groupBox_model_name;
        private System.Windows.Forms.TextBox textBox_admin_model_sku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_edit_existing;
        private System.Windows.Forms.Button btn_save_edits;
        private System.Windows.Forms.GroupBox groupBox_add_vendor;
        private System.Windows.Forms.GroupBox groupBox_select_model;
        private System.Windows.Forms.ComboBox comboBox_admin_url_chipset;
        private System.Windows.Forms.ComboBox comboBox_admin_url_vendor;
        private System.Windows.Forms.Label label_no_url_to_add;
        private System.Windows.Forms.ErrorProvider errorProvider_admin_model_validator;
        private System.Windows.Forms.TextBox textBox_admin_log;
        private System.Windows.Forms.Label label_admin_chispset_vendor;
        private System.Windows.Forms.Label label_admin_chipset_name;
        private System.Windows.Forms.ComboBox comboBox_admin_chipset_vendor;
        private System.Windows.Forms.TextBox textBox_admin_chipset_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_admin_url_contain_url;
        private System.Windows.Forms.GroupBox groupBox_what_to_get;
        private System.Windows.Forms.ComboBox comboBox_what_to_get;
        private System.Windows.Forms.GroupBox groupBox_remove_chipset;
        private System.Windows.Forms.ComboBox comboBox_select_chipset_to_remove;
        private System.Windows.Forms.Button button_remvoe_chipset;
        private System.Windows.Forms.GroupBox groupBox_add_shipset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_admin_model_delete;
        private System.Windows.Forms.Button btn_delete_model;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_admin_url_urls_add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_add_url_str;
        private System.Windows.Forms.TabPage tabPage_admin_url_urls_edit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_admin_url_edit;
        private System.Windows.Forms.Button btn_admin_url_add_url;
        private System.Windows.Forms.Button button_admin_url_save_del;
        private System.Windows.Forms.Label label_admin_model;
        private System.Windows.Forms.Button button_save_model_url;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_admin_model_url;
        private System.Windows.Forms.TabPage tabPage_admin_scripts;
        private System.Windows.Forms.TextBox textBox_admin_vendor_name;
        private System.Windows.Forms.TextBox textBox_admin_vendor_name_add;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox_admin_vendor_vendor_name;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox_admin_vendor_addon_edit;
        private System.Windows.Forms.GroupBox groupBox_admin_vendor_edit_base;
        private System.Windows.Forms.TextBox textBox_admin_vendor_base_edit;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox_admin_vendor_sort_edit;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox_admin_vendor_addon_add;
        private System.Windows.Forms.GroupBox groupBox_admin_vendor_add_base;
        private System.Windows.Forms.TextBox textBox_admin_vendor_base_add;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox_admin_vendor_sort_add;
        private System.Windows.Forms.Button button_add_vendor;
        private System.Windows.Forms.Button button_get_models;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_admin_vendor_del;
        private System.Windows.Forms.Label label_admin_url_model;
        private System.Windows.Forms.Button button_admin_url_model_copy;
        private System.Windows.Forms.Button button_admin_url_bulk_get;
        private System.Windows.Forms.Button button_admin_model_copy;
        private System.Windows.Forms.Button button_load_config;
        private System.Windows.Forms.Button button_save_config;
        private System.Windows.Forms.GroupBox groupBox_script_buttons;
        private System.Windows.Forms.TabPage tabPage_feed;
        private System.Windows.Forms.TabControl tabControl_admin_feed;
        private System.Windows.Forms.TabPage tabPage_admin_feed_url;
        private System.Windows.Forms.GroupBox groupBox_feed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_admin_scripts;
        private System.Windows.Forms.Button button_get_next_10;
        private System.Windows.Forms.TabPage tabPage_admin_feed_model;
        private System.Windows.Forms.Button pull_link_ddg;
        private System.Windows.Forms.Button button_goto_url;
        private System.Windows.Forms.Label admin_url_url_label;
        private System.Windows.Forms.Button button2;
    }
}

