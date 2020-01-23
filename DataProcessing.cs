
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphs
{

    static class DataProcessing
    {
        static double[][] dataTable;
        public static double[][] realDataTable;
        public static double[][][] points;
        
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

            /*box.Clear();
            foreach(double[] i in realDataTable)
            {
                foreach (double j in i)
                    box.Text += j + " ";
                box.Text += "\r\n";
            }*/
        }
        /*
         * Approximates, cuts realDataArray, creates points array for drawing graphs
         */
        static public void graphPoints(TextBox box)
        {
            if (realDataTable[0].Length == 0)
                return;
            // Порядок полиномальной функции
            int p = 3;
            int pNum = 7;
            double[][] funcs = new double[realDataTable.Length - 1][];
            double[][] range = new double[realDataTable.Length - 1][];

            points = new double[realDataTable.Length - 1][][];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new double[2][];
                points[i][0] = new double[pNum];
                points[i][1] = new double[pNum];
            }
                

            for (int i = 1; i < realDataTable.Length; i++)
            {
                int rowMax = realDataTable[0].Length > realDataTable[i].Length ? realDataTable[i].Length : realDataTable[0].Length;
                if (rowMax < 4 || rowMax == 0)
                    continue;
               
                funcs[i-1] = Fit.Polynomial(realDataTable[0].Take(rowMax).ToArray(), realDataTable[i].Take(rowMax).ToArray(), p);

                double minX = realDataTable[0][0];
                double maxX = realDataTable[0][rowMax-1];
                double increment = (maxX - minX) / (pNum - 1);

                for (int j = 0; j < pNum; j++)
                {
                    points[i-1][0][j] = minX + increment * j;
                    double x = points[i-1][0][j];
                    points[i-1][1][j] = 0;
                    for (int z = 0; z <= p; z++)
                        points[i-1][1][j] += (funcs[i - 1][z]) * (Math.Pow(x, z));
                }
            }

            box.Clear();
            foreach (double[] i in points[0])
            {
                if (i == null)
                    continue;
                foreach (double j in i)
                    box.Text += j + " ";
                box.Text += "\r\n ";
            }
            box.Text += "\r\n" + funcs.Length;

        }


        static public void kek (ref DataPointCollection points, double[] xValues, double[] yValues)
        {
            if (xValues.Length == 0 || xValues.Length != yValues.Length)
                return;
            points.Clear();
            for (int i = 0; i < xValues.Length; i++)
            {
                points.AddXY(xValues[i], yValues[i]);
            }
        }
    }
}
