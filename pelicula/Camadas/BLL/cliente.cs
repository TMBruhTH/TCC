using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class cliente
    {
        public List<Model.cliente> Select()
        {
            DAL.cliente dalCliente = new DAL.cliente();
            return dalCliente.Select();
        }

        public void Insert(Model.cliente cliente)
        {
            DAL.cliente dalCliente = new DAL.cliente();
            dalCliente.Insert(cliente);
        }

        public void Update(Model.cliente cliente)
        {
            DAL.cliente dalCliente = new DAL.cliente();
            dalCliente.Update(cliente);
        }

        public void Delete(Model.cliente cliente)
        {
            DAL.cliente dalCliente = new DAL.cliente();
            dalCliente.Delete(cliente);
        }
    }
}
