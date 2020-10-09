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
    public partial class frmTipo_serv : Form
    {
        public frmTipo_serv()
        {
            InitializeComponent();
        }

        private void frmTipo_serv_Load(object sender, EventArgs e)
        {
            List<Camadas.Model.tipo_prod> ListaTipoProd = new List<Camadas.Model.tipo_prod>();
            Camadas.BLL.tipo_prod bllTipoProd = new Camadas.BLL.tipo_prod();
            ListaTipoProd = bllTipoProd.Select();
            comboTipo.DisplayMember = "tipo";
            comboTipo.ValueMember = "idTipo_prod";
            comboTipo.DataSource = ListaTipoProd;

            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            comboTipo.SelectedValue = "";
            textServ_lateral.Text = "";
            textServ_frontal.Text = "";
        }

        void Habilita(bool status)
        {
            comboTipo.Enabled = status;
            textServ_lateral.Enabled = status;
            textServ_frontal.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
        }

        void LetrasMaiusculas()
        {
            textServ_lateral.CharacterCasing = CharacterCasing.Upper;
            textServ_frontal.CharacterCasing = CharacterCasing.Upper;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(comboTipo.Text.Trim()))
            {
                MessageBox.Show("O campo Tipo de produto é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboTipo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textServ_lateral.Text.Trim()))
            {
                MessageBox.Show("O campo serviço lateral é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textServ_lateral.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textServ_lateral.Text.Trim()))
            {
                MessageBox.Show("O campo serviço frontal é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textServ_frontal.Focus();
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo Tipo de serviço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                comboTipo.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.tipo_serv tipo_serv = new Camadas.Model.tipo_serv();
                Camadas.BLL.tipo_serv bllTipo_serv = new Camadas.BLL.tipo_serv();
                tipo_serv.idTipo_serv = Convert.ToInt32(lblid.Text);
                tipo_serv.idTipo_prod = Convert.ToInt32(comboTipo.SelectedValue);
                tipo_serv.serv_lateral = textServ_lateral.Text;
                tipo_serv.serv_frontal = textServ_frontal.Text;
                if (tipo_serv.idTipo_serv == -1)
                    bllTipo_serv.Insert(tipo_serv);
                else bllTipo_serv.Update(tipo_serv);

                if (MessageBox.Show("Deseja incluir um tipo de serviço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Tipo de serviço incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                comboTipo.Focus();
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
                    Camadas.Model.tipo_serv tipo_serv = new Camadas.Model.tipo_serv();
                    Camadas.BLL.tipo_serv bllTipo_serv = new Camadas.BLL.tipo_serv();
                    tipo_serv.idTipo_serv = Convert.ToInt32(lblid.Text);
                    tipo_serv.idTipo_prod = Convert.ToInt32(comboTipo.SelectedValue);
                    tipo_serv.serv_lateral = textServ_lateral.Text;
                    tipo_serv.serv_frontal = textServ_frontal.Text;
                    bllTipo_serv.Delete(tipo_serv);
                    dgvTipo_serv.DataSource = (from p in bllTipo_serv.Select()
                                               select new
                                               {
                                                   TipoServiço = p.idTipo_serv,
                                                   TipoProduto = new Camadas.BLL.tipo_prod().Select().FirstOrDefault(t => t.idTipo_prod == p.idTipo_prod)?.tipo ?? "Não encontrado",
                                                   ServiçoLateral = p.serv_lateral,
                                                   ServiçoFrontal = p.serv_frontal
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

        private void dgvTipo_serv_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvTipo_serv.SelectedRows.Count > 0)
            {
                lblid.Text = dgvTipo_serv.SelectedRows[0].Cells[0].Value.ToString();
                comboTipo.Text = dgvTipo_serv.SelectedRows[0].Cells[1].Value.ToString();
                textServ_lateral.Text = dgvTipo_serv.SelectedRows[0].Cells[2].Value.ToString();
                textServ_frontal.Text = dgvTipo_serv.SelectedRows[0].Cells[3].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.tipo_serv bllTipo_serv = new Camadas.BLL.tipo_serv();
            dgvTipo_serv.DataSource = (from p in bllTipo_serv.Select()
                                       select new
                                       {
                                           TipoServiço = p.idTipo_serv,
                                           TipoProduto = new Camadas.BLL.tipo_prod().Select().FirstOrDefault(t => t.idTipo_prod == p.idTipo_prod)?.tipo ?? "Não encontrado",
                                           ServiçoLateral = p.serv_lateral,
                                           ServiçoFrontal = p.serv_frontal
                                       }).ToList();
            btnGravar.Enabled = true;
        }

        private void btnTipo_prod_Click(object sender, EventArgs e)
        {
            frmTipo_prod formTipo_prod = new frmTipo_prod();
            formTipo_prod.ShowDialog();
            formTipo_prod.Dispose();
        }
    }
}