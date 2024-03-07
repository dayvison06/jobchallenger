using System;
using System.Runtime.Serialization;

namespace JobChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             
            2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma
            dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na
            linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne
            uma mensagem avisando se o número informado pertence ou não a sequência.

            IMPORTANTE:

            Esse número pode ser informado através de qualquer entrada de sua preferência ou
            pode ser previamente definido no código;
             
             */

            // Sequencia de Fibonacci

            int x = 0, y = 1;

            Console.Write("Insira um valor: ");
            int n = int.Parse(Console.ReadLine());
            int memory = 0;

            for (int i = 0; i <= n + 1; i++)
            {
                Console.Write($"{x} ");

                int cache = x;
                x = y;
                y = cache + y;

                if (cache == n)
                {
                    memory = cache;
                }
            }

            if (memory == n)
            {
                Console.WriteLine($"\n\n{n} pertence a sequência");
            }
            else
            {
                Console.WriteLine($"\n\n{n} não pertence");
            }

        }
    }
}
