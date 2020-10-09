using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class fornecedor
    {
        public List<Model.fornecedor> Select()
        {
            DAL.fornecedor dalFornecedor = new DAL.fornecedor();
            return dalFornecedor.Select();
        }

        public void Insert(Model.fornecedor fornecedor)
        {
            DAL.fornecedor dalFornecedor = new DAL.fornecedor();
            dalFornecedor.Insert(fornecedor);
        }

        public void Update(Model.fornecedor fornecedor)
        {
            DAL.fornecedor dalFornecedor = new DAL.fornecedor();
            dalFornecedor.Update(fornecedor);
        }

        public void Delete(Model.fornecedor fornecedor)
        {
            DAL.fornecedor dalFornecedor = new DAL.fornecedor();
            dalFornecedor.Delete(fornecedor);
        }
    }
}
