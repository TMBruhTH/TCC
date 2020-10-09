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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo serviço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                comboCliente.Focus();
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            List<Camadas.Model.cliente> ListaCliente = new List<Camadas.Model.cliente>();
            Camadas.BLL.cliente bllCliente = new Camadas.BLL.cliente();
            ListaCliente = bllCliente.Select();
            comboCliente.DisplayMember = "nome";
            comboCliente.ValueMember = "idCliente";
            comboCliente.DataSource = ListaCliente;

            List<Camadas.Model.veiculo> ListaVeiculo = new List<Camadas.Model.veiculo>();
            Camadas.BLL.veiculo bllVeiculo = new Camadas.BLL.veiculo();
            ListaVeiculo = bllVeiculo.Select();
            comboVeiculo.DisplayMember = "nome";
            comboVeiculo.ValueMember = "idVeiculo";
            comboVeiculo.DataSource = ListaVeiculo;

            List<Camadas.Model.produto> ListaProduto = new List<Camadas.Model.produto>();
            Camadas.BLL.produto bllProduto = new Camadas.BLL.produto();
            ListaProduto = bllProduto.Select();
            comboProduto.DisplayMember = "tonalidade";
            comboProduto.ValueMember = "idProduto";
            comboProduto.DataSource = ListaProduto;

            List<Camadas.Model.funcionario> ListaFuncionario = new List<Camadas.Model.funcionario>();
            Camadas.BLL.funcionario bllFuncionario = new Camadas.BLL.funcionario();
            ListaFuncionario = bllFuncionario.Select();
            comboFuncionario.DisplayMember = "nome";
            comboFuncionario.ValueMember = "idFuncionario";
            comboFuncionario.DataSource = ListaFuncionario;

            List<Camadas.Model.tipo_prod> ListaTipo = new List<Camadas.Model.tipo_prod>();
            Camadas.BLL.tipo_prod bllTipo = new Camadas.BLL.tipo_prod();
            ListaTipo = bllTipo.Select();
            comboTipo.DisplayMember = "tipo";
            comboTipo.ValueMember = "idTipo_prod";
            comboTipo.DataSource = ListaTipo;

            List<Camadas.Model.tipo_serv> ListaServ_lateral = new List<Camadas.Model.tipo_serv>();
            Camadas.BLL.tipo_serv bllServ_lateral = new Camadas.BLL.tipo_serv();
            ListaServ_lateral = bllServ_lateral.Select();
            comboServ_lateral.DisplayMember = "serv_lateral";
            comboServ_lateral.ValueMember = "idTipo_serv";
            comboServ_lateral.DataSource = ListaServ_lateral;

            List<Camadas.Model.tipo_serv> ListaServ_frontal = new List<Camadas.Model.tipo_serv>();
            Camadas.BLL.tipo_serv bllServ_frontal = new Camadas.BLL.tipo_serv();
            ListaServ_frontal = bllServ_frontal.Select();
            comboServ_frontal.DisplayMember = "serv_frontal";
            comboServ_frontal.ValueMember = "idTipo_serv";
            comboServ_frontal.DataSource = ListaServ_frontal;

            /*List<Camadas.Model.status> ListaStatus = new List<Camadas.Model.status>();
            Camadas.BLL.status bllStatus = new Camadas.BLL.status();
            ListaStatus = bllStatus.Select();
            comboStatus.DisplayMember = "desc_status";
            comboStatus.ValueMember = "idStatus";
            comboStatus.DataSource = ListaStatus;*/

            LimpaCampos();
            Habilita(false);
            Botoes(false);
            btnPreServico.Enabled = false;
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            comboCliente.Text = "";
            comboVeiculo.Text = "";
            comboProduto.Text = "";
            comboFuncionario.Text = "";
            comboTipo.Text = "";
            comboServ_lateral.Text = "";
            comboServ_frontal.Text = "";
            textValor.Text = "";
            labelStatus.Text = "";
            //comboStatus.Text = "";
        }

        void Habilita(bool status)
        {
            comboCliente.Enabled = status;
            comboVeiculo.Enabled = status;
            comboProduto.Enabled = status;
            comboFuncionario.Enabled = status;
            comboTipo.Enabled = status;
            comboServ_lateral.Enabled = status;
            comboServ_frontal.Enabled = status;
            textValor.Enabled = status;
            //comboStatus.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(comboCliente.Text.Trim()))
            {
                MessageBox.Show("O campo cliente é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboCliente.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboVeiculo.Text.Trim()))
            {
                MessageBox.Show("O campo veiculo é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboVeiculo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboProduto.Text.Trim()))
            {
                MessageBox.Show("O campo produto é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboProduto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboFuncionario.Text.Trim()))
            {
                MessageBox.Show("O campo tipo de produto é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboFuncionario.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboTipo.Text.Trim()))
            {
                MessageBox.Show("O campo tipo de produto é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboTipo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboServ_lateral.Text.Trim()))
            {
                MessageBox.Show("O campo serviço lateral é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboServ_lateral.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboServ_frontal.Text.Trim()))
            {
                MessageBox.Show("O campo serviço frontal é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboServ_frontal.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textValor.Text.Trim()))
            {
                MessageBox.Show("O campo valor é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textValor.Focus();
                return false;
            }

            /*if (string.IsNullOrEmpty(labelStatus.Text.Trim()))
            {
                MessageBox.Show("O campo status é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                labelStatus.Focus();
                return false;
            }*/
            return true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.servico servico = new Camadas.Model.servico();
                Camadas.BLL.servico bllServico = new Camadas.BLL.servico();
                servico.idServico = Convert.ToInt32(lblid.Text);
                servico.idCliente = Convert.ToInt32(comboCliente.SelectedValue);
                servico.idVeiculo = Convert.ToInt32(comboVeiculo.SelectedValue);
                servico.idProduto = Convert.ToInt32(comboProduto.SelectedValue);
                servico.idFuncionario = Convert.ToInt32(comboFuncionario.SelectedValue);
                servico.tipo = comboTipo.Text;
                servico.serv_lateral = comboServ_lateral.Text;
                servico.serv_frontal = comboServ_frontal.Text;
                servico.valor = Convert.ToDouble(textValor.Text);
                servico.status = "ABERTO";
                if (servico.idServico == -1)
                    bllServico.Insert(servico);
                else bllServico.Update(servico);

                if (MessageBox.Show("Deseja incluir um Serviço?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Serviço incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Não há nenhum orçamento para ser editado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            btnPreServico.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToInt32(lblid.Text) != -1)
                {
                    Camadas.Model.servico servico = new Camadas.Model.servico();
                    Camadas.BLL.servico bllServico = new Camadas.BLL.servico();
                    servico.idServico = Convert.ToInt32(lblid.Text);
                    servico.idCliente = Convert.ToInt32(comboCliente.SelectedValue);
                    servico.idVeiculo = Convert.ToInt32(comboVeiculo.SelectedValue);
                    servico.idProduto = Convert.ToInt32(comboProduto.SelectedValue);
                    servico.idFuncionario = Convert.ToInt32(comboFuncionario.SelectedValue);
                    //servico.idTipo_prod = Convert.ToInt32(comboTipo.SelectedValue);
                    servico.tipo = comboTipo.Text;
                    servico.serv_lateral = comboServ_lateral.Text;
                    servico.serv_frontal = comboServ_frontal.Text;
                    servico.valor = Convert.ToDouble(textValor.Text);
                    servico.status = "";
                    bllServico.Delete(servico);
                    dgvServico.DataSource = (from p in bllServico.Select()
                                             select new
                                             {
                                                 Serviço = p.idServico,
                                                 Cliente = new Camadas.BLL.cliente().Select().FirstOrDefault(t => t.idCliente == p.idCliente)?.nome ?? "Não encontrado",
                                                 Veiculo = new Camadas.BLL.veiculo().Select().FirstOrDefault(t => t.idVeiculo == p.idVeiculo)?.nome ?? "Não encontrado",
                                                 Produto = new Camadas.BLL.produto().Select().FirstOrDefault(t => t.idProduto == p.idProduto)?.tonalidade ?? "Não encontrado",
                                                 Funcionario = new Camadas.BLL.funcionario().Select().FirstOrDefault(t => t.idFuncionario == p.idFuncionario)?.nome ?? "Não encontrado",
                                                 //TipoProduto = new Camadas.BLL.tipo_prod().Select().FirstOrDefault(t => t.idTipo_prod == p.idTipo_prod)?.tipo ?? "Não encontrado",
                                                 //TipoServiço = new Camadas.BLL.tipo_serv().Select().FirstOrDefault(t => t.idTipo_serv == p.idTipo_serv)?.idTipo_serv.ToString() ?? "Não encontrado",
                                                 Tipo = p.tipo,
                                                 ServiçoLateral = p.serv_lateral,
                                                 ServiçoFrontal = p.serv_frontal,
                                                 Valor = p.valor,
                                                 Status = p.status
                                             }).ToList();
                }
                else
                {
                    MessageBox.Show("Não há nenhum cadastro para ser excluído!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            btnPreServico.Enabled = false;
            LimpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(false);
                Botoes(false);
                btnPreServico.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.servico bllServico = new Camadas.BLL.servico();
            dgvServico.DataSource = (from p in bllServico.Select()
                                     select new
                                     {
                                         Serviço = p.idServico,
                                         Cliente = new Camadas.BLL.cliente().Select().FirstOrDefault(t => t.idCliente == p.idCliente)?.nome ?? "Não encontrado",
                                         Veiculo = new Camadas.BLL.veiculo().Select().FirstOrDefault(t => t.idVeiculo == p.idVeiculo)?.nome ?? "Não encontrado",
                                         Produto = new Camadas.BLL.produto().Select().FirstOrDefault(t => t.idProduto == p.idProduto)?.tonalidade ?? "Não encontrado",
                                         Funcionario = new Camadas.BLL.funcionario().Select().FirstOrDefault(t => t.idFuncionario == p.idFuncionario)?.nome ?? "Não encontrado",
                                         //TipoProduto = new Camadas.BLL.tipo_prod().Select().FirstOrDefault(t => t.idTipo_prod == p.idTipo_prod)?.tipo ?? "Não encontrado",
                                         //TipoServiço = new Camadas.BLL.tipo_serv().Select().FirstOrDefault(t => t.idTipo_serv == p.idTipo_serv)?.idTipo_serv.ToString() ?? "Não encontrado",
                                         Tipo = p.tipo,
                                         ServiçoLateral = p.serv_lateral,
                                         ServiçoFrontal = p.serv_frontal,
                                         Valor = p.valor,
                                         Status = p.status
                                     }).ToList();
            btnGravar.Enabled = true;
            btnPreServico.Enabled = true;
        }

        private void dgvServico_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvServico.SelectedRows.Count > 0)
            {
                lblid.Text = dgvServico.SelectedRows[0].Cells[0].Value.ToString();
                comboCliente.Text = dgvServico.SelectedRows[0].Cells[1].Value.ToString();
                comboVeiculo.Text = dgvServico.SelectedRows[0].Cells[2].Value.ToString();
                comboProduto.Text = dgvServico.SelectedRows[0].Cells[3].Value.ToString();
                comboFuncionario.Text = dgvServico.SelectedRows[0].Cells[4].Value.ToString();
                comboTipo.Text = dgvServico.SelectedRows[0].Cells[5].Value.ToString();
                comboServ_lateral.Text = dgvServico.SelectedRows[0].Cells[6].Value.ToString();
                comboServ_frontal.Text = dgvServico.SelectedRows[0].Cells[7].Value.ToString();
                textValor.Text = dgvServico.SelectedRows[0].Cells[8].Value.ToString();
                labelStatus.Text = dgvServico.SelectedRows[0].Cells[9].Value.ToString();
                //comboStatus.Text = dgvServico.SelectedRows[0].Cells[9].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnTipo_serv_Click(object sender, EventArgs e)
        {
            frmTipo_serv formTipo_serv = new frmTipo_serv();
            formTipo_serv.ShowDialog();
            formTipo_serv.Dispose();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btnPreServico_Click(object sender, EventArgs e)
        {
            Camadas.BLL.servico bllSrv = new Camadas.BLL.servico();
            Camadas.Model.servico srv = new Camadas.Model.servico();
            srv.idServico = Convert.ToInt32(lblid.Text);
            srv.idCliente = Convert.ToInt32(comboCliente.SelectedValue);
            srv.valor = Convert.ToDouble(textValor.Text);
            srv.status = "PRÉ SERVIÇO";
            bllSrv.PreServico(srv);
            MessageBox.Show("Ordem de serviço " + srv.idServico + " está no caixa!");
            this.Close();
        }
    }
}
