using System;

namespace net
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio();
        }

        static void inicio()
        {
            // comentario de linea

            /*  comentario de bloque
             comentario de bloque
             comentario de bloque */

            int num1 = 2;
            int num2 = 5;
            int result = num1 * num2;
            string hello = "Hello World!";
            string nome;

            Console.WriteLine(result);
            Console.WriteLine(hello);
            Console.WriteLine("Hello World!");

            nome = "Darwin";
            Console.WriteLine(nome);
        }
    }
}
