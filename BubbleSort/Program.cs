namespace BubbleSort;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[100];

        Random r = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 50);
        }

        Console.WriteLine(String.Join(", ", Sort(arr)));
    }

    public static int[] Sort(int[] arr)
    {
        int temp;

        for (int i = 0; i < arr.Length - 1; i++)
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

        return arr;
    }
}
