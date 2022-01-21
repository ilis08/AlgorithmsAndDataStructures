using System.Diagnostics;

namespace Factoriel;

class Program
{
    static Stopwatch stopwatch = new Stopwatch();

    public static void Main()
    {
        int[] arr = new int[1000];

        Random r = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 50);
        }

        Console.WriteLine(String.Join(", ", Sort(arr)));
    }

    public static int[] Sort(int[] arr)
    {
        Stopwatch watch = new Stopwatch();

        watch.Start();

        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        watch.Stop();

        Console.WriteLine($"Elapsed time: {watch.Elapsed}");

        return arr;
    }
}