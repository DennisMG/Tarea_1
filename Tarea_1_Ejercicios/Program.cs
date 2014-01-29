using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Ejercicio 1 ");
            Console.WriteLine("-Ejercicio 2");
            Console.WriteLine("-Ejercicio 3");
            Console.WriteLine("-Ejercicio 4");
            Console.WriteLine("Ingrese el numero de ejercicio: ");
            int option = int.Parse(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    Console.WriteLine("---------Ejercicio 1---------");
                    Console.WriteLine("Ingrese valor 1: ");
                    int var1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese valor 2: ");
                    int var2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el rago de la suma: ");
                    int scope = int.Parse(Console.ReadLine());
                    Ejercicio1(scope, var1, var2);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;

            }
            
        }

        static public int Ejercicio1( int limite, int multiploA,  int multiploB)
        {

            int sumaTotal = 0, total = 0, total2 = 0, calculando = 0;

            for (int i = 1; i <= limite; i++)
            {

                total = multiploA * i;

                total2 = multiploB * i;
                if (total >= limite && total2 >= limite)
                    break;

                if (total >= limite)
                    total = 0;
                if (total2 >= limite)
                    total2 = 0;


                if (total != total2)
                {
                    sumaTotal += total + total2;
                    //Console.WriteLine("Multiplo 5: " + total);
                    //Console.WriteLine("Multiplo 3: " + total2);

                }
                else if (total == total2)
                {
                    sumaTotal += total;
                    //Console.WriteLine("Multiplo 5: " + total);
                }

            }
            Console.WriteLine("SUMA TOTAL = " + sumaTotal);

            Console.ReadLine();
            return sumaTotal;

        }

        public static int Ejercicio2()
        {
            return 0;
        }
    }
}
