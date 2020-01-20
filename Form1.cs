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
            DataProcessing.parseTable(inputTable, indicator);
            DataProcessing.graphPoints(indicator);
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
            /*DataProcessing.parseTable(inputTable, indicator);
            DataProcessing.graphPoints(indicator);*/
        }
    }
}
