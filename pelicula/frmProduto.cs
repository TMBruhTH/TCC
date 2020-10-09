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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            List<Camadas.Model.fornecedor> listaFornecedor = new List<Camadas.Model.fornecedor>();
            Camadas.BLL.fornecedor bllFornecedor = new Camadas.BLL.fornecedor();
            listaFornecedor = bllFornecedor.Select();
            comboFornecedor.DisplayMember = "razao_social";
            comboFornecedor.ValueMember = "idFornecedor";
            comboFornecedor.DataSource = listaFornecedor;

            List<Camadas.Model.tipo_prod> ListaTipo = new List<Camadas.Model.tipo_prod>();
            Camadas.BLL.tipo_prod bllTipo_prod = new Camadas.BLL.tipo_prod();
            ListaTipo = bllTipo_prod.Select();
            comboTipo.DisplayMember = "tipo";
            comboTipo.ValueMember = "idTipo_prod";
            comboTipo.DataSource = ListaTipo;

            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        void LetrasMaiusculas()
        {
            textTonalidade.CharacterCasing = CharacterCasing.Upper;
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            comboFornecedor.SelectedValue = "";
            comboTipo.SelectedValue = "";
            textTonalidade.Text = "";
            textValor.Text = "";
        }

        void Habilita(bool status)
        {
            comboFornecedor.Enabled = status;
            comboTipo.Enabled = status;
            textTonalidade.Enabled = status;
            textValor.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(comboFornecedor.Text.Trim()))
            {
                MessageBox.Show("O campo fornecedor é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboFornecedor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboTipo.Text.Trim()))
            {
                MessageBox.Show("O campo tipo é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboTipo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textTonalidade.Text.Trim()))
            {
                MessageBox.Show("O campo tonalidae é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textTonalidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textValor.Text.Trim()))
            {
                MessageBox.Show("O campo valor é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textValor.Focus();
                return false;
            }

            return true;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                comboFornecedor.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.produto produto = new Camadas.Model.produto();
                Camadas.BLL.produto bllProduto = new Camadas.BLL.produto();
                produto.idProduto = Convert.ToInt32(lblid.Text);
                produto.idFornecedor = Convert.ToInt32(comboFornecedor.SelectedValue);
                produto.idTipo_prod = Convert.ToInt32(comboTipo.SelectedValue);
                produto.tonalidade = textTonalidade.Text;
                produto.valor = Convert.ToDouble(textValor.Text);
                if (produto.idProduto == -1)
                    bllProduto.Insert(produto);
                else bllProduto.Update(produto);

                if (MessageBox.Show("Deseja incluir o produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Produto incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    Habilita(false);
                }
                else
                {
                    LimpaCampos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblid.Text != "-1")
            {
                Habilita(true);
                comboFornecedor.Focus();
            }
            else
            {
                MessageBox.Show("Não há nenhum registro para ser editado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToInt32(lblid.Text) != -1)
                {
                    Camadas.Model.produto produto = new Camadas.Model.produto();
                    Camadas.BLL.produto bllProduto = new Camadas.BLL.produto();
                    produto.idProduto = Convert.ToInt32(lblid.Text);
                    produto.idFornecedor = Convert.ToInt32(comboFornecedor.SelectedValue);
                    produto.idTipo_prod = Convert.ToInt32(comboTipo.SelectedValue);
                    produto.tonalidade = textTonalidade.Text;
                    produto.valor = Convert.ToDouble(textValor.Text);
                    bllProduto.Delete(produto);
                    dgvProduto.DataSource = (from p in bllProduto.Select()
                                             select new
                                             {
                                                 Produto = p.idProduto,
                                                 Fornecedor = new Camadas.BLL.fornecedor().Select().FirstOrDefault(t => t.idFornecedor == p.idFornecedor)?.razao_social ?? "Não encontrado",
                                                 TipoProduto = new Camadas.BLL.tipo_prod().Select().FirstOrDefault(t => t.idTipo_prod == p.idTipo_prod)?.tipo ?? "Não encontrado",
                                                 Tonalidade = p.tonalidade,
                                                 Valor = p.valor
                                             }).ToList();
                }
                else
                {
                    MessageBox.Show("Não há nenhum cadastro para ser excluído!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            LimpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(false);
                Botoes(false);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.produto bllProduto = new Camadas.BLL.produto();
            dgvProduto.DataSource = (from p in bllProduto.Select()
                                       select new
                                       {
                                           Produto = p.idProduto,
                                           Fornecedor = new Camadas.BLL.fornecedor().Select().FirstOrDefault(t => t.idFornecedor == p.idFornecedor)?.razao_social ?? "Não encontrado",
                                           TipoProduto = new Camadas.BLL.tipo_prod().Select().FirstOrDefault(t => t.idTipo_prod == p.idTipo_prod)?.tipo ?? "Não encontrado",
                                           Tonalidade = p.tonalidade,
                                           Valor = p.valor
                                       }).ToList();
            btnGravar.Enabled = true;
        }

        private void dgvProduto_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0)
            {
                lblid.Text = dgvProduto.SelectedRows[0].Cells[0].Value.ToString();
                comboFornecedor.Text = dgvProduto.SelectedRows[0].Cells[1].Value.ToString();
                comboTipo.Text = dgvProduto.SelectedRows[0].Cells[2].Value.ToString();
                textTonalidade.Text = dgvProduto.SelectedRows[0].Cells[3].Value.ToString();
                textValor.Text = dgvProduto.SelectedRows[0].Cells[4].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto formRelaProduto = new frmRelatorioProduto();
            formRelaProduto.ShowDialog();
            formRelaProduto.Dispose();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            frmTipo_prod formTipo_prod = new frmTipo_prod();
            formTipo_prod.ShowDialog();
            formTipo_prod.Dispose();
        }
    }
}
