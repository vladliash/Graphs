using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphs
{
    
   

    public partial class Form1 : Form
    {
        delegate void Change(Chart chart, string title);

        public Form1()
        {
            InitializeComponent();
            inputTable.Rows.Add(24);
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            Thread kek = new Thread(new ThreadStart(ChangeTitle));
            kek.Start();

            void ChangeTitle()
            {
                Invoke(new Change(writeChart), chartPressure, "График давления");
                Invoke(new Change(writeChart), chartPower, "График мощности");
                Invoke(new Change(writeChart), chartCoefficient, "График КПД");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTable.Rows.Clear();
            inputTable.Rows.Add(24);
            toolStripTextBox1.Clear();
            foreach (Series i in chartPressure.Series)
                i.Points.Clear();
            foreach (Series i in chartPower.Series)
                i.Points.Clear();
            foreach (Series i in chartCoefficient.Series)
                i.Points.Clear();
        }
        
        private void inputTable_KeyDown(object sender, KeyEventArgs e)
        {
            /// Очистка выбранных ячеек клавишей DELETE
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < inputTable.SelectedCells.Count; i++)
                    inputTable.SelectedCells[i].Value = null;
            }

            /// Вставка в таблицу сочетанием клавиш CTRL+V
            else if ((e.KeyCode == Keys.V)&&(Control.ModifierKeys == Keys.Control))
            {
                DataProcessing.pasteData();
                DataProcessing.fillTable(inputTable);
            }
        }

        private void inputTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataProcessing.parseTable(inputTable);
            DataProcessing.graphPoints(3,10);
            updateGraphs();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            double dub;
            bool isit = double.TryParse(((ToolStripTextBox) sender).Text?.Replace('.', ','), out dub);
            if (isit)
            {
                DataProcessing.Q = dub;
                DataProcessing.graphPoints( 3, 10);
                updateGraphs();
            }
        }

        /// <summary>
        /// Updates points of all charts, refreshes intervals of the graph
        /// </summary>
        void updateGraphs()
        {
            try
            {
                chartPressure.ChartAreas[0].AxisX.MinorGrid.Interval = Double.NaN;
                chartPressure.ChartAreas[0].AxisY.MinorGrid.Interval = Double.NaN;
                DataPointCollection points = chartPressure.Series[0].Points;
                DataPointCollection points2 = chartPressure.Series[1].Points;
                DataProcessing.pointsUpdate(ref points, DataProcessing.points[0][0], DataProcessing.points[0][1]);
                DataProcessing.pointsUpdate(ref points2, DataProcessing.points[1][0], DataProcessing.points[1][1]);
                chartPressure.Series[2].Points.Clear();
                chartPressure.Series[2].Points.AddXY(DataProcessing.Q, DataProcessing.workPoints[0]);
                chartPressure.Series[2].Points.AddXY(DataProcessing.Q, DataProcessing.workPoints[1]);
                double min = Math.Min(DataProcessing.points[0][0][0], DataProcessing.points[1][0][0]);
                double max = Math.Max(DataProcessing.points[0][0][DataProcessing.points[0][0].Length - 1], DataProcessing.points[1][0][DataProcessing.points[0][0].Length - 1]);
                double margin = (max - min) * 0.2;
                min = min - margin;
                max = max + margin;
                int degree = ((int)((max - min) / 5)).ToString().Length - 1;
                double interval = Math.Round(((max - min) / 5) / Math.Pow(10, degree), MidpointRounding.AwayFromZero) * Math.Pow(10, degree);
                min = ((int)(min / interval)) * interval;
                chartPressure.ChartAreas[0].AxisX.Interval = interval;
                chartPressure.ChartAreas[0].AxisX.Minimum = min;
                chartPressure.ChartAreas[0].AxisX.Maximum = ((int) ((max - min)/interval)+1)*(interval) + min;

                chartPower.ChartAreas[0].AxisX.MinorGrid.Interval = Double.NaN;
                chartPower.ChartAreas[0].AxisY.MinorGrid.Interval = Double.NaN;
                DataPointCollection points3 = chartPower.Series[0].Points;
                DataProcessing.pointsUpdate(ref points3, DataProcessing.points[2][0], DataProcessing.points[2][1]);
                chartPower.Series[1].Points.Clear();
                chartPower.Series[1].Points.AddXY(DataProcessing.Q, DataProcessing.workPoints[2]);
                min = DataProcessing.points[2][0][0];
                max = DataProcessing.points[2][0][DataProcessing.points[2][0].Length - 1];
                margin = (max - min) * 0.2;
                min = min - margin;
                max = max + margin;
                degree = ((int)((max - min) / 5)).ToString().Length - 1;
                interval = Math.Round(((max - min) / 5) / Math.Pow(10, degree), MidpointRounding.AwayFromZero) * Math.Pow(10, degree);
                min = ((int)(min / interval)) * interval;
                chartPower.ChartAreas[0].AxisX.Interval = interval;
                chartPower.ChartAreas[0].AxisX.Minimum = min;
                chartPower.ChartAreas[0].AxisX.Maximum = ((int)((max - min) / interval) + 1) * (interval) + min;

                chartCoefficient.ChartAreas[0].AxisX.MinorGrid.Interval = Double.NaN;
                chartCoefficient.ChartAreas[0].AxisY.MinorGrid.Interval = Double.NaN;
                DataPointCollection points4 = chartCoefficient.Series[0].Points;
                DataPointCollection points5 = chartCoefficient.Series[1].Points;
                DataProcessing.pointsUpdate(ref points4, DataProcessing.points[3][0], DataProcessing.points[3][1]);
                DataProcessing.pointsUpdate(ref points5, DataProcessing.points[4][0], DataProcessing.points[4][1]);
                chartCoefficient.Series[2].Points.Clear();
                chartCoefficient.Series[2].Points.AddXY(DataProcessing.Q, DataProcessing.workPoints[3]);
                chartCoefficient.Series[2].Points.AddXY(DataProcessing.Q, DataProcessing.workPoints[4]);
                min = Math.Min(DataProcessing.points[3][0][0], DataProcessing.points[4][0][0]);
                max = Math.Max(DataProcessing.points[3][0][DataProcessing.points[3][0].Length - 1], DataProcessing.points[4][0][DataProcessing.points[4][0].Length - 1]);
                margin = (max - min) * 0.2;
                min = min - margin;
                max = max + margin;
                degree = ((int)((max - min) / 5)).ToString().Length - 1;
                interval = Math.Round(((max - min) / 5) / Math.Pow(10, degree), MidpointRounding.AwayFromZero) * Math.Pow(10, degree);
                min = ((int)(min / interval)) * interval;
                chartCoefficient.ChartAreas[0].AxisX.Interval = interval;
                chartCoefficient.ChartAreas[0].AxisX.Minimum = min;
                chartCoefficient.ChartAreas[0].AxisX.Maximum = ((int)((max - min) / interval) + 1) * (interval) + min;



            } catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            catch (System.NullReferenceException)
            {
                return;
            }
        }

        /// <summary>
        /// Exports specifically edited graph as .bmp image into the root directory
        /// </summary>
        /// <param name="chart"><see cref="Chart"/> to be edited </param>
        /// <param name="title">Name of the image file in the operating system</param>
        void writeChart(Chart chart,string title)
        {
            tableLayoutPanel1.Controls.Remove(chart);
            chart.Height = 300;
            chart.Width = 600;
            chart.Legends[0].Enabled = true;
            chart.ChartAreas[0].Position.Width = 63;
            chart.ChartAreas[0].InnerPlotPosition.X = 15;
            double intervalX = chart.ChartAreas[0].AxisX.MajorGrid.Interval;
            double intervalY = chart.ChartAreas[0].AxisY.MajorGrid.Interval;
            chart.ChartAreas[0].AxisX.MinorGrid.Interval = intervalX / 5;
            chart.ChartAreas[0].AxisY.MinorGrid.Interval = intervalY / 5;

            chart.SaveImage(title + ".Bmp", ChartImageFormat.Bmp);

            chart.ChartAreas[0].AxisX.MinorGrid.Interval = Double.NaN;
            chart.ChartAreas[0].AxisY.MinorGrid.Interval = Double.NaN;
            chart.Legends[0].Enabled = false;
            chart.ChartAreas[0].Position.Auto = true;
            chart.ChartAreas[0].InnerPlotPosition.Auto = true;
            tableLayoutPanel1.Controls.Add(chart);
        }
    }
}
