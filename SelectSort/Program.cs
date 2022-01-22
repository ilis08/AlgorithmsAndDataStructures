using System.Diagnostics;

namespace SelectSort;

class Program
{
    public static void Main()
    {
        int[] arr = new int[100000];

        Random r =new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 1000);
        }

        Console.WriteLine(String.Join(", ", Sort(arr)));
    }

    public static int[] Sort(int [] arr)
    {
        Stopwatch watch = new Stopwatch();

        watch.Start();

        int temp;
        int min;

        for (int i = 0; i < arr.Length; i++)
        {
            min = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }

        watch.Stop();

        Console.WriteLine($"Elapsed time: {watch.Elapsed}");

        return arr;
    }
}