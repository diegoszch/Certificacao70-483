#define BLOCO1
//#undef BLOCO1

#define BLOCO2
#undef BLOCO2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certificacao70_480.Capitulo2
{
    class ExemploWhile : Exemplo
    {
        public void Executar()
        {

#if BLOCO1
            Console.WriteLine("BLOCO1");

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                //++i;
            }
#endif

#if BLOCO2
            Console.WriteLine("BLOCO2");

            var i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10)
#endif

        }
    }
}
