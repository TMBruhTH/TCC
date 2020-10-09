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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        void LimpaCampos()
        {
            lblid.Text = "-1";
            textNome.Text = "";
            textEmail.Text = "";
            maskCNPJ.Text = "";
            maskCNPJ.Mask = "";
            textEndereco.Text = "";
            textNr.Text = "";
            textIE.Text = "";
            textIM.Text = "";
            textCidade.Text = "";
            textEstado.Text = "";
            maskTelefone.Text = "";
            maskTelefone.Mask = "";
        }

        void Habilita(bool status)
        {
            textNome.Enabled = status;
            textEmail.Enabled = status;
            maskCNPJ.Enabled = status;
            textEndereco.Enabled = status;
            textNr.Enabled = status;
            textIE.Enabled = status;
            textIM.Enabled = status;
            textCidade.Enabled = status;
            textEstado.Enabled = status;
            maskTelefone.Enabled = status;
        }

        void Botoes(bool status)
        {
            btnGravar.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
            btnCancelar.Enabled = status;
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(textNome.Text.Trim()))
            {
                MessageBox.Show("O campo Razão Social/Nome é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textEmail.Text.Trim()))
            {
                MessageBox.Show("O campo E mail é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEmail.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskCNPJ.Text.Trim()))
            {
                MessageBox.Show("O campo CNPJ é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskCNPJ.Focus();
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
                MessageBox.Show("O campo Número é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNr.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textIE.Text.Trim()))
            {
                MessageBox.Show("O campo Inscrição Estadual é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textIE.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textIM.Text.Trim()))
            {
                MessageBox.Show("O campo Inscriçao Municipal é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textIM.Focus();
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

            if (string.IsNullOrEmpty(maskTelefone.Text.Trim()))
            {
                MessageBox.Show("O campo Telefone é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskTelefone.Focus();
                return false;
            }
            return true;
        }

        void LetrasMaiusculas()
        {
            textNome.CharacterCasing = CharacterCasing.Upper;
            textEmail.CharacterCasing = CharacterCasing.Upper;
            textCidade.CharacterCasing = CharacterCasing.Upper;
            textEndereco.CharacterCasing = CharacterCasing.Upper;
            textEstado.CharacterCasing = CharacterCasing.Upper;
            textIE.CharacterCasing = CharacterCasing.Upper;
            textIM.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir um novo Fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                Habilita(true);
                Botoes(true);
                textNome.Focus();
            }
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilita(false);
            Botoes(false);
            LetrasMaiusculas();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.fornecedor fornecedor = new Camadas.Model.fornecedor();
                Camadas.BLL.fornecedor bllFornecedor = new Camadas.BLL.fornecedor();
                fornecedor.idFornecedor = Convert.ToInt32(lblid.Text);
                fornecedor.razao_social = textNome.Text;
                fornecedor.email = textEmail.Text;
                fornecedor.cnpj = maskCNPJ.Text;
                fornecedor.endereco = textEndereco.Text;
                fornecedor.nr = textNr.Text;
                fornecedor.iestadual = textIE.Text;
                fornecedor.imunicipal = textIM.Text;
                fornecedor.cidade = textCidade.Text;
                fornecedor.estado = textEstado.Text;
                fornecedor.telefone = maskTelefone.Text;
                if (fornecedor.idFornecedor == -1)
                    bllFornecedor.Insert(fornecedor);
                else bllFornecedor.Update(fornecedor);

                if (MessageBox.Show("Deseja incluir o fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Fornecedor incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Camadas.Model.fornecedor fornecedor = new Camadas.Model.fornecedor();
                    Camadas.BLL.fornecedor bllFornecedor = new Camadas.BLL.fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(lblid.Text);
                    fornecedor.razao_social = textNome.Text;
                    fornecedor.email = textEmail.Text;
                    fornecedor.cnpj = maskCNPJ.Text;
                    fornecedor.endereco = textEndereco.Text;
                    fornecedor.nr = textNr.Text;
                    fornecedor.iestadual = textIE.Text;
                    fornecedor.imunicipal = textIM.Text;
                    fornecedor.cidade = textCidade.Text;
                    fornecedor.estado = textEstado.Text;
                    fornecedor.telefone = maskTelefone.Text;
                    bllFornecedor.Delete(fornecedor);
                    dgvFornecedor.DataSource = (from p in bllFornecedor.Select()
                                                select new
                                                {
                                                    Fornecedor = p.idFornecedor,
                                                    Razão_Social = p.razao_social,
                                                    Email = p.email,
                                                    CNPJ = p.cnpj,
                                                    Endereço = p.endereco,
                                                    Número = p.nr,
                                                    InscriçãoEstadual = p.iestadual,
                                                    InscriçãoMunicipal = p.imunicipal,
                                                    Cidade = p.cidade,
                                                    Estado = p.estado,
                                                    Telefone = p.telefone
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
            Camadas.BLL.fornecedor bllFornecedor = new Camadas.BLL.fornecedor();
            dgvFornecedor.DataSource = (from p in bllFornecedor.Select()
                                        select new
                                        {
                                            Fornecedor = p.idFornecedor,
                                            Razão_Social = p.razao_social,
                                            Email = p.email,
                                            CNPJ = p.cnpj,
                                            Endereço = p.endereco,
                                            Número = p.nr,
                                            InscriçãoEstadual = p.iestadual,
                                            InscriçãoMunicipal = p.imunicipal,
                                            Cidade = p.cidade,
                                            Estado = p.estado,
                                            Telefone = p.telefone
                                       }).ToList();
            btnGravar.Enabled = true;
        }

        private void maskCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (maskTelefone.Mask != null)
            {
                maskTelefone.Mask = "(00)0000-0000";
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

        private void dgvFornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                lblid.Text = dgvFornecedor.SelectedRows[0].Cells[0].Value.ToString();
                textNome.Text = dgvFornecedor.SelectedRows[0].Cells[1].Value.ToString();
                textEmail.Text = dgvFornecedor.SelectedRows[0].Cells[2].Value.ToString();
                maskCNPJ.Text = dgvFornecedor.SelectedRows[0].Cells[3].Value.ToString();
                textEndereco.Text = dgvFornecedor.SelectedRows[0].Cells[4].Value.ToString();
                textNr.Text = dgvFornecedor.SelectedRows[0].Cells[5].Value.ToString();
                textIE.Text = dgvFornecedor.SelectedRows[0].Cells[6].Value.ToString();
                textIM.Text = dgvFornecedor.SelectedRows[0].Cells[7].Value.ToString();
                textCidade.Text = dgvFornecedor.SelectedRows[0].Cells[8].Value.ToString();
                textEstado.Text = dgvFornecedor.SelectedRows[0].Cells[9].Value.ToString();
                maskTelefone.Text = dgvFornecedor.SelectedRows[0].Cells[10].Value.ToString();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void textNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedor formRelaForn = new frmRelatorioFornecedor();
            formRelaForn.ShowDialog();
            formRelaForn.Dispose();
        }
    }
}