using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayEntero = new int[5];


            for (int i = 0; i < arrayEntero.Length; i++)
            {
                Console.WriteLine("Ingrese un numero al arreglo");
                arrayEntero[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < arrayEntero.Length;i++)
            {
                Console.WriteLine(arrayEntero[i]);
            }
        }
    }
}