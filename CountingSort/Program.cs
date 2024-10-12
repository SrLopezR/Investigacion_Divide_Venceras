using System;

class CountingSort
{
    // Método para realizar el Counting Sort
    static void CountingSorter(int[] array)
    {
        // Encontrar el valor máximo en el arreglo
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }

        // Crear un arreglo de conteo de tamaño (max+1)
        int[] count = new int[max + 1];

        // Contar las apariciones de cada elemento en el arreglo original
        for (int i = 0; i < array.Length; i++)
        {
            count[array[i]]++;
        }

        // Acumular las posiciones correctas de los elementos
        for (int i = 1; i <= max; i++)
        {
            count[i] += count[i - 1];
        }

        // Crear un arreglo de salida
        int[] sortedArray = new int[array.Length];

        // Colocar los elementos en el arreglo ordenado según los valores acumulados en count[]
        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortedArray[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        // Copiar el arreglo ordenado al original
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = sortedArray[i];
        }
    }

    static void Main()
    {
        // Arreglo de ejemplo
        int[] array = { 1,3,4,2,0,1,2,2,5,5};

        Console.WriteLine("Arreglo original:");
        Console.WriteLine(string.Join(" ", array));

        // Aplicar Counting Sort
        CountingSorter(array);

        // Mostrar el arreglo ordenado
        Console.WriteLine("\nArreglo ordenado:");
        Console.WriteLine(string.Join(" ", array));
    }
}
