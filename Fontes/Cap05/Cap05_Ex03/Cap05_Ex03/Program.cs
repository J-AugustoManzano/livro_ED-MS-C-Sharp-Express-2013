﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap05_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            byte X;

            Console.Title = "Programa Fatorial";
            Console.Write("Entre um valor numerico: ");
            X = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            Fatorial(X);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }

        public static void Fatorial(byte N)
        {

            long FAT = 1;
            if (N == 0)
                FAT = 0;
            else
                for (int I = 1; I <= N; I++)
                    FAT *= I;
            Console.WriteLine("Fatorial de {0} = {1}", N, FAT);

        }
    }
}
