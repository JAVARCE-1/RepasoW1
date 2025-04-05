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


            int PrimerNumero, SegundoNumero, tercerNumero;
            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("Cual es el numero mayor de 3 numeros");
            PrimerNumero = Convert.ToInt32(Console.ReadLine());
            SegundoNumero = Convert.ToInt32(Console.ReadLine());
            tercerNumero = Convert.ToInt32(Console.ReadLine());

            int numeroMayor;
            if (PrimerNumero > SegundoNumero && PrimerNumero > tercerNumero)
            {
                numeroMayor = PrimerNumero;
            }
            else if (SegundoNumero > PrimerNumero && SegundoNumero > tercerNumero)
            {
                numeroMayor = SegundoNumero;
            }
            else
            {
                numeroMayor = tercerNumero;
            }
            Console.WriteLine("El numero mayor es :"+ numeroMayor);


            //obtener el area del circulo o cuadrado
            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("Base la opcion de que area es para comprobar");
            PrimerNumero = Convert.ToInt32(Console.ReadLine());


        }
    }
}
