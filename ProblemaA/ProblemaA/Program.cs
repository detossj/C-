// Triangulo, debe tener una base y altura. Tambien permitir calcular el area.

using System;

namespace ProblemaA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine(triangulo.CalcularArea());

            Triangulo triangulo2 = new Triangulo(4,4);

            Console.WriteLine(triangulo2.CalcularArea());

            Triangulo triangulo3 = new Triangulo();

            triangulo3.Altura = 4;
            triangulo3.Base = 4;

            Console.WriteLine(triangulo3.CalcularArea());





        }
    }
}