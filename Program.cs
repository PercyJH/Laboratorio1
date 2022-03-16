using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Conversión de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    // SUMA 
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a1, b1, Suma(a1, b1));
                        Console.ReadKey();
                        break;

                    // RESTA
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a2, b2, Resta(a2, b2));
                        Console.ReadKey();
                        break;

                    // MULTI
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El producto de {0} y {1} es {2}", a3, b3, Producto(a3, b3));
                        Console.ReadKey();
                        break;

                    // DIV
                    case "4":
                        Console.WriteLine("Ingrese dividendo");
                        int a4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese divisor");
                        int b4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El cociente de {0} y {1} es {2}", a4, b4, Division(a4, b4));
                        Console.ReadKey();
                        break;

                    // RAIZ
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    // PRIMOS
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    // TEMP
                    case "7":
                        Console.WriteLine("Convertir temperatura...");
                        Console.WriteLine("[1] Farenheit a Celsius");
                        Console.WriteLine("[2] Celsius a Farenheit");
                        Console.WriteLine("Ingrese una opción y presione ENTER");
                        opcion = Console.ReadLine();
                        switch (opcion)
                        {
                            case "1":
                                Console.WriteLine("Ingrese Grados Farenheit");
                                Double f1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} Farenheit son {1} Celsius", f1, FarToCel(f1));
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.WriteLine("Ingrese Grados Celsius");
                                Double f2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("{0} Celsius son {1} Farenheit", f2, CelToFar(f2));
                                Console.ReadKey();
                                break;
                        }
                        break;
                }
            } while (!opcion.Equals("0"));
        }

        static int Suma (int a1, int b1)
        {
            return a1 + b1;
        }
        static int Resta (int a2, int b2)
        {
            return a2 - b2;
        }
        static int Producto(int a3, int b3)
        {
            return a3 * b3;
        }
        static int Division(int a4, int b4)
        {
            return a4 / b4;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static void Primos()
        {
            int cont=1;
            for (int i = 1; cont <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0} es primo.", i);
                    cont++;
                }
            }
        }
        static Double FarToCel(Double f1)
        {
            return ((f1-32) * 5 ) /9;
        }
        static Double CelToFar(Double f2)
        {
            return ( (f2)*(1.8) ) + (32);
        }
    }
}
