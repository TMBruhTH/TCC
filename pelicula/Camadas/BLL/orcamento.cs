using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pelicula.Camadas.BLL
{
    public class orcamento
    {
        public List<Model.orcamento> Select()
        {
            DAL.orcamento dalOrcamento = new DAL.orcamento();
            return dalOrcamento.Select();
        }

        public void Aprovar(Model.orcamento orc)
        {
            //mudar orc para aprovado
            orcamento bllOrc = new orcamento();
            bllOrc.Update(orc);
            Model.servico srv = new Model.servico();
            servico bllServico = new servico();
            srv.idServico = orc.idOrcamento;
            srv.idCliente = orc.idCliente;
            srv.idVeiculo = orc.idVeiculo;
            srv.idProduto = orc.idProduto;
            srv.idFuncionario = orc.idFuncionario;
            srv.tipo = orc.tipo;
            srv.serv_lateral = orc.serv_lateral;
            srv.serv_frontal = orc.serv_frontal;
            srv.valor = orc.valor;
            srv.status = orc.status;
            bllServico.Insert(srv);
        }



        public void Insert(Model.orcamento orcamento)
        {
            DAL.orcamento dalOrcamento = new DAL.orcamento();
            dalOrcamento.Insert(orcamento);
        }

        public void Update(Model.orcamento orcamento)
        {
            DAL.orcamento dalOrcamento = new DAL.orcamento();
            dalOrcamento.Update(orcamento);
        }

        public void Delete(Model.orcamento orcamento)
        {
            DAL.orcamento dalOrcamento = new DAL.orcamento();
            dalOrcamento.Delete(orcamento);
        }
    }
}
