﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(A_TB.Text);
            int B = Convert.ToInt32(B_TB.Text);
            int Res = A + B;
            Res_TB.Text = Convert.ToString(Res);
        }
    }
}
