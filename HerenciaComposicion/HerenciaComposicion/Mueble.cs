using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class Mueble
    {
        public string color;
        public string material;
        public double alto;
        public double ancho;
    }

    internal class Mesa : Mueble
    {
        public int cantidaPatas;
    }

    internal class Silla : Mueble
    {
        public int cantidadPatas;
        public bool respaldo;
        public bool acolchado;
    }
}
