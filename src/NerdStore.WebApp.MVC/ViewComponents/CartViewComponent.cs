using Microsoft.AspNetCore.Mvc;
using NerdStore.Vendas.Application.Queries.Interfaces;
using System;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.ViewComponents
{
	public class CartViewComponent : ViewComponent
    {
        private readonly IPedidoQueriesService _pedidoQueries;

        // TODO: Obter cliente logado
        protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");


        public CartViewComponent(IPedidoQueriesService pedidoQueries)
        {
            _pedidoQueries = pedidoQueries;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var carrinho = await _pedidoQueries.ObterCarrinhoCliente(ClienteId);
            var itens = carrinho?.Items.Count ?? 0;

            return View(itens);
        }
    }
}