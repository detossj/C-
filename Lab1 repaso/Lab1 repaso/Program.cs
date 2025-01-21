
//Construya un programa que indıque los siguiente:
//(a)Se ingrese un numero entero e indique si es par o impar.


//b)Construya una coleccion y guarde en ella 10 numeros enteros.
// Muestre por pantalla todos los numeros.
// Muestre solo los numeros pares en la coleccion.
// Muestre solo los numeros impares y negativos en la coleccion.

using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A
            //int num;

            //Console.WriteLine("Ingrese un numero entero: ");
            //num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"El numero {num} es par ");
            //}
            //else
            //{
            //    Console.WriteLine("El numero es impar");
            //}



            // B

            var lista = new List<int>();

            int numero;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");

                numero = int.Parse(Console.ReadLine());

                lista.Add(numero);
            }

            Console.WriteLine("Numeros impares de la coleccion");
            foreach (var i in lista)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
            
        }

    }

}

