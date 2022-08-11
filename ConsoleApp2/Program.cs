using System;

public class Kata
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Collatz(n);
    }
    public static int Collatz(int n)
    {
        int j = 0;
        for (int i = 0; n != 1; i++)
        {
            if (n % 2 == 0)
                n = n / 2;
            else
                n = n * 3 + 1;

            if (n == 1)
                j = i + 2;
        }
        return j;
    }
}