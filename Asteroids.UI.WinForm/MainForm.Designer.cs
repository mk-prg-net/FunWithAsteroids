namespace Asteroids.UI.WinForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsteroidsCsv = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterInKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceSunInAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectedAsteroidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panImportCsvMain = new System.Windows.Forms.Panel();
            this.lblImportCsvCountAsteroids = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxMinDiameter = new System.Windows.Forms.CheckBox();
            this.cbxMaxDiameter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMinDistanceSun = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMaxDistanceSun = new System.Windows.Forms.CheckBox();
            this.btnGetSortOrderBuilder = new System.Windows.Forms.Button();
            this.cbxSortDiameter = new System.Windows.Forms.CheckBox();
            this.cbxSortDistanceSun = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.tbxMinDiameter = new System.Windows.Forms.TextBox();
            this.tbxMaxDiameter = new System.Windows.Forms.TextBox();
            this.tbxMinDistanceSun = new System.Windows.Forms.TextBox();
            this.tbxMaxDistanceSun = new System.Windows.Forms.TextBox();
            this.grpSortDiameter = new System.Windows.Forms.GroupBox();
            this.rbtDiameterDown = new System.Windows.Forms.RadioButton();
            this.rbtDiameterUp = new System.Windows.Forms.RadioButton();
            this.grpSortDistanceSun = new System.Windows.Forms.GroupBox();
            this.rbtDistanceSunDown = new System.Windows.Forms.RadioButton();
            this.rbtDistanceSunUp = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewQuery = new System.Windows.Forms.Button();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterInKmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceSunInAUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albedoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateCollectorCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectedAsteroidsBindingSource)).BeginInit();
            this.panImportCsvMain.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSortDiameter.SuspendLayout();
            this.grpSortDistanceSun.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fileToolStripMenuItem.Text = "&Open";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openAsteroidsCsv
            // 
            this.openAsteroidsCsv.FileName = "*.csv";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelMain,
            this.progressBarMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelMain
            // 
            this.statusLabelMain.Name = "statusLabelMain";
            this.statusLabelMain.Size = new System.Drawing.Size(93, 17);
            this.statusLabelMain.Text = "statusLabelMain";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Controls.Add(this.tabPageImport);
            this.tabControlMain.Controls.Add(this.tabPageQuery);
            this.tabControlMain.Controls.Add(this.tabPageResult);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(781, 437);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.lbxLog);
            this.tabPageLog.Controls.Add(this.panel2);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(773, 411);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Logs";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // lbxLog
            // 
            this.lbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.Location = new System.Drawing.Point(3, 64);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(767, 344);
            this.lbxLog.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 61);
            this.panel2.TabIndex = 0;
            // 
            // tabPageImport
            // 
            this.tabPageImport.Controls.Add(this.dataGridView1);
            this.tabPageImport.Controls.Add(this.panImportCsvMain);
            this.tabPageImport.Location = new System.Drawing.Point(4, 22);
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImport.Size = new System.Drawing.Size(773, 411);
            this.tabPageImport.TabIndex = 1;
            this.tabPageImport.Text = "Import CSV";
            this.tabPageImport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.diameterInKmDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn,
            this.distanceSunInAUDataGridViewTextBoxColumn,
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn,
            this.albedoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.CollectedAsteroidsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diameterInKmDataGridViewTextBoxColumn
            // 
            this.diameterInKmDataGridViewTextBoxColumn.DataPropertyName = "DiameterInKm";
            this.diameterInKmDataGridViewTextBoxColumn.HeaderText = "DiameterInKm";
            this.diameterInKmDataGridViewTextBoxColumn.Name = "diameterInKmDataGridViewTextBoxColumn";
            this.diameterInKmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "E";
            this.eDataGridViewTextBoxColumn.HeaderText = "E";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceSunInAUDataGridViewTextBoxColumn
            // 
            this.distanceSunInAUDataGridViewTextBoxColumn.DataPropertyName = "DistanceSunInAU";
            this.distanceSunInAUDataGridViewTextBoxColumn.HeaderText = "DistanceSunInAU";
            this.distanceSunInAUDataGridViewTextBoxColumn.Name = "distanceSunInAUDataGridViewTextBoxColumn";
            this.distanceSunInAUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orbitalTimeInEarthYearsDataGridViewTextBoxColumn
            // 
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn.DataPropertyName = "OrbitalTimeInEarthYears";
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn.HeaderText = "OrbitalTimeInEarthYears";
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn.Name = "orbitalTimeInEarthYearsDataGridViewTextBoxColumn";
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albedoDataGridViewTextBoxColumn
            // 
            this.albedoDataGridViewTextBoxColumn.DataPropertyName = "Albedo";
            this.albedoDataGridViewTextBoxColumn.HeaderText = "Albedo";
            this.albedoDataGridViewTextBoxColumn.Name = "albedoDataGridViewTextBoxColumn";
            this.albedoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CollectedAsteroidsBindingSource
            // 
            this.CollectedAsteroidsBindingSource.DataSource = typeof(AsteroidsBL.IAsteroid);
            // 
            // panImportCsvMain
            // 
            this.panImportCsvMain.Controls.Add(this.lblImportCsvCountAsteroids);
            this.panImportCsvMain.Controls.Add(this.label1);
            this.panImportCsvMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panImportCsvMain.Location = new System.Drawing.Point(3, 3);
            this.panImportCsvMain.Name = "panImportCsvMain";
            this.panImportCsvMain.Size = new System.Drawing.Size(767, 61);
            this.panImportCsvMain.TabIndex = 0;
            // 
            // lblImportCsvCountAsteroids
            // 
            this.lblImportCsvCountAsteroids.BackColor = System.Drawing.Color.Black;
            this.lblImportCsvCountAsteroids.ForeColor = System.Drawing.SystemColors.Info;
            this.lblImportCsvCountAsteroids.Location = new System.Drawing.Point(5, 23);
            this.lblImportCsvCountAsteroids.Name = "lblImportCsvCountAsteroids";
            this.lblImportCsvCountAsteroids.Size = new System.Drawing.Size(107, 23);
            this.lblImportCsvCountAsteroids.TabIndex = 1;
            this.lblImportCsvCountAsteroids.Text = "0";
            this.lblImportCsvCountAsteroids.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# erfasste Asteroiden";
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.tableLayoutPanel1);
            this.tabPageQuery.Controls.Add(this.panel1);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuery.Size = new System.Drawing.Size(773, 411);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Queries";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cbxMinDiameter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxMaxDiameter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxMinDistanceSun, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxMaxDistanceSun, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGetSortOrderBuilder, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxSortDiameter, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxSortDistanceSun, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGetResult, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbxMinDiameter, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxMaxDiameter, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxMinDistanceSun, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxMaxDistanceSun, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.grpSortDiameter, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.grpSortDistanceSun, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 348);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbxMinDiameter
            // 
            this.cbxMinDiameter.AutoSize = true;
            this.cbxMinDiameter.Location = new System.Drawing.Point(3, 3);
            this.cbxMinDiameter.Name = "cbxMinDiameter";
            this.cbxMinDiameter.Size = new System.Drawing.Size(14, 17);
            this.cbxMinDiameter.TabIndex = 0;
            this.cbxMinDiameter.Text = "checkBox1";
            this.cbxMinDiameter.UseVisualStyleBackColor = true;
            // 
            // cbxMaxDiameter
            // 
            this.cbxMaxDiameter.AutoSize = true;
            this.cbxMaxDiameter.Location = new System.Drawing.Point(3, 33);
            this.cbxMaxDiameter.Name = "cbxMaxDiameter";
            this.cbxMaxDiameter.Size = new System.Drawing.Size(14, 17);
            this.cbxMaxDiameter.TabIndex = 1;
            this.cbxMaxDiameter.Text = "checkBox1";
            this.cbxMaxDiameter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "min. Durchmesser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "max. Durchmesser";
            // 
            // cbxMinDistanceSun
            // 
            this.cbxMinDistanceSun.AutoSize = true;
            this.cbxMinDistanceSun.Location = new System.Drawing.Point(3, 63);
            this.cbxMinDistanceSun.Name = "cbxMinDistanceSun";
            this.cbxMinDistanceSun.Size = new System.Drawing.Size(14, 17);
            this.cbxMinDistanceSun.TabIndex = 4;
            this.cbxMinDistanceSun.Text = "checkBox1";
            this.cbxMinDistanceSun.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "min. Bahnradius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "max. Bahnradius";
            // 
            // cbxMaxDistanceSun
            // 
            this.cbxMaxDistanceSun.AutoSize = true;
            this.cbxMaxDistanceSun.Location = new System.Drawing.Point(3, 93);
            this.cbxMaxDistanceSun.Name = "cbxMaxDistanceSun";
            this.cbxMaxDistanceSun.Size = new System.Drawing.Size(14, 17);
            this.cbxMaxDistanceSun.TabIndex = 7;
            this.cbxMaxDistanceSun.Text = "checkBox1";
            this.cbxMaxDistanceSun.UseVisualStyleBackColor = true;
            // 
            // btnGetSortOrderBuilder
            // 
            this.btnGetSortOrderBuilder.Location = new System.Drawing.Point(23, 123);
            this.btnGetSortOrderBuilder.Name = "btnGetSortOrderBuilder";
            this.btnGetSortOrderBuilder.Size = new System.Drawing.Size(144, 23);
            this.btnGetSortOrderBuilder.TabIndex = 8;
            this.btnGetSortOrderBuilder.Text = "Sortierreihenfolgen def.";
            this.btnGetSortOrderBuilder.UseVisualStyleBackColor = true;
            this.btnGetSortOrderBuilder.Click += new System.EventHandler(this.btnGetSortOrderBuilder_Click);
            // 
            // cbxSortDiameter
            // 
            this.cbxSortDiameter.AutoSize = true;
            this.cbxSortDiameter.Location = new System.Drawing.Point(3, 163);
            this.cbxSortDiameter.Name = "cbxSortDiameter";
            this.cbxSortDiameter.Size = new System.Drawing.Size(14, 17);
            this.cbxSortDiameter.TabIndex = 9;
            this.cbxSortDiameter.Text = "checkBox1";
            this.cbxSortDiameter.UseVisualStyleBackColor = true;
            // 
            // cbxSortDistanceSun
            // 
            this.cbxSortDistanceSun.AutoSize = true;
            this.cbxSortDistanceSun.Location = new System.Drawing.Point(3, 203);
            this.cbxSortDistanceSun.Name = "cbxSortDistanceSun";
            this.cbxSortDistanceSun.Size = new System.Drawing.Size(14, 17);
            this.cbxSortDistanceSun.TabIndex = 10;
            this.cbxSortDistanceSun.Text = "checkBox2";
            this.cbxSortDistanceSun.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "sort. Durchmesser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "sort. Bahnradius";
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(23, 243);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(144, 23);
            this.btnGetResult.TabIndex = 13;
            this.btnGetResult.Text = "Abfrage ausführen";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // tbxMinDiameter
            // 
            this.tbxMinDiameter.Location = new System.Drawing.Point(173, 3);
            this.tbxMinDiameter.Name = "tbxMinDiameter";
            this.tbxMinDiameter.Size = new System.Drawing.Size(100, 20);
            this.tbxMinDiameter.TabIndex = 14;
            this.tbxMinDiameter.Leave += new System.EventHandler(this.tbxMinDiameter_Leave);
            // 
            // tbxMaxDiameter
            // 
            this.tbxMaxDiameter.Location = new System.Drawing.Point(173, 33);
            this.tbxMaxDiameter.Name = "tbxMaxDiameter";
            this.tbxMaxDiameter.Size = new System.Drawing.Size(100, 20);
            this.tbxMaxDiameter.TabIndex = 15;
            this.tbxMaxDiameter.Leave += new System.EventHandler(this.tbxMaxDiameter_Leave);
            // 
            // tbxMinDistanceSun
            // 
            this.tbxMinDistanceSun.Location = new System.Drawing.Point(173, 63);
            this.tbxMinDistanceSun.Name = "tbxMinDistanceSun";
            this.tbxMinDistanceSun.Size = new System.Drawing.Size(100, 20);
            this.tbxMinDistanceSun.TabIndex = 16;
            this.tbxMinDistanceSun.Leave += new System.EventHandler(this.tbxMinDistanceSun_Leave);
            // 
            // tbxMaxDistanceSun
            // 
            this.tbxMaxDistanceSun.Location = new System.Drawing.Point(173, 93);
            this.tbxMaxDistanceSun.Name = "tbxMaxDistanceSun";
            this.tbxMaxDistanceSun.Size = new System.Drawing.Size(100, 20);
            this.tbxMaxDistanceSun.TabIndex = 17;
            this.tbxMaxDistanceSun.Leave += new System.EventHandler(this.tbxMaxDistanceSun_Leave);
            // 
            // grpSortDiameter
            // 
            this.grpSortDiameter.Controls.Add(this.rbtDiameterDown);
            this.grpSortDiameter.Controls.Add(this.rbtDiameterUp);
            this.grpSortDiameter.Location = new System.Drawing.Point(173, 163);
            this.grpSortDiameter.Name = "grpSortDiameter";
            this.grpSortDiameter.Size = new System.Drawing.Size(200, 34);
            this.grpSortDiameter.TabIndex = 19;
            this.grpSortDiameter.TabStop = false;
            // 
            // rbtDiameterDown
            // 
            this.rbtDiameterDown.AutoSize = true;
            this.rbtDiameterDown.Location = new System.Drawing.Point(52, 11);
            this.rbtDiameterDown.Name = "rbtDiameterDown";
            this.rbtDiameterDown.Size = new System.Drawing.Size(37, 17);
            this.rbtDiameterDown.TabIndex = 19;
            this.rbtDiameterDown.TabStop = true;
            this.rbtDiameterDown.Text = "ab";
            this.rbtDiameterDown.UseVisualStyleBackColor = true;
            this.rbtDiameterDown.CheckedChanged += new System.EventHandler(this.rbtDiameterDown_CheckedChanged);
            // 
            // rbtDiameterUp
            // 
            this.rbtDiameterUp.AutoSize = true;
            this.rbtDiameterUp.Location = new System.Drawing.Point(6, 11);
            this.rbtDiameterUp.Name = "rbtDiameterUp";
            this.rbtDiameterUp.Size = new System.Drawing.Size(40, 17);
            this.rbtDiameterUp.TabIndex = 18;
            this.rbtDiameterUp.TabStop = true;
            this.rbtDiameterUp.Text = "auf";
            this.rbtDiameterUp.UseVisualStyleBackColor = true;
            this.rbtDiameterUp.CheckedChanged += new System.EventHandler(this.rbtDiameterUp_CheckedChanged);
            // 
            // grpSortDistanceSun
            // 
            this.grpSortDistanceSun.Controls.Add(this.rbtDistanceSunDown);
            this.grpSortDistanceSun.Controls.Add(this.rbtDistanceSunUp);
            this.grpSortDistanceSun.Location = new System.Drawing.Point(173, 203);
            this.grpSortDistanceSun.Name = "grpSortDistanceSun";
            this.grpSortDistanceSun.Size = new System.Drawing.Size(200, 34);
            this.grpSortDistanceSun.TabIndex = 20;
            this.grpSortDistanceSun.TabStop = false;
            // 
            // rbtDistanceSunDown
            // 
            this.rbtDistanceSunDown.AutoSize = true;
            this.rbtDistanceSunDown.Location = new System.Drawing.Point(52, 11);
            this.rbtDistanceSunDown.Name = "rbtDistanceSunDown";
            this.rbtDistanceSunDown.Size = new System.Drawing.Size(37, 17);
            this.rbtDistanceSunDown.TabIndex = 1;
            this.rbtDistanceSunDown.TabStop = true;
            this.rbtDistanceSunDown.Text = "ab";
            this.rbtDistanceSunDown.UseVisualStyleBackColor = true;
            this.rbtDistanceSunDown.CheckedChanged += new System.EventHandler(this.rbtDistanceSunDown_CheckedChanged);
            // 
            // rbtDistanceSunUp
            // 
            this.rbtDistanceSunUp.AutoSize = true;
            this.rbtDistanceSunUp.Location = new System.Drawing.Point(7, 11);
            this.rbtDistanceSunUp.Name = "rbtDistanceSunUp";
            this.rbtDistanceSunUp.Size = new System.Drawing.Size(40, 17);
            this.rbtDistanceSunUp.TabIndex = 0;
            this.rbtDistanceSunUp.TabStop = true;
            this.rbtDistanceSunUp.Text = "auf";
            this.rbtDistanceSunUp.UseVisualStyleBackColor = true;
            this.rbtDistanceSunUp.CheckedChanged += new System.EventHandler(this.rbtDistanceSunUp_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnNewQuery
            // 
            this.btnNewQuery.Location = new System.Drawing.Point(17, 15);
            this.btnNewQuery.Name = "btnNewQuery";
            this.btnNewQuery.Size = new System.Drawing.Size(88, 23);
            this.btnNewQuery.TabIndex = 0;
            this.btnNewQuery.Text = "neu";
            this.btnNewQuery.UseVisualStyleBackColor = true;
            this.btnNewQuery.Click += new System.EventHandler(this.btnNewQuery_Click);
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.dataGridView2);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(773, 411);
            this.tabPageResult.TabIndex = 3;
            this.tabPageResult.Text = "Result";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.diameterInKmDataGridViewTextBoxColumn1,
            this.eDataGridViewTextBoxColumn1,
            this.distanceSunInAUDataGridViewTextBoxColumn1,
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1,
            this.albedoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.QueryResultBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(767, 405);
            this.dataGridView2.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // diameterInKmDataGridViewTextBoxColumn1
            // 
            this.diameterInKmDataGridViewTextBoxColumn1.DataPropertyName = "DiameterInKm";
            this.diameterInKmDataGridViewTextBoxColumn1.HeaderText = "DiameterInKm";
            this.diameterInKmDataGridViewTextBoxColumn1.Name = "diameterInKmDataGridViewTextBoxColumn1";
            this.diameterInKmDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eDataGridViewTextBoxColumn1
            // 
            this.eDataGridViewTextBoxColumn1.DataPropertyName = "E";
            this.eDataGridViewTextBoxColumn1.HeaderText = "E";
            this.eDataGridViewTextBoxColumn1.Name = "eDataGridViewTextBoxColumn1";
            this.eDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // distanceSunInAUDataGridViewTextBoxColumn1
            // 
            this.distanceSunInAUDataGridViewTextBoxColumn1.DataPropertyName = "DistanceSunInAU";
            this.distanceSunInAUDataGridViewTextBoxColumn1.HeaderText = "DistanceSunInAU";
            this.distanceSunInAUDataGridViewTextBoxColumn1.Name = "distanceSunInAUDataGridViewTextBoxColumn1";
            this.distanceSunInAUDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orbitalTimeInEarthYearsDataGridViewTextBoxColumn1
            // 
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1.DataPropertyName = "OrbitalTimeInEarthYears";
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1.HeaderText = "OrbitalTimeInEarthYears";
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1.Name = "orbitalTimeInEarthYearsDataGridViewTextBoxColumn1";
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // albedoDataGridViewTextBoxColumn1
            // 
            this.albedoDataGridViewTextBoxColumn1.DataPropertyName = "Albedo";
            this.albedoDataGridViewTextBoxColumn1.HeaderText = "Albedo";
            this.albedoDataGridViewTextBoxColumn1.Name = "albedoDataGridViewTextBoxColumn1";
            this.albedoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // QueryResultBindingSource
            // 
            this.QueryResultBindingSource.DataSource = typeof(AsteroidsBL.IAsteroid);
            // 
            // UpdateCollectorCounterTimer
            // 
            this.UpdateCollectorCounterTimer.Interval = 300;
            this.UpdateCollectorCounterTimer.Tick += new System.EventHandler(this.UpdateCollectorCounterTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 483);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fun with Asteroids";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectedAsteroidsBindingSource)).EndInit();
            this.panImportCsvMain.ResumeLayout(false);
            this.panImportCsvMain.PerformLayout();
            this.tabPageQuery.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpSortDiameter.ResumeLayout(false);
            this.grpSortDiameter.PerformLayout();
            this.grpSortDistanceSun.ResumeLayout(false);
            this.grpSortDistanceSun.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openAsteroidsCsv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelMain;
        private System.Windows.Forms.ToolStripProgressBar progressBarMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabPage tabPageImport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterInKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceSunInAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orbitalTimeInEarthYearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albedoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource CollectedAsteroidsBindingSource;
        private System.Windows.Forms.Panel panImportCsvMain;
        private System.Windows.Forms.Label lblImportCsvCountAsteroids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer UpdateCollectorCounterTimer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbxMinDiameter;
        private System.Windows.Forms.CheckBox cbxMaxDiameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxMinDistanceSun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxMaxDistanceSun;
        private System.Windows.Forms.Button btnGetSortOrderBuilder;
        private System.Windows.Forms.CheckBox cbxSortDiameter;
        private System.Windows.Forms.CheckBox cbxSortDistanceSun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.TextBox tbxMinDiameter;
        private System.Windows.Forms.TextBox tbxMaxDiameter;
        private System.Windows.Forms.TextBox tbxMinDistanceSun;
        private System.Windows.Forms.TextBox tbxMaxDistanceSun;
        private System.Windows.Forms.GroupBox grpSortDiameter;
        private System.Windows.Forms.RadioButton rbtDiameterDown;
        private System.Windows.Forms.RadioButton rbtDiameterUp;
        private System.Windows.Forms.GroupBox grpSortDistanceSun;
        private System.Windows.Forms.RadioButton rbtDistanceSunDown;
        private System.Windows.Forms.RadioButton rbtDistanceSunUp;
        private System.Windows.Forms.Button btnNewQuery;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterInKmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceSunInAUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orbitalTimeInEarthYearsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albedoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource QueryResultBindingSource;
    }
}

