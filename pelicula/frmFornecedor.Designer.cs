namespace pelicula
{
    partial class frmFornecedor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.maskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textNr = new System.Windows.Forms.TextBox();
            this.textIE = new System.Windows.Forms.TextBox();
            this.textIM = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(34, 13);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "-1";
            this.lblid.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label4.Location = new System.Drawing.Point(150, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label9.Location = new System.Drawing.Point(576, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label10.Location = new System.Drawing.Point(380, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Inscrição Municipal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label11.Location = new System.Drawing.Point(163, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Telefone";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textNome.Location = new System.Drawing.Point(231, 32);
            this.textNome.Margin = new System.Windows.Forms.Padding(4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(646, 30);
            this.textNome.TabIndex = 11;
            this.textNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNome_KeyPress);
            // 
            // textEstado
            // 
            this.textEstado.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textEstado.Location = new System.Drawing.Point(462, 61);
            this.textEstado.Margin = new System.Windows.Forms.Padding(4);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(324, 30);
            this.textEstado.TabIndex = 12;
            this.textEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEstado_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textEmail.Location = new System.Drawing.Point(45, 28);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(571, 30);
            this.textEmail.TabIndex = 13;
            // 
            // textEndereco
            // 
            this.textEndereco.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textEndereco.Location = new System.Drawing.Point(12, 75);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(538, 30);
            this.textEndereco.TabIndex = 14;
            this.textEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEndereco_KeyPress);
            // 
            // maskCNPJ
            // 
            this.maskCNPJ.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.maskCNPJ.Location = new System.Drawing.Point(12, 37);
            this.maskCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.maskCNPJ.Name = "maskCNPJ";
            this.maskCNPJ.Size = new System.Drawing.Size(288, 30);
            this.maskCNPJ.TabIndex = 15;
            this.maskCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskCNPJ_KeyPress);
            // 
            // maskTelefone
            // 
            this.maskTelefone.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.maskTelefone.Location = new System.Drawing.Point(335, 110);
            this.maskTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(247, 30);
            this.maskTelefone.TabIndex = 16;
            this.maskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskTelefone_KeyPress);
            // 
            // textNr
            // 
            this.textNr.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textNr.Location = new System.Drawing.Point(639, 75);
            this.textNr.Margin = new System.Windows.Forms.Padding(4);
            this.textNr.Name = "textNr";
            this.textNr.Size = new System.Drawing.Size(148, 30);
            this.textNr.TabIndex = 17;
            this.textNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNr_KeyPress);
            // 
            // textIE
            // 
            this.textIE.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textIE.Location = new System.Drawing.Point(9, 75);
            this.textIE.Margin = new System.Windows.Forms.Padding(4);
            this.textIE.Name = "textIE";
            this.textIE.Size = new System.Drawing.Size(302, 30);
            this.textIE.TabIndex = 18;
            // 
            // textIM
            // 
            this.textIM.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textIM.Location = new System.Drawing.Point(384, 75);
            this.textIM.Margin = new System.Windows.Forms.Padding(4);
            this.textIM.Name = "textIM";
            this.textIM.Size = new System.Drawing.Size(296, 30);
            this.textIM.TabIndex = 19;
            // 
            // textCidade
            // 
            this.textCidade.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textCidade.Location = new System.Drawing.Point(10, 61);
            this.textCidade.Margin = new System.Windows.Forms.Padding(4);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(424, 30);
            this.textCidade.TabIndex = 20;
            this.textCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCidade_KeyPress);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(27, 20);
            this.dgvFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.Size = new System.Drawing.Size(933, 81);
            this.dgvFornecedor.TabIndex = 21;
            this.dgvFornecedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFornecedor_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnPesquisar.Location = new System.Drawing.Point(993, 43);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(223, 44);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnNovo.Location = new System.Drawing.Point(27, 106);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(184, 38);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGravar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnGravar.Location = new System.Drawing.Point(27, 188);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(184, 38);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnEditar.Location = new System.Drawing.Point(27, 270);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(184, 38);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnExcluir.Location = new System.Drawing.Point(27, 352);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(184, 38);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnCancelar.Location = new System.Drawing.Point(27, 434);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(184, 38);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnSair.Location = new System.Drawing.Point(27, 516);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(184, 38);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnRelatorio);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(39, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(234, 564);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de fornecedor";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.btnRelatorio.Location = new System.Drawing.Point(27, 27);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(184, 35);
            this.btnRelatorio.TabIndex = 29;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dgvFornecedor);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Location = new System.Drawing.Point(39, 623);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1241, 111);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar busca";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textNome);
            this.groupBox3.Location = new System.Drawing.Point(291, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(989, 574);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Razão Social";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textCidade);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.textEstado);
            this.groupBox7.Controls.Add(this.maskTelefone);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(60, 416);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(820, 148);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Contato e localidade";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textIE);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textIM);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(60, 284);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(819, 124);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dados de inscrições";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Inscrição Estadual";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.maskCNPJ);
            this.groupBox5.Controls.Add(this.textEndereco);
            this.groupBox5.Controls.Add(this.textNr);
            this.groupBox5.Location = new System.Drawing.Point(60, 161);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(819, 115);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CNPJ - Endereço - Número";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textEmail);
            this.groupBox4.Location = new System.Drawing.Point(60, 70);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(819, 83);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "E mail";
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFornecedor";
            this.Text = ".:: Fornecedor ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.MaskedTextBox maskCNPJ;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.TextBox textNr;
        private System.Windows.Forms.TextBox textIE;
        private System.Windows.Forms.TextBox textIM;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelatorio;
    }
}