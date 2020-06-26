using NerdStore.Core.DTO;
using NerdStore.Pagamentos.Business.Entities;
using System.Threading.Tasks;

namespace NerdStore.Pagamentos.Business.IServices
{
	public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}