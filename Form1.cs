﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //codigo para abertura do formulario de cadastro de cargo
            var janela=new frmcargo();
            janela.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
             System.Diagnostics.Process.Start("calc");
        }
    }
}
