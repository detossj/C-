using System;

class fibonacci
{
    static void Main(string[] args)
    {
        int v1 = 0, v2 = 1, fibonacci = 0;

        var lista = new List<int>();

        Console.WriteLine("Ingrese cuantos numeros de la sucesion de fibonacci quiere guardar en la lista");
        int n = Convert.ToInt32(Console.ReadLine());

        lista.Add(0);
        lista.Add(1);

        for (int i = 0; i < n-2; i++)
        {
            fibonacci = v1 + v2;
            v1 = v2;
            v2 = fibonacci;
            lista.Add(fibonacci);
        }

        foreach (int i in lista)
        {
            Console.WriteLine($"{i} ");
        }
    }
}