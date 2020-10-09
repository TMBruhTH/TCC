using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class veiculo
    {
        public List<Model.veiculo> Select()
        {
            DAL.veiculo dalVeiculo = new DAL.veiculo();
            return dalVeiculo.Select();
        }

        public void Insert(Model.veiculo veiculo)
        {
            DAL.veiculo dalVeiculo = new DAL.veiculo();
            dalVeiculo.Insert(veiculo);
        }

        public void Update(Model.veiculo veiculo)
        {
            DAL.veiculo dalVeiculo = new DAL.veiculo();
            dalVeiculo.Update(veiculo);
        }

        public void Delete(Model.veiculo veiculo)
        {
            DAL.veiculo dalVeiculo = new DAL.veiculo();
            dalVeiculo.Delete(veiculo);
        }
    }
}
