﻿using NerdStore.Core.Data;
using NerdStore.Vendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Domain.IRepository
{
	public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<Pedido> ObterPorId(Guid id);
        Task<IEnumerable<Pedido>> ObterListaPorClienteId(Guid clienteId);
        Task<Pedido> ObterPedidoRascunhoPorClienteId(Guid clienteId);
        void Adicionar(Pedido pedido);
        void Atualizar(Pedido pedido);

        Task<PedidoItem> ObterItemPorId(Guid id);
        Task<PedidoItem> ObterItemPorPedido(Guid pedidoId, Guid produtoId);
        void AdicionarItem(PedidoItem pedidoItem);
        void AtualizarItem(PedidoItem pedidoItem);
        void RemoverItem(PedidoItem pedidoItem);

        Task<Voucher> ObterVoucherPorCodigo(string codigo);
    }
}