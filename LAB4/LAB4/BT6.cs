﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class BT6 : Form
    {
        public BT6()
        {
            InitializeComponent();
        }

        private void BT6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}