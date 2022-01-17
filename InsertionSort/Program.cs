using System.Diagnostics;

namespace InsertionSort;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[10];

        Random r = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 50);
        }

        Console.WriteLine(String.Join(", ", Sort(arr)));
    }

    public static int [] Sort(int[] arr)
    {
        Stopwatch watch = new Stopwatch();

        watch.Start();
        int index;
        int currentNumber;

        for (int i = 0;i < arr.Length; i++)
        {
            index = i;
            currentNumber = arr[i];

            while (index > 0 && currentNumber < arr[index - 1])
            {
                arr[i] = arr[i - 1];
                index--; 
            }

            arr[index] = currentNumber;
        }
        watch.Stop();

        Console.WriteLine($"Elapsed time: {watch.Elapsed}");

        return arr;
    }
}