using System;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese su altura");
            altura = Convert.ToInt32(Console.ReadLine());
            

            switch(altura)
            {
                
                case 1:

                    Console.WriteLine("Sos un enano gorila");

                break;
                
                
                case 2:
                if(altura>150 && altura<170)
                {
                    Console.WriteLine("Tenes una altura promedio, sos un tibio");
                }
                break; 
               case 3:
                if(altura<190)
                {
                    Console.WriteLine("Hace frio ahi arriba?");
                }
                break;
                case 4:
                if(altura == 176)
                {
                    Console.WriteLine("Medis lo mismo que Tomi Jais, sos re capo");
                }
                break;
            }

        }
    }
}
