using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            CadAluno ALUNO = new CadAluno();

            Console.Write("Entre o nome ..: ");
            ALUNO.NOME = Console.ReadLine();
            Console.Write("Entre a sala ..: ");
            ALUNO.SALA = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre as notas:");
            Console.WriteLine();
            for (int I = 0; I <= 3; I++)
            {
                Console.Write("{0}a. nota ......: ", I + 1);
                ALUNO.NOTA[I] = float.Parse(Console.ReadLine());
            }
            ALUNO.CalcMedia();

            Console.WriteLine();
            Console.WriteLine("Nome ..........: {0}", ALUNO.NOME);
            Console.WriteLine("Sala ..........: {0}", ALUNO.SALA);
            Console.WriteLine();
            Console.WriteLine("Notas:");
            Console.WriteLine();
            for (int I = 0; I <= 3; I++)
            {
                Console.Write("{0}a. nota ......: ", I + 1);
                Console.WriteLine("{0,5:0.00} ", ALUNO.NOTA[I]);
            }
            Console.WriteLine();
            Console.WriteLine("Média .........: {0,5:0.00}", ALUNO.CalcMedia());

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
