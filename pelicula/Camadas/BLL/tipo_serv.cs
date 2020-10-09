using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class tipo_serv
    {
        public List<Model.tipo_serv> Select()
        {
            DAL.tipo_serv dalTipo_serv = new DAL.tipo_serv();
            return dalTipo_serv.Select();
        }

        public void Insert(Model.tipo_serv tipo_serv)
        {
            DAL.tipo_serv dalTipo_serv = new DAL.tipo_serv();
            dalTipo_serv.Insert(tipo_serv);
        }

        public void Update(Model.tipo_serv tipo_serv)
        {
            DAL.tipo_serv dalTipo_serv = new DAL.tipo_serv();
            dalTipo_serv.Update(tipo_serv);
        }

        public void Delete(Model.tipo_serv tipo_serv)
        {
            DAL.tipo_serv dalTipo_serv = new DAL.tipo_serv();
            dalTipo_serv.Delete(tipo_serv);
        }
    }
}
