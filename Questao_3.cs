using System;
using System.Runtime.Serialization;

namespace JobChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3) Descubra a lógica e complete o próximo elemento:


            // Letra A - 1, 3, 5, 7, ___
            // Possível lógica seria mostrar os número impares.
            
            int a = 9;
            Console.WriteLine("--- Letra A ---");
            Console.WriteLine("Próximo elemento é 9");
            for (int i = 0; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }


            Console.WriteLine("\n\n--- Letra B ---");

            // Letra B - 2, 4, 8, 16, 32, 64, ____
            // o número recebe ele mesmo * 2;
            Console.WriteLine("Próximo elemento é 128");
            int b = 80;
            int bi = 1;

            while (bi < b)
            {
                bi = bi * 2;
                Console.Write($"{bi} ");
            }

            Console.WriteLine("\n\n--- Letra C ---");

            // Letra C - 0, 1, 4, 9, 16, 25, 36, ____
            // Resultado do quadrado dos números de 1 a 7
            Console.WriteLine("Próximo elemento é 49");
            int c = 7;
            for (int i = 0; i <= c; i++)
            {
                Console.Write($"{Math.Pow(i, 2):F0} ");
            }

            Console.WriteLine("\n\n--- Letra D ---");
            // Letra D - 4, 16, 36, 64, ____
            // O quadro dos números de 2 a 10, pulando de 2 em 2.
            Console.WriteLine("Próximo elemento é 100");


            //expectativa = { 4, 16, 36, 64, 100 };
            int[] realidade = { 2, 4, 6, 8, 10 };

            foreach (int item in realidade)
            {
                Console.Write($"{Math.Pow(item, 2)} ");
            }


            Console.WriteLine("\n\n--- Letra E ---");

            // Letra E - 1, 1, 2, 3, 5, 8, ____
            // Sequencia de Fibonacci
            Console.WriteLine("Próximo elemento é 13");
            int n1 = 0, n2 = 1;
            int e = 8;

            for (int i = 0; i < e; i++)
            {
                Console.Write($"{n1} ");

                int cache = n1;
                n1 = n2;
                n2 = cache + n2;
            }

            Console.WriteLine("\n\n--- Letra F ---");

            // Letra F - 2,10, 12, 16, 17, 18, 19, ____
            // não tem um padrão perceptivel
            Console.WriteLine("Próximo elemento é 20");



        }
    }
}
