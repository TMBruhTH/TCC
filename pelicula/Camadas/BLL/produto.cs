using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class produto
    {
        public List<Model.produto> Select()
        {
            DAL.produto dalProduto = new DAL.produto();
            return dalProduto.Select();
        }

        public void Insert(Model.produto produto)
        {
            DAL.produto dalProduto = new DAL.produto();
            dalProduto.Insert(produto);
        }

        public void Update(Model.produto produto)
        {
            DAL.produto dalProduto = new DAL.produto();
            dalProduto.Update(produto);
        }

        public void Delete(Model.produto produto)
        {
            DAL.produto dalProduto = new DAL.produto();
            dalProduto.Delete(produto);
        }
    }
}
