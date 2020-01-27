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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.inputLabel});
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
            this.inputLabel.Size = new System.Drawing.Size(229, 22);
            this.inputLabel.Text = "Полное давление в рабочей точке, МПа";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.airFlow.DefaultCellStyle = dataGridViewCellStyle1;
            this.airFlow.HeaderText = "Q, м³";
            this.airFlow.Name = "airFlow";
            this.airFlow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.airFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.airFlow.ToolTipText = "Расход воздуха";
            // 
            // fullPressure
            // 
            this.fullPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullPressure.DefaultCellStyle = dataGridViewCellStyle2;
            this.fullPressure.HeaderText = "Pv, МПа";
            this.fullPressure.Name = "fullPressure";
            this.fullPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fullPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fullPressure.ToolTipText = "Полное давление";
            // 
            // staticPressure
            // 
            this.staticPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staticPressure.DefaultCellStyle = dataGridViewCellStyle3;
            this.staticPressure.HeaderText = "Ps, МПа";
            this.staticPressure.Name = "staticPressure";
            this.staticPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staticPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.staticPressure.ToolTipText = "Статическое давление";
            // 
            // power
            // 
            this.power.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.power.DefaultCellStyle = dataGridViewCellStyle4;
            this.power.HeaderText = "N, кВт";
            this.power.Name = "power";
            this.power.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.power.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.power.ToolTipText = "Мощность";
            // 
            // efficiencyFull
            // 
            this.efficiencyFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyFull.DefaultCellStyle = dataGridViewCellStyle5;
            this.efficiencyFull.HeaderText = "ηv";
            this.efficiencyFull.Name = "efficiencyFull";
            this.efficiencyFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.efficiencyFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.efficiencyFull.ToolTipText = "Полный КПД";
            // 
            // efficiencyStatic
            // 
            this.efficiencyStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyStatic.DefaultCellStyle = dataGridViewCellStyle6;
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
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea1.AlignWithChartArea = "ChartArea1";
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.Title = "Q, м³";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Title = "η, %";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chartCoefficient.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartCoefficient.Legends.Add(legend1);
            this.chartCoefficient.Location = new System.Drawing.Point(3, 387);
            this.chartCoefficient.Name = "chartCoefficient";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.Legend = "Legend1";
            series1.Name = "Полный КПД";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Статический КПД";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Рабочая точка";
            this.chartCoefficient.Series.Add(series1);
            this.chartCoefficient.Series.Add(series2);
            this.chartCoefficient.Series.Add(series3);
            this.chartCoefficient.Size = new System.Drawing.Size(352, 183);
            this.chartCoefficient.TabIndex = 7;
            this.chartCoefficient.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "КПД";
            this.chartCoefficient.Titles.Add(title1);
            // 
            // chartPower
            // 
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea2.AlignWithChartArea = "ChartArea1";
            chartArea2.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisX.Title = "Q, м³";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.Title = "N, кВт";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.chartPower.ChartAreas.Add(chartArea2);
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsDockedInsideChartArea = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartPower.Legends.Add(legend2);
            this.chartPower.Location = new System.Drawing.Point(3, 194);
            this.chartPower.Name = "chartPower";
            series4.BorderColor = System.Drawing.Color.Black;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.CustomProperties = "EmptyPointValue=Zero";
            series4.Legend = "Legend1";
            series4.Name = "Мощность";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Black;
            series5.Legend = "Legend1";
            series5.Name = "Рабочая точка";
            this.chartPower.Series.Add(series4);
            this.chartPower.Series.Add(series5);
            this.chartPower.Size = new System.Drawing.Size(352, 185);
            this.chartPower.TabIndex = 6;
            this.chartPower.Text = "chart1";
            title2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Мощность";
            this.chartPower.Titles.Add(title2);
            // 
            // chartPressure
            // 
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea3.AlignWithChartArea = "ChartArea1";
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.ScaleView.Zoomable = false;
            chartArea3.AxisX.Title = "Q, м³";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.Title = "P, МПа";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea3);
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Enabled = false;
            legend3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsDockedInsideChartArea = false;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartPressure.Legends.Add(legend3);
            this.chartPressure.Location = new System.Drawing.Point(3, 3);
            this.chartPressure.Name = "chartPressure";
            series6.BorderColor = System.Drawing.Color.Black;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Black;
            series6.CustomProperties = "EmptyPointValue=Zero";
            series6.Legend = "Legend1";
            series6.Name = "Полное давление";
            series7.BorderColor = System.Drawing.Color.Black;
            series7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Black;
            series7.Legend = "Legend1";
            series7.Name = "Статическое давление";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Color = System.Drawing.Color.Black;
            series8.Legend = "Legend1";
            series8.Name = "Рабочая точка";
            this.chartPressure.Series.Add(series6);
            this.chartPressure.Series.Add(series7);
            this.chartPressure.Series.Add(series8);
            this.chartPressure.Size = new System.Drawing.Size(352, 185);
            this.chartPressure.TabIndex = 5;
            this.chartPressure.Text = "chart1";
            title3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Давление";
            this.chartPressure.Titles.Add(title3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 601);
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
    }
}

