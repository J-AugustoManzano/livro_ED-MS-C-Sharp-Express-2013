using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap07_Ex04
{

    class ClassePai
    {
        public virtual void Executa()
        {
            Console.WriteLine("Acao na classe-pai");
        }
    }

    class ClasseFilho : ClassePai
    {

        public override void Executa()
        {
            Console.WriteLine("Acao na classe-filho");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            ClassePai PAI = new ClassePai();
            ClasseFilho FILHO = new ClasseFilho();

            PAI.Executa();
            FILHO.Executa();

            PAI = FILHO;
            PAI.Executa();

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();

        }
    }
}
