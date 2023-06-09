using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap05_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            String TEXTO = "Computador";

            Console.WriteLine(TEXTO.Length);          // 10
            Console.WriteLine(TEXTO.ToLower());       // computador
            Console.WriteLine(TEXTO.ToUpper());       // COMPUTADOR
            Console.WriteLine(TEXTO.Substring(0, 3)); // Com
            Console.WriteLine(TEXTO.Substring(3, 4)); // puta
            Console.WriteLine(TEXTO.Substring(7, 3)); // dor

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
