using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap06_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] MDG = new float[8];
            float SOMA = 0, MEDIA;
            int I;

            for (I = 0; I <= 7; I++)
            {
                Console.Write("Media media {0}o. aluno: ", I + 1);
                MDG[I] = float.Parse(Console.ReadLine());
                SOMA += MDG[I];
            }

            MEDIA = SOMA / 8;

            Console.WriteLine();
            Console.WriteLine("Media Geral = {0:0.00}", MEDIA);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
