using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.DAL
{
    public class Conexao
    {
        public static string getConexao()
        {
            return @"Data Source=.\Bruno;Initial Catalog=pelicula;Integrated Security=True";
        }
    }
}
