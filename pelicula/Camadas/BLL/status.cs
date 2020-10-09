using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class status
    {
        public List<Model.status> Select()
        {
            DAL.status dalStatus = new DAL.status();
            return dalStatus.Select();
        }

        public void Insert(Model.status status)
        {
            DAL.status dalStatus = new DAL.status();
            dalStatus.Insert(status);
        }

        public void Update(Model.status status)
        {
            DAL.status dalStatus = new DAL.status();
            dalStatus.Update(status);
        }

        public void Delete(Model.status status)
        {
            DAL.status dalStatus = new DAL.status();
            dalStatus.Delete(status);
        }
    }
}
