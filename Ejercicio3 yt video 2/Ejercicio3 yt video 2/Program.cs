namespace trabajadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de clientes que va a ingresar");
            int ingresado = int.Parse(Console.ReadLine());
            string[] nombres = new string[ingresado];
            int[] edades = new int[ingresado];

            IngresarClientes(nombres, edades);
            ImprimirClientes(nombres, edades);


        }

        public static void IngresarClientes(string[] n,int[] e)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del cliente");
                n[i] = Console.ReadLine();

                Console.WriteLine("Ingrese edad del cliente");
                e[i] = int.Parse(Console.ReadLine());

            }
        }

        public static void ImprimirClientes(string[] n, int[] e)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i]);
                Console.WriteLine(" " + e[i]);
            }

        }
    }
}