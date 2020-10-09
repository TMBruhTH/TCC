namespace pelicula
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.rbtFisico = new System.Windows.Forms.RadioButton();
            this.rbtJuridico = new System.Windows.Forms.RadioButton();
            this.lblid = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.textNr = new System.Windows.Forms.TextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskRG = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnNovo.Location = new System.Drawing.Point(6, 107);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(135, 36);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGravar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnGravar.Location = new System.Drawing.Point(6, 166);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(135, 36);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnEditar.Location = new System.Drawing.Point(6, 221);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnCancelar.Location = new System.Drawing.Point(6, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnExcluir.Location = new System.Drawing.Point(6, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 36);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnSair.Location = new System.Drawing.Point(6, 409);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // rbtFisico
            // 
            this.rbtFisico.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtFisico.AutoSize = true;
            this.rbtFisico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbtFisico.FlatAppearance.BorderSize = 4;
            this.rbtFisico.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtFisico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.rbtFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.rbtFisico.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.rbtFisico.Location = new System.Drawing.Point(654, 28);
            this.rbtFisico.Name = "rbtFisico";
            this.rbtFisico.Size = new System.Drawing.Size(150, 32);
            this.rbtFisico.TabIndex = 6;
            this.rbtFisico.TabStop = true;
            this.rbtFisico.Text = "Pessoa Física";
            this.rbtFisico.UseVisualStyleBackColor = true;
            this.rbtFisico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtFisico_MouseClick);
            // 
            // rbtJuridico
            // 
            this.rbtJuridico.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtJuridico.AutoSize = true;
            this.rbtJuridico.FlatAppearance.BorderSize = 4;
            this.rbtJuridico.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.rbtJuridico.Location = new System.Drawing.Point(654, 86);
            this.rbtJuridico.Name = "rbtJuridico";
            this.rbtJuridico.Size = new System.Drawing.Size(170, 32);
            this.rbtJuridico.TabIndex = 7;
            this.rbtJuridico.TabStop = true;
            this.rbtJuridico.Text = "Pessoa Juridica";
            this.rbtJuridico.UseVisualStyleBackColor = true;
            this.rbtJuridico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtJuridico_MouseClick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblid.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lblid.Location = new System.Drawing.Point(9, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(32, 24);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "-1";
            this.lblid.Visible = false;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRG.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lblRG.Location = new System.Drawing.Point(435, 32);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(32, 24);
            this.lblRG.TabIndex = 10;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCPF.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lblCPF.Location = new System.Drawing.Point(15, 32);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 24);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lblEstado.Location = new System.Drawing.Point(188, 93);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 24);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefone.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lblTelefone.Location = new System.Drawing.Point(15, 49);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(92, 24);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCidade.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lblCidade.Location = new System.Drawing.Point(382, 48);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(72, 24);
            this.lblCidade.TabIndex = 18;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textNome.Location = new System.Drawing.Point(27, 28);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(536, 30);
            this.textNome.TabIndex = 19;
            this.textNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNome_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textEmail.Location = new System.Drawing.Point(44, 19);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(492, 30);
            this.textEmail.TabIndex = 20;
            // 
            // textEndereco
            // 
            this.textEndereco.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textEndereco.Location = new System.Drawing.Point(15, 36);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(373, 30);
            this.textEndereco.TabIndex = 21;
            this.textEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEndereco_KeyPress);
            // 
            // maskCEP
            // 
            this.maskCEP.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.maskCEP.Location = new System.Drawing.Point(423, 36);
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(151, 30);
            this.maskCEP.TabIndex = 22;
            this.maskCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskCEP_KeyPress);
            // 
            // textNr
            // 
            this.textNr.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textNr.Location = new System.Drawing.Point(627, 37);
            this.textNr.Name = "textNr";
            this.textNr.Size = new System.Drawing.Size(79, 30);
            this.textNr.TabIndex = 23;
            this.textNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNr_KeyPress);
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.maskCPF.Location = new System.Drawing.Point(93, 29);
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(211, 30);
            this.maskCPF.TabIndex = 24;
            this.maskCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskCPF_KeyPress);
            // 
            // maskRG
            // 
            this.maskRG.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.maskRG.Location = new System.Drawing.Point(489, 29);
            this.maskRG.Name = "maskRG";
            this.maskRG.Size = new System.Drawing.Size(154, 30);
            this.maskRG.TabIndex = 25;
            this.maskRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskRG_KeyPress);
            // 
            // maskTelefone
            // 
            this.maskTelefone.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.maskTelefone.Location = new System.Drawing.Point(140, 45);
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(211, 30);
            this.maskTelefone.TabIndex = 26;
            this.maskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskTelefone_KeyPress);
            // 
            // textCidade
            // 
            this.textCidade.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textCidade.Location = new System.Drawing.Point(474, 48);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(253, 30);
            this.textCidade.TabIndex = 27;
            this.textCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCidade_KeyPress);
            // 
            // textEstado
            // 
            this.textEstado.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textEstado.Location = new System.Drawing.Point(289, 90);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(253, 30);
            this.textEstado.TabIndex = 28;
            this.textEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEstado_KeyPress);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCliente.Location = new System.Drawing.Point(16, 26);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(744, 95);
            this.dgvCliente.TabIndex = 29;
            this.dgvCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCliente_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnPesquisar.Location = new System.Drawing.Point(816, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(162, 39);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.rbtFisico);
            this.groupBox1.Controls.Add(this.rbtJuridico);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(171, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 489);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.maskTelefone);
            this.groupBox5.Controls.Add(this.lblTelefone);
            this.groupBox5.Controls.Add(this.textCidade);
            this.groupBox5.Controls.Add(this.lblEstado);
            this.groupBox5.Controls.Add(this.textEstado);
            this.groupBox5.Controls.Add(this.lblCidade);
            this.groupBox5.Location = new System.Drawing.Point(27, 344);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(736, 132);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato e localidade";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskCPF);
            this.groupBox4.Controls.Add(this.lblCPF);
            this.groupBox4.Controls.Add(this.maskRG);
            this.groupBox4.Controls.Add(this.lblRG);
            this.groupBox4.Location = new System.Drawing.Point(18, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(736, 75);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Identidade e registro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textEndereco);
            this.groupBox3.Controls.Add(this.maskCEP);
            this.groupBox3.Controls.Add(this.textNr);
            this.groupBox3.Location = new System.Drawing.Point(27, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 88);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço - CEP - Número";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEmail);
            this.groupBox2.Location = new System.Drawing.Point(27, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 61);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E mail";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.btnRelatorio);
            this.groupBox6.Controls.Add(this.btnNovo);
            this.groupBox6.Controls.Add(this.btnGravar);
            this.groupBox6.Controls.Add(this.btnEditar);
            this.groupBox6.Controls.Add(this.btnCancelar);
            this.groupBox6.Controls.Add(this.btnExcluir);
            this.groupBox6.Controls.Add(this.btnSair);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.groupBox6.Location = new System.Drawing.Point(12, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 489);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opções de clientes";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Controls.Add(this.dgvCliente);
            this.groupBox7.Controls.Add(this.btnPesquisar);
            this.groupBox7.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.groupBox7.Location = new System.Drawing.Point(12, 521);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1001, 154);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Realizar busca";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.Location = new System.Drawing.Point(6, 53);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(135, 37);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 687);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCliente";
            this.Text = ".:: Cadastro de Clientes ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rbtFisico;
        private System.Windows.Forms.RadioButton rbtJuridico;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.MaskedTextBox maskCEP;
        private System.Windows.Forms.TextBox textNr;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.MaskedTextBox maskRG;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnRelatorio;
    }
}