using NerdStore.Core.DTO;
using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Interfaces
{
	public interface IEstoqueService : IDisposable
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);
        Task<bool> DebitarListaProdutosPedido(ListaProdutosPedido listaProdutosPedido);
        Task<bool> ReporEstoque(Guid produtoId, int quantidade);
        Task<bool> ReporListaProdutosPedido(ListaProdutosPedido listaProdutosPedido);
    }
}