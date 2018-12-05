using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_5_Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Examen Unidad 5 Alejandro Lopez Garcia 16210545";
        perro:
            Console.Clear();
            Console.WriteLine(@"Seleccione el ejercicio
1.- -Bubble sort (1)
2.- Radix (2)
3.- Shell Sort (3)
4.- Quick Sort (4)
5.-Salir");
            int a = int.Parse(Console.ReadLine());
            
            Procesos OBJ = new Procesos();
           

            if (a == 1)
            {
                Console.Title = "METODO BURBUJA";
                OBJ.METODOBURBUJA();
                Console.WriteLine("\n\nTeclee cualquier tecla");
                Console.ReadKey();
                goto perro;
            }
            if (a == 2)
            {
                Console.Title = "METODO RADIX";
                OBJ.Radix();
                Console.ReadKey();
                Console.WriteLine("\n\nTeclee cualquier tecla");
                Console.ReadKey();
                goto perro;


            }

            if (a == 3)
            {
                Console.Title = "METODO SHELL SORT";
                OBJ.CAPTURAR();
                OBJ.METODO_SHELL();
                OBJ.RESULTADO();
                Console.WriteLine("\n\nTeclee cualquier tecla");
                Console.ReadKey();
                goto perro;

            }

            if (a == 4)
            {
                Console.Title = "METODO QUICK SORT";
                OBJ.Desarrollo();
                Console.ReadKey();
                goto perro;

            }
            if (a == 5)
            {

                Console.WriteLine("Teclee cualquier tecla");
                Console.Clear();

            }
        }
    }
}
