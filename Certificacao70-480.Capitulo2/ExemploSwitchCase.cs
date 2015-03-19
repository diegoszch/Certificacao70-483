#define BLOCO1
//#undef BLOCO1

#define BLOCO2
#undef BLOCO2

#define BLOCO3
#undef BLOCO3

#define BLOCO4
#undef BLOCO4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certificacao70_480.Capitulo2
{
    class ExemploSwitchCase : Exemplo
    {
        public void Executar()
        {
#if BLOCO1
            Console.WriteLine("BLOCO1");

            var valor = 1;

            switch(valor)
            {
                case 1:
                    Console.WriteLine("O Valor é 1");
                    break;
                case 2:
                    Console.WriteLine("O Valor é 2");
                    break;
                default:
                    Console.WriteLine("O Valor é 6");
                    break;
            }
#endif


#if BLOCO2
            Console.WriteLine("BLOCO2");

            var valor = 1;

            switch(valor)
            {
                case 1:
                    Console.WriteLine("O Valor é 1");
                    //break;
                case 2:
                    Console.WriteLine("O Valor é 2");
                    //break;
                default:
                    Console.WriteLine("O Valor é 6");
                    //break;
            }
#endif


#if BLOCO3
            Console.WriteLine("BLOCO3");

            var valor = 1;

            switch(valor)
            {
                case 1:
                    Console.WriteLine("O Valor é 1");
                    //break;
                case 2:
                    Console.WriteLine("O Valor é 2");
                    //break;
                default:
                    Console.WriteLine("O Valor é 6");
                    break;
            }
#endif


#if BLOCO4
            Console.WriteLine("BLOCO4");

            var valor = 1;

            switch(valor)
            {
                case 1:
                case 2:
                    Console.WriteLine("O Valor é 1");                    
                    Console.WriteLine("O Valor é 2");
                    break;
                default:
                    Console.WriteLine("O Valor é 6");
                    break;
            }
#endif

        }
    }
}
