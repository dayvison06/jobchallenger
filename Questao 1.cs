using System;
using System.Runtime.Serialization;

namespace JobChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            1) Observe o trecho de código abaixo:

            int INDICE = 13, SOMA = 0, K = 0;

            enquanto K < INDICE faça

            {

            K = K + 1;

            SOMA = SOMA + K;

            }

            imprimir(SOMA);



            Ao final do processamento, qual será o valor da variável SOMA?
             
             */

            int indice, soma, k; ;

            indice = 13;
            soma = 0;
            k = 0;

            while (k < indice)
            {
                k++;
                soma = soma + k;
            }

            System.Console.WriteLine(soma);
            //Soma = 91;

        }
    }
}
