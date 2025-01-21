using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad
{
    internal class Rueda
    {
        public double peso;
        public string tamano;
        public string tipo;
        public string material;

        public void Desplazar()
        {
            Console.WriteLine("El neumatico desplaza al automovil");
        }
    }
}
