using System;
using System.Runtime.Serialization;

namespace JobChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
             5) Escreva um programa que inverta os caracteres de um string.


            IMPORTANTE:

            a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

            b) Evite usar funções prontas, como, por exemplo, reverse;
             
             */

            Console.Write("Informe uma palavra para ser invertida: ");
            string entrada = Console.ReadLine();

            char[] letras = new char[entrada.Length]; 

            for (int i = 0; i < letras.Length; i++)
            {
                /* Como peguei o tamanho de caracteres da string "Entrada"
                 Eu passo esse parâmetro para que seja listado os items do array começando do tamanho total "- 1"
                 que seria para descontar o inicio do array de posição "0" onde não diminuiria nada já que o "i"
                 estará valendo "0" nesse momento, depois utilizo o proprio incremento "i"
                 para percorrer o array do fim para o inicio
                */

                letras[i] = entrada[entrada.Length - 1 - i];

            }

            // percorrer e listar os elementos do array que agora já estão invertidos
            foreach (char item in letras)
            {
                Console.Write($"{item}");
            }

        }
    }
}
