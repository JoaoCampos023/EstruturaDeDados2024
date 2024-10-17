using System;

class Program
{
    static void DisplayArray(int[] arr)
    {
        // Mostra o estado atual do array como uma "torre"
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static void CocktailSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped = true;
        int start = 0;
        int end = n - 1;

        Console.WriteLine("Array original:");
        DisplayArray(arr);

        while (swapped)
        {
            swapped = false;

            // Passo da esquerda para a direita
            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    // Troca os elementos
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }
            // Exibe o estado do array após a passagem da esquerda para a direita
            Console.WriteLine($"Esquerda para a direita:");
            DisplayArray(arr);

            // Se não houve trocas, a lista já está ordenada
            if (!swapped)
                break;

            swapped = false;
            end--;

            // Passo da direita para a esquerda
            for (int i = end - 1; i >= start; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    // Troca os elementos
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    swapped = true;
                }
            }
            // Exibe o estado do array após a passagem da direita para a esquerda
            Console.WriteLine($"Direita para a esquerda:");
            DisplayArray(arr);

            start++;
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 9, 7, 5, 3, 1, 4, 6, 2, 8, 0 }; // Aumentando a quantidade de números
        CocktailSort(array);
        
        Console.WriteLine("Array ordenado:");
        DisplayArray(array);
    }
}
