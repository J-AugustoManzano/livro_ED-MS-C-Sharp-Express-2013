using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap06_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[5];
            int I, J, X;

            // Entrada de dados

            for (I = 0; I <= 4; I++)
            {
                Console.Write("Entre valor para A[{0}]: ", I);
                A[I] = int.Parse(Console.ReadLine());
            }

            // Processamento ordenacao

            for (I = 0; I <= 3; I++)
                for (J = I + 1; J <= 4; J++)
                    if (A[I] > A[J])
                    {
                        X = A[I];
                        A[I] = A[J];
                        A[J] = X;
                    }
            Console.WriteLine();

            // Apresentacao dos arranjos

            for (I = 0; I <= 4; I++)
                Console.WriteLine("A[{0}] = {1,4}", I, A[I]);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}