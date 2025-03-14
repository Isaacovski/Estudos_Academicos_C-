﻿using System.Globalization;
using CalculaProdutosEstoque;

namespace Curse {
    internal class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:  ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qantidade no Estoque  :");
            p.Quantidade = int.Parse(Console.ReadLine());

             
            Console.WriteLine();
            Console.WriteLine( "Dados do produto:  "+  p );
            Console.WriteLine("Digite o numero de produtos a ser adcionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Dados do produto:  " + p);
            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
             qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}