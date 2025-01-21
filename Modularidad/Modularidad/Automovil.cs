using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modularidad
{
    internal class Automovil
    {
        Rueda[] ruedas = new Rueda[4];
        DepositoCombustible depositoCombustible = new DepositoCombustible();

        public void Arrancar()
        {
            Console.WriteLine("El automovil esta arrancando");
        }

        public void Frenar()
        {
            Console.WriteLine("El automovil esta frenando");
        }
    }
}
