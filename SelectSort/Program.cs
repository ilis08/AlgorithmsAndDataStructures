namespace SelectSort;

class Program
{
    public static void Main()
    {
        int[] arr = new int[10];

        Random r =new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(1, 50);
        }

        Console.WriteLine(String.Join(", ", Sort(arr)));
    }

    public static int[] Sort(int [] arr)
    {
        int min;
        int temp;

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

            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        return arr;
    }
}