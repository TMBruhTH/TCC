using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.Model
{
    public class caixa
    {
        public int idCaixa { get; set; }
        public int idServico { get; set; }
        public int cliente { get; set; }
        public double valor { get; set; }
        public string parcela { get; set; }
        //public string tipoParcela { get; set; }
        public string dataPagamento { get; set; }
        public string status { get; set; }
    }
}
