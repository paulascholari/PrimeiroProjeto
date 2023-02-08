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

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var janela = new frmcategoria();
            janela.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var janela = new frmclientes();
            janela.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var janela = new frmFornecedores();
            janela.Show();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var janela = new Frmfuncionarios();
            janela.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var janela = new Frmprodutos();
            janela.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmlogin login =new frmlogin();
            login.ShowDialog();
        }
    }
}
