﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN_Form_Client
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void regB_Click(object sender, EventArgs e)
        {
            Form1.F1.Show();
            this.Hide();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            logBox.Text = Form1.login;
        }
    }
}
