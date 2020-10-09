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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            /*List<Camadas.Model.status> ListaStatus = new List<Camadas.Model.status>();
            Camadas.BLL.status bllStatus = new Camadas.BLL.status();
            ListaStatus = bllStatus.Select();
            comboStatus.DisplayMember = "desc_status";
            comboStatus.ValueMember = "idStatus";
            comboStatus.DataSource = ListaStatus;*/

            List<Camadas.Model.pagamento> ListaPgt = new List<Camadas.Model.pagamento>();
            Camadas.BLL.pagamento bllPgt = new Camadas.BLL.pagamento();
            ListaPgt = bllPgt.Select();
            comboPagamento.DisplayMember = "desc_pagamento";
            comboPagamento.ValueMember = "idPagamento";
            comboPagamento.DataSource = ListaPgt;


            LimpaCampos();
            Habilita(false);
            //HabilitaRegra(false);
        }

        void LimpaCampos()
        {
            lblid.Text = "";
            labelServico.Text = "";
            labelCliente.Text = "";
            labelValor.Text = "";
            comboPagamento.Text = "";
            maskData.Text = "";
            maskData.Mask = "";
            labelStatus.Text = "";
        }

        void Habilita(bool status)
        {
            comboPagamento.Enabled = status;
            maskData.Enabled = status;
            //comboStatus.Enabled = status;
        }

        void HabilitaRegra(bool status)
        {
            labelServico.Enabled = status;
            labelCliente.Enabled = status;
            labelValor.Enabled = status;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(labelServico.Text.Trim()))
            {
                MessageBox.Show("O campo serviço é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                labelServico.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(labelCliente.Text.Trim()))
            {
                MessageBox.Show("O campo cliente é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                labelCliente.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(labelValor.Text.Trim()))
            {
                MessageBox.Show("O campo valor é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                labelValor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(comboPagamento.Text.Trim()))
            {
                MessageBox.Show("O campo pagamento é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboPagamento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskData.Text.Trim()))
            {
                MessageBox.Show("O campo data é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskData.Focus();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.caixa caixa = new Camadas.Model.caixa();
                Camadas.BLL.caixa bllCaixa = new Camadas.BLL.caixa();
                caixa.idCaixa = Convert.ToInt32(lblid.Text);
                caixa.idServico = Convert.ToInt32(labelServico.Text);
                caixa.cliente = Convert.ToInt32(labelCliente.Text);
                caixa.valor = Convert.ToDouble(labelValor.Text);
                caixa.parcela = comboPagamento.Text;
                caixa.dataPagamento = maskData.Text;
                caixa.status = "SERVIÇO FECHADO";
                if (caixa.idCaixa == -1)
                    bllCaixa.Insert(caixa);
                else bllCaixa.Update(caixa);
                MessageBox.Show("Serviço " + caixa.idServico + " fechado com sucesso!");
                LimpaCampos();
                Habilita(false);
            }
        }

        private void dgvCaixa_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCaixa.SelectedRows.Count > 0)
            {
                lblid.Text = dgvCaixa.SelectedRows[0].Cells[0].Value.ToString();
                labelServico.Text = dgvCaixa.SelectedRows[0].Cells[1].Value.ToString();
                labelCliente.Text = dgvCaixa.SelectedRows[0].Cells[2].Value.ToString();
                labelValor.Text = dgvCaixa.SelectedRows[0].Cells[3].Value.ToString();
                comboPagamento.Text = dgvCaixa.SelectedRows[0].Cells[4].Value.ToString();
                maskData.Text = dgvCaixa.SelectedRows[0].Cells[5].Value.ToString();
                labelStatus.Text = dgvCaixa.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.caixa bllCaixa = new Camadas.BLL.caixa();
            dgvCaixa.DataSource = (from p in bllCaixa.Select()
                                   select new
                                   {
                                       Caixa = p.idCaixa,
                                       Serviço = new Camadas.BLL.servico().Select().FirstOrDefault(t => t.idServico == p.idServico)?.idServico.ToString() ?? "Não encontrado",
                                       Cliente = p.cliente,
                                       Valor = p.valor,
                                       Parcela = p.parcela,
                                       DataPagamento = p.dataPagamento,
                                       Status = p.status
                                   }).ToList();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblid.Text != "-1")
            {
                Habilita(true);
                comboPagamento.Focus();
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
                    Camadas.Model.caixa caixa = new Camadas.Model.caixa();
                    Camadas.BLL.caixa bllCaixa = new Camadas.BLL.caixa();
                    caixa.idCaixa = Convert.ToInt32(lblid.Text);
                    caixa.idServico = Convert.ToInt32(labelServico.Text);
                    caixa.cliente = Convert.ToInt32(labelCliente.Text);
                    caixa.valor = Convert.ToDouble(labelValor.Text);
                    caixa.parcela = comboPagamento.Text;
                    caixa.dataPagamento = maskData.Text;
                    caixa.status = "";
                    bllCaixa.Delete(caixa);
                    dgvCaixa.DataSource = (from p in bllCaixa.Select()
                                           select new
                                           {
                                               Caixa = p.idCaixa,
                                               Serviço = new Camadas.BLL.servico().Select().FirstOrDefault(t => t.idServico == p.idServico)?.idServico.ToString() ?? "Não encontrado",
                                               Cliente = p.cliente,
                                               Valor = p.valor,
                                               Parcela = p.parcela,
                                               DataPagamento = p.dataPagamento,
                                               Status = p.status
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
            }
        }

        private void maskData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (maskData.Mask != null)
            {
                maskData.Mask = "00/00/0000";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
