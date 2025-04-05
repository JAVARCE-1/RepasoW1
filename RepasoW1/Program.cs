using System;

namespace RepasoW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int numero;

            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("Ingrese el valor a comprobar");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }else
            {
                Console.WriteLine("El numero es impar");
            }

 


        }
    }
}
