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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            textNome.Text = "";
            textEmail.Text = "";
            textRG.Text = "";
            textCPF.Text = "";
            textEndereco.Text = "";
            textNr.Text = "";
            maskCEP.Text = "";
            maskCEP.Mask = "";
            maskData.Text = "";
            maskData.Mask = "";
            textCidade.Text = "";
            textEstado.Text = "";
        }

        void Habilita(bool status)
        {
            textNome.Enabled = status;
            textEmail.Enabled = status;
            textRG.Enabled = status;
            textCPF.Enabled = status;
            textEndereco.Enabled = status;
            textNr.Enabled = status;
            maskCEP.Enabled = status;
            maskData.Enabled = status;
            textCidade.Enabled = status;
            textEstado.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
            btnCancelar.Enabled = status;
        }

        void LetrasMaiusculas()
        {
            textNome.CharacterCasing = CharacterCasing.Upper;
            textEmail.CharacterCasing = CharacterCasing.Upper;
            textCidade.CharacterCasing = CharacterCasing.Upper;
            textEndereco.CharacterCasing = CharacterCasing.Upper;
            textEstado.CharacterCasing = CharacterCasing.Upper;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(textNome.Text.Trim()))
            {
                MessageBox.Show("O campo Nome é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textEmail.Text.Trim()))
            {
                MessageBox.Show("O campo Email é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textRG.Text.Trim()))
            {
                MessageBox.Show("O campo RG é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textRG.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textCPF.Text.Trim()))
            {
                MessageBox.Show("O campo CPF é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textCPF.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textEndereco.Text.Trim()))
            {
                MessageBox.Show("O campo Endereço é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEndereco.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textNr.Text.Trim()))
            {
                MessageBox.Show("O campo Endereço é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNr.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskCEP.Text.Trim()))
            {
                MessageBox.Show("O campo CEP é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskCEP.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskData.Text.Trim()))
            {
                MessageBox.Show("O campo Data é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskData.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textCidade.Text.Trim()))
            {
                MessageBox.Show("O campo Cidade é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textEstado.Text.Trim()))
            {
                MessageBox.Show("O campo Estado é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEstado.Focus();
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                textNome.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.funcionario funcionario = new Camadas.Model.funcionario();
                Camadas.BLL.funcionario bllFuncionario = new Camadas.BLL.funcionario();
                funcionario.idFuncionario = Convert.ToInt32(lblid.Text);
                funcionario.nome = textNome.Text;
                funcionario.email = textEmail.Text;
                funcionario.rg = textRG.Text;
                funcionario.cpf = textCPF.Text;
                funcionario.endereco = textEndereco.Text;
                funcionario.nr = textNr.Text;
                funcionario.cep = maskCEP.Text;
                funcionario.admissao = maskData.Text;
                funcionario.cidade = textCidade.Text;
                funcionario.estado = textEstado.Text;
                if (funcionario.idFuncionario == -1)
                    bllFuncionario.Insert(funcionario);
                else bllFuncionario.Update(funcionario);

                if (MessageBox.Show("Deseja incluir o funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Funcionário incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                textNome.Focus();
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
                    Camadas.Model.funcionario funcionario = new Camadas.Model.funcionario();
                    Camadas.BLL.funcionario bllFuncionario = new Camadas.BLL.funcionario();
                    funcionario.idFuncionario = Convert.ToInt32(lblid.Text);
                    funcionario.nome = textNome.Text;
                    funcionario.email = textEmail.Text;
                    funcionario.rg = textRG.Text;
                    funcionario.cpf = textCPF.Text;
                    funcionario.endereco = textEndereco.Text;
                    funcionario.nr = textNr.Text;
                    funcionario.cep = maskCEP.Text;
                    funcionario.admissao = maskData.Text;
                    funcionario.cidade = textCidade.Text;
                    funcionario.estado = textEstado.Text;
                    bllFuncionario.Delete(funcionario);
                    dgvFuncionario.DataSource = (from p in bllFuncionario.Select()
                                                 select new
                                                 {
                                                     Funcionário = p.idFuncionario,
                                                     Nome = p.nome,
                                                     Email = p.email,
                                                     RG = p.rg,
                                                     CPF = p.cpf,
                                                     Endereço = p.endereco,
                                                     Número = p.nr,
                                                     CEP = p.cep,
                                                     DataAdmissão = p.admissao,
                                                     Cidade = p.cidade,
                                                     Estado = p.estado
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
            Camadas.BLL.funcionario bllFuncionario = new Camadas.BLL.funcionario();
            dgvFuncionario.DataSource = (from p in bllFuncionario.Select()
                                       select new
                                       {
                                           Funcionário = p.idFuncionario,
                                           Nome = p.nome,
                                           Email = p.email,
                                           RG = p.rg,
                                           CPF = p.cpf,
                                           Endereço = p.endereco,
                                           Número = p.nr,
                                           CEP = p.cep,
                                           DataAdmissão = p.admissao,
                                           Cidade = p.cidade,
                                           Estado = p.estado
                                       }).ToList();
            btnGravar.Enabled = true;
        }

        private void dgvFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                lblid.Text = dgvFuncionario.SelectedRows[0].Cells[0].Value.ToString();
                textNome.Text = dgvFuncionario.SelectedRows[0].Cells[1].Value.ToString();
                textEmail.Text = dgvFuncionario.SelectedRows[0].Cells[2].Value.ToString();
                textRG.Text = dgvFuncionario.SelectedRows[0].Cells[3].Value.ToString();
                textCPF.Text = dgvFuncionario.SelectedRows[0].Cells[4].Value.ToString();
                textEndereco.Text = dgvFuncionario.SelectedRows[0].Cells[5].Value.ToString();
                textNr.Text = dgvFuncionario.SelectedRows[0].Cells[6].Value.ToString();
                maskCEP.Text = dgvFuncionario.SelectedRows[0].Cells[7].Value.ToString();
                maskData.Text = dgvFuncionario.SelectedRows[0].Cells[8].Value.ToString();
                textCidade.Text = dgvFuncionario.SelectedRows[0].Cells[9].Value.ToString();
                textEstado.Text = dgvFuncionario.SelectedRows[0].Cells[10].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void textRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(maskCEP.Mask != null)
            {
                maskCEP.Mask = "00000-000";
            }

            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas letras!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioFuncionario formRelaFuncionario = new frmRelatorioFuncionario();
            formRelaFuncionario.ShowDialog();
            formRelaFuncionario.Dispose();
        }
    }
}
