using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cap05_Ex02
{
    class Program
    {

        public static float R, A, B;
        public static string MSG = "Tecle algo para continuar... ";

        static void Main(string[] args)
        {

            string OPCAO;

            OPCAO = "0";
            while (OPCAO != "5")
            {
                Console.Title = "Calculadora";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("--------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicacao");
                Console.WriteLine("4 - Divisao");
                Console.WriteLine("5 - Fim de Programa");
                Console.WriteLine();
                Console.Write("Escolha uma opcao: ");
                OPCAO = Console.ReadLine();
                if (OPCAO != "5")
                    switch (OPCAO)
                    {
                        case "1": RotSoma(); break;
                        case "2": RotSubtracao(); break;
                        case "3": RotMultiplicacao(); break;
                        case "4": RotDivisao(); break;
                        default:
                            Console.WriteLine("Opcao invalida");
                            Console.Write(MSG);
                            Console.ReadKey();
                            break;
                    }
            }

        }

        public static float Calculo(float X, float Y, string OPERADOR)
        {
            float Z = 0;
            switch (OPERADOR)
            {
                case "+": Z = X + Y; break;
                case "-": Z = X - Y; break;
                case "*": Z = X * Y; break;
                case "/": Z = X / Y; break;
            }
            return Z;
        }

        private static void Entrada()
        {
            Console.Write("Entre um valor para A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Entre um valor para B: ");
            B = float.Parse(Console.ReadLine());
        }

        private static void Saida()
        {
            Console.WriteLine();
            Console.Write("O resultado entre A e B = {0:0.00}", R);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(MSG);
            Console.ReadKey();
        }

        private static void RotSoma()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Rotina de Soma");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Entrada();
            R = Calculo(A, B, "+");
            Saida();
        }

        private static void RotSubtracao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rotina de Subtracao");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Entrada();
            R = Calculo(A, B, "-");
            Saida();
        }

        private static void RotMultiplicacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rotina de Multiplicacao");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Entrada();
            R = Calculo(A, B, "*");
            Saida();
        }

        private static void RotDivisao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Rotina de Divisao");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Entrada();
            if (B == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Erro.");
                Console.WriteLine();
                Console.Write(MSG);
                Console.ReadKey();
            }
            else
            {
                R = Calculo(A, B, "/");
                Saida();
            }
        }

    }
}
