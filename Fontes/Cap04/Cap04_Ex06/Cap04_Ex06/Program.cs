using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap04_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            double V1 = 123.456;
            double V2 = 234.5;
            double V3 = 345.0;
            double V4 = 12345.67;
            double V5 = 1234.5;
            double V6 = 12345.6789;

            int V7 = 123;
            int V8 = 12;
            int V9 = 1;

            long X = 1234567890;
            long Y = 12345678901;

            // apresentacao com duas casas decimais
            Console.WriteLine(String.Format("{0:0.00}", V1));
            Console.WriteLine(String.Format("{0:0.00}", V2));
            Console.WriteLine(String.Format("{0:0.00}", V3));

            // apresentacao com separador de milhar
            Console.WriteLine(String.Format("{0:0,0.00}", V4));
            Console.WriteLine(String.Format("{0:0,0.00}", V5));
            Console.WriteLine(String.Format("{0:0,0.00}", V6));

            // apresentacao com alinhamento a direita - valor real
            Console.WriteLine(String.Format("{0,15:0,0.00}", V4));
            Console.WriteLine(String.Format("{0,15:0,0.00}", V5));
            Console.WriteLine(String.Format("{0,15:0,0.00}", V2));

            // apresentacao com zeros a direita
            Console.WriteLine(String.Format("{0:00000}", V7));
            Console.WriteLine(String.Format("{0:00000}", V8));
            Console.WriteLine(String.Format("{0:00000}", V9));

            // apresentacao com alinhamento a direita - valor inteiro
            Console.WriteLine(String.Format("{0,5}", V7));
            Console.WriteLine(String.Format("{0,5}", V8));
            Console.WriteLine(String.Format("{0,5}", V9));

            // apresentacao formatacao customizada
            Console.WriteLine(String.Format("{0:(0xx##)####-####}", X));
            Console.WriteLine(String.Format(@"{0:###\.###\.###-##}", Y));

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
