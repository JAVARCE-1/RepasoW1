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

            Console.WriteLine("Ingresa el numero de filas");
              filas = 5;
            Console.WriteLine("");
            i = 1; j = 1;
            String cad = "*";
           // for (i = 1; i <= filas; i++)
              for (  i = filas; i >= 1; i--)
                {

                for (j = 1; j <= i; j++)
                {
                    Console.Write( "-");
                    //cad += "*";
                }

                Console.Write("\n");
            }

            // erjecicio
            int[] numero = new int[] { 44, 44, 32, 55 ,66, 55};
            int indice , repetido , anterior=-1;
            foreach (int item in numero)
            {
                //bool contiene = numero.Contains(3.14);
                
                indice = Array.IndexOf(numero, item);
                if (indice == anterior)
                {
                    Console.WriteLine($"\n Valor repetido {item} en el índice: {indice}");
                }
                
                anterior = indice;
                indice = -1;


            }



        }
    }
}
