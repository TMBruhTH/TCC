using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class servico
    {
        public int idServico { get; set; }
        public int idCliente { get; set; }
        public int idVeiculo { get; set; }
        public int idProduto { get; set; }
        public int idFuncionario { get; set; }
        //public int idTipo_prod { get; set; }
        //public int idTipo_serv { get; set; }
        public string tipo { get; set; }
        public string serv_lateral { get; set; }
        public string serv_frontal { get; set; }
        public double valor { get; set; }
        public string status { get; set; }
    }
}
