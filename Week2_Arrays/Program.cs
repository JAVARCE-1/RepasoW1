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
            MostrarCalificaciones(calificaciones);

            // // 4. Calcular y mostrar estadísticas
            CalcularEstadisticas(calificaciones);

            // // 5. Ordenar y mostrar calificaciones
            OrdenarCalificaciones(calificaciones);

            // // 6. Mostrar distribución por rangos
            MostrarDistribucionRangos(calificaciones);
        }

        // Método para ingresar calificaciones
        static void IngresarCalificaciones(double[] calificaciones)
        {
            Console.WriteLine("Ingrese las calificaciones de los 10 estudiantes (0-100):");

            for (int i = 0; i < calificaciones.Length; i++)
            {
                bool entradaValida = false;

                while (!entradaValida)
                {
                    Console.Write($"Estudiante {i + 1}: ");
                    string entrada = Console.ReadLine();

                    if (double.TryParse(entrada, out double calificacion) && calificacion >= 0 && calificacion <= 100)
                    {
                        calificaciones[i] = calificacion;
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un valor numérico entre 0 y 100.");
                    }
                }
            }

            Console.WriteLine();
        }

        // Método para mostrar todas las calificaciones
        static void MostrarCalificaciones(double[] calificaciones)
        {
            Console.WriteLine("Calificaciones ingresadas:");

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
            }

            Console.WriteLine();
        }

        // Método para calcular y mostrar estadísticas
        static void CalcularEstadisticas(double[] calificaciones)
        {
            // Calcular promedio
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Length;

            // Encontrar calificación más alta y más baja
            double maxima = calificaciones[0];
            double minima = calificaciones[0];

            foreach (double calificacion in calificaciones)
            {
                if (calificacion > maxima)
                    maxima = calificacion;

                if (calificacion < minima)
                    minima = calificacion;
            }

            // Contar aprobados
            int aprobados = 0;
            foreach (double calificacion in calificaciones)
            {
                if (calificacion >= 60)
                    aprobados++;
            }

            // Mostrar resultados
            Console.WriteLine("Estadísticas:");
            Console.WriteLine($"- Promedio: {promedio:F2}");
            Console.WriteLine($"- Calificación más alta: {maxima}");
            Console.WriteLine($"- Calificación más baja: {minima}");
            Console.WriteLine($"- Estudiantes aprobados: {aprobados} de {calificaciones.Length}");
            Console.WriteLine($"- Porcentaje de aprobación: {(double)aprobados / calificaciones.Length * 100:F2}%");
            Console.WriteLine();
        }

        // Método para ordenar y mostrar calificaciones
        static void OrdenarCalificaciones(double[] calificaciones)
        {
            // Crear una copia para no modificar el array original
            double[] calificacionesOrdenadas = new double[calificaciones.Length];
            Array.Copy(calificaciones, calificacionesOrdenadas, calificaciones.Length);

            // Ordenar la copia
            Array.Sort(calificacionesOrdenadas);

            // Mostrar calificaciones ordenadas
            Console.WriteLine("Calificaciones ordenadas (menor a mayor):");
            for (int i = 0; i < calificacionesOrdenadas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {calificacionesOrdenadas[i]}");
            }

            Console.WriteLine();
        }

        // Método para mostrar distribución por rangos
        static void MostrarDistribucionRangos(double[] calificaciones)
        {
            int[] rangos = new int[5]; // Para almacenar conteo por rangos

            // Contar calificaciones por rango
            foreach (double calificacion in calificaciones)
            {
                if (calificacion < 60)
                    rangos[0]++; // Reprobado
                else if (calificacion < 70)
                    rangos[1]++; // Suficiente
                else if (calificacion < 80)
                    rangos[2]++; // Bien
                else if (calificacion < 90)
                    rangos[3]++; // Notable
                else
                    rangos[4]++; // Excelente
            }

            // Mostrar distribución
            Console.WriteLine("Distribución por rangos:");
            Console.WriteLine($"- Reprobado (0-59): {rangos[0]} estudiantes");
            Console.WriteLine($"- Suficiente (60-69): {rangos[1]} estudiantes");
            Console.WriteLine($"- Bien (70-79): {rangos[2]} estudiantes");
            Console.WriteLine($"- Notable (80-89): {rangos[3]} estudiantes");
            Console.WriteLine($"- Excelente (90-100): {rangos[4]} estudiantes");

            // Visualización gráfica simplificada
            Console.WriteLine("\nGráfica de distribución:");
            string[] etiquetas = { "Reprobado", "Suficiente", "Bien    ", "Notable ", "Excelente" };

            for (int i = 0; i < rangos.Length; i++)
            {
                Console.Write($"{etiquetas[i]}: ");
                for (int j = 0; j < rangos[i]; j++)
                {
                    Console.Write("■ ");
                }
                Console.WriteLine($" ({rangos[i]})");
            }
        }


        private static void IngresarCalificaciones2(double[] calificaciones)
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
