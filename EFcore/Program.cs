using System;
using System.Linq;
using EFcore.Domain;
using EFcore.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace EF.core
{
    class Program
    {
        static void Main(string[] args, Produto produto)
        {
            InserirDados(produto);
        }

        private static void InserirDados(Produto produto)
        {
            var Produto = new Produto
            {
                Descricao = "Produto Teste",
                CodigoBarras = "123456789101112",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true
            };
        }
    }
}







