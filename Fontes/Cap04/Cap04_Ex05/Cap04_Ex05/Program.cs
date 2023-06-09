using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Programa exemplo para cálculo de tabuada 
 * de um valor numérico qualquer fornecido a partir
 * do teclado para operação em modo console.
 */

/*
 * Programa .......: Tabuada
 * Autor(es) ......: Augusto Manzano
 * Data ...........: 10/06/2010
 * Versão .........: 2.0
 * Revisão.........: 25/07/2010
 */

namespace Cap04_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, I, R;
            Console.WriteLine("PROGRAMA - TABUADA - v2.0");
            Console.WriteLine();
            Console.Write("Informe um valor: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (I = 1; I <= 10; I++)
            {
                // Cálculo da tabuada propriamente dito
                R = N * I;
                // Apresentação da tabuada no formato: N X I = R
                Console.WriteLine("{0,2} X {1,2} = {2,3}", N, I, R);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
