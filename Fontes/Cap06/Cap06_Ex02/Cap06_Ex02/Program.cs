using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap06_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int[] B = new int[10];

            int I;

            // Entrada de dados

            for (I = 0; I <= 9; I++)
            {
                Console.Write("Media media {0,2}o. aluno: ", I + 1);
                A[I] = int.Parse(Console.ReadLine());
            }

            // Processamento par ou impar

            for (I = 0; I <= 9; I++)
                if (I % 2 == 0)
                    B[I] = A[I] * 5;
                else
                    B[I] = A[I] + 5;
            Console.WriteLine();

            // Apresentacao dos arranjos

            for (I = 0; I <= 9; I++)
            {
                Console.Write("A[{0}] = {1,4} / ", I, A[I]);
                Console.Write("B[{0}] = {1,4}", I, B[I]);
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
