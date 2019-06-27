using System;

namespace if_else_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruta;


            Console.WriteLine("Ingrese fruta");
            fruta = Console.ReadLine();


            switch (fruta.ToLower())
            {

                case "naranja":
                    Console.WriteLine("Pintan esos jugos");
                    break;

                case "manzana":
                    Console.WriteLine("Hagamos una tarta");
                    break;

                case "pomelo":
                    Console.WriteLine("Tenes 50 años,tomas terma y viviste a Castillo");
                    break;
                default:
                    Console.WriteLine("Vamos a tirar esta fruta de mierda a un transeunte peronista y pseudo-comunista");
                    break;
            }

        }


    }
}
