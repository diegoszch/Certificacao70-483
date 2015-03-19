using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certificacao70_480.Capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Executar(new ExemploIf());
            //Executar(new ExemploSwitchCase());
            //Executar(new ExemploFor());
            //Executar(new ExemploWhile());

            Console.ReadKey();
        }

        public static void Executar(Exemplo exec)
        {
            exec.Executar();
        }
    }
}
