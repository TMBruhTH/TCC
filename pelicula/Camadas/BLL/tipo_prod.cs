using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class tipo_prod
    {
        public List<Model.tipo_prod> Select()
        {
            DAL.tipo_prod dalTipo_prod = new DAL.tipo_prod();
            return dalTipo_prod.Select();
        }

        public void Insert(Model.tipo_prod tipo_prod)
        {
            DAL.tipo_prod dalTipo_prod = new DAL.tipo_prod();
            dalTipo_prod.Insert(tipo_prod);
        }
        public void Update(Model.tipo_prod tipo_prod)
        {
            DAL.tipo_prod dalTipo_prod = new DAL.tipo_prod();
            dalTipo_prod.Update(tipo_prod);
        }

        public void Delete(Model.tipo_prod tipo_prod)
        {
            DAL.tipo_prod dalTipo_prod = new DAL.tipo_prod();
            dalTipo_prod.Delete(tipo_prod);
        }
    }
}
