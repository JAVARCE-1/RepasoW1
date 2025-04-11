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
                       filas = Convert.ToInt32(Console.ReadLine());
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
            int[] numero = new int[] { 44, 44, 32, 55 ,66, 55,5,33,77,6,44};
            int[] numOrdenados = new int[numero.Length];
            int valorRepetido=0, indice=0;
            ArrayList repetidos = new ArrayList();

            
            Array.Copy(numero, numOrdenados, numero.Length);
            Array.Sort(numOrdenados);

            int contarRepetido = 0;
            for  ( i = 0; i < numOrdenados.Length; i++)
            {
                for (j = i; j < numOrdenados.Length; j++)
                {

                    if (numOrdenados[i] == numOrdenados[j])
                    {
                        indice = Array.IndexOf(numOrdenados, numOrdenados[i]);
                        //Console.WriteLine(" " + indice);
                        contarRepetido++;
                        valorRepetido = numOrdenados[i];
                    }
                    //else
                    //{
                    //    contarRepetido = 1;
                    //}
                }


                if (contarRepetido > 1 && numOrdenados[indice] == numOrdenados[i] ) 
                {
                    Console.WriteLine(numOrdenados[i] +" repetidos" + contarRepetido);
                    repetidos.Add(numOrdenados[i]);
                }
                contarRepetido = 0;

            }

            //foreach (int rep in repetidos)
            //{
            //    Console.WriteLine(" repetida: " +rep);
            //}


            //if (contarRepetido > 1)
            //{
            //    Console.WriteLine($"\n El número {numero[i]}  se repite : {contarRepetido} veces");
            //}
            //contarRepetido = 0;

            /*
            //bool contiene = numero.Contains(3.14);

            indice = Array.IndexOf(numero, item);
            if (indice == anterior)
            {
                Console.WriteLine($"\n Valor repetido {item} en el índice: {indice}");
            }

            anterior = indice;
            indice = -1;
            */

        }
    }
}
