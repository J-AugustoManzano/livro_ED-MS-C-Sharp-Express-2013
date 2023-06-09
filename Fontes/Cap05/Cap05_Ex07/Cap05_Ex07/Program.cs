using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap05_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {

            long VN1 = 1234567;
            byte VN2 = 123;
            double VN3 = 123.45;

            string VC1, VC2, VC3;

            Console.WriteLine(VN1.ToString());
            Console.WriteLine(VN2.ToString());
            Console.WriteLine(VN3.ToString());

            VC1 = VN1.ToString();
            VC2 = VN2.ToString();
            VC3 = VN3.ToString();

            Console.WriteLine();
            Console.WriteLine(VC1.Length);
            Console.WriteLine(VC2.Length);
            Console.WriteLine(VC3.Length);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
