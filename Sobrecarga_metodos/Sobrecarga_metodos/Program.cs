using System;

namespace Sobrecarga_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La funcion random devuelve numeros enteros positivos
            Random rnd = new Random();


            // Si no colocamos un numero devolvera un numero del 0 hasta el int maximo
            Console.WriteLine(rnd.Next());
           
            // Si colocamos un numero devolvera un numero del 0 hasta 1 antes del numero que coloquemos
            Console.WriteLine(rnd.Next(3));

            // Si colocamos dos numeros devolvera un numero entre el primero hasta uno antes del ultimo

            Console.WriteLine(rnd.Next(0,3));

            Console.WriteLine(Suma(4.4, 5));
            Console.WriteLine(Suma(2 ,4, 5));
            Console.WriteLine(Suma(2, 4, 5, 7));

        }

        public static int Suma(double a, int b)
        {
            double suma = a + b;
            return (int)suma;
        }

        public static int Suma(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Suma(int a,int b, int c, int d)
        {
            return a + b + c + d;
        }

    }
}