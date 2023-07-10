using System;
public class programe
{
    public static void Main()
    {
        Console.WriteLine("Enter the Input");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("The Sum is {0}", sum);
        Console.ReadKey();

    }
}
