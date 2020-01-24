using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphs
{
    
   

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            inputTable.Rows.Add(24);
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            DataPointCollection points = chartPressure.Series[0].Points;
            DataPointCollection points2 = chartPressure.Series[1].Points;
            //DataProcessing.kek(ref points, DataProcessing.realDataTable[0], DataProcessing.realDataTable[1]);
            DataProcessing.kek(ref points,DataProcessing.points[0][0], DataProcessing.points[0][1]);
            DataProcessing.kek(ref points2, DataProcessing.points[1][0], DataProcessing.points[1][1]);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTable.Rows.Clear();
            inputTable.Rows.Add(24);
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
            DataProcessing.parseTable(inputTable, indicator);
            DataProcessing.graphPoints(indicator);

        }
    }
}
