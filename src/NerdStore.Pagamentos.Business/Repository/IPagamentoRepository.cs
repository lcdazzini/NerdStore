﻿using NerdStore.Core.Data;
using NerdStore.Pagamentos.Business.Entities;

namespace NerdStore.Pagamentos.Business.Repository
{
	public interface IPagamentoRepository : IRepository<Pagamento>
	{
		void Adicionar(Pagamento pagamento);

		void AdicionarTransacao(Transacao transacao);
	}
}