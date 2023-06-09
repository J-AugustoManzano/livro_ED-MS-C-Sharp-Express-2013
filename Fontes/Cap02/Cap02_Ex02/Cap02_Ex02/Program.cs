using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, R;

            Console.Write("Entre o 1o. valor: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Entre o 2o. valor: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);

            Console.WriteLine();
            Console.Write("Tecla <Enter> para continuar... ");
            Console.ReadLine();

        }
    }
}
