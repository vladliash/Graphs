
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
        static double[,] realDataTable;
        static double[][] points;
        static int[] rowMax;

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
            rowMax = new int[6];
            rowMax[0] = table.RowCount;
            box.Text = rowMax[0].ToString();
            realDataTable = new double[table.ColumnCount, table.RowCount];

            for (int j = 0; j < realDataTable.GetLength(0); j++)
            {
                
                for (int i = 0; i < rowMax[0]; i++)
                {
                    double dub;
                    bool isit = double.TryParse((table[j, i]?.Value?.ToString())?.Replace('.', ','), out dub);

                    if (!isit || dub == 0)
                    {
                        rowMax[j] = i;
                        break;
                    }
                    else
                    {
                        realDataTable[j, i] = dub;
                        rowMax[j] += 1;
                    }
                }
            }
        }
        /*
         * Approximates, cuts realDataArray, creates points array for drawing graphs
         */
        static public void graphPoints()
        {
            // Порядок полиномальной функции
            int p = 3;
            double[,] funcs = new double[5,p+1];
            /*
             * 1. Посчитать функции апроксимации для каждого столбца.
             * 2. Создать массив с точками для построения графиков.
             */

        }
    }
}
