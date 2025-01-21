using System;

class password
{
    static void Main()
    {
        string password = "jorge1807";

        Console.WriteLine("Ingresa tu contraseña");

        string pass = Console.ReadLine();

        if (pass == password)
        {
            Console.WriteLine("Contraseña correcta");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta");
        }
    }
}