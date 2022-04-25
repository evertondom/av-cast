using System;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sorteio = new Random().Next(1, 10);
            int tentativas = 1;

            Console.WriteLine("================================");
            Console.WriteLine("Bem vindo ao Jogo de Adivinhação");
            Console.WriteLine("================================");
            Console.WriteLine();

            Console.Write("Para começarmos, Digite a quantidade de Jogadas: ");
            int jogadas = int.Parse(Console.ReadLine());

            bool resp = true;
            
             while (resp)
             {
                 Console.Write("Digite um número entre 1 a 10: ");
                 int chute = int.Parse(Console.ReadLine());
                
                if (chute <= 10 && chute == sorteio && tentativas < jogadas)
                {
                    tentativas++;
                    Console.WriteLine();
                    Console.WriteLine("Você acetou o número! Parabénss!!");
                    Console.WriteLine($"Conseguiu acertar na tentativa: {tentativas}");
                    resp = false;
                }
                else if(chute <= 10 && chute != sorteio && tentativas < jogadas)
                {
                    tentativas++;
                    Console.WriteLine("Você errouu!");
                }
                else if (chute <= 10 && tentativas < jogadas)
                {
                    tentativas++;
                    Console.WriteLine();
                    Console.WriteLine($"Tentativas: {tentativas} vezes");
                    Console.WriteLine("Suas tentativas acabaram.");
                    Console.WriteLine("Você não conseguiu acertar o número");
                    resp = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Você tentou {tentativas} vezes, mas não conseguiu :c");
                    resp = false;
                }
                
             }
            Console.WriteLine();
            Console.WriteLine("O Jogo acabou, Volte Sempre :)");

                               
        }
    }
}
