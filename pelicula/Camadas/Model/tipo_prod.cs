using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class tipo_prod
    {
        public int idTipo_prod { get; set; }
        //public int idProduto { get; set; }
        public string tipo { get; set; }
    }
}
