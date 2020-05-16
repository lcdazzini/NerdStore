﻿using MediatR;
using NerdStore.Catalogo.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
	public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
	{
		private readonly IProdutoRepository _produtoRepository;

		public ProdutoEventHandler(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		public async Task Handle(ProdutoAbaixoEstoqueEvent notification, CancellationToken cancellationToken)
		{
			var produto = await _produtoRepository.ObterPorId(notification.AggregateId);

			// TODO: Enviar um e-mail para  aquisição de mais produtos.

			//return Task.CompletedTask;
		}
	}
}
