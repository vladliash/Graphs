namespace Graphs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exportButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.inputLabel = new System.Windows.Forms.ToolStripLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputTable = new System.Windows.Forms.DataGridView();
            this.airFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staticPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyStatic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartCoefficient = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPower = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCoefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportButton,
            this.clearButton,
            this.toolStripTextBox1,
            this.inputLabel,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exportButton
            // 
            this.exportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportButton.Image = ((System.Drawing.Image)(resources.GetObject("exportButton.Image")));
            this.exportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(56, 22);
            this.exportButton.Text = "Экспорт";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 22);
            this.clearButton.Text = "Очистить";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(235, 22);
            this.inputLabel.Text = "Полное давление в рабочей точке, МПа :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.inputTable);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 576);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // inputTable
            // 
            this.inputTable.AllowUserToResizeColumns = false;
            this.inputTable.AllowUserToResizeRows = false;
            this.inputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airFlow,
            this.fullPressure,
            this.staticPressure,
            this.power,
            this.efficiencyFull,
            this.efficiencyStatic});
            this.inputTable.Location = new System.Drawing.Point(3, 3);
            this.inputTable.Name = "inputTable";
            this.inputTable.RowHeadersVisible = false;
            this.inputTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTable.Size = new System.Drawing.Size(366, 573);
            this.inputTable.TabIndex = 0;
            this.inputTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputTable_CellValueChanged);
            this.inputTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTable_KeyDown);
            // 
            // airFlow
            // 
            this.airFlow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.airFlow.DefaultCellStyle = dataGridViewCellStyle13;
            this.airFlow.HeaderText = "Q, м³";
            this.airFlow.Name = "airFlow";
            this.airFlow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.airFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.airFlow.ToolTipText = "Расход воздуха";
            // 
            // fullPressure
            // 
            this.fullPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullPressure.DefaultCellStyle = dataGridViewCellStyle14;
            this.fullPressure.HeaderText = "Pv, МПа";
            this.fullPressure.Name = "fullPressure";
            this.fullPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fullPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fullPressure.ToolTipText = "Полное давление";
            // 
            // staticPressure
            // 
            this.staticPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staticPressure.DefaultCellStyle = dataGridViewCellStyle15;
            this.staticPressure.HeaderText = "Ps, МПа";
            this.staticPressure.Name = "staticPressure";
            this.staticPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staticPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.staticPressure.ToolTipText = "Статическое давление";
            // 
            // power
            // 
            this.power.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.power.DefaultCellStyle = dataGridViewCellStyle16;
            this.power.HeaderText = "N, кВт";
            this.power.Name = "power";
            this.power.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.power.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.power.ToolTipText = "Мощность";
            // 
            // efficiencyFull
            // 
            this.efficiencyFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyFull.DefaultCellStyle = dataGridViewCellStyle17;
            this.efficiencyFull.HeaderText = "ηv";
            this.efficiencyFull.Name = "efficiencyFull";
            this.efficiencyFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.efficiencyFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.efficiencyFull.ToolTipText = "Полный КПД";
            // 
            // efficiencyStatic
            // 
            this.efficiencyStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyStatic.DefaultCellStyle = dataGridViewCellStyle18;
            this.efficiencyStatic.HeaderText = "ηs";
            this.efficiencyStatic.Name = "efficiencyStatic";
            this.efficiencyStatic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.efficiencyStatic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.efficiencyStatic.ToolTipText = "Статический КПД";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartCoefficient, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartPower, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartPressure, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(375, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.86301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.13699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chartCoefficient
            // 
            chartArea7.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea7.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea7.AlignWithChartArea = "ChartArea1";
            chartArea7.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisX.MinorGrid.Enabled = true;
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea7.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisX.ScaleView.Zoomable = false;
            chartArea7.AxisX.Title = "Q, м³";
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea7.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea7.AxisY.IsLabelAutoFit = false;
            chartArea7.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea7.AxisY.Maximum = 100D;
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.AxisY.MinorGrid.Enabled = true;
            chartArea7.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea7.AxisY.Title = "η, %";
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea7.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea7.IsSameFontSizeForAllAxes = true;
            chartArea7.Name = "ChartArea1";
            this.chartCoefficient.ChartAreas.Add(chartArea7);
            legend7.DockedToChartArea = "ChartArea1";
            legend7.Enabled = false;
            legend7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend7.IsDockedInsideChartArea = false;
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chartCoefficient.Legends.Add(legend7);
            this.chartCoefficient.Location = new System.Drawing.Point(3, 387);
            this.chartCoefficient.Name = "chartCoefficient";
            series17.BorderColor = System.Drawing.Color.Black;
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Color = System.Drawing.Color.Black;
            series17.CustomProperties = "EmptyPointValue=Zero";
            series17.Legend = "Legend1";
            series17.Name = "Полный КПД";
            series18.BorderColor = System.Drawing.Color.Black;
            series18.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series18.BorderWidth = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Color = System.Drawing.Color.Black;
            series18.Legend = "Legend1";
            series18.Name = "Статический КПД";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series19.Color = System.Drawing.Color.Black;
            series19.Legend = "Legend1";
            series19.Name = "Рабочая точка";
            this.chartCoefficient.Series.Add(series17);
            this.chartCoefficient.Series.Add(series18);
            this.chartCoefficient.Series.Add(series19);
            this.chartCoefficient.Size = new System.Drawing.Size(352, 183);
            this.chartCoefficient.TabIndex = 7;
            this.chartCoefficient.Text = "chart1";
            title7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title7.Name = "Title1";
            title7.Text = "КПД";
            this.chartCoefficient.Titles.Add(title7);
            // 
            // chartPower
            // 
            chartArea8.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea8.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea8.AlignWithChartArea = "ChartArea1";
            chartArea8.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea8.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.AxisX.MinorGrid.Enabled = true;
            chartArea8.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea8.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisX.ScaleView.Zoomable = false;
            chartArea8.AxisX.Title = "Q, м³";
            chartArea8.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea8.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisX2.IsLabelAutoFit = false;
            chartArea8.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea8.AxisY.IsLabelAutoFit = false;
            chartArea8.AxisY.IsStartedFromZero = false;
            chartArea8.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea8.AxisY.MinorGrid.Enabled = true;
            chartArea8.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea8.AxisY.Title = "N, кВт";
            chartArea8.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea8.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea8.IsSameFontSizeForAllAxes = true;
            chartArea8.Name = "ChartArea1";
            this.chartPower.ChartAreas.Add(chartArea8);
            legend8.DockedToChartArea = "ChartArea1";
            legend8.Enabled = false;
            legend8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend8.IsDockedInsideChartArea = false;
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            legend8.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartPower.Legends.Add(legend8);
            this.chartPower.Location = new System.Drawing.Point(3, 194);
            this.chartPower.Name = "chartPower";
            series20.BorderColor = System.Drawing.Color.Black;
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Color = System.Drawing.Color.Black;
            series20.CustomProperties = "EmptyPointValue=Zero";
            series20.Legend = "Legend1";
            series20.Name = "Мощность";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series21.Color = System.Drawing.Color.Black;
            series21.Legend = "Legend1";
            series21.Name = "Рабочая точка";
            this.chartPower.Series.Add(series20);
            this.chartPower.Series.Add(series21);
            this.chartPower.Size = new System.Drawing.Size(352, 185);
            this.chartPower.TabIndex = 6;
            this.chartPower.Text = "chart1";
            title8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title8.Name = "Title1";
            title8.Text = "Мощность";
            this.chartPower.Titles.Add(title8);
            // 
            // chartPressure
            // 
            chartArea9.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea9.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea9.AlignWithChartArea = "ChartArea1";
            chartArea9.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea9.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea9.AxisX.IsStartedFromZero = false;
            chartArea9.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea9.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisX.MinorGrid.Enabled = true;
            chartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea9.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.ScaleView.Zoomable = false;
            chartArea9.AxisX.Title = "Q, м³";
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisY.IsLabelAutoFit = false;
            chartArea9.AxisY.IsStartedFromZero = false;
            chartArea9.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisY.MinorGrid.Enabled = true;
            chartArea9.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea9.AxisY.Title = "P, МПа";
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea9.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea9.IsSameFontSizeForAllAxes = true;
            chartArea9.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea9);
            legend9.DockedToChartArea = "ChartArea1";
            legend9.Enabled = false;
            legend9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend9.IsDockedInsideChartArea = false;
            legend9.IsTextAutoFit = false;
            legend9.Name = "Legend1";
            this.chartPressure.Legends.Add(legend9);
            this.chartPressure.Location = new System.Drawing.Point(3, 3);
            this.chartPressure.Name = "chartPressure";
            series22.BorderColor = System.Drawing.Color.Black;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Color = System.Drawing.Color.Black;
            series22.CustomProperties = "EmptyPointValue=Zero";
            series22.Legend = "Legend1";
            series22.Name = "Полное давление";
            series23.BorderColor = System.Drawing.Color.Black;
            series23.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Color = System.Drawing.Color.Black;
            series23.Legend = "Legend1";
            series23.Name = "Статическое давление";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series24.Color = System.Drawing.Color.Black;
            series24.Legend = "Legend1";
            series24.Name = "Рабочая точка";
            this.chartPressure.Series.Add(series22);
            this.chartPressure.Series.Add(series23);
            this.chartPressure.Series.Add(series24);
            this.chartPressure.Size = new System.Drawing.Size(352, 185);
            this.chartPressure.TabIndex = 5;
            this.chartPressure.Text = "chart1";
            title9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title9.Name = "Title1";
            title9.Text = "Давление";
            this.chartPressure.Titles.Add(title9);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(136, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(159, 18);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Показать рабочую точку ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 601);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Графики ｡◕‿‿◕｡";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCoefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView inputTable;
        private System.Windows.Forms.ToolStripButton exportButton;
        private System.Windows.Forms.ToolStripLabel inputLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn airFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyStatic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPower;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCoefficient;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

