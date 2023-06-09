using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap05_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.Acos(-1));    //  3.14159265358979
            Console.WriteLine(Math.Asin(-1));    // -1.5707963267949
            Console.WriteLine(Math.Atan(1));     //  0.785398163397448                
            Console.WriteLine(Math.Sin(1));      //  0.841470984807897
            Console.WriteLine(Math.Tan(4));      //  1.15782128234958
            Console.WriteLine(Math.Pow(2, 3));   //  8
            Console.WriteLine(Math.Sqrt(9.0));   //  3
            Console.WriteLine(Math.Exp(1));      //  2.71828182845905               
            Console.WriteLine(Math.Log(3));      //  1.09861228866811               
            Console.WriteLine(Math.Abs(-9));     //  9
            Console.WriteLine(Math.Floor(2.03)); //  2                  
            Console.WriteLine(Math.Max(10, 3));  //  10 
            Console.WriteLine(Math.Min(10, 3));  //  3 
            Console.WriteLine(Math.Round(5.8));  //  6                
            Console.WriteLine(Math.PI);          //  3.14159265358979                 
            Console.WriteLine(Math.E);           //  2.71828182845905

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
