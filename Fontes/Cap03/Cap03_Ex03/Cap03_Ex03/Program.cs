using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            int NUMERO;

            Console.Write("Entre um valor: ");
            NUMERO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (NUMERO >= 20 && NUMERO <= 90)
                Console.WriteLine("O valor esta entre 20 e 90");
            else
                Console.WriteLine("O valor nao esta entre 20 e 90");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
