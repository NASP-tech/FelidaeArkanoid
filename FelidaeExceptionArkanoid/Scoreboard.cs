﻿using System;
using System.Windows.Forms;

namespace FelidaeExceptionArkanoid
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 Menu = new Form1();
            Menu.Show();
            this.Close();
        }
    }
}