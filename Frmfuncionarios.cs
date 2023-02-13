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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TextNome.Enabled = true;
            TextCpf.Enabled= true;
            TextEndereço.Enabled= true;
            TextBairro.Enabled= true;
            TextCep.Enabled= true;
            TextTelefone.Enabled= true;
            TextEmail.Enabled= true;
            BtnSalvar.Enabled= true;
            BtnNovo.Enabled= false;
            BtnExcluir.Enabled= false;
            BtnCancelar.Enabled = true;
            BtnLocalizar.Enabled= false;
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TextNome.Enabled = false;
            TextCpf.Enabled = false;
            TextEndereço.Enabled = false;
            TextBairro.Enabled = false;
            TextCep.Enabled = false;
            TextTelefone.Enabled = false;
            TextEmail.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnNovo.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnLocalizar.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
