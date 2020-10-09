using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelicula
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa formCaixa = new frmCaixa();
            formCaixa.ShowDialog();
            formCaixa.Dispose();
        }

        private void novoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServico formServico = new frmServico();
            formServico.ShowDialog();
            formServico.Dispose();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamento formAgenda = new frmAgendamento();
            formAgenda.ShowDialog();
            formAgenda.Dispose();
        }

        private void novoOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrcamento formOrcamento = new frmOrcamento();
            formOrcamento.ShowDialog();
            formOrcamento.Dispose();
        }

        private void novoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor formFornecedor = new frmFornecedor();
            formFornecedor.ShowDialog();
            formFornecedor.Dispose();
        }

        private void novoFuncinoárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario formFuncionario = new frmFuncionario();
            formFuncionario.ShowDialog();
            formFuncionario.Dispose();
        }

        private void novoVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculos formVeiculos = new frmVeiculos();
            formVeiculos.ShowDialog();
            formVeiculos.Dispose();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente formCliente = new frmCliente();
            formCliente.ShowDialog();
            formCliente.Dispose();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto formProduto = new frmProduto();
            formProduto.ShowDialog();
            formProduto.Dispose();
            
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
