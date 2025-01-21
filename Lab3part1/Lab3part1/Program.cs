using System;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meseros = new List<Mesero>();
            int contador = 0;

            for (int i = 0; i < 101; i++)
            {
                Mesero mesero = new Mesero();
                mesero.AgregarPropina(i, i * 2);
                meseros.Add(mesero);
            }

            foreach (var mesero in meseros)
            {
                Console.WriteLine($"Propina de Mesero {contador}: "+mesero.Propina);
                contador++;
            }

            Console.Clear();

            Console.WriteLine("¿Cuantos platos desea ordenar?");

            int cantidad = int.Parse(Console.ReadLine());

            var platos = new List<Plato>();

            for (int i = 0;i <cantidad;i++)
            {
                Plato plato = new Plato();
                Console.WriteLine("Ingrese el plato de comida: ");
                plato.PlatoPrincipal = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del plato de comida: ");
                plato.Precio = int.Parse(Console.ReadLine());
                platos.Add(plato);
            }

            Console.WriteLine("¿Desea agregar propina al mesero?");

            string respuesta = Console.ReadLine();
            int total = 0;

            if (respuesta == "SI" || respuesta == "si")

            {
                Mesero mesero = new Mesero();
                foreach(var plato in platos)
                {
                    Console.WriteLine($"Plato principal: {plato.PlatoPrincipal}");
                    Console.WriteLine($"Precio: {plato.Precio}");
                }

                for (int i = 0;i<cantidad;i++)
                {
                    total = total + platos[i].Precio;
                }

                mesero.AgregarPropina(total, 0.10);
                
                
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Propina que gano el mesero: {mesero.Propina}");

            }
            else if(respuesta == "NO" || respuesta == "no")
            {
                foreach (var plato in platos)
                {
                    Console.WriteLine($"Plato principal: {plato.PlatoPrincipal}");
                    Console.WriteLine($"Precio: {plato.Precio}");
                }

                for (int i = 0; i < cantidad; i++)
                {
                    total = total + platos[i].Precio;
                }

                Console.WriteLine($"Total: {total}");

            }
            else
            {
                Console.WriteLine("Error");
            }


        }
    }
}