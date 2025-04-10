namespace MODULE1_CHALLENGE_JONATAN_ARCE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();

            //Console.WriteLine("Tipo de cambio de Monedas");


            //Dictionary<string, string[]> monedas = new Dictionary<string, string[]>();

            //monedas.Add("PEN", new string[] { "Soles", "3.75", "S/." });
            //monedas.Add("USD", new string[] { "Dolar", "1.09", "$" });
            //monedas.Add("EUR", new string[] { "Euro", "0.92", "€" });

            //var monedas = InicializarMonedas();
            //int[] detalle = new int[2];

            //foreach (var filas in monedas)
            //{
            //    Console.WriteLine($" la Moneda en {filas.Key}: ");

            //    foreach (string filaArray in filas.Value)
            //    {
            //        Console.WriteLine(" - " + filaArray );
            //    }
            //}





        }

        //metodos
        public static void optionSelection(int opcion)
        {
            const int CONVERTIR = 1;
            const int LISTAR = 2;
            const int MODIFICAR = 3;
            const int BUSCAR = 4;
            const int ADICIONAR = 5;

            switch (opcion)
            {
                case CONVERTIR:
                    {
                        Console.WriteLine("CONVERTIR");
                        currencyConvert("origen");
                        break;
                    }
                case LISTAR:
                    {
                        Console.WriteLine("LISTAR");
                        break;
                    }
                case MODIFICAR:
                    {
                        Console.WriteLine("MODIFICAR");
                        break;
                    }
                case BUSCAR:
                    {
                        Console.WriteLine("BUSCAR");
                        break;
                    }
                case ADICIONAR:
                    {
                        Console.WriteLine("ADICIONAR");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("FIN");
                        break;
                    }
            }
        }

        public static void Menu()
        {
            int opcion = 0;

            Console.WriteLine("======================================");
            Console.WriteLine("   Aplicación convertidor de moneda   ");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            Console.WriteLine("==== Menú de Opciones ====");
            Console.WriteLine("     1. Opción 1");
            Console.WriteLine("     2. Opción 2");
            Console.WriteLine("     3. Opción 3");
            Console.WriteLine("     4. Opción 3");
            Console.WriteLine("     5. Opción 3");
            Console.WriteLine("     6. Salir");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");

            while (opcion != 7)
            {
                Console.WriteLine("Ingrese su opcion: ");
                if (int.TryParse(Console.ReadLine(), out opcion) == false)
                {
                    Console.WriteLine("Debe ingresar solo valores númericos");
                    return;
                }
                else
                {
                    optionSelection(opcion);
                }

            }
            Console.WriteLine("Fin de programa...");
        }

        public static void currencyConvert(string origen)
        {
            var monedas = InicializarMonedas();


            Console.WriteLine("\nOpciones:");
            string[] valorMoneda = new string[2];
            foreach (var filas in monedas)
            {

                Console.Write($" {filas.Key}");
                valorMoneda = filas.Value;
                Console.Write(" - " + valorMoneda[0]);

                //foreach (string filaArray in filas.Value)
                //{
                //    Console.Write(" - " + filaArray.);
                //}
                Console.WriteLine("");
            }

            int monedaOrigen, monedaDestino;
            Console.WriteLine($" Seleccione la moneda origen: ");
            if (int.TryParse(Console.ReadLine(), out monedaOrigen) == false)
            {
                Console.WriteLine("Debe ingresar solo valores númericos");
                return;
            }
            Console.WriteLine($" Seleccione la moneda a convertir: ");
            if (int.TryParse(Console.ReadLine(), out monedaDestino) == false)
            {
                Console.WriteLine("Debe ingresar solo valores númericos");
                return;
            }

            Console.WriteLine($"Se Convertira la moneda: {monedaOrigen} a {monedaDestino} ");
        }

        public static Dictionary<int, string[]> InicializarMonedas()
        {
            Dictionary<int, string[]> monedas = new Dictionary<int, string[]>();

            monedas.Add(1, new string[] { "Soles", "PEN", "3.75", "S/." });
            monedas.Add(2, new string[] { "Dolar", "USD", "1.09", "$" });
            monedas.Add(3, new string[] { "Euro", "EUR", "0.92", "€" });

            return monedas;
        }
    }
}
