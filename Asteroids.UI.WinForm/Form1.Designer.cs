namespace Asteroids.UI.WinForm
{
    partial class Form1
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
            this.openAsteroidsCsv = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.panImportCsvMain = new System.Windows.Forms.Panel();
            this.CollectedAsteroidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterInKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceSunInAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orbitalTimeInEarthYearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albedoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImportCsvCountAsteroids = new System.Windows.Forms.Label();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.UpdateCollectorCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.panImportCsvMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollectedAsteroidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileToolStripMenuItem.Text = "&Open";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // CollectedAsteroidsBindingSource
            // 
            this.CollectedAsteroidsBindingSource.DataSource = typeof(AsteroidsBL.IAsteroid);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# erfasste Asteroiden";
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
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.panel1);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuery.Size = new System.Drawing.Size(773, 411);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Queries";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 57);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 61);
            this.panel2.TabIndex = 0;
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
            // UpdateCollectorCounterTimer
            // 
            this.UpdateCollectorCounterTimer.Interval = 300;
            this.UpdateCollectorCounterTimer.Tick += new System.EventHandler(this.UpdateCollectorCounterTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 483);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageImport.ResumeLayout(false);
            this.panImportCsvMain.ResumeLayout(false);
            this.panImportCsvMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollectedAsteroidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageQuery.ResumeLayout(false);
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
    }
}

