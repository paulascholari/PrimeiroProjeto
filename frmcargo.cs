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
    public partial class frmcargo : Form
    {
        public frmcargo()
        {
            InitializeComponent();
        }
        private void limpar()
        {

        }
        private void frmcargo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            txtCargo.Enabled = true;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = false;

           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
