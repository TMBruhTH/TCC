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
    public partial class frmTipo_prod : Form
    {
        public frmTipo_prod()
        {
            InitializeComponent();
        }

        private void frmTipo_prod_Load(object sender, EventArgs e)
        {
            /*List<Camadas.Model.produto> ListaProdutos = new List<Camadas.Model.produto>();
            Camadas.BLL.produto bllProdutos = new Camadas.BLL.produto();
            ListaProdutos = bllProdutos.Select();
            comboProduto.DisplayMember = "idProduto";
            comboProduto.ValueMember = "idProduto";
            comboProduto.DataSource = ListaProdutos;*/

            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            //comboProduto.SelectedValue = "";
            textTipo.Text = "";
        }

        void Habilita(bool status)
        {
            //comboProduto.Enabled = status;
            textTipo.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
        }

        void LetrasMaiusculas()
        {
            textTipo.CharacterCasing = CharacterCasing.Upper;
        }

        private bool Valida()
        {
            /*if (string.IsNullOrEmpty(comboProduto.Text.Trim()))
            {
                MessageBox.Show("O campo produto é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboProduto.Focus();
                return false;
            }*/

            if (string.IsNullOrEmpty(textTipo.Text.Trim()))
            {
                MessageBox.Show("O campo tipo é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textTipo.Focus();
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo Tipo de produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                textTipo.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.tipo_prod tipo_prod = new Camadas.Model.tipo_prod();
                Camadas.BLL.tipo_prod bllTipo_prod = new Camadas.BLL.tipo_prod();
                tipo_prod.idTipo_prod = Convert.ToInt32(lblid.Text);
                //tipo_prod.idProduto = Convert.ToInt32(comboProduto.SelectedValue);
                tipo_prod.tipo = textTipo.Text;
                if (tipo_prod.idTipo_prod == -1)
                    bllTipo_prod.Insert(tipo_prod);
                else bllTipo_prod.Update(tipo_prod);

                if (MessageBox.Show("Deseja incluir um tipo de produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Tipo de produto incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                textTipo.Focus();
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
                    Camadas.Model.tipo_prod tipo_prod = new Camadas.Model.tipo_prod();
                    Camadas.BLL.tipo_prod bllTipo_prod = new Camadas.BLL.tipo_prod();
                    tipo_prod.idTipo_prod = Convert.ToInt32(lblid.Text);
                    //tipo_prod.idProduto = Convert.ToInt32(comboProduto.SelectedValue);
                    tipo_prod.tipo = textTipo.Text;
                    bllTipo_prod.Delete(tipo_prod);
                    dgvTipo_prod.DataSource = (from p in bllTipo_prod.Select()
                                               select new
                                               {
                                                   TipoProduto = p.idTipo_prod,
                                                   //Produto = new Camadas.BLL.produto().Select().FirstOrDefault(t => t.idProduto == p.idProduto)?.tonalidade ?? "Não encontrado",
                                                   Tipo = p.tipo
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

        private void dgvTipo_prod_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvTipo_prod.SelectedRows.Count > 0)
            {
                lblid.Text = dgvTipo_prod.SelectedRows[0].Cells[0].Value.ToString();
                //comboProduto.Text = dgvTipo_prod.SelectedRows[0].Cells[1].Value.ToString();
                textTipo.Text = dgvTipo_prod.SelectedRows[0].Cells[1].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.tipo_prod bllTipo_prod = new Camadas.BLL.tipo_prod();
            dgvTipo_prod.DataSource = (from p in bllTipo_prod.Select()
                                     select new
                                     {
                                         TipoProduto= p.idTipo_prod,
                                         //Produto = new Camadas.BLL.produto().Select().FirstOrDefault(t => t.idProduto == p.idProduto)?.tonalidade ?? "Não encontrado",
                                         Tipo = p.tipo
                                     }).ToList();
            btnGravar.Enabled = true;
        }
    }
}
