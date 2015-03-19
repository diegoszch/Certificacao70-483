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
    class ExemploIf : Exemplo
    {
        public void Executar()
        {

#if BLOCO1  
            Console.WriteLine("BLOCO1");

            var valor = 6;

            if (valor == 1)
                Console.WriteLine("O Valor é 1");
            else if (valor == 2)
                Console.WriteLine("O Valor é 2");
            else if (valor == 3)
                Console.WriteLine("O Valor é 3");
            else if (valor == 4)
                Console.WriteLine("O Valor é 4");
            else if (valor == 5)
                Console.WriteLine("O Valor é 5");
            else
                Console.WriteLine("O Valor é 6");
#endif

#if BLOCO2
            Console.WriteLine("BLOCO2");

            var valor = 1;

            if (valor == 1)
                Console.WriteLine("O Valor é 1");
                Console.WriteLine("O Valor de teste");
            else if (valor == 2)
                Console.WriteLine("O Valor é 2");
            else if (valor == 3)
                Console.WriteLine("O Valor é 3");
            else if (valor == 4)
                Console.WriteLine("O Valor é 4");
            else if (valor == 5)
                Console.WriteLine("O Valor é 5");
            else
                Console.WriteLine("O Valor é 6");
#endif

#if BLOCO3
            Console.WriteLine("BLOCO3");

            var valor = 5;

            if (valor == 1)
            {
                Console.WriteLine("O Valor é 1");
            }
            else
            {
                if (valor == 2)
                {
                    Console.WriteLine("O Valor é 2");
                }
                else
                {
                    if (valor == 3)
                    {
                        Console.WriteLine("O Valor é 3");
                    }
                    else
                    {
                        if (valor == 4)
                        {
                            Console.WriteLine("O Valor é 4");
                        }
                        else
                        {
                            if (valor == 5)
                            {
                                Console.WriteLine("O Valor é 5");
                            }
                            else
                            {
                                Console.WriteLine("O Valor é 6");
                            }
                        }
                    }
                }
            }


            if (valor == 1)
            {
                Console.WriteLine("O Valor é 1");
            }
            else if (valor == 2)
            {
                Console.WriteLine("O Valor é 2");
            }
            else if (valor == 3)
            {
                Console.WriteLine("O Valor é 3");
            }
            else if (valor == 4)
            {
                Console.WriteLine("O Valor é 4");
            }
            else if (valor == 5)
            {
                Console.WriteLine("O Valor é 5");
            }
            else
            {
                Console.WriteLine("O Valor é 6");
            }
#endif

        }
    }
}
