using System;

namespace BobeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
        Puerta puerta = new Puerta();
        puerta.Color = "Rojo";
        SmallApartment depto = new SmallApartment(puerta);
        Person persona = new Person();
        persona.Nombre = "Alberto";
        persona.casa = depto;

        persona.ShowData();

        }
    }
}
