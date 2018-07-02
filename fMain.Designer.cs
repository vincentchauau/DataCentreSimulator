namespace DataCentreSimulator
{
    partial class fMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTestProblem = new System.Windows.Forms.TabPage();
            this.lbNumberOfChanges = new System.Windows.Forms.Label();
            this.cbNumberOfChanges = new System.Windows.Forms.ComboBox();
            this.lbNumberOfVariations = new System.Windows.Forms.Label();
            this.cbNumberOfVariations = new System.Windows.Forms.ComboBox();
            this.lbDuration = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.lbNumberofVMs = new System.Windows.Forms.Label();
            this.cbNumberOfVMs = new System.Windows.Forms.ComboBox();
            this.lbNumberofPMs = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbNumberOfPMs = new System.Windows.Forms.ComboBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.tabAlgorithms = new System.Windows.Forms.TabPage();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbDCGASize = new System.Windows.Forms.Label();
            this.cbDCGASize = new System.Windows.Forms.ComboBox();
            this.lbTermination = new System.Windows.Forms.Label();
            this.cbTermination = new System.Windows.Forms.ComboBox();
            this.lbPopulationSize = new System.Windows.Forms.Label();
            this.cbPopulationSize = new System.Windows.Forms.ComboBox();
            this.lbMutationProbability = new System.Windows.Forms.Label();
            this.cbMutationProbability = new System.Windows.Forms.ComboBox();
            this.lbCrossoverProbability = new System.Windows.Forms.Label();
            this.cbCrossoverProbability = new System.Windows.Forms.ComboBox();
            this.lbAlgorithm = new System.Windows.Forms.Label();
            this.btSolve = new System.Windows.Forms.Button();
            this.cbAlgorithms = new System.Windows.Forms.ComboBox();
            this.tabVisulization = new System.Windows.Forms.TabPage();
            this.splitVisualization = new System.Windows.Forms.SplitContainer();
            this.chartStatic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btPlay = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.chartDynamic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.splitStatus = new System.Windows.Forms.SplitContainer();
            this.lvPMs = new System.Windows.Forms.ListView();
            this.clPMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPMCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPMRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPMEmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPMEmax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPMK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clVMs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clWRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEnergyEfficiency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvVMs = new System.Windows.Forms.ListView();
            this.clVMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clVMCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clVMRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitOnlineOffline = new System.Windows.Forms.SplitContainer();
            this.lvOffline = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvOnline = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabResults = new System.Windows.Forms.TabPage();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.thread = new System.ComponentModel.BackgroundWorker();
            this.timerSolve = new System.Windows.Forms.Timer(this.components);
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabTestProblem.SuspendLayout();
            this.tabAlgorithms.SuspendLayout();
            this.tabVisulization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitVisualization)).BeginInit();
            this.splitVisualization.Panel1.SuspendLayout();
            this.splitVisualization.Panel2.SuspendLayout();
            this.splitVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDynamic)).BeginInit();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStatus)).BeginInit();
            this.splitStatus.Panel1.SuspendLayout();
            this.splitStatus.Panel2.SuspendLayout();
            this.splitStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitOnlineOffline)).BeginInit();
            this.splitOnlineOffline.Panel1.SuspendLayout();
            this.splitOnlineOffline.Panel2.SuspendLayout();
            this.splitOnlineOffline.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "Data Centre Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Data Centre Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1343, 24);
            this.menuStrip.TabIndex = 61;
            this.menuStrip.Text = "menuStrip";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.functionsToolStripMenuItem.Text = "&File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "&Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btExport_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btImport_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTestProblem);
            this.tabControl.Controls.Add(this.tabAlgorithms);
            this.tabControl.Controls.Add(this.tabVisulization);
            this.tabControl.Controls.Add(this.tabStatus);
            this.tabControl.Controls.Add(this.tabResults);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1343, 618);
            this.tabControl.TabIndex = 79;
            // 
            // tabTestProblem
            // 
            this.tabTestProblem.Controls.Add(this.lbNumberOfChanges);
            this.tabTestProblem.Controls.Add(this.cbNumberOfChanges);
            this.tabTestProblem.Controls.Add(this.lbNumberOfVariations);
            this.tabTestProblem.Controls.Add(this.cbNumberOfVariations);
            this.tabTestProblem.Controls.Add(this.lbDuration);
            this.tabTestProblem.Controls.Add(this.cbDuration);
            this.tabTestProblem.Controls.Add(this.lbNumberofVMs);
            this.tabTestProblem.Controls.Add(this.cbNumberOfVMs);
            this.tabTestProblem.Controls.Add(this.lbNumberofPMs);
            this.tabTestProblem.Controls.Add(this.btLoad);
            this.tabTestProblem.Controls.Add(this.btSave);
            this.tabTestProblem.Controls.Add(this.cbNumberOfPMs);
            this.tabTestProblem.Controls.Add(this.btCreate);
            this.tabTestProblem.Location = new System.Drawing.Point(4, 25);
            this.tabTestProblem.Name = "tabTestProblem";
            this.tabTestProblem.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestProblem.Size = new System.Drawing.Size(1335, 589);
            this.tabTestProblem.TabIndex = 0;
            this.tabTestProblem.Text = "Test Problem";
            this.tabTestProblem.UseVisualStyleBackColor = true;
            // 
            // lbNumberOfChanges
            // 
            this.lbNumberOfChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumberOfChanges.AutoSize = true;
            this.lbNumberOfChanges.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfChanges.ForeColor = System.Drawing.Color.Blue;
            this.lbNumberOfChanges.Location = new System.Drawing.Point(344, 176);
            this.lbNumberOfChanges.Name = "lbNumberOfChanges";
            this.lbNumberOfChanges.Size = new System.Drawing.Size(194, 21);
            this.lbNumberOfChanges.TabIndex = 91;
            this.lbNumberOfChanges.Text = "Number of VM Changes";
            // 
            // cbNumberOfChanges
            // 
            this.cbNumberOfChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNumberOfChanges.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfChanges.ForeColor = System.Drawing.Color.Blue;
            this.cbNumberOfChanges.FormattingEnabled = true;
            this.cbNumberOfChanges.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumberOfChanges.Location = new System.Drawing.Point(612, 174);
            this.cbNumberOfChanges.Name = "cbNumberOfChanges";
            this.cbNumberOfChanges.Size = new System.Drawing.Size(127, 29);
            this.cbNumberOfChanges.TabIndex = 90;
            this.cbNumberOfChanges.Text = "20";
            // 
            // lbNumberOfVariations
            // 
            this.lbNumberOfVariations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumberOfVariations.AutoSize = true;
            this.lbNumberOfVariations.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfVariations.ForeColor = System.Drawing.Color.Blue;
            this.lbNumberOfVariations.Location = new System.Drawing.Point(344, 131);
            this.lbNumberOfVariations.Name = "lbNumberOfVariations";
            this.lbNumberOfVariations.Size = new System.Drawing.Size(169, 21);
            this.lbNumberOfVariations.TabIndex = 89;
            this.lbNumberOfVariations.Text = "Number of Variations";
            // 
            // cbNumberOfVariations
            // 
            this.cbNumberOfVariations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNumberOfVariations.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfVariations.ForeColor = System.Drawing.Color.Blue;
            this.cbNumberOfVariations.FormattingEnabled = true;
            this.cbNumberOfVariations.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumberOfVariations.Location = new System.Drawing.Point(612, 128);
            this.cbNumberOfVariations.Name = "cbNumberOfVariations";
            this.cbNumberOfVariations.Size = new System.Drawing.Size(127, 29);
            this.cbNumberOfVariations.TabIndex = 88;
            this.cbNumberOfVariations.Text = "5";
            // 
            // lbDuration
            // 
            this.lbDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.ForeColor = System.Drawing.Color.Blue;
            this.lbDuration.Location = new System.Drawing.Point(344, 220);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(74, 21);
            this.lbDuration.TabIndex = 87;
            this.lbDuration.Text = "Duration";
            // 
            // cbDuration
            // 
            this.cbDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDuration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDuration.ForeColor = System.Drawing.Color.Blue;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbDuration.Location = new System.Drawing.Point(612, 218);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(127, 29);
            this.cbDuration.TabIndex = 86;
            this.cbDuration.Text = "20";
            // 
            // lbNumberofVMs
            // 
            this.lbNumberofVMs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumberofVMs.AutoSize = true;
            this.lbNumberofVMs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberofVMs.ForeColor = System.Drawing.Color.Blue;
            this.lbNumberofVMs.Location = new System.Drawing.Point(344, 86);
            this.lbNumberofVMs.Name = "lbNumberofVMs";
            this.lbNumberofVMs.Size = new System.Drawing.Size(133, 21);
            this.lbNumberofVMs.TabIndex = 85;
            this.lbNumberofVMs.Text = "Number of VMs";
            // 
            // cbNumberOfVMs
            // 
            this.cbNumberOfVMs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNumberOfVMs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfVMs.ForeColor = System.Drawing.Color.Blue;
            this.cbNumberOfVMs.FormattingEnabled = true;
            this.cbNumberOfVMs.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250"});
            this.cbNumberOfVMs.Location = new System.Drawing.Point(612, 84);
            this.cbNumberOfVMs.Name = "cbNumberOfVMs";
            this.cbNumberOfVMs.Size = new System.Drawing.Size(127, 29);
            this.cbNumberOfVMs.TabIndex = 84;
            this.cbNumberOfVMs.Text = "100";
            // 
            // lbNumberofPMs
            // 
            this.lbNumberofPMs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNumberofPMs.AutoSize = true;
            this.lbNumberofPMs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberofPMs.ForeColor = System.Drawing.Color.Blue;
            this.lbNumberofPMs.Location = new System.Drawing.Point(344, 41);
            this.lbNumberofPMs.Name = "lbNumberofPMs";
            this.lbNumberofPMs.Size = new System.Drawing.Size(131, 21);
            this.lbNumberofPMs.TabIndex = 83;
            this.lbNumberofPMs.Text = "Number of PMs";
            // 
            // btLoad
            // 
            this.btLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLoad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.ForeColor = System.Drawing.Color.Red;
            this.btLoad.Location = new System.Drawing.Point(834, 116);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(148, 50);
            this.btLoad.TabIndex = 81;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Red;
            this.btSave.Location = new System.Drawing.Point(834, 188);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(148, 48);
            this.btSave.TabIndex = 80;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btExport_Click);
            // 
            // cbNumberOfPMs
            // 
            this.cbNumberOfPMs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNumberOfPMs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfPMs.ForeColor = System.Drawing.Color.Blue;
            this.cbNumberOfPMs.FormattingEnabled = true;
            this.cbNumberOfPMs.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbNumberOfPMs.Location = new System.Drawing.Point(612, 39);
            this.cbNumberOfPMs.Name = "cbNumberOfPMs";
            this.cbNumberOfPMs.Size = new System.Drawing.Size(127, 29);
            this.cbNumberOfPMs.TabIndex = 79;
            this.cbNumberOfPMs.Text = "20";
            // 
            // btCreate
            // 
            this.btCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCreate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.ForeColor = System.Drawing.Color.Red;
            this.btCreate.Location = new System.Drawing.Point(834, 41);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(145, 53);
            this.btCreate.TabIndex = 78;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // tabAlgorithms
            // 
            this.tabAlgorithms.Controls.Add(this.lbStatus);
            this.tabAlgorithms.Controls.Add(this.lbDCGASize);
            this.tabAlgorithms.Controls.Add(this.cbDCGASize);
            this.tabAlgorithms.Controls.Add(this.lbTermination);
            this.tabAlgorithms.Controls.Add(this.cbTermination);
            this.tabAlgorithms.Controls.Add(this.lbPopulationSize);
            this.tabAlgorithms.Controls.Add(this.cbPopulationSize);
            this.tabAlgorithms.Controls.Add(this.lbMutationProbability);
            this.tabAlgorithms.Controls.Add(this.cbMutationProbability);
            this.tabAlgorithms.Controls.Add(this.lbCrossoverProbability);
            this.tabAlgorithms.Controls.Add(this.cbCrossoverProbability);
            this.tabAlgorithms.Controls.Add(this.lbAlgorithm);
            this.tabAlgorithms.Controls.Add(this.btSolve);
            this.tabAlgorithms.Controls.Add(this.cbAlgorithms);
            this.tabAlgorithms.Location = new System.Drawing.Point(4, 25);
            this.tabAlgorithms.Name = "tabAlgorithms";
            this.tabAlgorithms.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlgorithms.Size = new System.Drawing.Size(1335, 589);
            this.tabAlgorithms.TabIndex = 3;
            this.tabAlgorithms.Text = "Algorithms";
            this.tabAlgorithms.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Blue;
            this.lbStatus.Location = new System.Drawing.Point(1167, 67);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 21);
            this.lbStatus.TabIndex = 111;
            // 
            // lbDCGASize
            // 
            this.lbDCGASize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDCGASize.AutoSize = true;
            this.lbDCGASize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDCGASize.ForeColor = System.Drawing.Color.Blue;
            this.lbDCGASize.Location = new System.Drawing.Point(355, 249);
            this.lbDCGASize.Name = "lbDCGASize";
            this.lbDCGASize.Size = new System.Drawing.Size(98, 21);
            this.lbDCGASize.TabIndex = 110;
            this.lbDCGASize.Text = "DCGA Size";
            this.lbDCGASize.Visible = false;
            // 
            // cbDCGASize
            // 
            this.cbDCGASize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDCGASize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDCGASize.ForeColor = System.Drawing.Color.Blue;
            this.cbDCGASize.FormattingEnabled = true;
            this.cbDCGASize.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cbDCGASize.Location = new System.Drawing.Point(665, 247);
            this.cbDCGASize.Name = "cbDCGASize";
            this.cbDCGASize.Size = new System.Drawing.Size(73, 29);
            this.cbDCGASize.TabIndex = 109;
            this.cbDCGASize.Text = "5";
            this.cbDCGASize.Visible = false;
            // 
            // lbTermination
            // 
            this.lbTermination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTermination.AutoSize = true;
            this.lbTermination.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTermination.ForeColor = System.Drawing.Color.Blue;
            this.lbTermination.Location = new System.Drawing.Point(355, 162);
            this.lbTermination.Name = "lbTermination";
            this.lbTermination.Size = new System.Drawing.Size(98, 21);
            this.lbTermination.TabIndex = 108;
            this.lbTermination.Text = "Termination";
            this.lbTermination.Visible = false;
            // 
            // cbTermination
            // 
            this.cbTermination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTermination.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTermination.ForeColor = System.Drawing.Color.Blue;
            this.cbTermination.FormattingEnabled = true;
            this.cbTermination.Items.AddRange(new object[] {
            "40",
            "60",
            "80"});
            this.cbTermination.Location = new System.Drawing.Point(665, 159);
            this.cbTermination.Name = "cbTermination";
            this.cbTermination.Size = new System.Drawing.Size(73, 29);
            this.cbTermination.TabIndex = 107;
            this.cbTermination.Text = "80";
            this.cbTermination.Visible = false;
            // 
            // lbPopulationSize
            // 
            this.lbPopulationSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPopulationSize.AutoSize = true;
            this.lbPopulationSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPopulationSize.ForeColor = System.Drawing.Color.Blue;
            this.lbPopulationSize.Location = new System.Drawing.Point(355, 207);
            this.lbPopulationSize.Name = "lbPopulationSize";
            this.lbPopulationSize.Size = new System.Drawing.Size(126, 21);
            this.lbPopulationSize.TabIndex = 106;
            this.lbPopulationSize.Text = "Population Size";
            this.lbPopulationSize.Visible = false;
            // 
            // cbPopulationSize
            // 
            this.cbPopulationSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPopulationSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPopulationSize.ForeColor = System.Drawing.Color.Blue;
            this.cbPopulationSize.FormattingEnabled = true;
            this.cbPopulationSize.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.cbPopulationSize.Location = new System.Drawing.Point(665, 205);
            this.cbPopulationSize.Name = "cbPopulationSize";
            this.cbPopulationSize.Size = new System.Drawing.Size(73, 29);
            this.cbPopulationSize.TabIndex = 105;
            this.cbPopulationSize.Text = "100";
            this.cbPopulationSize.Visible = false;
            // 
            // lbMutationProbability
            // 
            this.lbMutationProbability.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMutationProbability.AutoSize = true;
            this.lbMutationProbability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMutationProbability.ForeColor = System.Drawing.Color.Blue;
            this.lbMutationProbability.Location = new System.Drawing.Point(355, 114);
            this.lbMutationProbability.Name = "lbMutationProbability";
            this.lbMutationProbability.Size = new System.Drawing.Size(162, 21);
            this.lbMutationProbability.TabIndex = 104;
            this.lbMutationProbability.Text = "Mutation Probability";
            this.lbMutationProbability.Visible = false;
            // 
            // cbMutationProbability
            // 
            this.cbMutationProbability.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMutationProbability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMutationProbability.ForeColor = System.Drawing.Color.Blue;
            this.cbMutationProbability.FormattingEnabled = true;
            this.cbMutationProbability.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3"});
            this.cbMutationProbability.Location = new System.Drawing.Point(665, 111);
            this.cbMutationProbability.Name = "cbMutationProbability";
            this.cbMutationProbability.Size = new System.Drawing.Size(73, 29);
            this.cbMutationProbability.TabIndex = 103;
            this.cbMutationProbability.Text = "0.1";
            this.cbMutationProbability.Visible = false;
            // 
            // lbCrossoverProbability
            // 
            this.lbCrossoverProbability.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCrossoverProbability.AutoSize = true;
            this.lbCrossoverProbability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrossoverProbability.ForeColor = System.Drawing.Color.Blue;
            this.lbCrossoverProbability.Location = new System.Drawing.Point(355, 69);
            this.lbCrossoverProbability.Name = "lbCrossoverProbability";
            this.lbCrossoverProbability.Size = new System.Drawing.Size(174, 21);
            this.lbCrossoverProbability.TabIndex = 100;
            this.lbCrossoverProbability.Text = "Crossover Probability";
            this.lbCrossoverProbability.Visible = false;
            // 
            // cbCrossoverProbability
            // 
            this.cbCrossoverProbability.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCrossoverProbability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrossoverProbability.ForeColor = System.Drawing.Color.Blue;
            this.cbCrossoverProbability.FormattingEnabled = true;
            this.cbCrossoverProbability.Items.AddRange(new object[] {
            "0.7",
            "0.8",
            "0.9"});
            this.cbCrossoverProbability.Location = new System.Drawing.Point(665, 67);
            this.cbCrossoverProbability.Name = "cbCrossoverProbability";
            this.cbCrossoverProbability.Size = new System.Drawing.Size(73, 29);
            this.cbCrossoverProbability.TabIndex = 99;
            this.cbCrossoverProbability.Text = "0.9";
            this.cbCrossoverProbability.Visible = false;
            // 
            // lbAlgorithm
            // 
            this.lbAlgorithm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAlgorithm.AutoSize = true;
            this.lbAlgorithm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlgorithm.ForeColor = System.Drawing.Color.Blue;
            this.lbAlgorithm.Location = new System.Drawing.Point(355, 24);
            this.lbAlgorithm.Name = "lbAlgorithm";
            this.lbAlgorithm.Size = new System.Drawing.Size(84, 21);
            this.lbAlgorithm.TabIndex = 98;
            this.lbAlgorithm.Text = "Algorithm";
            // 
            // btSolve
            // 
            this.btSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSolve.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSolve.ForeColor = System.Drawing.Color.Red;
            this.btSolve.Location = new System.Drawing.Point(1161, 20);
            this.btSolve.Name = "btSolve";
            this.btSolve.Size = new System.Drawing.Size(156, 30);
            this.btSolve.TabIndex = 92;
            this.btSolve.Text = "Solve";
            this.btSolve.UseVisualStyleBackColor = true;
            this.btSolve.Click += new System.EventHandler(this.btSolve_Click);
            // 
            // cbAlgorithms
            // 
            this.cbAlgorithms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAlgorithms.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlgorithms.ForeColor = System.Drawing.Color.Blue;
            this.cbAlgorithms.FormattingEnabled = true;
            this.cbAlgorithms.Items.AddRange(new object[] {
            "FFD",
            "FF",
            "GA",
            "DCGA",
            "FFA"});
            this.cbAlgorithms.Location = new System.Drawing.Point(665, 22);
            this.cbAlgorithms.Name = "cbAlgorithms";
            this.cbAlgorithms.Size = new System.Drawing.Size(73, 29);
            this.cbAlgorithms.TabIndex = 92;
            this.cbAlgorithms.Text = "FFD";
            this.cbAlgorithms.SelectedIndexChanged += new System.EventHandler(this.cbAlgorithms_SelectedIndexChanged);
            // 
            // tabVisulization
            // 
            this.tabVisulization.Controls.Add(this.splitVisualization);
            this.tabVisulization.Location = new System.Drawing.Point(4, 25);
            this.tabVisulization.Name = "tabVisulization";
            this.tabVisulization.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisulization.Size = new System.Drawing.Size(1335, 589);
            this.tabVisulization.TabIndex = 1;
            this.tabVisulization.Text = "Visualization";
            this.tabVisulization.UseVisualStyleBackColor = true;
            // 
            // splitVisualization
            // 
            this.splitVisualization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitVisualization.Location = new System.Drawing.Point(3, 3);
            this.splitVisualization.Name = "splitVisualization";
            this.splitVisualization.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitVisualization.Panel1
            // 
            this.splitVisualization.Panel1.Controls.Add(this.chartStatic);
            // 
            // splitVisualization.Panel2
            // 
            this.splitVisualization.Panel2.Controls.Add(this.btPlay);
            this.splitVisualization.Panel2.Controls.Add(this.btReset);
            this.splitVisualization.Panel2.Controls.Add(this.chartDynamic);
            this.splitVisualization.Size = new System.Drawing.Size(1329, 583);
            this.splitVisualization.SplitterDistance = 307;
            this.splitVisualization.TabIndex = 80;
            // 
            // chartStatic
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Title = "Number of VMs";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Blue;
            chartArea1.Name = "staticArea";
            this.chartStatic.ChartAreas.Add(chartArea1);
            this.chartStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartStatic.Location = new System.Drawing.Point(0, 0);
            this.chartStatic.Name = "chartStatic";
            series1.ChartArea = "staticArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.IsValueShownAsLabel = true;
            series1.Name = "onlineSeries";
            series2.ChartArea = "staticArea";
            series2.IsValueShownAsLabel = true;
            series2.Name = "offlineSeries";
            this.chartStatic.Series.Add(series1);
            this.chartStatic.Series.Add(series2);
            this.chartStatic.Size = new System.Drawing.Size(1329, 307);
            this.chartStatic.TabIndex = 57;
            this.chartStatic.Text = "Static Graph";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "titleChart";
            title1.Text = "Static Graph";
            this.chartStatic.Titles.Add(title1);
            this.chartStatic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartStatic_MouseClick);
            // 
            // btPlay
            // 
            this.btPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPlay.AutoSize = true;
            this.btPlay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.Color.Red;
            this.btPlay.Location = new System.Drawing.Point(1079, 205);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(68, 32);
            this.btPlay.TabIndex = 84;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btReset
            // 
            this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.Red;
            this.btReset.Location = new System.Drawing.Point(1079, 166);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(68, 32);
            this.btReset.TabIndex = 85;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // chartDynamic
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea2.AxisX2.Minimum = 0D;
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisY.Title = "Energy Consumption";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Blue;
            chartArea2.Name = "energyArea";
            this.chartDynamic.ChartAreas.Add(chartArea2);
            this.chartDynamic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDynamic.Location = new System.Drawing.Point(0, 0);
            this.chartDynamic.Name = "chartDynamic";
            series3.ChartArea = "energyArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series3.Name = "energySeries";
            series3.YValuesPerPoint = 2;
            this.chartDynamic.Series.Add(series3);
            this.chartDynamic.Size = new System.Drawing.Size(1329, 272);
            this.chartDynamic.TabIndex = 86;
            this.chartDynamic.Text = "Dynamic Graph";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "titleChart";
            title2.Text = "Dynamic Graph";
            this.chartDynamic.Titles.Add(title2);
            this.chartDynamic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartDynamic_MouseClick);
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.splitStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 25);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Size = new System.Drawing.Size(1335, 589);
            this.tabStatus.TabIndex = 2;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // splitStatus
            // 
            this.splitStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStatus.Location = new System.Drawing.Point(0, 0);
            this.splitStatus.Name = "splitStatus";
            // 
            // splitStatus.Panel1
            // 
            this.splitStatus.Panel1.Controls.Add(this.lvPMs);
            // 
            // splitStatus.Panel2
            // 
            this.splitStatus.Panel2.Controls.Add(this.splitContainer1);
            this.splitStatus.Size = new System.Drawing.Size(1335, 589);
            this.splitStatus.SplitterDistance = 947;
            this.splitStatus.TabIndex = 80;
            // 
            // lvPMs
            // 
            this.lvPMs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPMID,
            this.clPMCPU,
            this.clPMRAM,
            this.clPMEmin,
            this.clPMEmax,
            this.clPMK,
            this.clVMs,
            this.clWCPU,
            this.clWRAM,
            this.clE,
            this.clEnergyEfficiency});
            this.lvPMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPMs.FullRowSelect = true;
            this.lvPMs.Location = new System.Drawing.Point(0, 0);
            this.lvPMs.Name = "lvPMs";
            this.lvPMs.Size = new System.Drawing.Size(947, 589);
            this.lvPMs.TabIndex = 60;
            this.lvPMs.UseCompatibleStateImageBehavior = false;
            this.lvPMs.View = System.Windows.Forms.View.Details;
            this.lvPMs.SelectedIndexChanged += new System.EventHandler(this.lvPMs_SelectedIndexChanged);
            // 
            // clPMID
            // 
            this.clPMID.Text = "Current PID";
            this.clPMID.Width = 119;
            // 
            // clPMCPU
            // 
            this.clPMCPU.Text = "CPU";
            // 
            // clPMRAM
            // 
            this.clPMRAM.Text = "RAM";
            // 
            // clPMEmin
            // 
            this.clPMEmin.Text = "Emin";
            // 
            // clPMEmax
            // 
            this.clPMEmax.Text = "Emax";
            // 
            // clPMK
            // 
            this.clPMK.Text = "K";
            // 
            // clVMs
            // 
            this.clVMs.Text = "VMs";
            // 
            // clWCPU
            // 
            this.clWCPU.Text = "WCPU";
            // 
            // clWRAM
            // 
            this.clWRAM.Text = "WRAM";
            // 
            // clE
            // 
            this.clE.Text = "Total Energy";
            // 
            // clEnergyEfficiency
            // 
            this.clEnergyEfficiency.Text = "Energy Efficiency";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvVMs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitOnlineOffline);
            this.splitContainer1.Size = new System.Drawing.Size(384, 589);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvVMs
            // 
            this.lvVMs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clVMID,
            this.clVMCPU,
            this.clVMRAM});
            this.lvVMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVMs.Location = new System.Drawing.Point(0, 0);
            this.lvVMs.Name = "lvVMs";
            this.lvVMs.Size = new System.Drawing.Size(384, 291);
            this.lvVMs.TabIndex = 59;
            this.lvVMs.UseCompatibleStateImageBehavior = false;
            this.lvVMs.View = System.Windows.Forms.View.Details;
            // 
            // clVMID
            // 
            this.clVMID.Text = "Current VID";
            this.clVMID.Width = 51;
            // 
            // clVMCPU
            // 
            this.clVMCPU.Text = "CPU";
            // 
            // clVMRAM
            // 
            this.clVMRAM.Text = "RAM";
            this.clVMRAM.Width = 67;
            // 
            // splitOnlineOffline
            // 
            this.splitOnlineOffline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitOnlineOffline.Location = new System.Drawing.Point(0, 0);
            this.splitOnlineOffline.Name = "splitOnlineOffline";
            this.splitOnlineOffline.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitOnlineOffline.Panel1
            // 
            this.splitOnlineOffline.Panel1.Controls.Add(this.lvOffline);
            // 
            // splitOnlineOffline.Panel2
            // 
            this.splitOnlineOffline.Panel2.Controls.Add(this.lvOnline);
            this.splitOnlineOffline.Size = new System.Drawing.Size(384, 294);
            this.splitOnlineOffline.SplitterDistance = 150;
            this.splitOnlineOffline.TabIndex = 0;
            // 
            // lvOffline
            // 
            this.lvOffline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvOffline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOffline.Location = new System.Drawing.Point(0, 0);
            this.lvOffline.Name = "lvOffline";
            this.lvOffline.Size = new System.Drawing.Size(384, 150);
            this.lvOffline.TabIndex = 60;
            this.lvOffline.UseCompatibleStateImageBehavior = false;
            this.lvOffline.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Offline VID";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPU";
            // 
            // lvOnline
            // 
            this.lvOnline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOnline.Location = new System.Drawing.Point(0, 0);
            this.lvOnline.Name = "lvOnline";
            this.lvOnline.Size = new System.Drawing.Size(384, 140);
            this.lvOnline.TabIndex = 61;
            this.lvOnline.UseCompatibleStateImageBehavior = false;
            this.lvOnline.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Online VID";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPU";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RAM";
            this.columnHeader6.Width = 67;
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.rtbInformation);
            this.tabResults.Location = new System.Drawing.Point(4, 25);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1335, 589);
            this.tabResults.TabIndex = 4;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // rtbInformation
            // 
            this.rtbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInformation.Location = new System.Drawing.Point(3, 3);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.Size = new System.Drawing.Size(1329, 583);
            this.rtbInformation.TabIndex = 0;
            this.rtbInformation.Text = "";
            // 
            // thread
            // 
            this.thread.WorkerSupportsCancellation = true;
            this.thread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread_DoWork);
            this.thread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thread_RunWorkerCompleted);
            // 
            // timerSolve
            // 
            this.timerSolve.Interval = 1000;
            this.timerSolve.Tick += new System.EventHandler(this.timerSolve_Tick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RAM";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 642);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fMain";
            this.Text = "Data Centre Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.Resize += new System.EventHandler(this.fMain_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabTestProblem.ResumeLayout(false);
            this.tabTestProblem.PerformLayout();
            this.tabAlgorithms.ResumeLayout(false);
            this.tabAlgorithms.PerformLayout();
            this.tabVisulization.ResumeLayout(false);
            this.splitVisualization.Panel1.ResumeLayout(false);
            this.splitVisualization.Panel2.ResumeLayout(false);
            this.splitVisualization.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitVisualization)).EndInit();
            this.splitVisualization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDynamic)).EndInit();
            this.tabStatus.ResumeLayout(false);
            this.splitStatus.Panel1.ResumeLayout(false);
            this.splitStatus.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStatus)).EndInit();
            this.splitStatus.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitOnlineOffline.Panel1.ResumeLayout(false);
            this.splitOnlineOffline.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitOnlineOffline)).EndInit();
            this.splitOnlineOffline.ResumeLayout(false);
            this.tabResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTestProblem;
        private System.Windows.Forms.ComboBox cbAlgorithms;
        private System.Windows.Forms.Label lbNumberOfChanges;
        private System.Windows.Forms.ComboBox cbNumberOfChanges;
        private System.Windows.Forms.Label lbNumberOfVariations;
        private System.Windows.Forms.ComboBox cbNumberOfVariations;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.Label lbNumberofVMs;
        private System.Windows.Forms.ComboBox cbNumberOfVMs;
        private System.Windows.Forms.Label lbNumberofPMs;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbNumberOfPMs;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.TabPage tabVisulization;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatic;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.TabPage tabAlgorithms;
        private System.Windows.Forms.Button btSolve;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDynamic;
        private System.Windows.Forms.ListView lvPMs;
        private System.Windows.Forms.ColumnHeader clPMID;
        private System.Windows.Forms.ColumnHeader clPMCPU;
        private System.Windows.Forms.ColumnHeader clPMRAM;
        private System.Windows.Forms.ColumnHeader clPMEmin;
        private System.Windows.Forms.ColumnHeader clPMEmax;
        private System.Windows.Forms.ColumnHeader clPMK;
        private System.Windows.Forms.ColumnHeader clVMs;
        private System.Windows.Forms.SplitContainer splitVisualization;
        private System.Windows.Forms.SplitContainer splitStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvVMs;
        private System.Windows.Forms.ColumnHeader clVMID;
        private System.Windows.Forms.ColumnHeader clVMCPU;
        private System.Windows.Forms.ColumnHeader clVMRAM;
        private System.Windows.Forms.SplitContainer splitOnlineOffline;
        private System.Windows.Forms.ListView lvOffline;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvOnline;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.ComponentModel.BackgroundWorker thread;
        private System.Windows.Forms.ColumnHeader clWCPU;
        private System.Windows.Forms.ColumnHeader clWRAM;
        private System.Windows.Forms.Label lbPopulationSize;
        private System.Windows.Forms.ComboBox cbPopulationSize;
        private System.Windows.Forms.ComboBox cbMutationProbability;
        private System.Windows.Forms.Label lbCrossoverProbability;
        private System.Windows.Forms.ComboBox cbCrossoverProbability;
        private System.Windows.Forms.Label lbAlgorithm;
        private System.Windows.Forms.Label lbMutationProbability;
        private System.Windows.Forms.Label lbTermination;
        private System.Windows.Forms.ComboBox cbTermination;
        private System.Windows.Forms.ColumnHeader clE;
        private System.Windows.Forms.ColumnHeader clEnergyEfficiency;
        private System.Windows.Forms.Label lbDCGASize;
        private System.Windows.Forms.ComboBox cbDCGASize;
        private System.Windows.Forms.Timer timerSolve;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

