namespace Asteroids.UI.Pattern.Presenter.WinForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openAsteroidsCSV = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.tabImportCSV = new System.Windows.Forms.TabPage();
            this.grdCollected = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterInKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceSunInAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectedAsteroidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxCollectedCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDefSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExeQuery = new System.Windows.Forms.Button();
            this.tbxDiameterMin = new System.Windows.Forms.TextBox();
            this.tbxDiameterMax = new System.Windows.Forms.TextBox();
            this.tbxDistanceSunMin = new System.Windows.Forms.TextBox();
            this.tbxDistanceSunMax = new System.Windows.Forms.TextBox();
            this.grpSortDiameter = new System.Windows.Forms.GroupBox();
            this.rbtDiameterDown = new System.Windows.Forms.RadioButton();
            this.rbtDiameterUp = new System.Windows.Forms.RadioButton();
            this.grpSortDistanceSun = new System.Windows.Forms.GroupBox();
            this.rbtDistanceSunDown = new System.Windows.Forms.RadioButton();
            this.rbtDistanceSunUp = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewQuery = new System.Windows.Forms.Button();
            this.tabQueryResult = new System.Windows.Forms.TabPage();
            this.grdQueryResult = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterInKmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceSunInAUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albedoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryResultbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateCollectorCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabImportCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCollected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectedAsteroidsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSortDiameter.SuspendLayout();
            this.grpSortDistanceSun.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResultbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openAsteroidsCSV
            // 
            this.openAsteroidsCSV.FileName = "*.csv";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Controls.Add(this.tabImportCSV);
            this.tabControl1.Controls.Add(this.tabQuery);
            this.tabControl1.Controls.Add(this.tabQueryResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 444);
            this.tabControl1.TabIndex = 2;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.lbxLog);
            this.tabLog.Controls.Add(this.panel1);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(785, 418);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // lbxLog
            // 
            this.lbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.Location = new System.Drawing.Point(3, 41);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(779, 374);
            this.lbxLog.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Location = new System.Drawing.Point(5, 3);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(75, 23);
            this.btnLogClear.TabIndex = 0;
            this.btnLogClear.Text = "Clear";
            this.btnLogClear.UseVisualStyleBackColor = true;
            // 
            // tabImportCSV
            // 
            this.tabImportCSV.Controls.Add(this.grdCollected);
            this.tabImportCSV.Controls.Add(this.panel2);
            this.tabImportCSV.Location = new System.Drawing.Point(4, 22);
            this.tabImportCSV.Name = "tabImportCSV";
            this.tabImportCSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabImportCSV.Size = new System.Drawing.Size(785, 418);
            this.tabImportCSV.TabIndex = 1;
            this.tabImportCSV.Text = "ImportCSV";
            this.tabImportCSV.UseVisualStyleBackColor = true;
            // 
            // grdCollected
            // 
            this.grdCollected.AutoGenerateColumns = false;
            this.grdCollected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.diameterInKmDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn,
            this.distanceSunInAUDataGridViewTextBoxColumn,
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn,
            this.albedoDataGridViewTextBoxColumn});
            this.grdCollected.DataSource = this.CollectedAsteroidsBindingSource;
            this.grdCollected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCollected.Location = new System.Drawing.Point(3, 61);
            this.grdCollected.Name = "grdCollected";
            this.grdCollected.Size = new System.Drawing.Size(779, 354);
            this.grdCollected.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxCollectedCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 58);
            this.panel2.TabIndex = 0;
            // 
            // tbxCollectedCount
            // 
            this.tbxCollectedCount.BackColor = System.Drawing.Color.Black;
            this.tbxCollectedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCollectedCount.ForeColor = System.Drawing.Color.Yellow;
            this.tbxCollectedCount.Location = new System.Drawing.Point(9, 20);
            this.tbxCollectedCount.Name = "tbxCollectedCount";
            this.tbxCollectedCount.Size = new System.Drawing.Size(130, 20);
            this.tbxCollectedCount.TabIndex = 1;
            this.tbxCollectedCount.Text = "0";
            this.tbxCollectedCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# erfasste Asteroiden";
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.tableLayoutPanel1);
            this.tabQuery.Controls.Add(this.panel3);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Size = new System.Drawing.Size(785, 418);
            this.tabQuery.TabIndex = 2;
            this.tabQuery.Text = "Query";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDefSort, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnExeQuery, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbxDiameterMin, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxDiameterMax, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxDistanceSunMin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxDistanceSunMax, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.grpSortDiameter, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.grpSortDistanceSun, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 376);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "min. Durchmesser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "max. Durchmesser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "min. Bahnradius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "max. Bahnradius";
            // 
            // btnDefSort
            // 
            this.btnDefSort.Location = new System.Drawing.Point(23, 163);
            this.btnDefSort.Name = "btnDefSort";
            this.btnDefSort.Size = new System.Drawing.Size(139, 23);
            this.btnDefSort.TabIndex = 4;
            this.btnDefSort.Text = "neue Sortierreihenfolge";
            this.btnDefSort.UseVisualStyleBackColor = true;
            this.btnDefSort.Click += new System.EventHandler(this.btnDefSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "sort Durchmesser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "sort Radius";
            // 
            // btnExeQuery
            // 
            this.btnExeQuery.Location = new System.Drawing.Point(23, 283);
            this.btnExeQuery.Name = "btnExeQuery";
            this.btnExeQuery.Size = new System.Drawing.Size(75, 23);
            this.btnExeQuery.TabIndex = 7;
            this.btnExeQuery.Text = "Abfrage ausführen";
            this.btnExeQuery.UseVisualStyleBackColor = true;
            this.btnExeQuery.Click += new System.EventHandler(this.btnExeQuery_Click);
            // 
            // tbxDiameterMin
            // 
            this.tbxDiameterMin.Location = new System.Drawing.Point(173, 3);
            this.tbxDiameterMin.Name = "tbxDiameterMin";
            this.tbxDiameterMin.Size = new System.Drawing.Size(100, 20);
            this.tbxDiameterMin.TabIndex = 8;
            // 
            // tbxDiameterMax
            // 
            this.tbxDiameterMax.Location = new System.Drawing.Point(173, 43);
            this.tbxDiameterMax.Name = "tbxDiameterMax";
            this.tbxDiameterMax.Size = new System.Drawing.Size(100, 20);
            this.tbxDiameterMax.TabIndex = 9;
            // 
            // tbxDistanceSunMin
            // 
            this.tbxDistanceSunMin.Location = new System.Drawing.Point(173, 83);
            this.tbxDistanceSunMin.Name = "tbxDistanceSunMin";
            this.tbxDistanceSunMin.Size = new System.Drawing.Size(100, 20);
            this.tbxDistanceSunMin.TabIndex = 10;
            // 
            // tbxDistanceSunMax
            // 
            this.tbxDistanceSunMax.Location = new System.Drawing.Point(173, 123);
            this.tbxDistanceSunMax.Name = "tbxDistanceSunMax";
            this.tbxDistanceSunMax.Size = new System.Drawing.Size(100, 20);
            this.tbxDistanceSunMax.TabIndex = 11;
            // 
            // grpSortDiameter
            // 
            this.grpSortDiameter.Controls.Add(this.rbtDiameterDown);
            this.grpSortDiameter.Controls.Add(this.rbtDiameterUp);
            this.grpSortDiameter.Location = new System.Drawing.Point(173, 203);
            this.grpSortDiameter.Name = "grpSortDiameter";
            this.grpSortDiameter.Size = new System.Drawing.Size(194, 34);
            this.grpSortDiameter.TabIndex = 12;
            this.grpSortDiameter.TabStop = false;
            // 
            // rbtDiameterDown
            // 
            this.rbtDiameterDown.AutoSize = true;
            this.rbtDiameterDown.Location = new System.Drawing.Point(52, 11);
            this.rbtDiameterDown.Name = "rbtDiameterDown";
            this.rbtDiameterDown.Size = new System.Drawing.Size(37, 17);
            this.rbtDiameterDown.TabIndex = 1;
            this.rbtDiameterDown.TabStop = true;
            this.rbtDiameterDown.Text = "ab";
            this.rbtDiameterDown.UseVisualStyleBackColor = true;
            // 
            // rbtDiameterUp
            // 
            this.rbtDiameterUp.AutoSize = true;
            this.rbtDiameterUp.Location = new System.Drawing.Point(6, 11);
            this.rbtDiameterUp.Name = "rbtDiameterUp";
            this.rbtDiameterUp.Size = new System.Drawing.Size(40, 17);
            this.rbtDiameterUp.TabIndex = 0;
            this.rbtDiameterUp.TabStop = true;
            this.rbtDiameterUp.Text = "auf";
            this.rbtDiameterUp.UseVisualStyleBackColor = true;
            // 
            // grpSortDistanceSun
            // 
            this.grpSortDistanceSun.Controls.Add(this.rbtDistanceSunDown);
            this.grpSortDistanceSun.Controls.Add(this.rbtDistanceSunUp);
            this.grpSortDistanceSun.Location = new System.Drawing.Point(173, 243);
            this.grpSortDistanceSun.Name = "grpSortDistanceSun";
            this.grpSortDistanceSun.Size = new System.Drawing.Size(194, 34);
            this.grpSortDistanceSun.TabIndex = 13;
            this.grpSortDistanceSun.TabStop = false;
            // 
            // rbtDistanceSunDown
            // 
            this.rbtDistanceSunDown.AutoSize = true;
            this.rbtDistanceSunDown.Location = new System.Drawing.Point(53, 11);
            this.rbtDistanceSunDown.Name = "rbtDistanceSunDown";
            this.rbtDistanceSunDown.Size = new System.Drawing.Size(37, 17);
            this.rbtDistanceSunDown.TabIndex = 1;
            this.rbtDistanceSunDown.TabStop = true;
            this.rbtDistanceSunDown.Text = "ab";
            this.rbtDistanceSunDown.UseVisualStyleBackColor = true;
            // 
            // rbtDistanceSunUp
            // 
            this.rbtDistanceSunUp.AutoSize = true;
            this.rbtDistanceSunUp.Location = new System.Drawing.Point(6, 11);
            this.rbtDistanceSunUp.Name = "rbtDistanceSunUp";
            this.rbtDistanceSunUp.Size = new System.Drawing.Size(40, 17);
            this.rbtDistanceSunUp.TabIndex = 0;
            this.rbtDistanceSunUp.TabStop = true;
            this.rbtDistanceSunUp.Text = "auf";
            this.rbtDistanceSunUp.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNewQuery);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 42);
            this.panel3.TabIndex = 0;
            // 
            // btnNewQuery
            // 
            this.btnNewQuery.Location = new System.Drawing.Point(9, 4);
            this.btnNewQuery.Name = "btnNewQuery";
            this.btnNewQuery.Size = new System.Drawing.Size(75, 23);
            this.btnNewQuery.TabIndex = 0;
            this.btnNewQuery.Text = "Neu";
            this.btnNewQuery.UseVisualStyleBackColor = true;
            this.btnNewQuery.Click += new System.EventHandler(this.btnNewQuery_Click);
            // 
            // tabQueryResult
            // 
            this.tabQueryResult.Controls.Add(this.grdQueryResult);
            this.tabQueryResult.Controls.Add(this.panel4);
            this.tabQueryResult.Location = new System.Drawing.Point(4, 22);
            this.tabQueryResult.Name = "tabQueryResult";
            this.tabQueryResult.Size = new System.Drawing.Size(785, 418);
            this.tabQueryResult.TabIndex = 3;
            this.tabQueryResult.Text = "Result";
            this.tabQueryResult.UseVisualStyleBackColor = true;
            // 
            // grdQueryResult
            // 
            this.grdQueryResult.AutoGenerateColumns = false;
            this.grdQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQueryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.diameterInKmDataGridViewTextBoxColumn1,
            this.eDataGridViewTextBoxColumn1,
            this.distanceSunInAUDataGridViewTextBoxColumn1,
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn1,
            this.albedoDataGridViewTextBoxColumn1});
            this.grdQueryResult.DataSource = this.QueryResultbindingSource;
            this.grdQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdQueryResult.Location = new System.Drawing.Point(0, 43);
            this.grdQueryResult.Name = "grdQueryResult";
            this.grdQueryResult.Size = new System.Drawing.Size(785, 375);
            this.grdQueryResult.TabIndex = 1;
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
            // QueryResultbindingSource
            // 
            this.QueryResultbindingSource.DataSource = typeof(AsteroidsBL.IAsteroid);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 43);
            this.panel4.TabIndex = 0;
            // 
            // UpdateCollectorCounterTimer
            // 
            this.UpdateCollectorCounterTimer.Tick += new System.EventHandler(this.UpdateCollectorCounterTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 490);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabImportCSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCollected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectedAsteroidsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpSortDiameter.ResumeLayout(false);
            this.grpSortDiameter.PerformLayout();
            this.grpSortDistanceSun.ResumeLayout(false);
            this.grpSortDistanceSun.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabQueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResultbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openAsteroidsCSV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.TabPage tabImportCSV;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.TabPage tabQueryResult;
        private System.Windows.Forms.DataGridView grdCollected;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxCollectedCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterInKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceSunInAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orbitalTimeInEarthYearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albedoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource CollectedAsteroidsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNewQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDefSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExeQuery;
        private System.Windows.Forms.TextBox tbxDiameterMin;
        private System.Windows.Forms.TextBox tbxDiameterMax;
        private System.Windows.Forms.TextBox tbxDistanceSunMin;
        private System.Windows.Forms.TextBox tbxDistanceSunMax;
        private System.Windows.Forms.GroupBox grpSortDiameter;
        private System.Windows.Forms.GroupBox grpSortDistanceSun;
        private System.Windows.Forms.RadioButton rbtDiameterDown;
        private System.Windows.Forms.RadioButton rbtDiameterUp;
        private System.Windows.Forms.RadioButton rbtDistanceSunUp;
        private System.Windows.Forms.RadioButton rbtDistanceSunDown;
        private System.Windows.Forms.DataGridView grdQueryResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterInKmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceSunInAUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orbitalTimeInEarthYearsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albedoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource QueryResultbindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer UpdateCollectorCounterTimer;
    }
}

