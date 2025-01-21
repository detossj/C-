using System;
class bass
{
    static void Main(string[] args)
    {
        double bono = 0,sueldo_total;

        Console.WriteLine("Ingrese sus años de servicio: ");
        int anhios_servicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su sueldo");
        
        int sueldo = Convert.ToInt32(Console.ReadLine());

        if ( anhios_servicio <= 1 )
        {
            bono = sueldo * 0.15;

            sueldo_total = bono + sueldo;

            Console.WriteLine($"Tu sueldo total es: ${sueldo_total}");
        }
        else if(anhios_servicio <= 2 && anhios_servicio <= 5) 
        {
            bono = sueldo * 0.2;

            sueldo_total = bono + sueldo;

            Console.WriteLine($"Tu sueldo total es: ${sueldo_total}");

        }
        else if (anhios_servicio > 5)
        {
            bono = sueldo * 0.25;

            sueldo_total = bono + sueldo;

            Console.WriteLine($"Tu sueldo total es: ${sueldo_total}");
        }
        else
        {
            bono = sueldo * 0;

            sueldo_total = bono + sueldo;

            Console.WriteLine($"Tu sueldo total es: ${sueldo_total}");
        }


    }

}
