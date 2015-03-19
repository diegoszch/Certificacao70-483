#define BLOCO1
//#undef BLOCO1

#define BLOCO2
#undef BLOCO2

#define BLOCO3
#undef BLOCO3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certificacao70_480.Capitulo2
{
    class ExemploFor : Exemplo
    {
        public void Executar()
        {

#if BLOCO1
            Console.WriteLine("BLOCO1");
            for (int i = 0; i < 10; i++)
            {
                //var teste1 = 0;
                //var teste2 = 0;

                //Console.WriteLine(teste1++);
                //Console.WriteLine(teste1);
                //Console.WriteLine(++teste2);

                Console.WriteLine(i);
            }
#endif

#if BLOCO2
            Console.WriteLine("BLOCO2");

            int[] arrayInt = new int[5] { 0, 1, 2, 3, 4 };

            foreach (var valor in arrayInt)
            {
                Console.WriteLine(valor);
                //break;
            }
#endif

#if BLOCO3
            Console.WriteLine("BLOCO3");

            for (int i = 1; i <= 10; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
#endif
        }
    }
}
