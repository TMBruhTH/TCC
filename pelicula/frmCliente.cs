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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            textNome.Text = "";
            textEmail.Text = "";
            textEndereco.Text = "";
            maskCEP.Text = "";
            maskCEP.Mask = "";
            textNr.Text = "";
            maskCPF.Text = "";
            maskRG.Text = "";
            maskTelefone.Text = "";
            maskTelefone.Mask = "";
            textCidade.Text = "";
            textEstado.Text = "";
        }

        void Habilita(bool status)

        {
            textNome.Enabled = status;
            textEmail.Enabled = status;
            textEndereco.Enabled = status;
            maskCEP.Enabled = status;
            textNr.Enabled = status;
            maskCPF.Enabled = status;
            maskRG.Enabled = status;
            maskTelefone.Enabled = status;
            textCidade.Enabled = status;
            textEstado.Enabled = status;
        }

        private void Botoes(bool campo)
        {
            btnGravar.Enabled = campo;
            btnEditar.Enabled = campo;
            btnExcluir.Enabled = campo;
            btnCancelar.Enabled = campo;
        }

        private void Visibilidade(bool visivel)
        {
            //text box
            textNome.Visible = visivel;
            textEmail.Visible = visivel;
            textEndereco.Visible = visivel;
            maskCEP.Visible = visivel;
            textNr.Visible = visivel;
            maskCPF.Visible = visivel;
            maskRG.Visible = visivel;
            maskTelefone.Visible = visivel;
            textCidade.Visible = visivel;
            textEstado.Visible = visivel;
            //label
            /*lblNome.Visible = visivel;
            lblEmail.Visible = visivel;
            lblEndereco.Visible = visivel;
            lblCEP.Visible = visivel;
            lblNr.Visible = visivel;*/
            lblCPF.Visible = visivel;
            lblRG.Visible = visivel;
            lblTelefone.Visible = visivel;
            lblCidade.Visible = visivel;
            lblEstado.Visible = visivel;  
        }

        private void LetrasMaiusculas()
        {
            textNome.CharacterCasing = CharacterCasing.Upper;
            textEmail.CharacterCasing = CharacterCasing.Upper;
            textCidade.CharacterCasing = CharacterCasing.Upper;
            textEndereco.CharacterCasing = CharacterCasing.Upper;
            textEstado.CharacterCasing = CharacterCasing.Upper;
        }

        private bool Valida()
        {
            if (textNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Nome é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNome.Focus();
                return false;
            }

            if (textEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo E - Mail é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEmail.Focus();
                return false;
            }

            if (textEndereco.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Endereço é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEndereco.Focus();
                return false;
            }

            if (maskCEP.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo CEP é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskCEP.Focus();
                return false;
            }

            if (textNr.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Número é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textNr.Focus();
                return false;
            }

            if (maskCPF.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo CPF/CNPJ é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskCPF.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(maskRG.Text.Trim()))
            {
                MessageBox.Show("O campo RG/IE é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskRG.Focus();
                return false;
            }

            if (maskTelefone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Telefone é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maskTelefone.Focus();
                return false;
            }

            if (textCidade.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Cidade é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textCidade.Focus();
                return false;
            }          

            if (textEstado.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Estado é obrigatório!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textEstado.Focus();
                return false;
            }                       
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblid.Text = "-1";
            if (btnNovo.Enabled != rbtFisico.Checked & btnNovo.Enabled != rbtJuridico.Checked)
            {
                MessageBox.Show("Por favor, informe se é Cliente Físico ou Jurídico!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (btnNovo.Enabled == rbtFisico.Checked | btnNovo.Enabled == rbtJuridico.Checked)
            {
                if (MessageBox.Show("Deseja inserir um novo Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpaCampos();
                    Habilita(true);
                    Botoes(true);
                    Visibilidade(true);
                    textNome.Focus();
                    if (btnNovo.Enabled == rbtFisico.Checked)
                    {
                        maskCPF.Visible = true;
                        maskRG.Visible = true;
                        lblCPF.Visible = true;
                        lblRG.Visible = true;

                    }
                    if (btnNovo.Enabled == rbtJuridico.Checked)
                    {
                        maskCPF.Visible = true;
                        maskRG.Visible = true;
                        lblCPF.Visible = true;
                        lblRG.Visible = true;

                    }
                }
                else
                {
                    LimpaCampos();
                    Habilita(false);
                    Botoes(false);
                }
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilita(false);
            Botoes(false);
            Visibilidade(false);
            LetrasMaiusculas();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                Camadas.Model.cliente cliente = new Camadas.Model.cliente();
                Camadas.BLL.cliente bllCliente = new Camadas.BLL.cliente();
                cliente.idCliente = Convert.ToInt32(lblid.Text);
                cliente.nome = textNome.Text;
                cliente.email = textEmail.Text;
                cliente.endereco = textEndereco.Text;
                cliente.cep = maskCEP.Text;
                cliente.nr = textNr.Text;
                cliente.cpf = maskCPF.Text;
                cliente.rg = maskRG.Text;
                cliente.telefone = maskTelefone.Text;
                cliente.cidade = textCidade.Text;
                cliente.estado = textEstado.Text;       
                if (cliente.idCliente == -1)
                    bllCliente.Insert(cliente);
                else bllCliente.Update(cliente);

                if (MessageBox.Show("Deseja incluir o cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MessageBox.Show("Cliente incluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Camadas.Model.cliente cliente = new Camadas.Model.cliente();
                    Camadas.BLL.cliente bllCliente = new Camadas.BLL.cliente();
                    cliente.idCliente = Convert.ToInt32(lblid.Text);

                    bllCliente.Delete(cliente);
                    dgvCliente.DataSource = (from p in bllCliente.Select()
                                             select new
                                             {
                                                 Cliente = p.idCliente,
                                                 Nome = p.nome,
                                                 Email = p.email,
                                                 Endereço = p.endereco,
                                                 CEP = p.cep,
                                                 Número = p.nr,
                                                 CPF = p.cpf,
                                                 RG = p.rg,
                                                 Telefone = p.telefone,
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

        private void maskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (maskCEP.Mask != null)
            {
                maskCEP.Mask = "00000-000";
            }

            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void maskCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, digite apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskRG_KeyPress(object sender, KeyPressEventArgs e)
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
                maskTelefone.Mask = "(00)00000-0000";
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

        private void dgvCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                lblid.Text = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();
                textNome.Text = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();
                textEmail.Text = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();
                textEndereco.Text = dgvCliente.SelectedRows[0].Cells[3].Value.ToString();
                maskCEP.Text = dgvCliente.SelectedRows[0].Cells[4].Value.ToString();
                textNr.Text = dgvCliente.SelectedRows[0].Cells[5].Value.ToString();
                maskCPF.Text = dgvCliente.SelectedRows[0].Cells[6].Value.ToString();
                maskRG.Text = dgvCliente.SelectedRows[0].Cells[7].Value.ToString();
                maskTelefone.Text = dgvCliente.SelectedRows[0].Cells[8].Value.ToString();
                textCidade.Text = dgvCliente.SelectedRows[0].Cells[9].Value.ToString();
                textEstado.Text = dgvCliente.SelectedRows[0].Cells[10].Value.ToString();                             
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.cliente bllCliente = new Camadas.BLL.cliente();
            dgvCliente.DataSource = (from p in bllCliente.Select()
                                       select new
                                       {
                                           Cliente = p.idCliente,
                                           Nome = p.nome,
                                           Email = p.email,
                                           Endereço = p.endereco,
                                           CEP = p.cep,
                                           Número = p.nr,
                                           CPF = p.cpf,
                                           RG = p.rg,
                                           Telefone = p.telefone,
                                           Cidade = p.cidade,
                                           Estado = p.estado
                                       }).ToList();
            btnGravar.Enabled = true;
        }

        private void rbtFisico_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnNovo.Enabled == rbtFisico.Checked)
            {
                Visibilidade(true);
                lblCPF.Text = "CPF";
                lblRG.Text = "RG";
            }
        }

        private void rbtJuridico_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnNovo.Enabled == rbtJuridico.Checked)
            {
                Visibilidade(true);
                lblRG.Text = "IE";
                lblCPF.Text = "CNPJ";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente formRelatCliente = new frmRelatorioCliente();
            formRelatCliente.ShowDialog();
            formRelatCliente.Dispose();
        }
    }
}
