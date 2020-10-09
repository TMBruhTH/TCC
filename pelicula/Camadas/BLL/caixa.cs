using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class caixa
    {
        public List<Model.caixa> Select()
        {
            DAL.caixa dalCaixa = new DAL.caixa();
            return dalCaixa.Select();
        }

        public void Insert(Model.caixa caixa)
        {
            DAL.caixa dalCaixa = new DAL.caixa();
            dalCaixa.Insert(caixa);
        }

        public void PreSrvCaixa(Model.caixa caixa)
        {
            DAL.caixa dalCaixa = new DAL.caixa();
            dalCaixa.PreSrvCaixa(caixa);
        }

        public void Update(Model.caixa caixa)
        {
            DAL.caixa dalCaixa = new DAL.caixa();
            dalCaixa.Update(caixa);
        }

        public void Delete(Model.caixa caixa)
        {
            DAL.caixa dalCaixa = new DAL.caixa();
            dalCaixa.Delete(caixa);
        }
    }
}
