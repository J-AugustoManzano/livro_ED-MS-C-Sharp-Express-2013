using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap06_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] A = new int[3, 3];

            int I, J, LIN = 7, COL = 0;

            Console.SetCursorPosition(0, 0);
            Console.Write("Entre um valor na coordenada:");
            Console.SetCursorPosition(0, 2);
            Console.Write("Linha ...: ");
            Console.SetCursorPosition(0, 3);
            Console.Write("Coluna ..: ");

            for (I = 0; I <= 2; I++)
            {
                for (J = 0; J <= 2; J++)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("{0}", I + 1);
                    Console.SetCursorPosition(11, 3);
                    Console.Write("{0}", J + 1);
                    Console.SetCursorPosition(0, 5);
                    Console.Write("--> ");
                    A[I, J] = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(4, 5);
                    Console.Write("    ");
                    Console.SetCursorPosition(COL, LIN);
                    Console.Write("{0,4}", A[I, J]);
                    COL += 6;
                }
                LIN += 2;
                COL -= 18;
            }

            Console.SetCursorPosition(0, 13);
            Console.Write("Saida - Diagonal Principal");
            Console.SetCursorPosition(0, 15);

            for (I = 0; I <= 2; I++)
            {
                for (J = 0; J <= 2; J++)
                {
                    if (I == J)
                    {
                        Console.Write("A[{0},{1}]", I + 1, J + 1);
                        Console.WriteLine(" = {0,4}", A[I, J]);
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
