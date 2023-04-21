// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Day2;

public class Program
{
    // 1. 
    public static int[] GenerateNumbers()
    {
        Random rand = new Random();
        int[] arr = new int[10];

        for (int i=0;i<arr.Length;i++)
        {
            arr[i] = rand.Next(arr.Length);
        }
        foreach (var i in arr) Console.Write(i + " ");
        return arr;
    }

    public static int[] Reverse(int[] arr)
    {
        int tmpA=0, tmpB=0, tmp=0;

        for (int i=0;i<5;i++)
        {
            tmp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = tmp;
        }
        return arr;
    }

    public static void PrintNumbers(int[] arr)
    {
        Console.WriteLine();
        foreach (var i in arr) Console.Write(i+" ");

    }


    // 2.
    public static int Fibonacci(int idx)
    {
        if (idx == 1 || idx == 0) return 1;
        return Fibonacci(idx-1)+Fibonacci(idx-2);
    }


    public static void Main()
    {
        // 1.
        /*
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
        */

        // 2.
        /*
        int[] fiboArr = new int[10];
        fiboArr[0] = 1;
        fiboArr[1] = 1;
        for (int i=2; i<10;i++)
        {
            fiboArr[i] = fiboArr[i - 2] + fiboArr[i - 1];
        }

        foreach (var i in fiboArr) Console.Write(i+" ");
        Console.WriteLine();
        int idx = int.Parse(Console.ReadLine());
        int fibo = Fibonacci(idx-1);
        Console.WriteLine(fibo);
        */
    }
}