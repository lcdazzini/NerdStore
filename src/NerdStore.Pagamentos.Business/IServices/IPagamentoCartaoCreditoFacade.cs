using NerdStore.Pagamentos.Business.Entities;

namespace NerdStore.Pagamentos.Business.IServices
{
	public interface IPagamentoCartaoCreditoFacade
    {
        Transacao RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}