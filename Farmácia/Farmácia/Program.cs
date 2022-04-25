using System;

namespace Farmácia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos remédios você quer cadastrar: ");
            int tamanhoVetor = int.Parse(Console.ReadLine());

            string[] remedios = new string[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write("Qual é o medicamento: ");
                remedios[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("--------------------------");

            int count = 1;
            foreach (var remedio in remedios)
            {
                
                Console.WriteLine($"{count++}. {remedio}");

            }
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("Qual é o nome do medicamente você está procurando: ");
            var resp = Array.IndexOf(remedios, Console.ReadLine());
            Console.WriteLine($"Ainda temos e está na posição {resp + 1}");
        }
    }
}
