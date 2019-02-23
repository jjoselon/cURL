using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosTaller4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dígite el ejercicio");

            switch (int.Parse(Console.ReadLine())) {
                case 1 :
                    {
                        int[] numeros = new int[10];
                        string numerosPares = "", numerosImpares = "";
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine("Ingrese un número");
                            numeros[i] = int.Parse(Console.ReadLine());
                            if (numeros[i] % 2 == 0)
                            {
                                numerosPares += numeros[i] + ", ";
                            }
                            else
                            {
                                numerosImpares += numeros[i] + ", ";
                            }
                        }

                        Console.WriteLine("Los números ingresados fueron: " + string.Join(", ", numeros));
                        Console.WriteLine("Los números pares son: " + numerosPares);
                        Console.WriteLine("Los números impares son: " + numerosImpares);
                        Console.ReadLine();
                    }
                    break;
                case 2 :
                    {
                        // Para llamar a un método de la clase podemos :
                        // Program o = new Program();
                        // o.ejercicio2();
                        // o establecer el método como static 
                        ejercicio2();
                    }
                    break;
                case 3 :
                    {
                        ejercicio3();
                    }
                    break;

            }

        }

        public static void ejercicio2() {
            string[] alumnos = new string[5];

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Nombre del alumno del curso ");
                alumnos[i] = Console.ReadLine();
            }
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine(i + ". " + alumnos[i]);
            }
            Console.ReadLine();
        }


        public static void ejercicio3() {
            string[] productos = new string[1];
            float[] precios = new float[1];

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre del producto {i}:");
                productos[i] = Console.ReadLine();
                Console.WriteLine($"Precio del producto {i}:");
                precios[i] = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < productos.Length; i++)
            {
                if (precios[i] > 3000)
                {
                    Console.WriteLine($"Producto: {productos[i]} - Precio: {precios[i]} - Posición: {i}");
                }
                   
            }
            Console.ReadLine();
        }

    }
}
