using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class produto
    {
        public int idProduto { get; set; }
        public int idFornecedor { get; set; }
        public int idTipo_prod { get; set; }
        public string tonalidade { get; set; }
        public double valor { get; set; }
    }
}
