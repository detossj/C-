//Trabajador, este debe tener nombre, apellido paterno, apellido materno, fecha de nacimiento,
//departamento, cargo. Se debe poder obtener, ademas de sus atributos, la edad del trabajador.

using System;

namespace ProblemaE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trabajador t1 = new Trabajador("Jorge","Rubilar","Romero",new DateTime(2003,07,18),"Ingenieria","Profesor");

            t1.CalcularEdad();

        }
    }
}