using System;
using System.Collections;
using System.Collections.Generic;

namespace test1

{
    internal class Program
    {
        static void Main(string[] args)

        {
            // EJERCICIO 1


            //Console.WriteLine("Ingrese el numero de notas que va a ingresar");

            //int cantidad = int.Parse(Console.ReadLine());

            //var lista_notas  = new List<float>(cantidad);

            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine("Ingrese una nota: ");
            //    lista_notas.Add(float.Parse(Console.ReadLine()));
            //}

            //float suma_notas = 0;

            //foreach (float i in lista_notas)
            //{
            //    suma_notas = suma_notas + i;
            //}

            //float promedio = 0;

            //promedio = suma_notas / (float)cantidad;

            //if (promedio >= 4.0)
            //{
            //    Console.WriteLine($"El promedio de las notas es: {promedio} por lo tanto el estudiante aprobo");
            //}
            //else if (promedio < 4.0)
            //{
            //    Console.WriteLine($"El promedio de las notas es: {promedio} por lo tanto el estudiante reprobo");
            //}










            //EJERCICIO 2







            //var list_pacientes = new List<float>();

            //int opcion = 0;

            //while (true)
            //{
            //    Console.WriteLine("Ingrese la temperatura corporal del paciente: ");
            //    float temp = float.Parse(Console.ReadLine());
            //    list_pacientes.Add(temp);

            //    Console.Clear();

            //    Console.WriteLine("Ingrese una opcion: ");
            //    Console.WriteLine("1.Agregar otro paciente");
            //    Console.WriteLine("2.Salir");

            //    opcion = int.Parse(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.Clear();
            //        continue;
            //    }
            //    else if(opcion == 2)
            //    {

            //        Console.Clear();

            //        Console.WriteLine("Pacientes con temperatura superior a 37,5: ");

            //        foreach (float i in list_pacientes)
            //        {
            //            if (i >= 37.5)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opcion no valida");
            //    }






            //EJERCICIO 3


            //var list1 = new List<int> { 1, 2, 3 };
            //var list2 = new List<int> { 1, 2, 3 };
            //var list3 = new List<int>();

            //for (int i = 0; i < list1.Count; i++)
            //{
            //    list3.Add(list1[i] + list2[i]);
            //}

            //foreach (var item3 in list3)
            //{
            //    Console.WriteLine(item3);
            //}



            //EJERCICIO 4

            //var lista = new List<int> {2, 4, -3, 7, 11, 21, 9, 12, -13 };

            //int par = 0, impar = 0, positivo = 0, negativo = 0;

            //foreach (int i in lista)
            //{
            //    if(i > 0)
            //    {
            //        positivo++;
            //        if (i % 2 == 0)
            //        {
            //            par++;
            //        }
            //        else if (i % 2 != 0)
            //        {
            //            impar++;
            //        }
            //    }
            //    else if(i < 0)
            //    {
            //        negativo++;
            //        if (i % 2 == 0)
            //        {
            //            par++;
            //        }
            //        else if (i % 2 != 0)
            //        {
            //            impar++;
            //        }
            //    }


            //}

            //Console.WriteLine($"La cantidad de numeros positivos es: {positivo}");
            //Console.WriteLine($"La cantidad de numeros negativos es: {negativo}");
            //Console.WriteLine($"La cantidad de numeros pares es: {par}");
            //Console.WriteLine($"La cantidad de numeros impares es: {impar}");









            //EJERCICIO 5


            //var lista = new List<int> { 1, 2, 3, 4, 5 };

            //lista.Reverse();

            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}





            //EJERCICIO 6


            //var num = new List<int> {-2,-4, 6 };

            //var absoluto = new List<int>();

            //foreach (int i in num)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int i in num)
            //{
            //    if (i > 0)
            //    {
            //        absoluto.Add(i);
            //    }
            //    else if (i < 0)
            //    {
            //        absoluto.Add(Math.Abs(i));
            //    }
            //}

            //foreach (int i in absoluto)
            //{
            //    Console.WriteLine(i);
            //}





            //EJERCICIO 7

            //var lista = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Ingrese la edad de la persona");
            //    lista.Add(int.Parse(Console.ReadLine()));

            //    Console.Clear();

            //    Console.WriteLine("Ingrese una opcion: ");
            //    Console.WriteLine("1.Agregar edad");
            //    Console.WriteLine("2.Salir");

            //    int opcion = int.Parse(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.Clear();
            //        continue;
            //    }
            //    else if (opcion == 2)
            //    {
            //        break;
            //    }
            //}

            //var menor_edad = new Queue<int>();
            //var mediana_edad = new Queue<int>();
            //var mayor_edad = new Queue<int>();

            //foreach (int i in lista)
            //{
            //    if (i >= 0 && i <= 4)
            //    {
            //        menor_edad.Enqueue(i);
            //    }
            //    else if (i >= 5 && i <= 59)
            //    {
            //        mediana_edad.Enqueue(i);
            //    }
            //    else if (i >= 60)
            //    {
            //        mayor_edad.Enqueue(i);
            //    }
            //}

            //Console.WriteLine("Edades de personas  de menor edad");

            //foreach (int i in menor_edad)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Edades de personas de mediana edad");

            //foreach (int i in mediana_edad)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Edades de personas de mayor edad");

            //foreach (int i in mayor_edad)
            //{
            //    Console.WriteLine(i);
            //}



            //EJERCICIO 8

            //var pila1 = new Stack<string>(new string[] { "Salmon", "Papas duquesas", "Bistec" });
            //var pila_aux = new Stack<string>();
            //var pila2 = new Stack<string>();

            //foreach (string s in pila1)
            //{
            //    Console.WriteLine(s);
            //    pila_aux.Push(s);
            //}

            //foreach (string s in pila_aux)
            //{
            //    pila2.Push(s);
            //}

            //foreach (string s in pila2)
            //{
            //    Console.WriteLine(s);
            //}


            // EJERCICIO 9


        }


    }

}
