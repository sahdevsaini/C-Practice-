using System;

public class Loop
{

    static void Main()
    {
        Console.WriteLine("Enter the Target Value : ");
        int targetvalue = int.Parse(Console.ReadLine());
        int start = 0;
        while (start <= targetvalue)
        {
            Console.WriteLine(start);
            start += 2;
        }

        Console.ReadKey();
    }

}
