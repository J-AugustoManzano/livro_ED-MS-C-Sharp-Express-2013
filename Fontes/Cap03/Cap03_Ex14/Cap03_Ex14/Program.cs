using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex14
{
    class Program
    {
        static void Main(string[] args)
        {


            int DIVIDENDO, DIVISOR, QUOCIENTE;

            Console.Write("Entre o valor do dividendo ..: ");
            DIVIDENDO = int.Parse(Console.ReadLine());

            Console.Write("Entre o valor do divisor ....: ");
            DIVISOR = int.Parse(Console.ReadLine());

            try
            {
                QUOCIENTE = DIVIDENDO / DIVISOR;

                Console.WriteLine();
                Console.WriteLine("Resultado = {0}", QUOCIENTE);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine("Erro - divisao por zero");
            }

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
