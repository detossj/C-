using System;

class cont_impar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entero: ");
        
         int contador = 0;

        while (contador != 5)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 != 0 )
            {
                contador++;
            }
            
        }
    }
}