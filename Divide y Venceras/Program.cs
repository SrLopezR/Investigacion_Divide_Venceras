using System;

class MergeSort
{
    // Método para fusionar dos subarreglos
    static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copiando los datos a los subarreglos temporales
        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        // Fusionando los subarreglos
        int k = left;
        int iIndex = 0, jIndex = 0;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                array[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                array[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }

        // Copiando los elementos restantes de leftArray si los hay
        while (iIndex < n1)
        {
            array[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }

        // Copiando los elementos restantes de rightArray si los hay
        while (jIndex < n2)
        {
            array[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }

    // Método recursivo para aplicar el Merge Sort
    static void Sort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Ordenar la primera y segunda mitad
            Sort(array, left, mid);
            Sort(array, mid + 1, right);

            // Fusionar las dos mitades
            Merge(array, left, mid, right);
        }
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

        // Aplicar el Merge Sort
        Sort(array, 0, n - 1);

        Console.WriteLine("\nArreglo ordenado:");
        Console.WriteLine(string.Join(" ", array));
    }
}