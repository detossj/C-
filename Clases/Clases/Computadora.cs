using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Computadora
    {
        public string Marca;
        public int AnhioFabricacion;
        public int CantidadRam;
        public bool EsLaptop;

        public void Encender()
        {
            Console.WriteLine($"La computadora de marca: {Marca} se esta encendiendo");
        }

        public void Apagar()
        {
            Console.WriteLine($"La computadora de marca: {Marca} se esta apagando");
        }

        public void TransferenciaDeImformacion()
        {
            if (CantidadRam < 2)
            {
                Console.WriteLine("Esta computadora no es muy rapida transfiriendo datos");
            }
            else if (CantidadRam < 4)
            {
                Console.WriteLine("Esta computadora transfiere datos de forma moderada");
            }
            else
            {
                Console.WriteLine("La computadora trasnfiere datos de manera eficiente");
            }
        }
        
        public void MostrarInformacion()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(AnhioFabricacion);
            Console.WriteLine(CantidadRam);
            if (EsLaptop == true)
            {
                Console.WriteLine("Laptop");
            }
            else if (EsLaptop == false)
            {
                Console.WriteLine("Pc");
            }
        }




    }
}
