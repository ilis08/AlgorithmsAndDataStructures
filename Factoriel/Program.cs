using System.Diagnostics;

namespace Factoriel;

class Program
{
    static Stopwatch stopwatch = new Stopwatch();

    public static void Main()
    {
        Console.WriteLine(Fibonachi(10));
    }

    public static int Fibonachi(int n)
    {
        if (n == 0 || n == 1) return n;

        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }

    public static int FactorielRecursion(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n * FactorielRecursion(n - 1);
    }

    public static int FactorielFor(int n)
    {
        int value = n;

        if (n == 1)
        {
            return 1;
        }

        for (int i = n - 1; i >= 1; i--)
        {
            value = value * i;
        }

        return value;
    }
}