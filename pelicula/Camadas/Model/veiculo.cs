using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class veiculo
    {
        public int idVeiculo { get; set; }
        public int idCiente { get; set; }
        public string nome { get; set; }
        public string modelo { get; set; }
        public string chassi { get; set; }
        public string ano { get; set; }
        public string placa { get; set; }
    }
}
