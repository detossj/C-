//Pelota, debe tener un radio, color, textura y transparencia. Debe tener un servicio que permita
//establecer la textura de la pelota, el radio y transparencia.

using System;

namespace ProblemaB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelota1 = new Pelota();
            Pelota pelota2 = new Pelota(3,"Rojo","Aspera",true);

            Console.WriteLine(pelota1.Radio);
            Console.WriteLine(pelota2.Radio);
            Console.WriteLine(pelota2.Color);
            Console.WriteLine(pelota2.Textura);
            Console.WriteLine(pelota2.Transparencia);

            pelota2.Radio = 4;
            pelota2.Color = "Azul";
            pelota2.Textura = "Lisa";
            pelota2.Transparencia = false;

            Console.WriteLine(pelota2.Radio);
            Console.WriteLine(pelota2.Color);
            Console.WriteLine(pelota2.Textura);
            Console.WriteLine(pelota2.Transparencia);
        }
    }
}