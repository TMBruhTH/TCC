using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class funcionario
    {
        public List<Model.funcionario> Select()
        {
            DAL.funcionario dalFuncionario = new DAL.funcionario();
            return dalFuncionario.Select();
        }

        public void Insert(Model.funcionario funcionario)
        {
            DAL.funcionario dalFuncionario = new DAL.funcionario();
            dalFuncionario.Insert(funcionario);
        }

        public void Update(Model.funcionario funcionario)
        {
            DAL.funcionario dalFuncionario = new DAL.funcionario();
            dalFuncionario.Update(funcionario);
        }

        public void Delete(Model.funcionario funcionario)
        {
            DAL.funcionario dalFuncionario = new DAL.funcionario();
            dalFuncionario.Delete(funcionario);
        }
    }
}
