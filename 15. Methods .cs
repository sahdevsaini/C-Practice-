using System;

public class program
{

    static void Main()
    {
        Console.WriteLine("Enter the number");
        int n = int.Parse(Console.ReadLine());
        program.EvenNumber(n);
        program p1 = new program();
        p1.oddnumber(n);
        program p = new program();
        Console.WriteLine("\nThe Sum of two number is :- {0}", p.add1(10, 20));
        Console.ReadKey();

    }
    public void oddnumber(int n)
    {
        if (n % 2 != 0)
        {
            Console.WriteLine("Given number is Odd");
        }
        else
        {
            Console.WriteLine("Given Number is Even");
        }

    }

    public int add1(int a, int b)
    {
        return a + b;
    }
    public static void EvenNumber(int target)
    {
        int start = 0;
        while (start < target)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }
}
