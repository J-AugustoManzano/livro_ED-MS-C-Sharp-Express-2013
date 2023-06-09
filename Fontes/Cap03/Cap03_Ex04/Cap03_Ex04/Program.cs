using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            int CODIGO;

            Console.Write("Entre o codigo de acesso: ");
            CODIGO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (CODIGO == 1 || CODIGO == 2 || CODIGO == 3)
            {
                if (CODIGO == 1)
                    Console.WriteLine("um");
                if (CODIGO == 2)
                    Console.WriteLine("dois");
                if (CODIGO == 3)
                    Console.WriteLine("tres");
            }
            else
                Console.WriteLine("codigo invalido");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
