using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap03_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {

            float A, B, C;

            Console.Write("Informe o lado A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado B: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado C: ");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (A < B + C && B < A + C && C < A + B)
                if (A == B && B == C)
                    Console.WriteLine("Triangulo Equilatero");
                else
                    if (A == B || A == C || C == B)
                        Console.WriteLine("Triangulo Isosceles");
                    else
                        Console.WriteLine("Triangulo Escaleno");
            else
                Console.WriteLine("Valores nao formam um triangulon");

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
