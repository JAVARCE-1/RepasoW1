using System;
using System.Collections;
using System.Globalization;

namespace RepasoModulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             */
           
            int i, j, filas;
            /*
            Console.WriteLine("Ingresa el numero de filas");
            //filas = Convert.ToInt32(Console.ReadLine());
            filas = 4;
            Console.WriteLine("");

            for (i = 1; i <= filas; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nSe acabo el bucle");
            */

            /*
             * -----*
             * ----* *
             * ---* * *
             * --* * * *
             * -* * * * *
             */
            /*
            Console.WriteLine("Ingresa el numero de filas");
              filas = 5;
            Console.WriteLine("");
            i = 1; j = 1;
            String cad = "*";
              for (  i = filas; i >= 1; i--)
                {

                for (j = 1; j <= i; j++)
                {
                    Console.Write( "-");
                    //cad += "*";
                }

                Console.Write("\n");
            }
            */



            //EJERCICIO encontrar Duplicados:
            Console.WriteLine("-----------------------------");
            Console.WriteLine("ENCONTRAR NUMEROS DUPLICADOS");
            Console.WriteLine("-----------------------------");
            int[] numero = new int[] { 44, 44, 32, 55 ,66, 55,5,33,77,6,44};

            int[] numOrdenados = new int[numero.Length];
            int valorRepetido=0, indice=0;
            int contarRepetido = 0;
            //ArrayList repetidos = new ArrayList();

            Array.Copy(numero, numOrdenados, numero.Length);
            Array.Sort(numOrdenados);

            Console.WriteLine("");
            for (i = 0; i < numero.Length; i++)
            {
                if (i == 0)
                    Console.Write($"Arreglo: {numero[i]}");
                else
                    Console.Write($" , {numero[i]}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("------------------");
            Console.WriteLine("Listar duplicados:");
            for (i = 0; i < numOrdenados.Length; i++)
            {
                for (j = i; j < numOrdenados.Length; j++)
                {
                    if (numOrdenados[i] == numOrdenados[j])
                    {
                        indice = Array.IndexOf(numOrdenados, numOrdenados[i]);
                        contarRepetido++;
                        //valorRepetido = numOrdenados[i];
                    }
                }

                if (contarRepetido > 1 && indice == i)
                {
                    Console.WriteLine($"El numero {numOrdenados[i]} : Tiene {contarRepetido} duplicados");
                    //repetidos.Add(numOrdenados[i]);
                }
                contarRepetido = 0;

            }





        }
    }
}
