namespace insertion_sort;

public class Program
{
    static void Main(string[] args)
    {
        int[] array = [4, 2, 7, 12, 53, 1, 0];

        InsertionSort(array);

        Console.WriteLine("Array ordenado:");

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    static void InsertionSort(int[] lista)
    {
        int n = lista.Length;

        for (int i = 1; i < n; i++)
        {
            int key = lista[i];
            int j = i - 1;
            
            while(j >= 0 && lista[j] > key)
            {
                lista[j + 1] = lista[j];
                j--;
            }

            lista[j + 1] = key;
        }
    }
}
