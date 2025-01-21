using System;

class switch_case
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese una vocal: ");

        char vocal = Convert.ToChar(Console.ReadLine());

        switch (vocal)
        {
            case 'a':
                Console.WriteLine("Es la vocal a");
                break;
            case 'e':
                Console.WriteLine("Es la vocal e");
                break;
            case 'i':
                Console.WriteLine("Es la vocal i");
                break;
            case 'o':
                Console.WriteLine("Es la vocal o");
                break;
            case 'u':
                Console.WriteLine("Es la vocal u");
                break;
            default:
                Console.WriteLine("Esa no es una vocal");
                break;
        }
    }
}
