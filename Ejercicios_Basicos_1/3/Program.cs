using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingrese el Segundo numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            
            int r = n1/n2;
            Console.Write("El resultado es: " +r);
            Console.Write("");
        }
    }
}
