namespace pelicula
{
    partial class frmRelatorioVeiculos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.veiculosDataset = new pelicula.veiculosDataset();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new pelicula.veiculosDatasetTableAdapters.veiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.veiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pelicula.relatorioVeiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(473, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // veiculosDataset
            // 
            this.veiculosDataset.DataSetName = "veiculosDataset";
            this.veiculosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "veiculo";
            this.veiculoBindingSource.DataSource = this.veiculosDataset;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 442);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmRelatorioVeiculos";
            this.Text = ".:: Relatório de Veículos ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veiculosDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private veiculosDataset veiculosDataset;
        private veiculosDatasetTableAdapters.veiculoTableAdapter veiculoTableAdapter;
    }
}