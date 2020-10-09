namespace pelicula
{
    partial class frmVeiculos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.maskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.textAno = new System.Windows.Forms.TextBox();
            this.textChassi = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textVeiculo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
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
            this.lblid.Location = new System.Drawing.Point(22, 12);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "-1";
            this.lblid.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Veículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chassi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Placa";
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(40, 27);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(490, 27);
            this.comboCliente.TabIndex = 7;
            // 
            // maskPlaca
            // 
            this.maskPlaca.Location = new System.Drawing.Point(351, 80);
            this.maskPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskPlaca.Name = "maskPlaca";
            this.maskPlaca.Size = new System.Drawing.Size(157, 27);
            this.maskPlaca.TabIndex = 8;
            this.maskPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskPlaca_KeyPress);
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(98, 80);
            this.textAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(148, 27);
            this.textAno.TabIndex = 9;
            this.textAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAno_KeyPress);
            // 
            // textChassi
            // 
            this.textChassi.Location = new System.Drawing.Point(154, 27);
            this.textChassi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textChassi.Name = "textChassi";
            this.textChassi.Size = new System.Drawing.Size(492, 27);
            this.textChassi.TabIndex = 10;
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(146, 83);
            this.textModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(376, 27);
            this.textModelo.TabIndex = 11;
            this.textModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textModelo_KeyPress);
            // 
            // textVeiculo
            // 
            this.textVeiculo.Location = new System.Drawing.Point(182, 28);
            this.textVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textVeiculo.Name = "textVeiculo";
            this.textVeiculo.Size = new System.Drawing.Size(451, 27);
            this.textVeiculo.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovo.Location = new System.Drawing.Point(9, 107);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(201, 33);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGravar.Location = new System.Drawing.Point(9, 170);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(201, 33);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(9, 232);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(201, 33);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(9, 294);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(201, 33);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(9, 357);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(9, 419);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(201, 33);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(990, 41);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 33);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Location = new System.Drawing.Point(28, 27);
            this.dgvVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.Size = new System.Drawing.Size(931, 57);
            this.dgvVeiculo.TabIndex = 20;
            this.dgvVeiculo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVeiculo_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(320, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(850, 473);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veículo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboCliente);
            this.groupBox2.Location = new System.Drawing.Point(33, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(681, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textVeiculo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textModelo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(33, 140);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(681, 136);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textChassi);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textAno);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.maskPlaca);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(33, 289);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(681, 155);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registros";
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
            this.groupBox5.Location = new System.Drawing.Point(18, 36);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(244, 465);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opções de veículos";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.Location = new System.Drawing.Point(9, 46);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(201, 31);
            this.btnRelatorio.TabIndex = 0;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.dgvVeiculo);
            this.groupBox6.Controls.Add(this.btnPesquisar);
            this.groupBox6.Location = new System.Drawing.Point(27, 521);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(1143, 103);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Realizar busca";
            // 
            // frmVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 637);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVeiculos";
            this.Text = ".:: Veiculos ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.MaskedTextBox maskPlaca;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.TextBox textChassi;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textVeiculo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}