using Constructores;
using System;

namespace  Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono();
            Telefono telefono2 = new Telefono(256, 8 , 170, 20, true);
            
            Console.WriteLine(telefono1.getMemoria());
            Console.WriteLine(telefono2.getMemoria());


        }
    }
}