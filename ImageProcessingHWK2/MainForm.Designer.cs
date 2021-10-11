namespace ImageProcessingHWK2
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.pnl001 = new System.Windows.Forms.Panel();
            this.pbx001 = new System.Windows.Forms.PictureBox();
            this.lab001 = new System.Windows.Forms.Label();
            this.btnColorAveragedGray = new System.Windows.Forms.Button();
            this.btnBetterGray = new System.Windows.Forms.Button();
            this.cht001 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbx002 = new System.Windows.Forms.PictureBox();
            this.cht002 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lab002 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbx003 = new System.Windows.Forms.PictureBox();
            this.cht003 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lab003 = new System.Windows.Forms.Label();
            this.tkbThresh = new System.Windows.Forms.TrackBar();
            this.labThresh = new System.Windows.Forms.Label();
            this.btnBlackWhite = new System.Windows.Forms.Button();
            this.tkbLevel = new System.Windows.Forms.TrackBar();
            this.labLevel = new System.Windows.Forms.Label();
            this.btnLeveledGray = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pagMonoImage = new System.Windows.Forms.TabPage();
            this.pagColorEdit = new System.Windows.Forms.TabPage();
            this.btnContrast = new System.Windows.Forms.Button();
            this.labContrast = new System.Windows.Forms.Label();
            this.tkbContrast = new System.Windows.Forms.TrackBar();
            this.tkbBrightness = new System.Windows.Forms.TrackBar();
            this.labBrightness = new System.Windows.Forms.Label();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.pnl001.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht001)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx002)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht002)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx003)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht003)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLevel)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pagMonoImage.SuspendLayout();
            this.pagColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1431, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.openImageToolStripMenuItem.Text = "Open Image ...";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 682);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1431, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1431, 658);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pbxMain);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel2.Enabled = false;
            this.splitContainer2.Size = new System.Drawing.Size(343, 658);
            this.splitContainer2.SplitterDistance = 369;
            this.splitContainer2.TabIndex = 0;
            // 
            // pbxMain
            // 
            this.pbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMain.Location = new System.Drawing.Point(0, 0);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(343, 369);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            // 
            // pnl001
            // 
            this.pnl001.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl001.Controls.Add(this.pbx001);
            this.pnl001.Controls.Add(this.cht001);
            this.pnl001.Controls.Add(this.lab001);
            this.pnl001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl001.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnl001.Location = new System.Drawing.Point(0, 0);
            this.pnl001.Name = "pnl001";
            this.pnl001.Size = new System.Drawing.Size(361, 658);
            this.pnl001.TabIndex = 0;
            // 
            // pbx001
            // 
            this.pbx001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx001.Location = new System.Drawing.Point(0, 35);
            this.pbx001.Name = "pbx001";
            this.pbx001.Size = new System.Drawing.Size(361, 484);
            this.pbx001.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx001.TabIndex = 1;
            this.pbx001.TabStop = false;
            // 
            // lab001
            // 
            this.lab001.BackColor = System.Drawing.Color.Purple;
            this.lab001.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab001.ForeColor = System.Drawing.Color.White;
            this.lab001.Location = new System.Drawing.Point(0, 0);
            this.lab001.Name = "lab001";
            this.lab001.Size = new System.Drawing.Size(361, 35);
            this.lab001.TabIndex = 0;
            this.lab001.Text = "  ";
            this.lab001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColorAveragedGray
            // 
            this.btnColorAveragedGray.Location = new System.Drawing.Point(6, 9);
            this.btnColorAveragedGray.Name = "btnColorAveragedGray";
            this.btnColorAveragedGray.Size = new System.Drawing.Size(274, 33);
            this.btnColorAveragedGray.TabIndex = 0;
            this.btnColorAveragedGray.Text = "RGV Averaged Gray Image";
            this.btnColorAveragedGray.UseVisualStyleBackColor = true;
            this.btnColorAveragedGray.Click += new System.EventHandler(this.btnColorAveragedGray_Click);
            // 
            // btnBetterGray
            // 
            this.btnBetterGray.Location = new System.Drawing.Point(6, 48);
            this.btnBetterGray.Name = "btnBetterGray";
            this.btnBetterGray.Size = new System.Drawing.Size(274, 33);
            this.btnBetterGray.TabIndex = 1;
            this.btnBetterGray.Text = "RGV Arranged Gray Image";
            this.btnBetterGray.UseVisualStyleBackColor = true;
            this.btnBetterGray.Click += new System.EventHandler(this.btnBetterGray_Click);
            // 
            // cht001
            // 
            chartArea25.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea25.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea25.AxisX.Title = "intensity";
            chartArea25.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea25.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea25.AxisY.Title = "count";
            chartArea25.Name = "ChartArea1";
            this.cht001.ChartAreas.Add(chartArea25);
            this.cht001.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cht001.Location = new System.Drawing.Point(0, 519);
            this.cht001.Name = "cht001";
            series25.ChartArea = "ChartArea1";
            series25.Color = System.Drawing.Color.Green;
            series25.Name = "Series1";
            this.cht001.Series.Add(series25);
            this.cht001.Size = new System.Drawing.Size(361, 139);
            this.cht001.TabIndex = 2;
            this.cht001.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pbx002);
            this.panel1.Controls.Add(this.cht002);
            this.panel1.Controls.Add(this.lab002);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 658);
            this.panel1.TabIndex = 3;
            // 
            // pbx002
            // 
            this.pbx002.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx002.Location = new System.Drawing.Point(0, 35);
            this.pbx002.Name = "pbx002";
            this.pbx002.Size = new System.Drawing.Size(343, 484);
            this.pbx002.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx002.TabIndex = 1;
            this.pbx002.TabStop = false;
            // 
            // cht002
            // 
            chartArea26.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea26.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea26.AxisX.Title = "intensity";
            chartArea26.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea26.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea26.AxisY.Title = "count";
            chartArea26.Name = "ChartArea1";
            this.cht002.ChartAreas.Add(chartArea26);
            this.cht002.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cht002.Location = new System.Drawing.Point(0, 519);
            this.cht002.Name = "cht002";
            series26.ChartArea = "ChartArea1";
            series26.Color = System.Drawing.Color.Green;
            series26.Name = "Series1";
            this.cht002.Series.Add(series26);
            this.cht002.Size = new System.Drawing.Size(343, 139);
            this.cht002.TabIndex = 2;
            this.cht002.Text = "chart2";
            // 
            // lab002
            // 
            this.lab002.BackColor = System.Drawing.Color.Purple;
            this.lab002.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab002.ForeColor = System.Drawing.Color.White;
            this.lab002.Location = new System.Drawing.Point(0, 0);
            this.lab002.Name = "lab002";
            this.lab002.Size = new System.Drawing.Size(343, 35);
            this.lab002.TabIndex = 0;
            this.lab002.Text = "  ";
            this.lab002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pbx003);
            this.panel2.Controls.Add(this.cht003);
            this.panel2.Controls.Add(this.lab003);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 658);
            this.panel2.TabIndex = 4;
            // 
            // pbx003
            // 
            this.pbx003.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx003.Location = new System.Drawing.Point(0, 35);
            this.pbx003.Name = "pbx003";
            this.pbx003.Size = new System.Drawing.Size(372, 484);
            this.pbx003.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx003.TabIndex = 1;
            this.pbx003.TabStop = false;
            // 
            // cht003
            // 
            chartArea27.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea27.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea27.AxisX.Title = "intensity";
            chartArea27.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea27.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea27.AxisY.Title = "count";
            chartArea27.Name = "ChartArea1";
            this.cht003.ChartAreas.Add(chartArea27);
            this.cht003.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cht003.Location = new System.Drawing.Point(0, 519);
            this.cht003.Name = "cht003";
            series27.ChartArea = "ChartArea1";
            series27.Color = System.Drawing.Color.Green;
            series27.Name = "Series1";
            this.cht003.Series.Add(series27);
            this.cht003.Size = new System.Drawing.Size(372, 139);
            this.cht003.TabIndex = 2;
            this.cht003.Text = "chart3";
            // 
            // lab003
            // 
            this.lab003.BackColor = System.Drawing.Color.Purple;
            this.lab003.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab003.ForeColor = System.Drawing.Color.White;
            this.lab003.Location = new System.Drawing.Point(0, 0);
            this.lab003.Name = "lab003";
            this.lab003.Size = new System.Drawing.Size(372, 35);
            this.lab003.TabIndex = 0;
            this.lab003.Text = "  ";
            this.lab003.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tkbThresh
            // 
            this.tkbThresh.AutoSize = false;
            this.tkbThresh.Location = new System.Drawing.Point(8, 95);
            this.tkbThresh.Maximum = 255;
            this.tkbThresh.Name = "tkbThresh";
            this.tkbThresh.Size = new System.Drawing.Size(165, 45);
            this.tkbThresh.TabIndex = 2;
            this.tkbThresh.TickFrequency = 16;
            this.tkbThresh.Value = 128;
            this.tkbThresh.ValueChanged += new System.EventHandler(this.tkbThresh_ValueChanged);
            // 
            // labThresh
            // 
            this.labThresh.AutoSize = true;
            this.labThresh.Location = new System.Drawing.Point(190, 98);
            this.labThresh.Name = "labThresh";
            this.labThresh.Size = new System.Drawing.Size(43, 16);
            this.labThresh.TabIndex = 3;
            this.labThresh.Text = "label1";
            // 
            // btnBlackWhite
            // 
            this.btnBlackWhite.Enabled = false;
            this.btnBlackWhite.Location = new System.Drawing.Point(6, 126);
            this.btnBlackWhite.Name = "btnBlackWhite";
            this.btnBlackWhite.Size = new System.Drawing.Size(274, 33);
            this.btnBlackWhite.TabIndex = 4;
            this.btnBlackWhite.Text = "Black / White Image";
            this.btnBlackWhite.UseVisualStyleBackColor = true;
            this.btnBlackWhite.Click += new System.EventHandler(this.btnBlackWhite_Click);
            // 
            // tkbLevel
            // 
            this.tkbLevel.AutoSize = false;
            this.tkbLevel.Location = new System.Drawing.Point(8, 172);
            this.tkbLevel.Maximum = 32;
            this.tkbLevel.Minimum = 2;
            this.tkbLevel.Name = "tkbLevel";
            this.tkbLevel.Size = new System.Drawing.Size(165, 45);
            this.tkbLevel.TabIndex = 6;
            this.tkbLevel.TickFrequency = 4;
            this.tkbLevel.Value = 16;
            this.tkbLevel.ValueChanged += new System.EventHandler(this.tkbLevel_ValueChanged);
            // 
            // labLevel
            // 
            this.labLevel.AutoSize = true;
            this.labLevel.Location = new System.Drawing.Point(190, 172);
            this.labLevel.Name = "labLevel";
            this.labLevel.Size = new System.Drawing.Size(43, 16);
            this.labLevel.TabIndex = 7;
            this.labLevel.Text = "label1";
            // 
            // btnLeveledGray
            // 
            this.btnLeveledGray.Enabled = false;
            this.btnLeveledGray.Location = new System.Drawing.Point(8, 201);
            this.btnLeveledGray.Name = "btnLeveledGray";
            this.btnLeveledGray.Size = new System.Drawing.Size(274, 33);
            this.btnLeveledGray.TabIndex = 8;
            this.btnLeveledGray.Text = "Leveled Gray Image";
            this.btnLeveledGray.UseVisualStyleBackColor = true;
            this.btnLeveledGray.Click += new System.EventHandler(this.btnLeveledGray_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagMonoImage);
            this.tabControl1.Controls.Add(this.pagColorEdit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 285);
            this.tabControl1.TabIndex = 9;
            // 
            // pagMonoImage
            // 
            this.pagMonoImage.Controls.Add(this.btnBlackWhite);
            this.pagMonoImage.Controls.Add(this.btnLeveledGray);
            this.pagMonoImage.Controls.Add(this.btnColorAveragedGray);
            this.pagMonoImage.Controls.Add(this.labLevel);
            this.pagMonoImage.Controls.Add(this.btnBetterGray);
            this.pagMonoImage.Controls.Add(this.tkbLevel);
            this.pagMonoImage.Controls.Add(this.tkbThresh);
            this.pagMonoImage.Controls.Add(this.labThresh);
            this.pagMonoImage.Location = new System.Drawing.Point(4, 25);
            this.pagMonoImage.Name = "pagMonoImage";
            this.pagMonoImage.Padding = new System.Windows.Forms.Padding(3);
            this.pagMonoImage.Size = new System.Drawing.Size(335, 256);
            this.pagMonoImage.TabIndex = 0;
            this.pagMonoImage.Text = "Momo Operations";
            this.pagMonoImage.UseVisualStyleBackColor = true;
            // 
            // pagColorEdit
            // 
            this.pagColorEdit.Controls.Add(this.btnBrightness);
            this.pagColorEdit.Controls.Add(this.btnContrast);
            this.pagColorEdit.Controls.Add(this.labContrast);
            this.pagColorEdit.Controls.Add(this.tkbContrast);
            this.pagColorEdit.Controls.Add(this.tkbBrightness);
            this.pagColorEdit.Controls.Add(this.labBrightness);
            this.pagColorEdit.Location = new System.Drawing.Point(4, 25);
            this.pagColorEdit.Name = "pagColorEdit";
            this.pagColorEdit.Padding = new System.Windows.Forms.Padding(3);
            this.pagColorEdit.Size = new System.Drawing.Size(335, 256);
            this.pagColorEdit.TabIndex = 1;
            this.pagColorEdit.Text = "ImageProcess";
            this.pagColorEdit.UseVisualStyleBackColor = true;
            // 
            // btnContrast
            // 
            this.btnContrast.Location = new System.Drawing.Point(10, 125);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(319, 38);
            this.btnContrast.TabIndex = 11;
            this.btnContrast.Text = "Adjust Contrast";
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // labContrast
            // 
            this.labContrast.AutoSize = true;
            this.labContrast.Location = new System.Drawing.Point(180, 105);
            this.labContrast.Name = "labContrast";
            this.labContrast.Size = new System.Drawing.Size(43, 16);
            this.labContrast.TabIndex = 13;
            this.labContrast.Text = "label1";
            // 
            // tkbContrast
            // 
            this.tkbContrast.AutoSize = false;
            this.tkbContrast.Location = new System.Drawing.Point(10, 93);
            this.tkbContrast.Maximum = 200;
            this.tkbContrast.Minimum = 1;
            this.tkbContrast.Name = "tkbContrast";
            this.tkbContrast.Size = new System.Drawing.Size(165, 45);
            this.tkbContrast.TabIndex = 12;
            this.tkbContrast.TickFrequency = 4;
            this.tkbContrast.Value = 16;
            this.tkbContrast.ValueChanged += new System.EventHandler(this.tkbContrast_ValueChanged);
            // 
            // tkbBrightness
            // 
            this.tkbBrightness.AutoSize = false;
            this.tkbBrightness.Location = new System.Drawing.Point(8, 18);
            this.tkbBrightness.Maximum = 200;
            this.tkbBrightness.Minimum = -200;
            this.tkbBrightness.Name = "tkbBrightness";
            this.tkbBrightness.Size = new System.Drawing.Size(165, 45);
            this.tkbBrightness.TabIndex = 8;
            this.tkbBrightness.TickFrequency = 16;
            this.tkbBrightness.Value = 20;
            this.tkbBrightness.ValueChanged += new System.EventHandler(this.tkbBrightness_ValueChanged);
            // 
            // labBrightness
            // 
            this.labBrightness.AutoSize = true;
            this.labBrightness.Location = new System.Drawing.Point(180, 25);
            this.labBrightness.Name = "labBrightness";
            this.labBrightness.Size = new System.Drawing.Size(43, 16);
            this.labBrightness.TabIndex = 9;
            this.labBrightness.Text = "label1";
            // 
            // btnBrightness
            // 
            this.btnBrightness.Location = new System.Drawing.Point(8, 54);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(313, 33);
            this.btnBrightness.TabIndex = 10;
            this.btnBrightness.Text = "Adjust Brightness";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pnl001);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1084, 658);
            this.splitContainer3.SplitterDistance = 361;
            this.splitContainer3.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.panel2);
            this.splitContainer4.Size = new System.Drawing.Size(719, 658);
            this.splitContainer4.SplitterDistance = 343;
            this.splitContainer4.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 704);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Image Processing HWK 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.pnl001.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht001)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx002)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht002)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx003)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht003)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLevel)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pagMonoImage.ResumeLayout(false);
            this.pagMonoImage.PerformLayout();
            this.pagColorEdit.ResumeLayout(false);
            this.pagColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Panel pnl001;
        private System.Windows.Forms.PictureBox pbx001;
        private System.Windows.Forms.Label lab001;
        private System.Windows.Forms.Button btnColorAveragedGray;
        private System.Windows.Forms.Button btnBetterGray;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht001;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbx002;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht002;
        private System.Windows.Forms.Label lab002;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbx003;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht003;
        private System.Windows.Forms.Label lab003;
        private System.Windows.Forms.Label labThresh;
        private System.Windows.Forms.TrackBar tkbThresh;
        private System.Windows.Forms.Button btnBlackWhite;
        private System.Windows.Forms.Label labLevel;
        private System.Windows.Forms.TrackBar tkbLevel;
        private System.Windows.Forms.Button btnLeveledGray;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pagMonoImage;
        private System.Windows.Forms.TabPage pagColorEdit;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Label labContrast;
        private System.Windows.Forms.TrackBar tkbContrast;
        private System.Windows.Forms.TrackBar tkbBrightness;
        private System.Windows.Forms.Label labBrightness;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}

