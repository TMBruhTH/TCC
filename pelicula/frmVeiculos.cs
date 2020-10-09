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
    public partial class frmVeiculos : Form
    {
        public frmVeiculos()
        {
            InitializeComponent();
        }

        private void frmVeiculos_Load(object sender, EventArgs e)
        {
            List<Camadas.Model.cliente> ListaClientes = new List<Camadas.Model.cliente>();
            Camadas.BLL.cliente bllClientes = new Camadas.BLL.cliente();
            ListaClientes = bllClientes.Select();
            comboCliente.DisplayMember = "nome";
            comboCliente.ValueMember = "idCliente";
            comboCliente.DataSource = ListaClientes;

            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            comboCliente.SelectedValue = "";
            textVeiculo.Text = "";
            textModelo.Text = "";
            textChassi.Text = "";
            textAno.Text = "";
            maskPlaca.Text = "";
            maskPlaca.Mask = "";
        }

        void Habilita(bool status)
        {
            comboCliente.Enabled = status;
            textVeiculo.Enabled = status;
            textModelo.Enabled = status;
            textChassi.Enabled = status;
            textAno.Enabled = status;
            maskPlaca.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
        }

        void LetrasMaiusculas()
        {
            textVeiculo.CharacterCasing = CharacterCasing.Upper;
            textModelo.CharacterCasing = CharacterCasing.Upper;
            textChassi.CharacterCasing = CharacterCasing.Upper;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(comboCliente.Text.Trim()))
            {
                MessageBox.Show("O campo cliente é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboCliente.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textVeiculo.Text.Trim()))
            {
                MessageBox.Show("O campo veiculo é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textVeiculo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textModelo.Text.Trim()))
            {
                MessageBox.Show("O campo modelo é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textModelo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textChassi.Text.Trim()))
            {
                MessageBox.Show("O campo chassi é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textChassi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textAno.Text.Trim()))
            {
                MessageBox.Show("O campo ano é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textAno.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskPlaca.Text.Trim()))
            {
                MessageBox.Show("O campo placa é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskPlaca.Focus();
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo veiculo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                comboCliente.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.veiculo veiculos = new Camadas.Model.veiculo();
                Camadas.BLL.veiculo bllVeiculos = new Camadas.BLL.veiculo();
                veiculos.idVeiculo = Convert.ToInt32(lblid.Text);
                veiculos.idCiente = Convert.ToInt32(comboCliente.SelectedValue);
                veiculos.nome = textVeiculo.Text;
                veiculos.modelo = textModelo.Text;
                veiculos.chassi = textChassi.Text;
                veiculos.ano = textAno.Text;
                veiculos.placa = maskPlaca.Text;
                if (veiculos.idVeiculo == -1)
                    bllVeiculos.Insert(veiculos);
                else bllVeiculos.Update(veiculos);

                if (MessageBox.Show("Deseja incluir o veiculo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Veiculo incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                comboCliente.Focus();
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
                    Camadas.Model.veiculo veiculos = new Camadas.Model.veiculo();
                    Camadas.BLL.veiculo bllVeiculos = new Camadas.BLL.veiculo();
                    veiculos.idVeiculo = Convert.ToInt32(lblid.Text);
                    veiculos.idCiente = Convert.ToInt32(comboCliente.SelectedValue);
                    veiculos.nome = textVeiculo.Text;
                    veiculos.modelo = textModelo.Text;
                    veiculos.chassi = textChassi.Text;
                    veiculos.ano = textAno.Text;
                    veiculos.placa = maskPlaca.Text;
                    bllVeiculos.Delete(veiculos);
                    dgvVeiculo.DataSource = (from p in bllVeiculos.Select()
                                             select new
                                             {
                                                 Veiculo = p.idVeiculo,
                                                 Cliente = new Camadas.BLL.cliente().Select().FirstOrDefault(c => c.idCliente == p.idCiente)?.nome ?? "Não encontrado",
                                                 Nome = p.nome,
                                                 Modelo = p.modelo,
                                                 Chassi = p.chassi,
                                                 Ano = p.ano,
                                                 Placa = p.placa
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

        private void dgvVeiculo_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvVeiculo.SelectedRows.Count > 0)
            {
                lblid.Text = dgvVeiculo.SelectedRows[0].Cells[0].Value.ToString();
                comboCliente.Text = dgvVeiculo.SelectedRows[0].Cells[1].Value.ToString();
                textVeiculo.Text = dgvVeiculo.SelectedRows[0].Cells[2].Value.ToString();
                textModelo.Text = dgvVeiculo.SelectedRows[0].Cells[3].Value.ToString();
                textChassi.Text = dgvVeiculo.SelectedRows[0].Cells[4].Value.ToString();
                textAno.Text = dgvVeiculo.SelectedRows[0].Cells[5].Value.ToString();
                maskPlaca.Text = dgvVeiculo.SelectedRows[0].Cells[6].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.veiculo bllVeiculo = new Camadas.BLL.veiculo();
            dgvVeiculo.DataSource = (from p in bllVeiculo.Select()
                                     select new
                                     {
                                         Veiculo = p.idVeiculo,
                                         Cliente = new Camadas.BLL.cliente().Select().FirstOrDefault(c => c.idCliente == p.idCiente)?.nome ?? "Não encontrado",
                                         Nome = p.nome,
                                         Modelo = p.modelo,
                                         Chassi = p.chassi,
                                         Ano = p.ano,
                                         Placa = p.placa
                                     }).ToList();
            btnGravar.Enabled = true;
        }

        private void textAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(maskPlaca.Mask != null)
            {
                maskPlaca.Mask = "AAA-0000";
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioVeiculos formRelaVeiculos = new frmRelatorioVeiculos();
            formRelaVeiculos.ShowDialog();
            formRelaVeiculos.Dispose();
        }
    }
}
