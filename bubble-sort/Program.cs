namespace bubble_sort;

public class Program
{
    static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4, 5];

        BubbleSort(array);

        Console.WriteLine("Array ordenado:");

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    public static void BubbleSort(int[] array)
    {
        int size = array.Length;

        for (int j = 0; j < size - 1; j++)
        {
            var changes = 0;

            for (int i = 0; i < size - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i + 1], array[i]) = (array[i], array[i + 1]);
                    changes++;
                }
            }

            if (changes <= 1) break;
        }
    }
}
