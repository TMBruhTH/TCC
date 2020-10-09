using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class funcionario
    {
        public int idFuncionario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string nr { get; set; }
        public string cep { get; set; }
        public string admissao { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
