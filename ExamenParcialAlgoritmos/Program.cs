using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoge el problema del 1 al 4 ");
            int pro = int.Parse(Console.ReadLine());
            switch (pro) {
                case 1:
                    Console.WriteLine("Problema 01");
                    Problema01(); 
                    
                    break;
                case 2:
                    Console.WriteLine("Problema 02");
                    Problema02();

                    break;

                case 3:
                    Console.WriteLine("Problema 03");
                    Problema03();

                    break;

                case 4:
                    Console.WriteLine("Problema 04");
                    Problema04();

                    break;

            }

        }
        static void Problema01() {
            float suma = 0f;
            int cantidad = 0;
            while (true)
            {
                Console.Write("Ingrese una nota o escriba 'STOP' para detenerse: ");
                string entrada = Console.ReadLine();

                if (entrada.ToUpper() == "STOP")
                {
                    break; //Sale del bucle
                }

                if (int.TryParse(entrada, out int nota))
                {
                    suma = suma + nota;
                    cantidad++;
                    Console.WriteLine("La nota es  "+suma);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido o escriba 'STOP' para detenerse.");
                }
            }

            float promedio = suma / cantidad;


            Console.WriteLine("==============================");
            Console.WriteLine("El promedio es : "+promedio);
            Console.ReadKey();

           

        }

        static void Problema02() {

            Console.WriteLine("Ingrese el dividendo: ");
            int divid = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor: ");
            int div = int.Parse(Console.ReadLine());

            int re=divid;
            while (re >= div) {
                re -= div;
            
            }
            Console.WriteLine("El residuo de "+divid+ " dividido por " +
                div+ " es "+re );


            Console.ReadLine(); 
            }
        static void Problema03() {

            Console.WriteLine("Ingrese numero: ");
            int numero=int.Parse(Console.ReadLine());
            Console.WriteLine("*");
            for (int i = 1; i < numero; i++) {
                for (int j = 1; j <=i*2-0; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();



            }
            Console.ReadLine();

        }
        static void Problema04()
        {
            {
                int i = 1;
                while (true)
                {
                    Console.Write("Ingrese limite: ");
                    int lim = int.Parse(Console.ReadLine());
                    for (int j = 1; j <=lim+1; j++)
                    {
                        for (int k = 0; k <= lim - j; k++) {
                            Console.Write(" ");
                        
                        }
                        for (int y = i; y <= j; y++) { 
                        
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
            }
           
        }
       
        
        
    }

}
