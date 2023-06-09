using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex09
{
    class Program
    {
        static void Main(string[] args)
        {

            int MES;

            Console.Write("Entre o mes (numerico): ");
            MES = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (MES == 1)
                Console.WriteLine("Janeiro");
            else if (MES == 2)
                Console.WriteLine("Fevereiro");
            else if (MES == 3)
                Console.WriteLine("Marco");
            else if (MES == 4)
                Console.WriteLine("Abril");
            else if (MES == 5)
                Console.WriteLine("Maio");
            else if (MES == 6)
                Console.WriteLine("Junho");
            else if (MES == 7)
                Console.WriteLine("Julho");
            else if (MES == 8)
                Console.WriteLine("Agosto");
            else if (MES == 9)
                Console.WriteLine("Setembro");
            else if (MES == 10)
                Console.WriteLine("Outubro");
            else if (MES == 11)
                Console.WriteLine("Novembro");
            else if (MES == 12)
                Console.WriteLine("Dezembro");
            else
                Console.WriteLine("Mes invalido");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
