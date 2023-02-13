using System;
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
            TextN.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            BtnLocalizar.Enabled = false;

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
            TextN.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnLocalizar.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
