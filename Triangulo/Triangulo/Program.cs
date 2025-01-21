using System;
using Lab2;

internal class Program
{
    static void Main(string[] args)
    {
        Triangulo T1 = new Triangulo(4,5);
        T1.Altura = 4;
        T1.Basee = 5;
        Console.WriteLine(T1.CalcularArea());
    }
}
