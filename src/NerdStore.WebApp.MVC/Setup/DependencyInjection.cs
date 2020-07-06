using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalogo.Application.IServices;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Data.Context;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain.Events;
using NerdStore.Catalogo.Domain.Interfaces;
using NerdStore.Catalogo.Domain.Services;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Pagamentos.AntiCorruption.Facade;
using NerdStore.Pagamentos.AntiCorruption.Interfaces;
using NerdStore.Pagamentos.AntiCorruption.Services;
using NerdStore.Pagamentos.Business.Events;
using NerdStore.Pagamentos.Business.IServices;
using NerdStore.Pagamentos.Business.Repository;
using NerdStore.Pagamentos.Business.Services;
using NerdStore.Pagamentos.Data.Context;
using NerdStore.Pagamentos.Data.Repository;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Application.Events;
using NerdStore.Vendas.Application.Queries.Interfaces;
using NerdStore.Vendas.Application.Queries.Services;
using NerdStore.Vendas.Data.Context;
using NerdStore.Vendas.Data.Repository;
using NerdStore.Vendas.Domain.IRepository;

namespace NerdStore.WebApp.MVC.Setup
{
	public static class DependencyInjection
	{
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

			// Notifications
			services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

			// Event Sourcing
			services.AddSingleton<EventSourcing.IEventStoreService, EventSourcing.EventStoreService>();
			services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

			// Catalogo
			services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
			services.AddScoped<INotificationHandler<PedidoIniciadoEvent>, ProdutoEventHandler>();
			services.AddScoped<INotificationHandler<PedidoProcessamentoCanceladoEvent>, ProdutoEventHandler>();

			//// Vendas
			services.AddScoped<IPedidoRepository, PedidoRepository>();
			services.AddScoped<IPedidoQueriesService, PedidoQueriesService>();
			services.AddScoped<VendaContext>();

			services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<AtualizarItemPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<RemoverItemPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<AplicarVoucherPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<IniciarPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<FinalizarPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoCommand, bool>, PedidoCommandHandler>();
			services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoEstornarEstoqueCommand, bool>, PedidoCommandHandler>();

			services.AddScoped<INotificationHandler<PedidoRascunhoIniciadoEvent>, PedidoEventHandler>();
			services.AddScoped<INotificationHandler<PedidoEstoqueRejeitadoEvent>, PedidoEventHandler>();
			services.AddScoped<INotificationHandler<PedidoPagamentoRealizadoEvent>, PedidoEventHandler>();
			services.AddScoped<INotificationHandler<PedidoPagamentoRecusadoEvent>, PedidoEventHandler>();

			// Pagamento
			services.AddScoped<IPagamentoRepository, PagamentoRepository>();
			services.AddScoped<IPagamentoService, PagamentoService>();
			services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
			services.AddScoped<IPayPalGateway, PayPalGateway>();
			services.AddScoped<IConfigurationManager, ConfigurationManager>();
			services.AddScoped<PagamentoContext>();

			services.AddScoped<INotificationHandler<PedidoEstoqueConfirmadoEvent>, PagamentoEventHandler>();
		}
    }
}