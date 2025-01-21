using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora samsung = new Computadora();

            samsung.Marca = "Samsung";
            samsung.EsLaptop = true;
            samsung.AnhioFabricacion = 2015;
            samsung.CantidadRam = 8;

            samsung.MostrarInformacion();

            Console.WriteLine("\n");

            Computadora apple = new Computadora();

            apple.Marca = "Apple";
            apple.EsLaptop = true;
            apple.AnhioFabricacion = 2024;
            apple.CantidadRam = 16;

            apple.MostrarInformacion();

        }
    }
}
