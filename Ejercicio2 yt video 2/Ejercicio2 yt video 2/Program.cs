using System;

namespace Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dias = {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};

            Console.WriteLine("Ingrese el numero del dia de la semana");

            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine(dias[dia-1]);


            
        }
    }
}