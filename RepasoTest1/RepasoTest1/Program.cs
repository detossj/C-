using System;
using System.Collections;
internal class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Ingrese un numero entero: ");

        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Es un numero entero par");
        }
        else
        {
            Console.WriteLine("Es un numero entero impar");


        


        Console.WriteLine("Ingresa un numero float: ");
        float num = float.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("El numero es mayor que 0");
        }

        int contador = 0;

        while (true)
        {
            Console.WriteLine("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            
            if ( num % 2 != 0)
            {
                contador++;

                if (contador == 5)
                {
                    break;

                }
            }

        }
        




        int fibonacci = 0;

        int v1 = 0;
        int v2 = 1;

        Console.WriteLine(v1);
        Console.WriteLine(v2);
        for (int i = 0; i < 28; i++)
        {
            fibonacci = v1 + v2;
            Console.WriteLine(fibonacci);
            v1 = v2;
            v2 = fibonacci;
        }
        





        var queue = new Queue<int>(new[] { 2, -4, 5, 6, -5, 8, -3, 7, 11,-9 });

        Console.WriteLine("Fila: ");
        foreach (int i in queue)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Numeros pares de la fila");

        foreach (int i in queue)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Numeros impares y negativos de la fila");

        foreach(int i in queue)
        {
            if (i % 2 != 0 && i<0)
            {
                Console.WriteLine(i);
            }
        }*/

        var Stack = new Stack();

        Console.WriteLine("Ingrese un numero entero");

        int n = int.Parse(Console.ReadLine());

        int fibonacci = 0;

        int v1 = 0;
        int v2 = 1;

        Stack.Push(v1);
        Stack.Push(v2);

        for (int i = 0; i < n-2; i++)
        {
            fibonacci = v1 + v2;
            Stack.Push(fibonacci);
            v1 = v2;
            v2 = fibonacci;
        }

        foreach (int i in Stack)
        {
            Console.WriteLine(i);
        }
 








    }
}