using System;

namespace nashei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            InicializarArray(array);
            NumPares(array, array2);

            Console.WriteLine("Primer array");
            ImprimirArray(array);

            Console.WriteLine("\n");

            Console.WriteLine("Segundo array");
            ImprimirArray(array2);
            
            


        }

        public static void InicializarArray(int[] array)
        {   
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }

        public static void NumPares(int[] array, int[] array2)
        {
            for(int i = 0;i < array.Length;i++)
            {
                if (array[i] % 2 == 0)
                {
                    array2[i] = array[i]; 
                }
            }
        }

        public static void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}