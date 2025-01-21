using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Y_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero; //DECLARACION DE VARIABLE

            numeroEntero = 5;   //INICIALIZACION DE VARIABLE

            double numeroDecimal = 10.5; // DECLARACION E INICIALIZACION DE VARIABLE

            Console.WriteLine(numeroEntero);

            Console.WriteLine(numeroDecimal);

            numeroEntero = 20;

            Console.WriteLine(numeroEntero);

            string texto = "Este es un texto de prueba";

            Console.WriteLine(texto);


            // CONSTANTES

            const int CONSTANTE = 100;

            Console.WriteLine(CONSTANTE);
        }
    }
}
