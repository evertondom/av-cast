using System;
using System.Globalization;

namespace VendasComissoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários são: ");
            int tamanhoVetor = int.Parse(Console.ReadLine());
            Console.Write("Quantos produtos são: ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            Console.Clear();

            string[] item = new string[qtdProdutos];
            double[] valores = new double[qtdProdutos];
            string[] funcionarios = new string[tamanhoVetor];
            
            for (int j = 0; j < qtdProdutos; j++)
            {
               Console.Write("Qual é o produto: ");
               item[j] = Console.ReadLine();
               Console.Write("Qual é o valor: ");
               valores[j] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine("Qual é o nome do Funcionário: ");
                funcionarios[i] = Console.ReadLine(); 
            }
            Console.Clear();           

        }
    }
}
