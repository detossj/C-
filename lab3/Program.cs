using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Program programa = new Program();
        string path = "C:\\Users\\jorge\\Desktop\\lab3\\sets\\set1_laberinto_10x10.txt";


        if (File.Exists(path))
        {
            var matriz = LeerMatrizLazily(path).ToArray();
            int filas = matriz.Length;
            int columnas = matriz[0].Length;

            (int startX, int startY) = EncontrarPosicion(matriz, 'A', filas, columnas);
            (int endX, int endY) = EncontrarPosicion(matriz, 'B', filas, columnas);

            if (startX == -1 || endX == -1)
            {
                Console.WriteLine("No se encontraron posiciones válidas para 'A' o 'B'.");
                return;
            }

            Console.WriteLine("Seleccione la heurística:");
            Console.WriteLine("1. Distancia de Manhattan");
            Console.WriteLine("2. Distancia Euclidiana");
            int opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            Func<int, int, int, int, double> heuristica = opcion switch
            {
                1 => CaminoDeManhattan,
                2 => CaminoEuclidiano,
                _ => throw new ArgumentException("Opción no válida")
            };

            Stopwatch timer = new Stopwatch();
            timer.Start();
            (List<string> caminoCorto, int nodosExpandidos) = programa.BuscarCaminoMasCortoAStar(
                matriz, startX, startY, endX, endY, heuristica);
            timer.Stop();

            if (caminoCorto.Count > 0)
            {
                Console.WriteLine($"Longitud del camino: {caminoCorto.Count}");
                Console.WriteLine($"Nodos expandidos: {nodosExpandidos}");
                foreach (var paso in caminoCorto)
                {
                    Console.WriteLine(paso.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("No se encontró un camino válido.");
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }

    static IEnumerable<char[]> LeerMatrizLazily(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line.ToCharArray();
            }
        }
    }

    static (int, int) EncontrarPosicion(char[][] matriz, char objetivo, int filas, int columnas)
    {
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                if (matriz[i][j] == objetivo)
                    return (i, j);
        return (-1, -1);
    }

    public (List<string> camino, int nodosExpandidos) BuscarCaminoMasCortoAStar(
        char[][] matriz, int startX, int startY, int endX, int endY,
        Func<int, int, int, int, double> heuristica)
    {
        var direcciones = new (int, int, string)[] { (-1, 0, "UP"), (1, 0, "DOWN"), (0, -1, "LEFT"), (0, 1, "RIGHT") };
        var visitados = new bool[matriz.Length, matriz[0].Length];
        var padres = new Dictionary<(int, int), (int, int, string)>();
        var cola = new PriorityQueue<(int, int, int), double>();
        int nodosExpandidos = 0;

        cola.Enqueue((startX, startY, 0), 0);

        while (cola.Count > 0)
        {
            var (x, y, costoActual) = cola.Dequeue();

            if (visitados[x, y]) continue;
            visitados[x, y] = true;

            if (x == endX && y == endY)
            {
                return (ReconstruirCamino(padres, startX, startY, endX, endY), nodosExpandidos);
            }

            foreach (var (dx, dy, dir) in direcciones)
            {
                int nx = x + dx;
                int ny = y + dy;

                if (EsMovimientoValido(matriz, nx, ny, visitados))
                {
                    nodosExpandidos++;
                    padres[(nx, ny)] = (x, y, dir);
                    int nuevoCosto = costoActual + 1;
                    double prioridad = nuevoCosto + heuristica(nx, endX, ny, endY);

                    cola.Enqueue((nx, ny, nuevoCosto), prioridad);
                }
            }
        }

        return (new List<string>(), nodosExpandidos);
    }

    private List<string> ReconstruirCamino(
        Dictionary<(int, int), (int, int, string)> padres, int startX, int startY, int endX, int endY)
    {
        var camino = new List<string>();
        var actual = (endX, endY);

        while (actual != (startX, startY))
        {
            var (px, py, dir) = padres[actual];
            camino.Add(dir);
            actual = (px, py);
        }

        camino.Reverse();
        return camino;
    }

    private bool EsMovimientoValido(char[][] matriz, int x, int y, bool[,] visitados)
    {
        return x >= 0 && y >= 0 && x < matriz.Length && y < matriz[0].Length &&
               matriz[x][y] != '#' && !visitados[x, y];
    }

    public static double CaminoDeManhattan(int x1, int x2, int y1, int y2)
    {
        return Math.Abs(x2 - x1) + Math.Abs(y2 - y1);
    }

    public static double CaminoEuclidiano(int x1, int x2, int y1, int y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}

// Clase PriorityQueue personalizada
public class PriorityQueue<TElement, TPriority> where TPriority : IComparable<TPriority>
{
    private SortedDictionary<TPriority, Queue<TElement>> _dictionary = new();
    public int Count { get; private set; }

    public void Enqueue(TElement element, TPriority priority)
    {
        if (!_dictionary.ContainsKey(priority))
        {
            _dictionary[priority] = new Queue<TElement>();
        }
        _dictionary[priority].Enqueue(element);
        Count++;
    }

    public TElement Dequeue()
    {
        var firstPair = _dictionary.First();
        var element = firstPair.Value.Dequeue();

        if (firstPair.Value.Count == 0)
        {
            _dictionary.Remove(firstPair.Key);
        }

        Count--;
        return element;
    }
}