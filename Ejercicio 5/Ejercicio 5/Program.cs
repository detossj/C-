using System;

class colection
{
    static void Main(string[] args)
    {
        var lista = new List<int>();

        Console.WriteLine("Ingrese 10 numeros entero: ");

        int num = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nIngrese un numero");

            num = Convert.ToInt32(Console.ReadLine());

            lista.Add(num);

        }
        Console.WriteLine("\n");

        foreach (int i in lista)
        {
            Console.Write($"{i}  ");
        }

        Console.WriteLine("\nNumeros pares de la coleccion: ");
        foreach (int i in lista)
        {
            if ( i % 2 == 0 )
            {
                Console.Write($"{i}  ");
            }
        }

        Console.WriteLine("\nNumeros impares  y negativos de la coleccion: ");
        foreach (int i in lista)
        {
            if (i % 2 != 0 && i<0)
            {
                Console.Write($"{i}  ");
            }
        }
    }
}