namespace pelicula
{
    partial class frmFuncionario
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
            this.lblid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textRG = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textNr = new System.Windows.Forms.TextBox();
            this.maskData = new System.Windows.Forms.MaskedTextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(18, 12);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "-1";
            this.lblid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data de Admissão";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(716, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Número";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 248);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "CEP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(122, 47);
            this.textNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(673, 27);
            this.textNome.TabIndex = 11;
            this.textNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNome_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(98, 47);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(566, 27);
            this.textEmail.TabIndex = 12;
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(88, 37);
            this.textRG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(218, 27);
            this.textRG.TabIndex = 13;
            this.textRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRG_KeyPress);
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(520, 33);
            this.textCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(271, 27);
            this.textCPF.TabIndex = 14;
            this.textCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCPF_KeyPress);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(104, 190);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(592, 27);
            this.textEndereco.TabIndex = 15;
            this.textEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEndereco_KeyPress);
            // 
            // textNr
            // 
            this.textNr.Location = new System.Drawing.Point(790, 191);
            this.textNr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNr.Name = "textNr";
            this.textNr.Size = new System.Drawing.Size(106, 27);
            this.textNr.TabIndex = 16;
            this.textNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNr_KeyPress_1);
            // 
            // maskData
            // 
            this.maskData.Location = new System.Drawing.Point(631, 244);
            this.maskData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskData.Name = "maskData";
            this.maskData.Size = new System.Drawing.Size(148, 27);
            this.maskData.TabIndex = 18;
            this.maskData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskData_KeyPress);
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(104, 38);
            this.textCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(349, 27);
            this.textCidade.TabIndex = 19;
            this.textCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCidade_KeyPress);
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(583, 39);
            this.textEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(313, 27);
            this.textEstado.TabIndex = 20;
            this.textEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEstado_KeyPress);
            // 
            // maskCEP
            // 
            this.maskCEP.Location = new System.Drawing.Point(104, 244);
            this.maskCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(187, 27);
            this.maskCEP.TabIndex = 21;
            this.maskCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskCEP_KeyPress);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(9, 107);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(218, 33);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGravar.Location = new System.Drawing.Point(9, 172);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(218, 33);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(9, 237);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(218, 33);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(9, 303);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(218, 33);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(9, 368);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(218, 33);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(9, 433);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(218, 33);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(8, 26);
            this.dgvFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(1155, 99);
            this.dgvFuncionario.TabIndex = 28;
            this.dgvFuncionario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFuncionario_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1171, 60);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 33);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(292, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1053, 509);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textEndereco);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textNr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.maskCEP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.maskData);
            this.groupBox2.Location = new System.Drawing.Point(43, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(912, 297);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de contato";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textRG);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textCPF);
            this.groupBox3.Location = new System.Drawing.Point(9, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(887, 73);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textCidade);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textEstado);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(43, 397);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(912, 84);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localização";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.btnRelatorio);
            this.groupBox5.Controls.Add(this.btnNovo);
            this.groupBox5.Controls.Add(this.btnGravar);
            this.groupBox5.Controls.Add(this.btnEditar);
            this.groupBox5.Controls.Add(this.btnSair);
            this.groupBox5.Controls.Add(this.btnExcluir);
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Location = new System.Drawing.Point(18, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(236, 509);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opções de funcionários";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.Location = new System.Drawing.Point(9, 43);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(218, 31);
            this.btnRelatorio.TabIndex = 0;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.dgvFuncionario);
            this.groupBox6.Controls.Add(this.btnPesquisar);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(27, 563);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1330, 136);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Realizar busca";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFuncionario";
            this.Text = ".:: Funcionário ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textNr;
        private System.Windows.Forms.MaskedTextBox maskData;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.MaskedTextBox maskCEP;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}