namespace NurseSystem.PresentationLayer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelEdge = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tabControlHome = new System.Windows.Forms.TabControl();
            this.tpPatients = new System.Windows.Forms.TabPage();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.cbPatientsFilterBy = new System.Windows.Forms.ComboBox();
            this.txtPatientsFilterBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.cmsPatients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPatientShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpNurses = new System.Windows.Forms.TabPage();
            this.btnAddNurse = new System.Windows.Forms.Button();
            this.cbNursesFilterBy = new System.Windows.Forms.ComboBox();
            this.txtNursesFilterBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNurses = new System.Windows.Forms.DataGridView();
            this.cmsNurses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNurseShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNurseEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNurseDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpDoctors = new System.Windows.Forms.TabPage();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.cbDoctorsFilterBy = new System.Windows.Forms.ComboBox();
            this.txtDoctorsFilterBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.cmsDoctors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDoctorShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoctorEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoctorDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpPatientService = new System.Windows.Forms.TabPage();
            this.btnAddPatientService = new System.Windows.Forms.Button();
            this.cbPatientServiceFilterBy = new System.Windows.Forms.ComboBox();
            this.txtPatientServiceFilterBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPatientServices = new System.Windows.Forms.DataGridView();
            this.cmsPatientService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientServiceShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientServiceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPatientServiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPatientDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowNurseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowDoctorDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cbServicesFilterBy = new System.Windows.Forms.ComboBox();
            this.txtServicesFilterBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.cmsServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiServiceShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServiceEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServiceDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.gbCalculations = new System.Windows.Forms.GroupBox();
            this.btnCollect = new System.Windows.Forms.Button();
            this.lblMoneyToCollect = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.cbUsersFilterBy = new System.Windows.Forms.ComboBox();
            this.txtUsersFilterBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUserShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tpLogout = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tabControlHome.SuspendLayout();
            this.tpPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.cmsPatients.SuspendLayout();
            this.tpNurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNurses)).BeginInit();
            this.cmsNurses.SuspendLayout();
            this.tpDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.cmsDoctors.SuspendLayout();
            this.tpPatientService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientServices)).BeginInit();
            this.cmsPatientService.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.cmsServices.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.gbCalculations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdge
            // 
            this.panelEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.panelEdge.Controls.Add(this.lblStatus);
            this.panelEdge.Controls.Add(this.lblBattery);
            this.panelEdge.Controls.Add(this.pbLogo);
            this.panelEdge.Controls.Add(this.btnLogout);
            this.panelEdge.Controls.Add(this.btnSettings);
            this.panelEdge.Controls.Add(this.btnHome);
            this.panelEdge.Controls.Add(this.lblClock);
            this.panelEdge.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEdge.Location = new System.Drawing.Point(0, 0);
            this.panelEdge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEdge.Name = "panelEdge";
            this.panelEdge.Size = new System.Drawing.Size(84, 743);
            this.panelEdge.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(2, 696);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblBattery
            // 
            this.lblBattery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery.ForeColor = System.Drawing.Color.White;
            this.lblBattery.Location = new System.Drawing.Point(2, 672);
            this.lblBattery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(49, 16);
            this.lblBattery.TabIndex = 5;
            this.lblBattery.Text = "Battery";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::NurseSystem.PresentationLayer.Properties.Resources.Screenshot_2024_08_22_224826_2;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(53, 46);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.logout__1_;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.btnLogout.Location = new System.Drawing.Point(12, 240);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(53, 46);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.settings__1_;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.btnSettings.Location = new System.Drawing.Point(12, 163);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(53, 46);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.btnHome.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.home_icon_silhouette;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.btnHome.Location = new System.Drawing.Point(12, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(53, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(2, 650);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(41, 16);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "Clock";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Controls.Add(this.tpHome);
            this.tabControlMain.Controls.Add(this.tpSettings);
            this.tabControlMain.Controls.Add(this.tpLogout);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(84, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1220, 743);
            this.tabControlMain.TabIndex = 4;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tpHome
            // 
            this.tpHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpHome.Controls.Add(this.tabControlHome);
            this.tpHome.Location = new System.Drawing.Point(4, 4);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHome.Size = new System.Drawing.Size(1212, 717);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tabControlHome
            // 
            this.tabControlHome.Controls.Add(this.tpPatients);
            this.tabControlHome.Controls.Add(this.tpNurses);
            this.tabControlHome.Controls.Add(this.tpDoctors);
            this.tabControlHome.Controls.Add(this.tpPatientService);
            this.tabControlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlHome.ImageList = this.imageList1;
            this.tabControlHome.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControlHome.Location = new System.Drawing.Point(3, 3);
            this.tabControlHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.Padding = new System.Drawing.Point(50, 3);
            this.tabControlHome.SelectedIndex = 0;
            this.tabControlHome.Size = new System.Drawing.Size(1202, 707);
            this.tabControlHome.TabIndex = 7;
            this.tabControlHome.SelectedIndexChanged += new System.EventHandler(this.tabControlHome_SelectedIndexChanged);
            // 
            // tpPatients
            // 
            this.tpPatients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpPatients.Controls.Add(this.btnAddPatient);
            this.tpPatients.Controls.Add(this.cbPatientsFilterBy);
            this.tpPatients.Controls.Add(this.txtPatientsFilterBy);
            this.tpPatients.Controls.Add(this.label4);
            this.tpPatients.Controls.Add(this.dgvPatients);
            this.tpPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPatients.ImageIndex = 0;
            this.tpPatients.Location = new System.Drawing.Point(4, 34);
            this.tpPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPatients.Name = "tpPatients";
            this.tpPatients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPatients.Size = new System.Drawing.Size(1194, 669);
            this.tpPatients.TabIndex = 0;
            this.tpPatients.Text = "Patients";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.plus;
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPatient.Location = new System.Drawing.Point(470, 15);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(38, 32);
            this.btnAddPatient.TabIndex = 4;
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // cbPatientsFilterBy
            // 
            this.cbPatientsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatientsFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPatientsFilterBy.FormattingEnabled = true;
            this.cbPatientsFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "First Name",
            "Last Name",
            "Phone Number"});
            this.cbPatientsFilterBy.Location = new System.Drawing.Point(134, 20);
            this.cbPatientsFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPatientsFilterBy.Name = "cbPatientsFilterBy";
            this.cbPatientsFilterBy.Size = new System.Drawing.Size(152, 25);
            this.cbPatientsFilterBy.TabIndex = 3;
            this.cbPatientsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbPatientsFilterBy_SelectedIndexChanged);
            // 
            // txtPatientsFilterBy
            // 
            this.txtPatientsFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientsFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientsFilterBy.Location = new System.Drawing.Point(304, 20);
            this.txtPatientsFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientsFilterBy.Name = "txtPatientsFilterBy";
            this.txtPatientsFilterBy.Size = new System.Drawing.Size(147, 23);
            this.txtPatientsFilterBy.TabIndex = 2;
            this.txtPatientsFilterBy.TextChanged += new System.EventHandler(this.txtPatientsFilterBy_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Filter By:";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToOrderColumns = true;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.cmsPatients;
            this.dgvPatients.Location = new System.Drawing.Point(28, 52);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1058, 613);
            this.dgvPatients.TabIndex = 0;
            // 
            // cmsPatients
            // 
            this.cmsPatients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPatients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPatientShowDetails,
            this.tsmiPatientEdit,
            this.tsmiPatientDelete});
            this.cmsPatients.Name = "contextMenuStrip1";
            this.cmsPatients.Size = new System.Drawing.Size(146, 82);
            // 
            // tsmiPatientShowDetails
            // 
            this.tsmiPatientShowDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiPatientShowDetails.Name = "tsmiPatientShowDetails";
            this.tsmiPatientShowDetails.Size = new System.Drawing.Size(145, 26);
            this.tsmiPatientShowDetails.Text = "Show Details";
            this.tsmiPatientShowDetails.Click += new System.EventHandler(this.tsmiPatientShowDetails_Click);
            // 
            // tsmiPatientEdit
            // 
            this.tsmiPatientEdit.Image = global::NurseSystem.PresentationLayer.Properties.Resources.compose;
            this.tsmiPatientEdit.Name = "tsmiPatientEdit";
            this.tsmiPatientEdit.Size = new System.Drawing.Size(145, 26);
            this.tsmiPatientEdit.Text = "Edit";
            this.tsmiPatientEdit.Click += new System.EventHandler(this.tsmiPatientEdit_Click);
            // 
            // tsmiPatientDelete
            // 
            this.tsmiPatientDelete.Image = global::NurseSystem.PresentationLayer.Properties.Resources.bin__1_;
            this.tsmiPatientDelete.Name = "tsmiPatientDelete";
            this.tsmiPatientDelete.Size = new System.Drawing.Size(145, 26);
            this.tsmiPatientDelete.Text = "Delete";
            this.tsmiPatientDelete.Click += new System.EventHandler(this.tsmiPatientDelete_Click);
            // 
            // tpNurses
            // 
            this.tpNurses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpNurses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpNurses.Controls.Add(this.btnAddNurse);
            this.tpNurses.Controls.Add(this.cbNursesFilterBy);
            this.tpNurses.Controls.Add(this.txtNursesFilterBy);
            this.tpNurses.Controls.Add(this.label5);
            this.tpNurses.Controls.Add(this.dgvNurses);
            this.tpNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNurses.ImageIndex = 1;
            this.tpNurses.Location = new System.Drawing.Point(4, 34);
            this.tpNurses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpNurses.Name = "tpNurses";
            this.tpNurses.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpNurses.Size = new System.Drawing.Size(1194, 669);
            this.tpNurses.TabIndex = 1;
            this.tpNurses.Text = "Nurses";
            // 
            // btnAddNurse
            // 
            this.btnAddNurse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNurse.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.plus;
            this.btnAddNurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNurse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNurse.Location = new System.Drawing.Point(473, 16);
            this.btnAddNurse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNurse.Name = "btnAddNurse";
            this.btnAddNurse.Size = new System.Drawing.Size(38, 32);
            this.btnAddNurse.TabIndex = 8;
            this.btnAddNurse.UseVisualStyleBackColor = false;
            this.btnAddNurse.Click += new System.EventHandler(this.btnAddNurse_Click);
            // 
            // cbNursesFilterBy
            // 
            this.cbNursesFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNursesFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNursesFilterBy.FormattingEnabled = true;
            this.cbNursesFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "First Name",
            "Last Name",
            "Phone Number"});
            this.cbNursesFilterBy.Location = new System.Drawing.Point(136, 23);
            this.cbNursesFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNursesFilterBy.Name = "cbNursesFilterBy";
            this.cbNursesFilterBy.Size = new System.Drawing.Size(152, 25);
            this.cbNursesFilterBy.TabIndex = 7;
            this.cbNursesFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbNursesFilterBy_SelectedIndexChanged);
            // 
            // txtNursesFilterBy
            // 
            this.txtNursesFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNursesFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNursesFilterBy.Location = new System.Drawing.Point(307, 23);
            this.txtNursesFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNursesFilterBy.Name = "txtNursesFilterBy";
            this.txtNursesFilterBy.Size = new System.Drawing.Size(147, 23);
            this.txtNursesFilterBy.TabIndex = 6;
            this.txtNursesFilterBy.TextChanged += new System.EventHandler(this.txtNursesFilterBy_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filter By:";
            // 
            // dgvNurses
            // 
            this.dgvNurses.AllowUserToAddRows = false;
            this.dgvNurses.AllowUserToDeleteRows = false;
            this.dgvNurses.AllowUserToOrderColumns = true;
            this.dgvNurses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNurses.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvNurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNurses.ContextMenuStrip = this.cmsNurses;
            this.dgvNurses.Location = new System.Drawing.Point(29, 54);
            this.dgvNurses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNurses.Name = "dgvNurses";
            this.dgvNurses.ReadOnly = true;
            this.dgvNurses.RowHeadersWidth = 51;
            this.dgvNurses.RowTemplate.Height = 24;
            this.dgvNurses.Size = new System.Drawing.Size(1069, 611);
            this.dgvNurses.TabIndex = 4;
            // 
            // cmsNurses
            // 
            this.cmsNurses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNurses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNurseShowDetails,
            this.tsmiNurseEdit,
            this.tsmiNurseDelete});
            this.cmsNurses.Name = "cmsNurses";
            this.cmsNurses.Size = new System.Drawing.Size(146, 82);
            // 
            // tsmiNurseShowDetails
            // 
            this.tsmiNurseShowDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiNurseShowDetails.Name = "tsmiNurseShowDetails";
            this.tsmiNurseShowDetails.Size = new System.Drawing.Size(145, 26);
            this.tsmiNurseShowDetails.Text = "Show Details";
            this.tsmiNurseShowDetails.Click += new System.EventHandler(this.tsmiNurseShowDetails_Click);
            // 
            // tsmiNurseEdit
            // 
            this.tsmiNurseEdit.Image = global::NurseSystem.PresentationLayer.Properties.Resources.compose;
            this.tsmiNurseEdit.Name = "tsmiNurseEdit";
            this.tsmiNurseEdit.Size = new System.Drawing.Size(145, 26);
            this.tsmiNurseEdit.Text = "Edit";
            this.tsmiNurseEdit.Click += new System.EventHandler(this.tsmiNurseEdit_Click);
            // 
            // tsmiNurseDelete
            // 
            this.tsmiNurseDelete.Image = global::NurseSystem.PresentationLayer.Properties.Resources.bin__1_;
            this.tsmiNurseDelete.Name = "tsmiNurseDelete";
            this.tsmiNurseDelete.Size = new System.Drawing.Size(145, 26);
            this.tsmiNurseDelete.Text = "Delete";
            this.tsmiNurseDelete.Click += new System.EventHandler(this.tsmiNurseDelete_Click);
            // 
            // tpDoctors
            // 
            this.tpDoctors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDoctors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpDoctors.Controls.Add(this.btnAddDoctor);
            this.tpDoctors.Controls.Add(this.cbDoctorsFilterBy);
            this.tpDoctors.Controls.Add(this.txtDoctorsFilterBy);
            this.tpDoctors.Controls.Add(this.label6);
            this.tpDoctors.Controls.Add(this.dgvDoctors);
            this.tpDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDoctors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpDoctors.ImageIndex = 2;
            this.tpDoctors.Location = new System.Drawing.Point(4, 34);
            this.tpDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDoctors.Name = "tpDoctors";
            this.tpDoctors.Size = new System.Drawing.Size(1194, 669);
            this.tpDoctors.TabIndex = 2;
            this.tpDoctors.Text = "Doctors";
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.plus;
            this.btnAddDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoctor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDoctor.Location = new System.Drawing.Point(465, 16);
            this.btnAddDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(38, 32);
            this.btnAddDoctor.TabIndex = 9;
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // cbDoctorsFilterBy
            // 
            this.cbDoctorsFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctorsFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoctorsFilterBy.FormattingEnabled = true;
            this.cbDoctorsFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "First Name",
            "Last Name",
            "Phone Number"});
            this.cbDoctorsFilterBy.Location = new System.Drawing.Point(132, 22);
            this.cbDoctorsFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDoctorsFilterBy.Name = "cbDoctorsFilterBy";
            this.cbDoctorsFilterBy.Size = new System.Drawing.Size(152, 25);
            this.cbDoctorsFilterBy.TabIndex = 7;
            this.cbDoctorsFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbDoctorsFilterBy_SelectedIndexChanged);
            // 
            // txtDoctorsFilterBy
            // 
            this.txtDoctorsFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoctorsFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorsFilterBy.Location = new System.Drawing.Point(303, 22);
            this.txtDoctorsFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDoctorsFilterBy.Name = "txtDoctorsFilterBy";
            this.txtDoctorsFilterBy.Size = new System.Drawing.Size(147, 23);
            this.txtDoctorsFilterBy.TabIndex = 6;
            this.txtDoctorsFilterBy.TextChanged += new System.EventHandler(this.txtDoctorsFilterBy_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filter By:";
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToOrderColumns = true;
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.ContextMenuStrip = this.cmsDoctors;
            this.dgvDoctors.Location = new System.Drawing.Point(27, 54);
            this.dgvDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(1067, 611);
            this.dgvDoctors.TabIndex = 4;
            // 
            // cmsDoctors
            // 
            this.cmsDoctors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDoctors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDoctorShowDetails,
            this.tsmiDoctorEdit,
            this.tsmiDoctorDelete});
            this.cmsDoctors.Name = "cmsDoctors";
            this.cmsDoctors.Size = new System.Drawing.Size(146, 82);
            // 
            // tsmiDoctorShowDetails
            // 
            this.tsmiDoctorShowDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiDoctorShowDetails.Name = "tsmiDoctorShowDetails";
            this.tsmiDoctorShowDetails.Size = new System.Drawing.Size(145, 26);
            this.tsmiDoctorShowDetails.Text = "Show Details";
            this.tsmiDoctorShowDetails.Click += new System.EventHandler(this.tsmiDoctorShowDetails_Click);
            // 
            // tsmiDoctorEdit
            // 
            this.tsmiDoctorEdit.Image = global::NurseSystem.PresentationLayer.Properties.Resources.compose;
            this.tsmiDoctorEdit.Name = "tsmiDoctorEdit";
            this.tsmiDoctorEdit.Size = new System.Drawing.Size(145, 26);
            this.tsmiDoctorEdit.Text = "Edit";
            this.tsmiDoctorEdit.Click += new System.EventHandler(this.tsmiDoctorEdit_Click);
            // 
            // tsmiDoctorDelete
            // 
            this.tsmiDoctorDelete.Image = global::NurseSystem.PresentationLayer.Properties.Resources.bin__1_;
            this.tsmiDoctorDelete.Name = "tsmiDoctorDelete";
            this.tsmiDoctorDelete.Size = new System.Drawing.Size(145, 26);
            this.tsmiDoctorDelete.Text = "Delete";
            this.tsmiDoctorDelete.Click += new System.EventHandler(this.tsmiDoctorDelete_Click);
            // 
            // tpPatientService
            // 
            this.tpPatientService.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpPatientService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpPatientService.Controls.Add(this.btnAddPatientService);
            this.tpPatientService.Controls.Add(this.cbPatientServiceFilterBy);
            this.tpPatientService.Controls.Add(this.txtPatientServiceFilterBy);
            this.tpPatientService.Controls.Add(this.label3);
            this.tpPatientService.Controls.Add(this.dgvPatientServices);
            this.tpPatientService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPatientService.ImageIndex = 3;
            this.tpPatientService.Location = new System.Drawing.Point(4, 34);
            this.tpPatientService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPatientService.Name = "tpPatientService";
            this.tpPatientService.Size = new System.Drawing.Size(1194, 669);
            this.tpPatientService.TabIndex = 3;
            this.tpPatientService.Text = "Bills";
            // 
            // btnAddPatientService
            // 
            this.btnAddPatientService.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.plus;
            this.btnAddPatientService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPatientService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatientService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPatientService.Location = new System.Drawing.Point(465, 18);
            this.btnAddPatientService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPatientService.Name = "btnAddPatientService";
            this.btnAddPatientService.Size = new System.Drawing.Size(38, 32);
            this.btnAddPatientService.TabIndex = 14;
            this.btnAddPatientService.UseVisualStyleBackColor = true;
            this.btnAddPatientService.Click += new System.EventHandler(this.btnAddPatientService_Click);
            // 
            // cbPatientServiceFilterBy
            // 
            this.cbPatientServiceFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatientServiceFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPatientServiceFilterBy.FormattingEnabled = true;
            this.cbPatientServiceFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "Patient First Name",
            "Patient Last Name",
            "Nurse First Name",
            "Doctor First Name",
            "Application Date"});
            this.cbPatientServiceFilterBy.Location = new System.Drawing.Point(132, 24);
            this.cbPatientServiceFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPatientServiceFilterBy.Name = "cbPatientServiceFilterBy";
            this.cbPatientServiceFilterBy.Size = new System.Drawing.Size(152, 25);
            this.cbPatientServiceFilterBy.TabIndex = 13;
            this.cbPatientServiceFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbPatientServiceFilterBy_SelectedIndexChanged);
            // 
            // txtPatientServiceFilterBy
            // 
            this.txtPatientServiceFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientServiceFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientServiceFilterBy.Location = new System.Drawing.Point(303, 24);
            this.txtPatientServiceFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatientServiceFilterBy.Name = "txtPatientServiceFilterBy";
            this.txtPatientServiceFilterBy.Size = new System.Drawing.Size(147, 23);
            this.txtPatientServiceFilterBy.TabIndex = 12;
            this.txtPatientServiceFilterBy.TextChanged += new System.EventHandler(this.txtPatientServiceFilterBy_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filter By:";
            // 
            // dgvPatientServices
            // 
            this.dgvPatientServices.AllowUserToAddRows = false;
            this.dgvPatientServices.AllowUserToDeleteRows = false;
            this.dgvPatientServices.AllowUserToOrderColumns = true;
            this.dgvPatientServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientServices.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPatientServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientServices.ContextMenuStrip = this.cmsPatientService;
            this.dgvPatientServices.Location = new System.Drawing.Point(27, 56);
            this.dgvPatientServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPatientServices.Name = "dgvPatientServices";
            this.dgvPatientServices.ReadOnly = true;
            this.dgvPatientServices.RowHeadersWidth = 51;
            this.dgvPatientServices.RowTemplate.Height = 24;
            this.dgvPatientServices.Size = new System.Drawing.Size(1009, 608);
            this.dgvPatientServices.TabIndex = 10;
            // 
            // cmsPatientService
            // 
            this.cmsPatientService.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPatientService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrint,
            this.tsmiPatientServiceShowDetails,
            this.tsmiPatientServiceEdit,
            this.tsmiPatientServiceDelete,
            this.tsmiShowPatientDetails,
            this.tsmiShowNurseDetails,
            this.tsmiShowDoctorDetails});
            this.cmsPatientService.Name = "cmsPatientService";
            this.cmsPatientService.Size = new System.Drawing.Size(186, 186);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Image = global::NurseSystem.PresentationLayer.Properties.Resources.paper;
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(185, 26);
            this.tsmiPrint.Text = "Print";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiPatientServiceShowDetails
            // 
            this.tsmiPatientServiceShowDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiPatientServiceShowDetails.Name = "tsmiPatientServiceShowDetails";
            this.tsmiPatientServiceShowDetails.Size = new System.Drawing.Size(185, 26);
            this.tsmiPatientServiceShowDetails.Text = "Show Details";
            this.tsmiPatientServiceShowDetails.Click += new System.EventHandler(this.tsmiPatientServiceShowDetails_Click);
            // 
            // tsmiPatientServiceEdit
            // 
            this.tsmiPatientServiceEdit.Image = global::NurseSystem.PresentationLayer.Properties.Resources.compose;
            this.tsmiPatientServiceEdit.Name = "tsmiPatientServiceEdit";
            this.tsmiPatientServiceEdit.Size = new System.Drawing.Size(185, 26);
            this.tsmiPatientServiceEdit.Text = "Edit";
            this.tsmiPatientServiceEdit.Click += new System.EventHandler(this.tsmiPatientServiceEdit_Click);
            // 
            // tsmiPatientServiceDelete
            // 
            this.tsmiPatientServiceDelete.Image = global::NurseSystem.PresentationLayer.Properties.Resources.bin__1_;
            this.tsmiPatientServiceDelete.Name = "tsmiPatientServiceDelete";
            this.tsmiPatientServiceDelete.Size = new System.Drawing.Size(185, 26);
            this.tsmiPatientServiceDelete.Text = "Delete";
            this.tsmiPatientServiceDelete.Click += new System.EventHandler(this.tsmiPatientServiceDelete_Click);
            // 
            // tsmiShowPatientDetails
            // 
            this.tsmiShowPatientDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiShowPatientDetails.Name = "tsmiShowPatientDetails";
            this.tsmiShowPatientDetails.Size = new System.Drawing.Size(185, 26);
            this.tsmiShowPatientDetails.Text = "Show Patient Details";
            this.tsmiShowPatientDetails.Click += new System.EventHandler(this.tsmiShowPatientDetails_Click);
            // 
            // tsmiShowNurseDetails
            // 
            this.tsmiShowNurseDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiShowNurseDetails.Name = "tsmiShowNurseDetails";
            this.tsmiShowNurseDetails.Size = new System.Drawing.Size(185, 26);
            this.tsmiShowNurseDetails.Text = "Show Nurse Details";
            this.tsmiShowNurseDetails.Click += new System.EventHandler(this.tsmiShowNurseDetails_Click);
            // 
            // tsmiShowDoctorDetails
            // 
            this.tsmiShowDoctorDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiShowDoctorDetails.Name = "tsmiShowDoctorDetails";
            this.tsmiShowDoctorDetails.Size = new System.Drawing.Size(185, 26);
            this.tsmiShowDoctorDetails.Text = "Show Doctor Details";
            this.tsmiShowDoctorDetails.Click += new System.EventHandler(this.tsmiShowDoctorDetails_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "patient (1).png");
            this.imageList1.Images.SetKeyName(1, "nurse.png");
            this.imageList1.Images.SetKeyName(2, "doctor.png");
            this.imageList1.Images.SetKeyName(3, "customer-service.png");
            this.imageList1.Images.SetKeyName(4, "headphone.png");
            this.imageList1.Images.SetKeyName(5, "office-man.png");
            // 
            // tpSettings
            // 
            this.tpSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpSettings.Controls.Add(this.tabControlSettings);
            this.tpSettings.Location = new System.Drawing.Point(4, 4);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSettings.Size = new System.Drawing.Size(1212, 717);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tpServices);
            this.tabControlSettings.Controls.Add(this.tpUsers);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSettings.ImageList = this.imageList1;
            this.tabControlSettings.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControlSettings.Location = new System.Drawing.Point(3, 3);
            this.tabControlSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.Padding = new System.Drawing.Point(50, 3);
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(1202, 707);
            this.tabControlSettings.TabIndex = 5;
            this.tabControlSettings.SelectedIndexChanged += new System.EventHandler(this.tabControlSettings_SelectedIndexChanged);
            // 
            // tpServices
            // 
            this.tpServices.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpServices.Controls.Add(this.btnAddService);
            this.tpServices.Controls.Add(this.cbServicesFilterBy);
            this.tpServices.Controls.Add(this.txtServicesFilterBy);
            this.tpServices.Controls.Add(this.label1);
            this.tpServices.Controls.Add(this.dgvServices);
            this.tpServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpServices.ImageIndex = 4;
            this.tpServices.Location = new System.Drawing.Point(4, 34);
            this.tpServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpServices.Size = new System.Drawing.Size(1194, 669);
            this.tpServices.TabIndex = 0;
            this.tpServices.Text = "Services";
            // 
            // btnAddService
            // 
            this.btnAddService.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.plus;
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddService.Location = new System.Drawing.Point(530, 20);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(38, 32);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // cbServicesFilterBy
            // 
            this.cbServicesFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicesFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicesFilterBy.FormattingEnabled = true;
            this.cbServicesFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "Name"});
            this.cbServicesFilterBy.Location = new System.Drawing.Point(188, 27);
            this.cbServicesFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbServicesFilterBy.Name = "cbServicesFilterBy";
            this.cbServicesFilterBy.Size = new System.Drawing.Size(152, 25);
            this.cbServicesFilterBy.TabIndex = 3;
            this.cbServicesFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbServicesFilterBy_SelectedIndexChanged);
            // 
            // txtServicesFilterBy
            // 
            this.txtServicesFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServicesFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicesFilterBy.Location = new System.Drawing.Point(358, 27);
            this.txtServicesFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServicesFilterBy.Name = "txtServicesFilterBy";
            this.txtServicesFilterBy.Size = new System.Drawing.Size(147, 23);
            this.txtServicesFilterBy.TabIndex = 2;
            this.txtServicesFilterBy.TextChanged += new System.EventHandler(this.txtServicesFilterBy_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By:";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToOrderColumns = true;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.ContextMenuStrip = this.cmsServices;
            this.dgvServices.Location = new System.Drawing.Point(82, 58);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(658, 613);
            this.dgvServices.TabIndex = 0;
            // 
            // cmsServices
            // 
            this.cmsServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiServiceShowDetails,
            this.tsmiServiceEdit,
            this.tsmiServiceDelete});
            this.cmsServices.Name = "cmsServices";
            this.cmsServices.Size = new System.Drawing.Size(146, 82);
            // 
            // tsmiServiceShowDetails
            // 
            this.tsmiServiceShowDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiServiceShowDetails.Name = "tsmiServiceShowDetails";
            this.tsmiServiceShowDetails.Size = new System.Drawing.Size(145, 26);
            this.tsmiServiceShowDetails.Text = "Show Details";
            this.tsmiServiceShowDetails.Click += new System.EventHandler(this.tsmiServiceShowDetails_Click);
            // 
            // tsmiServiceEdit
            // 
            this.tsmiServiceEdit.Image = global::NurseSystem.PresentationLayer.Properties.Resources.compose;
            this.tsmiServiceEdit.Name = "tsmiServiceEdit";
            this.tsmiServiceEdit.Size = new System.Drawing.Size(145, 26);
            this.tsmiServiceEdit.Text = "Edit";
            this.tsmiServiceEdit.Click += new System.EventHandler(this.tsmiServiceEdit_Click);
            // 
            // tsmiServiceDelete
            // 
            this.tsmiServiceDelete.Image = global::NurseSystem.PresentationLayer.Properties.Resources.bin__1_;
            this.tsmiServiceDelete.Name = "tsmiServiceDelete";
            this.tsmiServiceDelete.Size = new System.Drawing.Size(145, 26);
            this.tsmiServiceDelete.Text = "Delete";
            this.tsmiServiceDelete.Click += new System.EventHandler(this.tsmiServiceDelete_Click);
            // 
            // tpUsers
            // 
            this.tpUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpUsers.Controls.Add(this.gbCalculations);
            this.tpUsers.Controls.Add(this.cbUsersFilterBy);
            this.tpUsers.Controls.Add(this.txtUsersFilterBy);
            this.tpUsers.Controls.Add(this.label2);
            this.tpUsers.Controls.Add(this.dgvUsers);
            this.tpUsers.Controls.Add(this.btnAddUser);
            this.tpUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUsers.ImageIndex = 5;
            this.tpUsers.Location = new System.Drawing.Point(4, 34);
            this.tpUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpUsers.Size = new System.Drawing.Size(1194, 669);
            this.tpUsers.TabIndex = 1;
            this.tpUsers.Text = "Users";
            // 
            // gbCalculations
            // 
            this.gbCalculations.BackColor = System.Drawing.Color.Transparent;
            this.gbCalculations.Controls.Add(this.btnCollect);
            this.gbCalculations.Controls.Add(this.lblMoneyToCollect);
            this.gbCalculations.Controls.Add(this.label7);
            this.gbCalculations.Controls.Add(this.lblTitle);
            this.gbCalculations.Controls.Add(this.btnCalculate);
            this.gbCalculations.Controls.Add(this.cbYear);
            this.gbCalculations.Controls.Add(this.cbMonth);
            this.gbCalculations.Controls.Add(this.lblAmountPaid);
            this.gbCalculations.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCalculations.Location = new System.Drawing.Point(792, 2);
            this.gbCalculations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCalculations.Name = "gbCalculations";
            this.gbCalculations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCalculations.Size = new System.Drawing.Size(396, 661);
            this.gbCalculations.TabIndex = 60;
            this.gbCalculations.TabStop = false;
            this.gbCalculations.Text = "Calculations:";
            // 
            // btnCollect
            // 
            this.btnCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollect.Location = new System.Drawing.Point(46, 364);
            this.btnCollect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(114, 28);
            this.btnCollect.TabIndex = 62;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.lblCollect_Click);
            // 
            // lblMoneyToCollect
            // 
            this.lblMoneyToCollect.AutoSize = true;
            this.lblMoneyToCollect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoneyToCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoneyToCollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyToCollect.Location = new System.Drawing.Point(231, 315);
            this.lblMoneyToCollect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoneyToCollect.Name = "lblMoneyToCollect";
            this.lblMoneyToCollect.Size = new System.Drawing.Size(33, 22);
            this.lblMoneyToCollect.TabIndex = 61;
            this.lblMoneyToCollect.Text = "0 $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.label7.Location = new System.Drawing.Point(30, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 30);
            this.label7.TabIndex = 60;
            this.label7.Text = "Money To Collect:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(140)))), ((int)(((byte)(67)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 50);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 30);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "Amount Paid In A Specific Month:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(46, 150);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 28);
            this.btnCalculate.TabIndex = 59;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.cbYear.Location = new System.Drawing.Point(46, 101);
            this.cbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(115, 25);
            this.cbYear.TabIndex = 9;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(201, 101);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(110, 25);
            this.cbMonth.TabIndex = 10;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(201, 153);
            this.lblAmountPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(33, 22);
            this.lblAmountPaid.TabIndex = 11;
            this.lblAmountPaid.Text = "0 $";
            // 
            // cbUsersFilterBy
            // 
            this.cbUsersFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsersFilterBy.FormattingEnabled = true;
            this.cbUsersFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "User Name"});
            this.cbUsersFilterBy.Location = new System.Drawing.Point(189, 22);
            this.cbUsersFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUsersFilterBy.Name = "cbUsersFilterBy";
            this.cbUsersFilterBy.Size = new System.Drawing.Size(152, 25);
            this.cbUsersFilterBy.TabIndex = 7;
            this.cbUsersFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbUsersFilterBy_SelectedIndexChanged);
            // 
            // txtUsersFilterBy
            // 
            this.txtUsersFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsersFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsersFilterBy.Location = new System.Drawing.Point(360, 22);
            this.txtUsersFilterBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsersFilterBy.Name = "txtUsersFilterBy";
            this.txtUsersFilterBy.Size = new System.Drawing.Size(147, 23);
            this.txtUsersFilterBy.TabIndex = 6;
            this.txtUsersFilterBy.TextChanged += new System.EventHandler(this.txtUsersFilterBy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvUsers.Location = new System.Drawing.Point(82, 52);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(505, 617);
            this.dgvUsers.TabIndex = 4;
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserShowDetails,
            this.tsmiUserEdit,
            this.tsmiUserDelete});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.Size = new System.Drawing.Size(146, 82);
            // 
            // tsmiUserShowDetails
            // 
            this.tsmiUserShowDetails.Image = global::NurseSystem.PresentationLayer.Properties.Resources.details;
            this.tsmiUserShowDetails.Name = "tsmiUserShowDetails";
            this.tsmiUserShowDetails.Size = new System.Drawing.Size(145, 26);
            this.tsmiUserShowDetails.Text = "Show Details";
            this.tsmiUserShowDetails.Click += new System.EventHandler(this.tsmiUserShowDetails_Click);
            // 
            // tsmiUserEdit
            // 
            this.tsmiUserEdit.Image = global::NurseSystem.PresentationLayer.Properties.Resources.compose;
            this.tsmiUserEdit.Name = "tsmiUserEdit";
            this.tsmiUserEdit.Size = new System.Drawing.Size(145, 26);
            this.tsmiUserEdit.Text = "Edit";
            this.tsmiUserEdit.Click += new System.EventHandler(this.tsmiUserEdit_Click);
            // 
            // tsmiUserDelete
            // 
            this.tsmiUserDelete.Image = global::NurseSystem.PresentationLayer.Properties.Resources.bin__1_;
            this.tsmiUserDelete.Name = "tsmiUserDelete";
            this.tsmiUserDelete.Size = new System.Drawing.Size(145, 26);
            this.tsmiUserDelete.Text = "Delete";
            this.tsmiUserDelete.Click += new System.EventHandler(this.tsmiUserDelete_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::NurseSystem.PresentationLayer.Properties.Resources.plus;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUser.Location = new System.Drawing.Point(526, 15);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(38, 32);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tpLogout
            // 
            this.tpLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpLogout.Location = new System.Drawing.Point(4, 4);
            this.tpLogout.Name = "tpLogout";
            this.tpLogout.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpLogout.Size = new System.Drawing.Size(1212, 717);
            this.tpLogout.TabIndex = 2;
            this.tpLogout.Text = "Logout";
            this.tpLogout.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 743);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelEdge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelEdge.ResumeLayout(false);
            this.panelEdge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tabControlHome.ResumeLayout(false);
            this.tpPatients.ResumeLayout(false);
            this.tpPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.cmsPatients.ResumeLayout(false);
            this.tpNurses.ResumeLayout(false);
            this.tpNurses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNurses)).EndInit();
            this.cmsNurses.ResumeLayout(false);
            this.tpDoctors.ResumeLayout(false);
            this.tpDoctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.cmsDoctors.ResumeLayout(false);
            this.tpPatientService.ResumeLayout(false);
            this.tpPatientService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientServices)).EndInit();
            this.cmsPatientService.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tpServices.ResumeLayout(false);
            this.tpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.cmsServices.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            this.gbCalculations.ResumeLayout(false);
            this.gbCalculations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEdge;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabControl tabControlHome;
        private System.Windows.Forms.TabPage tpPatients;
        private System.Windows.Forms.ComboBox cbPatientsFilterBy;
        private System.Windows.Forms.TextBox txtPatientsFilterBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.TabPage tpNurses;
        private System.Windows.Forms.ComboBox cbNursesFilterBy;
        private System.Windows.Forms.TextBox txtNursesFilterBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNurses;
        private System.Windows.Forms.TabPage tpDoctors;
        private System.Windows.Forms.ComboBox cbDoctorsFilterBy;
        private System.Windows.Forms.TextBox txtDoctorsFilterBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.TabPage tpLogout;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.ComboBox cbServicesFilterBy;
        private System.Windows.Forms.TextBox txtServicesFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.ComboBox cbUsersFilterBy;
        private System.Windows.Forms.TextBox txtUsersFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip cmsPatients;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientDelete;
        private System.Windows.Forms.ContextMenuStrip cmsNurses;
        private System.Windows.Forms.ToolStripMenuItem tsmiNurseShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiNurseEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiNurseDelete;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddNurse;
        private System.Windows.Forms.ContextMenuStrip cmsDoctors;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctorShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctorEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoctorDelete;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserDelete;
        private System.Windows.Forms.ContextMenuStrip cmsServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiServiceShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiServiceEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiServiceDelete;
        private System.Windows.Forms.TabPage tpPatientService;
        private System.Windows.Forms.Button btnAddPatientService;
        private System.Windows.Forms.ComboBox cbPatientServiceFilterBy;
        private System.Windows.Forms.TextBox txtPatientServiceFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPatientServices;
        private System.Windows.Forms.ContextMenuStrip cmsPatientService;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientServiceShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientServiceEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiPatientServiceDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPatientDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowNurseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDoctorDetails;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbCalculations;
        private System.Windows.Forms.Label lblMoneyToCollect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
    }
}

