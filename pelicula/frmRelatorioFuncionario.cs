using System;
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
    public partial class frmRelatorioFuncionario : Form
    {
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funcionarioDataset.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.funcionarioDataset.funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
