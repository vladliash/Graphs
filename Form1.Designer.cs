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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exportButton = new System.Windows.Forms.ToolStripButton();
            this.exportDirButton = new System.Windows.Forms.ToolStripButton();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.indicator = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportButton,
            this.exportDirButton,
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
            // exportDirButton
            // 
            this.exportDirButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exportDirButton.Image = ((System.Drawing.Image)(resources.GetObject("exportDirButton.Image")));
            this.exportDirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportDirButton.Name = "exportDirButton";
            this.exportDirButton.Size = new System.Drawing.Size(100, 22);
            this.exportDirButton.Text = "Экспорт в папку";
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
            this.inputTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTable_KeyDown);
            // 
            // airFlow
            // 
            this.airFlow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.airFlow.DefaultCellStyle = dataGridViewCellStyle1;
            this.airFlow.HeaderText = "Q, м3";
            this.airFlow.Name = "airFlow";
            this.airFlow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.airFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fullPressure
            // 
            this.fullPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullPressure.DefaultCellStyle = dataGridViewCellStyle2;
            this.fullPressure.HeaderText = "pv, МПа";
            this.fullPressure.Name = "fullPressure";
            this.fullPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fullPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // staticPressure
            // 
            this.staticPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staticPressure.DefaultCellStyle = dataGridViewCellStyle3;
            this.staticPressure.HeaderText = "ps, МПа";
            this.staticPressure.Name = "staticPressure";
            this.staticPressure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staticPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // 
            // efficiencyFull
            // 
            this.efficiencyFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyFull.DefaultCellStyle = dataGridViewCellStyle5;
            this.efficiencyFull.HeaderText = "Ev";
            this.efficiencyFull.Name = "efficiencyFull";
            this.efficiencyFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.efficiencyFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // efficiencyStatic
            // 
            this.efficiencyStatic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.efficiencyStatic.DefaultCellStyle = dataGridViewCellStyle6;
            this.efficiencyStatic.HeaderText = "Es";
            this.efficiencyStatic.Name = "efficiencyStatic";
            this.efficiencyStatic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.efficiencyStatic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.indicator, 0, 1);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(352, 185);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // indicator
            // 
            this.indicator.AcceptsReturn = true;
            this.indicator.AllowDrop = true;
            this.indicator.Location = new System.Drawing.Point(3, 194);
            this.indicator.Multiline = true;
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(352, 145);
            this.indicator.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 601);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Графики ｡◕‿‿◕｡";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView inputTable;
        private System.Windows.Forms.ToolStripButton exportButton;
        private System.Windows.Forms.ToolStripButton exportDirButton;
        private System.Windows.Forms.ToolStripLabel inputLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn airFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn staticPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn efficiencyStatic;
        private System.Windows.Forms.TextBox indicator;
    }
}

