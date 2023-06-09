using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap04_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {

            int VALOR = 1, RESULTADO;

            RESULTADO = VALOR++;
            Console.WriteLine("RESULTADO = {0}", RESULTADO);
            Console.WriteLine("VALOR     = {0}", VALOR);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
