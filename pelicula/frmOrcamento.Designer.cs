namespace pelicula
{
    partial class frmOrcamento
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboVeiculo = new System.Windows.Forms.ComboBox();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboServ_lateral = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvOrcamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboServ_frontal = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTipo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(18, 13);
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
            this.label4.Location = new System.Drawing.Point(14, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(420, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(207, 454);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(22, 28);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(356, 27);
            this.comboCliente.TabIndex = 7;
            // 
            // comboVeiculo
            // 
            this.comboVeiculo.FormattingEnabled = true;
            this.comboVeiculo.Location = new System.Drawing.Point(27, 28);
            this.comboVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.comboVeiculo.Name = "comboVeiculo";
            this.comboVeiculo.Size = new System.Drawing.Size(349, 27);
            this.comboVeiculo.TabIndex = 8;
            // 
            // comboProduto
            // 
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Location = new System.Drawing.Point(114, 28);
            this.comboProduto.Margin = new System.Windows.Forms.Padding(4);
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(264, 27);
            this.comboProduto.TabIndex = 9;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(577, 33);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(232, 27);
            this.comboTipo.TabIndex = 10;
            // 
            // comboServ_lateral
            // 
            this.comboServ_lateral.FormattingEnabled = true;
            this.comboServ_lateral.Location = new System.Drawing.Point(168, 51);
            this.comboServ_lateral.Margin = new System.Windows.Forms.Padding(4);
            this.comboServ_lateral.Name = "comboServ_lateral";
            this.comboServ_lateral.Size = new System.Drawing.Size(206, 27);
            this.comboServ_lateral.TabIndex = 11;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(10, 92);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(198, 34);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGravar.Location = new System.Drawing.Point(10, 165);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(198, 34);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(10, 238);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(198, 34);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(10, 311);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(198, 34);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(10, 457);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(198, 34);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvOrcamento
            // 
            this.dgvOrcamento.AllowUserToAddRows = false;
            this.dgvOrcamento.AllowUserToDeleteRows = false;
            this.dgvOrcamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamento.Location = new System.Drawing.Point(9, 28);
            this.dgvOrcamento.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrcamento.Name = "dgvOrcamento";
            this.dgvOrcamento.ReadOnly = true;
            this.dgvOrcamento.Size = new System.Drawing.Size(1091, 91);
            this.dgvOrcamento.TabIndex = 18;
            this.dgvOrcamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvOrcamento_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Serviço Lateral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(400, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Serviço Frontal";
            // 
            // comboServ_frontal
            // 
            this.comboServ_frontal.FormattingEnabled = true;
            this.comboServ_frontal.Location = new System.Drawing.Point(555, 51);
            this.comboServ_frontal.Margin = new System.Windows.Forms.Padding(4);
            this.comboServ_frontal.Name = "comboServ_frontal";
            this.comboServ_frontal.Size = new System.Drawing.Size(202, 27);
            this.comboServ_frontal.TabIndex = 21;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1169, 64);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 34);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(292, 450);
            this.textValor.Margin = new System.Windows.Forms.Padding(4);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(121, 27);
            this.textValor.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(10, 384);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(198, 34);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(302, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1021, 501);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orçamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(471, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTipo);
            this.groupBox5.Controls.Add(this.comboServ_lateral);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.comboServ_frontal);
            this.groupBox5.Location = new System.Drawing.Point(63, 314);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(938, 124);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipos de serviços";
            // 
            // btnTipo
            // 
            this.btnTipo.Location = new System.Drawing.Point(776, 40);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(155, 50);
            this.btnTipo.TabIndex = 27;
            this.btnTipo.Text = "Tipos de serviços";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.comboProduto);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboTipo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(9, 148);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(992, 158);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipos e produtos";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboFuncionario);
            this.groupBox8.Location = new System.Drawing.Point(261, 76);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(550, 75);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Funcionário";
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.FormattingEnabled = true;
            this.comboFuncionario.Location = new System.Drawing.Point(77, 25);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(453, 27);
            this.comboFuncionario.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboVeiculo);
            this.groupBox3.Location = new System.Drawing.Point(444, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(412, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veículo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboCliente);
            this.groupBox2.Location = new System.Drawing.Point(9, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(404, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnNovo);
            this.groupBox6.Controls.Add(this.btnGravar);
            this.groupBox6.Controls.Add(this.btnCancelar);
            this.groupBox6.Controls.Add(this.btnEditar);
            this.groupBox6.Controls.Add(this.btnSair);
            this.groupBox6.Controls.Add(this.btnExcluir);
            this.groupBox6.Location = new System.Drawing.Point(22, 52);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(216, 515);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opções de orçamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Aprovar orçamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Controls.Add(this.dgvOrcamento);
            this.groupBox7.Controls.Add(this.btnPesquisar);
            this.groupBox7.Location = new System.Drawing.Point(22, 575);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1323, 153);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Realizar busca";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatus.Location = new System.Drawing.Point(568, 454);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(2, 22);
            this.labelStatus.TabIndex = 26;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrcamento";
            this.Text = ".:: Orçamento ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboVeiculo;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboServ_lateral;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboServ_frontal;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.Label labelStatus;
    }
}