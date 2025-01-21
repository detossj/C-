using System;

namespace trabajadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>(4);

            string trabajador;

            for (int i = 0; i < 4; i++)
            {
                trabajador = Console.ReadLine();
                lista.Add(trabajador);
            }

            foreach (string i in lista)
            {
                Console.WriteLine(i);
            }


        }
    }
}