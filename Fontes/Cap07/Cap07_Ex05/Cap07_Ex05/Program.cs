using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap07_Ex05
{

    public class CalcArea
    {

        public long Area(int X)
        {
            long AREA = X * X;
            return AREA;
        }

        public double Area(float R, float H)
        {
            double AREA = R * R * 3.14159 * H;
            return AREA;
        }

        public int Area(int X, int Y, int Z)
        {
            int AREA = X * Y * Z;
            return AREA;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            CalcArea A = new CalcArea();

            Console.WriteLine();
            Console.WriteLine("Calculo de Areas");
            Console.WriteLine();
            Console.WriteLine("Quadrado ..: " + A.Area(5));
            Console.WriteLine("Cubo ......: " + A.Area(5, 6, 7));
            Console.WriteLine("Cilindro ..: " + A.Area(7, 3));
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
