namespace pelicula
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncinoárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.orçamentosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.serviçosToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serviçosToolStripMenuItem.BackgroundImage")));
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoServiçoToolStripMenuItem,
            this.agendamentoToolStripMenuItem});
            this.serviçosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.serviçosToolStripMenuItem.Text = "&Serviços";
            // 
            // novoServiçoToolStripMenuItem
            // 
            this.novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            this.novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.novoServiçoToolStripMenuItem.Text = "&Novo serviço";
            this.novoServiçoToolStripMenuItem.Click += new System.EventHandler(this.novoServiçoToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.agendamentoToolStripMenuItem.Text = "&Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoOrçamentoToolStripMenuItem});
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.orçamentosToolStripMenuItem.Text = "&Orçamentos";
            // 
            // novoOrçamentoToolStripMenuItem
            // 
            this.novoOrçamentoToolStripMenuItem.Name = "novoOrçamentoToolStripMenuItem";
            this.novoOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.novoOrçamentoToolStripMenuItem.Text = "&Novo orçamento";
            this.novoOrçamentoToolStripMenuItem.Click += new System.EventHandler(this.novoOrçamentoToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFornecedorToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.fornecedoresToolStripMenuItem.Text = "&Fornecedores";
            // 
            // novoFornecedorToolStripMenuItem
            // 
            this.novoFornecedorToolStripMenuItem.Name = "novoFornecedorToolStripMenuItem";
            this.novoFornecedorToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.novoFornecedorToolStripMenuItem.Text = "&Novo fornecedor";
            this.novoFornecedorToolStripMenuItem.Click += new System.EventHandler(this.novoFornecedorToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncinoárioToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.funcionáriosToolStripMenuItem.Text = "&Funcionários";
            // 
            // novoFuncinoárioToolStripMenuItem
            // 
            this.novoFuncinoárioToolStripMenuItem.Name = "novoFuncinoárioToolStripMenuItem";
            this.novoFuncinoárioToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.novoFuncinoárioToolStripMenuItem.Text = "&Novo funcinoário";
            this.novoFuncinoárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncinoárioToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoVeículoToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.veículosToolStripMenuItem.Text = "&Veículos";
            // 
            // novoVeículoToolStripMenuItem
            // 
            this.novoVeículoToolStripMenuItem.Name = "novoVeículoToolStripMenuItem";
            this.novoVeículoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.novoVeículoToolStripMenuItem.Text = "&Novo veículo";
            this.novoVeículoToolStripMenuItem.Click += new System.EventHandler(this.novoVeículoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.novoClienteToolStripMenuItem.Text = "&Novo cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.caixaToolStripMenuItem.Text = "&Produto";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Checked = true;
            this.sairToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.sairToolStripMenuItem.Text = "&Caixa";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.produtoToolStripMenuItem.Text = "&Sair";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 638);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoOrçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncinoárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
    }
}