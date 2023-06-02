// See https://aka.ms/new-console-template for more information
            int opcion = 0;
            decimal ingresos = 0;
            decimal gastos = 0;

            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Registrar ingreso");
                Console.WriteLine("2. Registrar gasto");
                Console.WriteLine("3. Mostrar balance");
                Console.WriteLine("4. Salir");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción inválida");
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el monto del ingreso:");
                        try
                        {
                            decimal montoIngreso = Convert.ToDecimal(Console.ReadLine());
                            ingresos += montoIngreso;
                            Console.WriteLine("Ingreso registrado");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Monto inválido");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto del gasto:");
                        try
                        {
                            decimal montoGasto = Convert.ToDecimal(Console.ReadLine());
                            gastos += montoGasto;
                            Console.WriteLine("Gasto registrado");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Monto inválido");
                        }
                        break;
                    case 3:
                        decimal balance = ingresos - gastos;
                        Console.WriteLine($"Ingresos: {ingresos}");
                        Console.WriteLine($"Gastos: {gastos}");
                        Console.WriteLine($"Balance: {balance}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (opcion != 4);
