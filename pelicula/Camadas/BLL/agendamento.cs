using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class agendamento
    {
        public List<Model.agendamento> Select()
        {
            DAL.agendamento dalAgenda = new DAL.agendamento();
            return dalAgenda.Select();
        }

        public void Insert(Model.agendamento agenda)
        {
            DAL.agendamento dalAgenda = new DAL.agendamento();
            dalAgenda.Insert(agenda);
        }

        public void Update(Model.agendamento agenda)
        {
            DAL.agendamento dalAgenda = new DAL.agendamento();
            dalAgenda.Update(agenda);
        }

        public void Delete(Model.agendamento agenda)
        {
            DAL.agendamento dalAgenda = new DAL.agendamento();
            dalAgenda.Delete(agenda);
        }
    }
}
