using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catalogo.Domain
{
	public class Produto : Entity, IAggregateRoot
	{
		public string Nome { get; private set; }

		public string Descricao { get; private set; }

		public bool Ativo { get; private set; }

		public decimal Valor { get; private set; }

		public DateTime DataCadastro { get; private set; }

		public string Imagem { get; private set; }

		public int QuantidadeEstoque { get; private set; }

		public Guid CategoriaId { get; private set; }

		public Categoria Categoria { get; private set; }

		public Produto(
			string nome,
			string descricao,
			bool ativo,
			decimal valor,
			Guid categoriaId,
			DateTime dataCadastro,
			string imagem,
			int quantidadeEstoque)
		{
			Nome = nome;
			Descricao = descricao;
			Ativo = ativo;
			Valor = valor;
			CategoriaId = categoriaId;
			DataCadastro = dataCadastro;
			Imagem = imagem;
			QuantidadeEstoque = quantidadeEstoque;

		}
	}

	public class Categoria : Entity
	{

	}
}
