
using MathNet.Numerics;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphs
{

    static class DataProcessing
    {
        /// <summary>
        /// Air flow at the operating point
        /// </summary>
        public static double Q = 0;
        /// <summary>
        /// Uncut array of formatted input data
        /// </summary>
        private static double[][] dataTable;

        /// <summary>
        /// Cut array of formatted input data
        /// </summary>
        private static double[][] realDataTable;

        /// <summary>
        /// Array of points of lines, approximated from realDataPoints
        /// </summary>
        public static double[][][] points;

        /// <summary>
        /// Values of certain parameters for given Q(Air flow) at the operating point
        /// </summary>
        public static double[] workPoints;
        
        /// <summary>
        /// Parces data from Clipboard into <see cref="dataTable"/>
        /// </summary>
        static public void pasteData()
        {
            char[] rowSplitter = { '\r', '\n' };
            string[] rows = Clipboard.GetText().Split(rowSplitter,StringSplitOptions.RemoveEmptyEntries);
            if (rows.Length == 0)
                return;
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
                        if (j == 4 || j == 5 || dub < 1)
                            dataTable[j][i] = dub * 100;
                        else
                            dataTable[j][i] = dub;
                    }
                }
            }
        }

        /// <summary>
        /// Fills given <see cref="DataGridView"/> table from <see cref="dataTable"/>
        /// </summary>
        /// <param name="table">Given <see cref="DataGridView"/> table</param>
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
                    if (j + firstRow +1 >= table.RowCount)
                        table.Rows.Add();
                    table[i + firstCol, j + firstRow].Value = dataTable[i][j];
                }
            }
        }

        
        /// <summary>
        /// Parces data from a <see cref="DataGridView"/> table into <see cref="realDataTable"/>
        /// </summary>
        /// <param name="table">Given <see cref="DataGridView"/> table</param>
        static public void parseTable(DataGridView table)
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
        }

        /// <summary>
        /// Updates array of @<see cref="points"/> and @<see cref="workPoints"/> by with points of lines, 
        /// which are approximated /// from @<see cref="realDataTable"/> data
        /// </summary>
        /// <param name="p">Degerre of polynom defining approximation line </param>
        /// <param name="pNum">Number of points taken from each line</param>
        static public void graphPoints(int p, int pNum)
        {
            if (realDataTable[0].Length == 0)
                return;
            double[][] funcs = new double[realDataTable.Length - 1][];
            workPoints = new double[realDataTable.Length - 1];

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

                for (int z = 0; z <= p; z++)
                    workPoints[i-1] += (funcs[i - 1][z]) * (Math.Pow(Q, z));
            }
        }

        /// <summary>
        /// Clears given collection of points and fills it with new points from given arrays of x Values and y values
        /// </summary>
        /// <param name="points">Current collection of points</param>
        /// <param name="xValues">x values of new points</param>
        /// <param name="yValues">y values of new points</param>
        static public void pointsUpdate (ref DataPointCollection points, double[] xValues, double[] yValues)
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
