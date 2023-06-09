using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            long FAT = 1, N, I;

            Console.Write("Informe um valor: ");
            N = long.Parse(Console.ReadLine());

            I = 1;
            while (I <= N)
            {
                FAT = FAT * I;
                I = I + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Fatorial de {0} = {1}.", N, FAT);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
