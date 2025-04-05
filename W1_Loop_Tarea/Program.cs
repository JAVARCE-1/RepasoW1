namespace W1_Loop_Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iniciar 
            int valorTabla;
            int resultado;
            int valorPatron;

            Console.WriteLine("Bienvenido a los deasfios FOR loops");
            Console.WriteLine("");

            //-------------------------------------------------------------------------------
            // 1 - Challenge
            // Write a program in C# Sharp to display the multiplication table of a given integer.
            // Test Data:
                // Input the number(Table to be calculated) : 15
                // Expected Output :
                // 15 X 1 = 15...
                // ...
                // 15 X 10 = 150

            Console.WriteLine("=================================");
            Console.WriteLine("  (1) Tabla de Multiplicación    ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar:");
            valorTabla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------");
            for (int i = 1; i <= 12; i++)
            {
                resultado = valorTabla * i;
                Console.WriteLine( " "+ valorTabla + "x" + i + " = " + resultado);
            }

            //-------------------------------------------------------------------------------
            // 2- Imprimir cuadrado con patrones 
            // EL mismo patron que hicimos con while pero con for
                // 1 * * * *
                // 1 2 * * *
                // 1 2 3 * *
                // 1 2 3 4 *
                // 1 2 3 4 5

            Console.WriteLine("");
            Console.WriteLine("====================================================");
            Console.WriteLine("    (2) Imprimir cuadrado con patrones de 1 al X    ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingresa el valor para el patron:");
            valorPatron = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 1; i <= valorPatron; i++)
            {
                for (int j = 1; j <= valorPatron; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("");
            }


            //fin del programa
            Console.WriteLine("");
            Console.WriteLine("Fin del Programa..");
            Console.ReadKey();


        }
    }
}
