﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFeichar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMininizar_Click(Object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
