﻿using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain.Entities
{
	public class Categoria : Entity
	{
		public string Nome { get; private set; }

		public int Codigo { get; private set; }

		public ICollection<Produto> Produtos { get; set;  }

		protected Categoria() { }

		public Categoria(
			string nome,
			int codigo)
		{
			Nome = nome;
			Codigo = codigo;

			Validar();
		}

		public override string ToString()
		{
			return $"{Codigo} - {Nome}";
		}

		public void Validar()
		{
			Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria não pode estar vazio");
			Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser 0");
		}
	}
}