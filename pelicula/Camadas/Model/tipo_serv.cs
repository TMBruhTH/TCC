using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class tipo_serv
    {
        public int idTipo_serv { get; set; }
        public int idTipo_prod { get; set; }
        public string serv_lateral { get; set; }
        public string serv_frontal { get; set; }
    }
}
