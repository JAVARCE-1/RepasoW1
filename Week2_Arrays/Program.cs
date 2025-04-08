using System.Runtime.InteropServices;

namespace Week2_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ARRAYS UNIDIMENSIONALES EN C#");
            Console.WriteLine("============================\n");
            //Random r = new Random(100);

            /*
            RETO: SISTEMA DE CALIFICACIONES

            Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
            diferentes operaciones estadísticas.

            Requisitos:
            1. Crear un array para almacenar las calificaciones de 10 estudiantes (valores entre 0 y 100)
            2. Implementar las siguientes funcionalidades:
               - Calcular el promedio de calificaciones
               - Encontrar la calificación más alta y la más baja
               - Calcular cuántos estudiantes aprobaron (calificación >= 60)
               - Mostrar las calificaciones en orden ascendente
               - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
                 * 0-59 (Reprobado)
                 * 60-69 (Suficiente)
                 * 70-79 (Bien)
                 * 80-89 (Notable)
                 * 90-100 (Excelente)

            Extra (opcional):
            - Permitir que el usuario ingrese las calificaciones
            - Implementar un menú para que el usuario elija la operación a realizar
            */
            Console.WriteLine("SISTEMA DE CALIFICACIONES");
            Console.WriteLine("=========================\n");

            // 1. Declarar el array de calificaciones
            double[] calificaciones = new double[10];
            string bienvenida;
            // 2. Ingresar las calificaciones (puede ser manual o automático)
            IngresarCalificaciones(calificaciones);

            // // 3. Mostrar todas las calificaciones
           // MostrarCalificaciones(calificaciones);

            // // 4. Calcular y mostrar estadísticas
            //CalcularEstadisticas(calificaciones);

            // // 5. Ordenar y mostrar calificaciones
  //          OrdenarCalificaciones(calificaciones);

            // // 6. Mostrar distribución por rangos
//            MostrarDistribucionRangos(calificaciones);
        }

        private static void IngresarCalificaciones(double[] calificaciones)
        {
            //throw new NotImplementedException();
            double notas;
            int canAlumnos=1;
            bool condicion = true;


            int conta = 0;
            while (conta < 5)
            {

                int fila=1;
                Console.WriteLine($"ingrese las notas : {conta+1}");

                if (double.TryParse(Console.ReadLine(), out  notas))
                {
                    if (notas >=0  && notas<=100)
                    {
                        calificaciones[conta] = notas;
                        conta++;
                    }else
                    {
                        Console.WriteLine("Entrada no válida. Solo notas del 0 al 100.");
                    }

                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
                }
   

            }

            Console.WriteLine("cantidad "+ calificaciones.Length);

        }

    
 
    }
}
