using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class fornecedor
    {
        public int idFornecedor { get; set; }
        public string razao_social { get; set; }
        public string email { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string nr { get; set; }
        public string iestadual { get; set; }
        public string imunicipal { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
    }
}
