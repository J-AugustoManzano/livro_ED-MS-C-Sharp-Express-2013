using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Object> LISTA = new List<Object>();

            int T;
            string N;

            // Entrada dos nomes

            Console.WriteLine();
            Console.Write("Quantos nomes a entrar? ");
            T = int.Parse(Console.ReadLine());
            for (int I = 0; I < T; I++)
            {
                Console.Write("Entre o {0,3}o. nome: ", I + 1);
                N = Console.ReadLine();
                LISTA.Add(N);
            }

            // Apresentacao dos nomes

            Console.WriteLine();
            for (int I = 0; I < LISTA.Count; I++)
            {
                N = LISTA[I].ToString();
                Console.WriteLine("{0,3}o. nome = {1}", I + 1, N);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
