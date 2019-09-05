using System;

namespace ejercicio_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un auto
            Auto auto = new Auto("Fiat", "147", "ABC123", "Mabuchi12Volts");

            //acelerar el auto
            auto.Acelerar(100);

            //frenar el auto
            auto.Frenar();

            Bus bus = new Bus("Chevroley", "narampol", "abc123", "holamanola");




            Console.WriteLine("A nisman lo mataron");
        }
    }
}
