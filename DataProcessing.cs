
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{

    static class DataProcessing
    {
        static double[][] dataTable;
        static double[][] realDataTable;
        static double[][] points;

        /*
         * Parses data from clipboard to dataTable
         */
        static public void pasteData()
        {
            char[] rowSplitter = { '\r', '\n' };
            string[] rows = Clipboard.GetText().Split(rowSplitter,StringSplitOptions.RemoveEmptyEntries);
            int colNum = (rows[0].Split('\t')).Length;

            dataTable = new double[colNum][];
            for (int i = 0; i < colNum; i++)
                dataTable[i] = new double[rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                string[] row = rows[i].Split('\t');
                for (int j = 0; j<  Math.Min(row.Length, colNum); j++)
                {
                    double dub;
                    bool isit = double.TryParse(row[j].Replace('.',','), out dub);
                    if (isit)
                    {
                        dataTable[j][i] = dub;
                    }
                }
            }
        }
        /*
         * Fills given table with data from dataTable
         */
        static public void fillTable(DataGridView table)
        {
            if (dataTable == null)
                return;

            if (table.SelectedCells == null)
                return;
            DataGridViewSelectedCellCollection cells = table.SelectedCells;
            DataGridViewCell lastCell = cells[cells.Count - 1];
            int firstCol = lastCell.ColumnIndex;
            int firstRow = lastCell.RowIndex;

            for (int i = 0; i < dataTable.Length; i++)
            {
                if (i + firstCol >= table.ColumnCount)
                    return;
                for (int j = 0; j < dataTable[0].Length; j++)
                {
                    if (j + firstRow >= table.RowCount)
                        table.Rows.Add();
                    table[i + firstCol, j + firstRow].Value = dataTable[i][j];

                }
            }
        }

        /*
         * Creates an array from DataGridView table data.
         */
        static public void parseTable(DataGridView table, TextBox box)
        {
            realDataTable = new double[table.ColumnCount][];
            for (int i = 0; i < realDataTable.Length; i++)
                realDataTable[i] = new double[table.RowCount];

            for (int j = 0; j < realDataTable.Length; j++)
            {
                
                for (int i = 0; i < table.RowCount; i++)
                {
                    double dub;
                    bool isit = double.TryParse((table[j, i]?.Value?.ToString())?.Replace('.', ','), out dub);

                    if (!isit || dub == 0)
                    {
                        continue;
                    }
                    else
                    {
                        realDataTable[j][i] = dub;
                    }
                }
            }
            for (int i = 0; i < realDataTable.Length; i++)
                realDataTable[i] = realDataTable[i].TakeWhile(x => x != 0).ToArray();

            box.Clear();
            foreach(double[] i in realDataTable)
            {
                foreach (double j in i)
                    box.Text += j + " ";
                box.Text += "\r\n";
            }
        }
        /*
         * Approximates, cuts realDataArray, creates points array for drawing graphs
         */
        static public void graphPoints(TextBox box)
        {
            box.Clear();
            if (realDataTable[0].Length == 0)
                return;
            // Порядок полиномальной функции
            int p = 3;
            double[][] funcs = new double[realDataTable.Length - 1][];

            /*
             * 1.Посчитать функции апроксимации для каждого столбца.
             * 2.Создать массив с точками для построения графиков.
             */


            for (int i = 1; i < realDataTable.Length; i++)
            {
                if (realDataTable[i].Length == 0)
                    break;
                
                int rowMax = realDataTable[0].Length > realDataTable[i].Length ? realDataTable[i].Length : realDataTable[0].Length;
                if (rowMax < 4 || rowMax == 0)
                    continue;
               
                funcs[i-1] = Fit.Polynomial(realDataTable[0].Take(rowMax).ToArray(), realDataTable[i].Take(rowMax).ToArray(), p);

            }

            foreach (double[] i in funcs)
            {
                if (i == null)
                    continue;
                foreach (double j in i)
                    box.Text += j + " ";
                box.Text += "\r\n ";
            }
        }
    }
}
