using System;

class RandomSort
{
    // Método para verificar si el arreglo está ordenado
    static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
                return false;
        }
        return true;
    }

    // Método para generar una permutación aleatoria del arreglo
    static void Shuffle(int[] array)
    {
        Random rand = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rand.Next(0, i + 1); // Índice aleatorio entre 0 e i
            // Intercambiar array[i] con array[j]
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    // Método principal de RandomSort
    static void RandomSortAlgorithm(int[] array)
    {
        int attempts = 0;
        // Mientras el arreglo no esté ordenado, seguir generando permutaciones
        while (!IsSorted(array))
        {
            Shuffle(array);
            attempts++;
        }
        Console.WriteLine($"\nArreglo ordenado después de {attempts} intentos:");
        Console.WriteLine(string.Join(" ", array));
    }

    static void Main()
    {
        Console.Write("Introduce el tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Introduce los elementos del arreglo:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nArreglo original:");
        Console.WriteLine(string.Join(" ", array));

        // Aplicar RandomSort
        RandomSortAlgorithm(array);
    }
}
