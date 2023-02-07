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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TextName.Enabled = true;
            TextCnpj.Enabled = true;
            TextEndereço.Enabled = true;
            TextBairro.Enabled = true;
            TextCep.Enabled = true;
            TextTelefone.Enabled = true;
            TextEmail.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TextName.Enabled = false;
            TextCnpj.Enabled = false;
            TextEndereço.Enabled = false;
            TextBairro.Enabled = false;
            TextCep.Enabled = false;
            TextTelefone.Enabled = false;
            TextEmail.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}