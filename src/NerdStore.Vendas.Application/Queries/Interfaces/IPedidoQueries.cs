using NerdStore.Vendas.Application.Queries.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Queries.Interfaces
{
	public interface IPedidoQueriesService
	{
		Task<CarrinhoViewModel> ObterCarrinhoCliente(Guid clienteId);
		Task<IEnumerable<PedidoViewModel>> ObterPedidosCliente(Guid clienteId);
	}
}
