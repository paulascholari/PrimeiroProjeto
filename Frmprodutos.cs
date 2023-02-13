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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TextNomeEmpresa.Enabled = true;
            TextCnpj.Enabled = true;
            TextNomeProduto.Enabled = true;
            TextQuantidade.Enabled = true;  
            TextCodigoProdutos.Enabled = true;
            TextDescrição.Enabled = true;
            BtnNovo.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnSalvar.Enabled = true;
            btnLocalizar.Enabled = false;
        }   

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TextNomeEmpresa.Enabled = false;
            TextCnpj.Enabled = false;
            TextNomeProduto.Enabled = false;
            TextQuantidade.Enabled = false;
            TextCodigoProdutos.Enabled = false;
            TextDescrição.Enabled = false;
            BtnNovo.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnSalvar.Enabled = false;
            btnLocalizar.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
