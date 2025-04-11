using System.ComponentModel.Design;

namespace DFCsharp_Week1_Mentor
{
    internal class Program
    {
        public String nombre;
        public double calificacion;
        public int edad;
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World2!");


            //calculadora reto
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("        CALCULADORA       ");
            Console.WriteLine("--------------------------");
            Console.Write("Ingrese el primer numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            Console.Write("Ingrese el segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la operacion [+, -, *, /]: ");
            char operacion = Console.ReadLine()[0];

            Console.WriteLine("");

            if (operacion == '+')
            {
                resultado = numero1 + numero2;
                Console.WriteLine("La suma de los valores es: " + resultado);
            }
            else if (operacion == '-')
            {
                resultado = numero1 + numero2;
                Console.WriteLine("La resta de los valores es: " + resultado);
            }
            else if (operacion == '*')
            {
                resultado = numero1 + numero2;
                Console.WriteLine("La multiplicacion de los valores es: " + resultado);
            }
            else if (operacion == '/')
            {

                resultado = numero1 + numero2;
                Console.WriteLine("La division de los valores es: " + resultado);
            }
            else
            {
                Console.WriteLine("El valor de la operacion es incorrecta ");
            }

            /*
            //----------------CLASE CONDICIONALES
            //if - else
            Console.WriteLine("-- Codigo de: IF - ELSE ");
            int edad = 29;
            if (edad >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            }
            else
            {
                Console.WriteLine("eres menor de edad");
            }

            //if - else if
            int calificacion = 18;
            if (calificacion >= 18)
            {
                Console.WriteLine("tu nota es sobresaliente");
            }
            else if (calificacion >= 14)
            {
                Console.WriteLine("tu nota es buena");
            }
            else if (calificacion >= 10)
            {
                Console.WriteLine("tu nota debe mejorar");
            }
            else
            {
                Console.WriteLine("estas jalado");
            }
            */
        }


    }
}
