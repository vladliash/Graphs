﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTable.Rows.Clear();
            inputTable.Rows.Add(24);
        }
    }
}
