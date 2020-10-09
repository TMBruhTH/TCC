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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            textCliente.Text = "";
            maskData.Text = "";
        }

        void Habilita(bool status)
        {
            textCliente.Enabled = status;
            maskData.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
        }

        void LetrasMaiusculas()
        {
            textCliente.CharacterCasing = CharacterCasing.Upper;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(textCliente.Text.Trim()))
            {
                MessageBox.Show("O campo cliente é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textCliente.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskData.Text.Trim()))
            {
                MessageBox.Show("O campo data é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskData.Focus();
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                textCliente.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.agendamento agenda = new Camadas.Model.agendamento();
                Camadas.BLL.agendamento bllAgenda = new Camadas.BLL.agendamento();
                agenda.idAgendamento = Convert.ToInt32(lblid.Text);
                agenda.cliente = textCliente.Text;
                agenda.data = maskData.Text;
                if (agenda.idAgendamento == -1)
                    bllAgenda.Insert(agenda);
                else bllAgenda.Update(agenda);

                if (MessageBox.Show("Deseja incluir o agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Agendamento incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                textCliente.Focus();
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
                    Camadas.Model.agendamento agenda = new Camadas.Model.agendamento();
                    Camadas.BLL.agendamento bllAgenda = new Camadas.BLL.agendamento();
                    agenda.idAgendamento = Convert.ToInt32(lblid.Text);
                    agenda.cliente = textCliente.Text;
                    agenda.data = maskData.Text;
                    bllAgenda.Delete(agenda);
                    dgvAgendamento.DataSource = (from p in bllAgenda.Select()
                                                 select new
                                                 {
                                                     Agenda = p.idAgendamento,
                                                     Cliente = p.cliente,
                                                     Data = p.data
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
            Camadas.BLL.agendamento bllAgenda = new Camadas.BLL.agendamento();
            dgvAgendamento.DataSource = (from p in bllAgenda.Select()
                                         select new
                                         {
                                             Agenda = p.idAgendamento,
                                             Cliente = p.cliente,
                                             Data = p.data
                                       }).ToList();
            btnGravar.Enabled = true;
        }

        private void dgvAgendamento_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAgendamento.SelectedRows.Count > 0)
            {
                lblid.Text = dgvAgendamento.SelectedRows[0].Cells[0].Value.ToString();
                textCliente.Text = dgvAgendamento.SelectedRows[0].Cells[1].Value.ToString();
                maskData.Text = dgvAgendamento.SelectedRows[0].Cells[2].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void maskData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(maskData.Mask != null)
            {
                maskData.Mask = "00/00/0000";
            }

            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
