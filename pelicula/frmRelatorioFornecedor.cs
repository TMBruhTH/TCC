﻿using System;
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
    public partial class frmRelatorioFornecedor : Form
    {
        public frmRelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void frmRelatorioFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fornecedorDataset.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.fornecedorDataset.fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
