namespace selection_sort;

public class Program
{
    static void Main(string[] args)
    {
        int[] array = [7, 5, 1, 8, 3];

        SelectionSort(array);

        Console.WriteLine("Array ordenado:");

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    static void SelectionSort(int[] lista)
    {
        int n = lista.Length;

        for (int j = 0; j < n - 1; j++)
        {
            int minIndex = j;

            for (int i = j; i < n; i++)
            {
                if (lista[i] < lista[minIndex])
                {
                    minIndex = i;
                }
            }

            if (lista[j] > lista[minIndex])
            {
                (lista[minIndex], lista[j]) = (lista[j], lista[minIndex]);
            }
        }
    }
}
