using System;

class Num
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero int: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Es un numero par");
        }
        else
        {
            Console.WriteLine("Es un numero impar");
        }

        Console.WriteLine("\nIngresa un numero float: ");
        float numero2 = Convert.ToSingle(Console.ReadLine());

        if ( numero2 > 0 )
        {
            Console.WriteLine("Es mayor a 0");
        }
        else
        {
            Console.WriteLine("Es menor o igual a 0");
        }

        Console.WriteLine("\nIngresa un numero double: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        if (numero3 > 0)
        {
            Console.WriteLine("Es mayor a 0");
        }
        else
        {
            Console.WriteLine("Es menor o igual a 0");
        }
    }
}