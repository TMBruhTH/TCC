using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pelicula.Camadas.DAL;
using CrystalDecisions.Windows.Forms.Internal.Win32;

namespace pelicula
{
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clienteDataset.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.clienteDataset.cliente);


            this.reportViewer1.RefreshReport();
        }
    }
}
