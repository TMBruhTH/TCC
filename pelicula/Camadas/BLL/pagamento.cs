using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class pagamento
    {
        public List<Model.pagamento> Select()
        {
            DAL.pagamento dalPgt = new DAL.pagamento();
            return dalPgt.Select();
        }

        public void Insert(Model.pagamento pgt)
        {
            DAL.pagamento dalPgt = new DAL.pagamento();
            dalPgt.Insert(pgt);
        }

        public void Update(Model.pagamento pgt)
        {
            DAL.pagamento dalPgt = new DAL.pagamento();
            dalPgt.Update(pgt);
        }

        public void Delete(Model.pagamento pgt)
        {
            DAL.pagamento dalPgt = new DAL.pagamento();
            dalPgt.Delete(pgt);
        }
    }
}
