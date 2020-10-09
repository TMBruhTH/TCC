namespace pelicula
{
    partial class frmServico
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboVeiculo = new System.Windows.Forms.ComboBox();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.comboFuncionario = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboServ_lateral = new System.Windows.Forms.ComboBox();
            this.comboServ_frontal = new System.Windows.Forms.ComboBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreServico = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnTipo_serv = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(90, 15);
            this.lblid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 22);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "-1";
            this.lblid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(10, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Serviço lateral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(243, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Serviço frontal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(23, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(35, 32);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(5);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(304, 30);
            this.comboCliente.TabIndex = 10;
            // 
            // comboVeiculo
            // 
            this.comboVeiculo.FormattingEnabled = true;
            this.comboVeiculo.Location = new System.Drawing.Point(25, 32);
            this.comboVeiculo.Margin = new System.Windows.Forms.Padding(5);
            this.comboVeiculo.Name = "comboVeiculo";
            this.comboVeiculo.Size = new System.Drawing.Size(306, 30);
            this.comboVeiculo.TabIndex = 11;
            // 
            // comboProduto
            // 
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Location = new System.Drawing.Point(25, 54);
            this.comboProduto.Margin = new System.Windows.Forms.Padding(5);
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(311, 30);
            this.comboProduto.TabIndex = 12;
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.FormattingEnabled = true;
            this.comboFuncionario.Location = new System.Drawing.Point(45, 54);
            this.comboFuncionario.Margin = new System.Windows.Forms.Padding(5);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(282, 30);
            this.comboFuncionario.TabIndex = 13;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(42, 51);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(5);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(519, 30);
            this.comboTipo.TabIndex = 14;
            // 
            // comboServ_lateral
            // 
            this.comboServ_lateral.FormattingEnabled = true;
            this.comboServ_lateral.Location = new System.Drawing.Point(10, 98);
            this.comboServ_lateral.Margin = new System.Windows.Forms.Padding(5);
            this.comboServ_lateral.Name = "comboServ_lateral";
            this.comboServ_lateral.Size = new System.Drawing.Size(199, 30);
            this.comboServ_lateral.TabIndex = 15;
            // 
            // comboServ_frontal
            // 
            this.comboServ_frontal.FormattingEnabled = true;
            this.comboServ_frontal.Location = new System.Drawing.Point(238, 98);
            this.comboServ_frontal.Margin = new System.Windows.Forms.Padding(5);
            this.comboServ_frontal.Name = "comboServ_frontal";
            this.comboServ_frontal.Size = new System.Drawing.Size(199, 30);
            this.comboServ_frontal.TabIndex = 16;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(105, 44);
            this.textValor.Margin = new System.Windows.Forms.Padding(5);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(199, 30);
            this.textValor.TabIndex = 17;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(10, 135);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(192, 39);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo Serviço";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboCliente);
            this.groupBox1.Location = new System.Drawing.Point(42, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(363, 93);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(10, 209);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(192, 39);
            this.btnGravar.TabIndex = 20;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(10, 283);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(192, 39);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(10, 357);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(192, 39);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(10, 431);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 39);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(10, 505);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(192, 39);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnPreServico);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnGravar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(14, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(232, 564);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inclusões e alterações de serviços";
            // 
            // btnPreServico
            // 
            this.btnPreServico.Location = new System.Drawing.Point(10, 70);
            this.btnPreServico.Name = "btnPreServico";
            this.btnPreServico.Size = new System.Drawing.Size(192, 35);
            this.btnPreServico.TabIndex = 25;
            this.btnPreServico.Text = "Pré serviço";
            this.btnPreServico.UseVisualStyleBackColor = true;
            this.btnPreServico.Click += new System.EventHandler(this.btnPreServico_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboVeiculo);
            this.groupBox3.Location = new System.Drawing.Point(497, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(363, 93);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veiculo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboProduto);
            this.groupBox4.Location = new System.Drawing.Point(497, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(363, 118);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produto";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboFuncionario);
            this.groupBox5.Location = new System.Drawing.Point(42, 135);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(363, 118);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Funcionário";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelStatus);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.comboTipo);
            this.groupBox6.Location = new System.Drawing.Point(42, 264);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(1018, 322);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(671, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textValor);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(652, 110);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox8.Size = new System.Drawing.Size(335, 94);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Pagamento";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnTipo_serv);
            this.groupBox7.Controls.Add(this.comboServ_lateral);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.comboServ_frontal);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(42, 110);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox7.Size = new System.Drawing.Size(600, 194);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tipos de Serviços";
            // 
            // btnTipo_serv
            // 
            this.btnTipo_serv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTipo_serv.Location = new System.Drawing.Point(469, 79);
            this.btnTipo_serv.Name = "btnTipo_serv";
            this.btnTipo_serv.Size = new System.Drawing.Size(123, 66);
            this.btnTipo_serv.TabIndex = 17;
            this.btnTipo_serv.Text = "Tipos de serviços";
            this.btnTipo_serv.UseVisualStyleBackColor = false;
            this.btnTipo_serv.Click += new System.EventHandler(this.btnTipo_serv_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox4);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Location = new System.Drawing.Point(274, 15);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox9.Size = new System.Drawing.Size(1070, 596);
            this.groupBox9.TabIndex = 30;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Serviço";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // dgvServico
            // 
            this.dgvServico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(45, 24);
            this.dgvServico.Margin = new System.Windows.Forms.Padding(5);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(1043, 77);
            this.dgvServico.TabIndex = 31;
            this.dgvServico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvServico_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1137, 33);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(183, 39);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox10.Controls.Add(this.dgvServico);
            this.groupBox10.Controls.Add(this.btnPesquisar);
            this.groupBox10.Location = new System.Drawing.Point(14, 622);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox10.Size = new System.Drawing.Size(1330, 116);
            this.groupBox10.TabIndex = 33;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Realizar busca";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatus.Location = new System.Drawing.Point(807, 254);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(2, 24);
            this.labelStatus.TabIndex = 18;
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmServico";
            this.Text = ".:: Serviços ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboVeiculo;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboServ_lateral;
        private System.Windows.Forms.ComboBox comboServ_frontal;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnTipo_serv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreServico;
        private System.Windows.Forms.Label labelStatus;
    }
}