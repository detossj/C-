//Habitacion, que debe tener un identificador, numero de piso, un valor que indique si la habitacion
//esta libre o ocupada. Debe tener metodos que permitan acceder a todos los campos de la clase.

using System;

namespace ProblemaC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Habitacion h1 = new Habitacion();
            Habitacion h2 = new Habitacion(43,4,true);

            Console.WriteLine(h1.IdHabitacion);
            Console.WriteLine(h1.NPiso);
            Console.WriteLine(h1.EstadoHabitacion);

            Console.WriteLine(h2.IdHabitacion);
            Console.WriteLine(h2.NPiso);
            Console.WriteLine(h2.EstadoHabitacion);

            h1.IdHabitacion = 13;
            h1.NPiso = 1;
            h1.EstadoHabitacion = false;

            Console.WriteLine(h1.IdHabitacion);
            Console.WriteLine(h1.NPiso);
            Console.WriteLine(h1.EstadoHabitacion);

            h1.consultarEstado();
            h2.consultarEstado();
        }
    }
}