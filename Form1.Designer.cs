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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.airFlow.DefaultCellStyle = dataGridViewCellStyle7;
            this.airFlow.HeaderText = "Q, м³";
            this.airFlow.Name = "airFlow";
            this.airFlow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.airFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.airFlow.ToolTipText = "Расход воздуха";
            // 
            // fullPressure
            // 
            this.fullPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullPressure.DefaultCellStyle = dataGridViewCellStyle8;
            this.fullPressure.HeaderText = "Pv, МПа";
            this.fullPressure.Name = "fullPressure";
            this.fullPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fullPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fullPressure.ToolTipText = "Полное давление";
            // 
            // staticPressure
            // 
            this.staticPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staticPressure.DefaultCellStyle = dataGridViewCellStyle9;
            this.staticPressure.HeaderText = "Ps, МПа";
            this.staticPressure.Name = "staticPressure";
            this.staticPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staticPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.staticPressure.ToolTipText = "Статическое давление";
            // 
            // power
            // 
            this.power.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.power.DefaultCellStyle = dataGridViewCellStyle10;
            this.power.HeaderText = "N, кВт";
            this.power.Name = "power";
            this.power.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.power.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.power.ToolTipText = "Мощность";
            // 
            // efficiencyFull
            // 
            this.efficiencyFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyFull.DefaultCellStyle = dataGridViewCellStyle11;
            this.efficiencyFull.HeaderText = "ηv";
            this.efficiencyFull.Name = "efficiencyFull";
            this.efficiencyFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.efficiencyFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.efficiencyFull.ToolTipText = "Полный КПД";
            // 
            // efficiencyStatic
            // 
            this.efficiencyStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyStatic.DefaultCellStyle = dataGridViewCellStyle12;
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
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea4.AlignWithChartArea = "ChartArea1";
            chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.MinorGrid.Enabled = true;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.ScaleView.Zoomable = false;
            chartArea4.AxisX.Title = "Q, м³";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.MinorGrid.Enabled = true;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.Title = "η, %";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "ChartArea1";
            this.chartCoefficient.ChartAreas.Add(chartArea4);
            legend4.DockedToChartArea = "ChartArea1";
            legend4.Enabled = false;
            legend4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend4.IsDockedInsideChartArea = false;
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chartCoefficient.Legends.Add(legend4);
            this.chartCoefficient.Location = new System.Drawing.Point(3, 387);
            this.chartCoefficient.Name = "chartCoefficient";
            series9.BorderColor = System.Drawing.Color.Black;
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Black;
            series9.CustomProperties = "EmptyPointValue=Zero";
            series9.Legend = "Legend1";
            series9.Name = "Полный КПД";
            series10.BorderColor = System.Drawing.Color.Black;
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Black;
            series10.Legend = "Legend1";
            series10.Name = "Статический КПД";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Color = System.Drawing.Color.Black;
            series11.Legend = "Legend1";
            series11.Name = "Рабочая точка";
            this.chartCoefficient.Series.Add(series9);
            this.chartCoefficient.Series.Add(series10);
            this.chartCoefficient.Series.Add(series11);
            this.chartCoefficient.Size = new System.Drawing.Size(352, 183);
            this.chartCoefficient.TabIndex = 7;
            this.chartCoefficient.Text = "chart1";
            title4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "КПД";
            this.chartCoefficient.Titles.Add(title4);
            // 
            // chartPower
            // 
            chartArea5.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea5.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea5.AlignWithChartArea = "ChartArea1";
            chartArea5.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.MinorGrid.Enabled = true;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.ScaleView.Zoomable = false;
            chartArea5.AxisX.Title = "Q, м³";
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX2.IsLabelAutoFit = false;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.MinorGrid.Enabled = true;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.Title = "N, кВт";
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.IsSameFontSizeForAllAxes = true;
            chartArea5.Name = "ChartArea1";
            this.chartPower.ChartAreas.Add(chartArea5);
            legend5.DockedToChartArea = "ChartArea1";
            legend5.Enabled = false;
            legend5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend5.IsDockedInsideChartArea = false;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            legend5.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chartPower.Legends.Add(legend5);
            this.chartPower.Location = new System.Drawing.Point(3, 194);
            this.chartPower.Name = "chartPower";
            series12.BorderColor = System.Drawing.Color.Black;
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Black;
            series12.CustomProperties = "EmptyPointValue=Zero";
            series12.Legend = "Legend1";
            series12.Name = "Мощность";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series13.Color = System.Drawing.Color.Black;
            series13.Legend = "Legend1";
            series13.Name = "Рабочая точка";
            this.chartPower.Series.Add(series12);
            this.chartPower.Series.Add(series13);
            this.chartPower.Size = new System.Drawing.Size(352, 185);
            this.chartPower.TabIndex = 6;
            this.chartPower.Text = "chart1";
            title5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.Name = "Title1";
            title5.Text = "Мощность";
            this.chartPower.Titles.Add(title5);
            // 
            // chartPressure
            // 
            chartArea6.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea6.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea6.AlignWithChartArea = "ChartArea1";
            chartArea6.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisX.MinorGrid.Enabled = true;
            chartArea6.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisX.ScaleView.Zoomable = false;
            chartArea6.AxisX.Title = "Q, м³";
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea6.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.MinorGrid.Enabled = true;
            chartArea6.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.Title = "P, МПа";
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.IsSameFontSizeForAllAxes = true;
            chartArea6.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea6);
            legend6.DockedToChartArea = "ChartArea1";
            legend6.Enabled = false;
            legend6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend6.IsDockedInsideChartArea = false;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartPressure.Legends.Add(legend6);
            this.chartPressure.Location = new System.Drawing.Point(3, 3);
            this.chartPressure.Name = "chartPressure";
            series14.BorderColor = System.Drawing.Color.Black;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.Black;
            series14.CustomProperties = "EmptyPointValue=Zero";
            series14.Legend = "Legend1";
            series14.Name = "Полное давление";
            series15.BorderColor = System.Drawing.Color.Black;
            series15.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.Black;
            series15.Legend = "Legend1";
            series15.Name = "Статическое давление";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series16.Color = System.Drawing.Color.Black;
            series16.Legend = "Legend1";
            series16.Name = "Рабочая точка";
            this.chartPressure.Series.Add(series14);
            this.chartPressure.Series.Add(series15);
            this.chartPressure.Series.Add(series16);
            this.chartPressure.Size = new System.Drawing.Size(352, 185);
            this.chartPressure.TabIndex = 5;
            this.chartPressure.Text = "chart1";
            title6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.Name = "Title1";
            title6.Text = "Давление";
            this.chartPressure.Titles.Add(title6);
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

