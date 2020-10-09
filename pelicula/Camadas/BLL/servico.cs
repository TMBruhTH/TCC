using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class servico
    {
        public List<Model.servico> Select()
        {
            DAL.servico dalServico = new DAL.servico();
            return dalServico.Select();
        }

        public void PreServico(Model.servico srv)
        {
            servico bllSrv = new servico();
            bllSrv.PreSrv(srv);
            Model.caixa caixa = new Model.caixa();
            caixa bllCaixa = new caixa();
            caixa.idServico = srv.idServico;
            caixa.cliente = srv.idCliente;
            caixa.valor = srv.valor;
            caixa.status = srv.status;
            bllCaixa.PreSrvCaixa(caixa);
        }

        public void Insert(Model.servico servico)
        {
            DAL.servico dalServico = new DAL.servico();
            dalServico.Insert(servico);
        }

        public void Update(Model.servico servico)
        {
            DAL.servico dalServico = new DAL.servico();
            dalServico.Update(servico);
        }

        public void PreSrv(Model.servico srv)
        {
            DAL.servico dalSrv = new DAL.servico();
            dalSrv.Pre(srv);
        }

        public void Delete(Model.servico servico)
        {
            DAL.servico dalServico = new DAL.servico();
            dalServico.Delete(servico);
        }
    }
}
