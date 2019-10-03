using System;

namespace BobeFinder
{
    public class Person
    {
        public string Nombre;
        public Casa casa;

        public void ShowData()
        {
            Console.WriteLine(Nombre);
        }
    }
}