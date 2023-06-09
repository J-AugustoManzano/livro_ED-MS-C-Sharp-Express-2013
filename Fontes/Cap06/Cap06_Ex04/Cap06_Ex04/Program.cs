using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap06_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] NOME = new string[5];
            int I, J;
            string X;

            // Entrada de dados

            for (I = 0; I <= 4; I++)
            {
                Console.Write("Entre o {0}o. nome: ", I + 1);
                NOME[I] = Console.ReadLine();
            }

            // Processamento ordenacao

            for (I = 0; I <= 3; I++)
                for (J = I + 1; J <= 4; J++)
                    if (NOME[I].CompareTo(NOME[J]) > 0)
                    {
                        X = NOME[I];
                        NOME[I] = NOME[J];
                        NOME[J] = X;
                    }
            Console.WriteLine();

            // Apresentacao dos arranjos

            Console.WriteLine("Lista de nomes ordenada");
            Console.WriteLine();

            for (I = 0; I <= 4; I++)
                Console.WriteLine(NOME[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
