using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public Pedido BuscarPedidoEmAbertoPorComanda(string comanda)
        {
            var pedido = (from p in Db.Pedido where p.Comanda.Equals(comanda) && p.DataFechamento == null select p).FirstOrDefault();
            if (pedido == null)
                throw new Exception("Nenhum pedido com esta comanda está em aberto!");
            return pedido;
        }
    }
}
