using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoW1
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS UNIDIMENSIONALES");

            int x, y;
            x = 20;
            y = 10;
            int resultado = Sumar(x, y);
            Console.WriteLine("La suma es:" + resultado); //llamada de la funcion

            resultado = Resta(x, y);
            Console.WriteLine("La resta es:" + resultado); //llamada de la funcion

            int[] notas = { 1, 2, 4, 6, 8, 9 };
        }

        public static int Sumar(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Resta(int a, int b)
        {
            int result = a + b;
            return result;
        }

    }


}
