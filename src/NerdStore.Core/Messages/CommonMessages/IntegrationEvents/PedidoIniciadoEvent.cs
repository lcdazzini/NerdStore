﻿using NerdStore.Core.DTO;
using System;

namespace NerdStore.Core.Messages.CommonMessages.IntegrationEvents
{
	public class PedidoIniciadoEvent : IntegrationEvent
	{


		public Guid PedidoId { get; private set; }

		public Guid ClienteId { get; private set; }

		public decimal Total { get; private set; }

		public ListaProdutosPedido ListaProdutosPedido { get; private set; }

		public string NomeCartao { get; private set; }

		public string NumeroCartao { get; private set; }

		public string ExpiracaoCartao { get; private set; }

		public string CvvCartao { get; private set; }

		public PedidoIniciadoEvent(
			Guid pedidoId, 
			Guid clienteId, 
			decimal total, 
			ListaProdutosPedido listaProdutosPedido, 
			string nomeCartao, 
			string numeroCartao, 
			string expiracaoCartao, 
			string cvvCartao)
		{
			PedidoId = pedidoId;
			ClienteId = clienteId;
			Total = total;
			ListaProdutosPedido = listaProdutosPedido;
			NomeCartao = nomeCartao;
			NumeroCartao = numeroCartao;
			ExpiracaoCartao = expiracaoCartao;
			CvvCartao = cvvCartao;
		}
	}
}
