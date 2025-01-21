using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2repaso2
{
    internal class Automovil
    {
        public string color;

        public Ruedas[] Ruedas = new Ruedas[4];


        public Espejos[] Espejos = new Espejos[2];

        public Puertas[] Puertas = new Puertas[4];
    }

    internal class Bus : Automovil
    {
       
    }

    internal class Moto : Automovil
    {

    }

    internal class Ruedas 
    {
        public string neumaticos;
    }

    internal class Puertas
    {
        public string color;
    }
    internal class Espejos
    {
        public int tamahio;
    }
}
