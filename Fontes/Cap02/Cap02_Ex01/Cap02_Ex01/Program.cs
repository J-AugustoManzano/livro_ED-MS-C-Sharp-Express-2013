using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            string NOME;

            Console.Write("Entre seu nome: ");
            NOME = Console.ReadLine();
            Console.WriteLine("Ola, " + NOME);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
