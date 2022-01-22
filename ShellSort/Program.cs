
using System.Diagnostics;

namespace ShellSort;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[200000000];

        Random r = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 1000);
        }

        Console.WriteLine(String.Join(", ", Sort(arr)));
    }

    public static void Swap(ref int a, ref int b)
    {
        var t = a;
        a = b;
        b = t;
    }

    public static int[] Sort(int[] arr)
    {
        Stopwatch watch = new Stopwatch();

        watch.Start();

        int step = arr.Length / 2;

        while (step > 0)
        {
            for (int i = step; i < arr.Length; i++)
            {
                int j = i;

                while ((j >= step) && (arr[j - step] > arr[j]))
                {
                    Swap(ref arr[j - step],ref arr[j]);
                    j -= step;
                }
            }

            step /= 2;
        }

        watch.Stop();

        Console.WriteLine($"Elapsed time: {watch.Elapsed}");

        return arr;
    }
}

