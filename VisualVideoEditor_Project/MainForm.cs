﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualVideoEditor_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            InitializeComponent();
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
