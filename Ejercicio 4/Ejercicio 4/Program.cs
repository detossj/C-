using System;

class fibonacci
{
    static void Main(string[] args)
    {
      int v1 = 0;
      int v2 = 1;
      int fibonacci = 0;  

        Console.WriteLine(v1);
        Console.WriteLine(v2);
        for (int i = 0; i < 28; i++)
        {
            fibonacci = v1 + v2;
            Console.WriteLine(fibonacci);
            v1 = v2;
            v2 = fibonacci;

        }
    }
}