using System;

public class ParameterClass
{
    public static void Main()
    {
        int[] newlist = new int[5] { 10, 20, 5, 8, 50 };
        ArrayParameter(newlist);
        Console.Read();
    }
    public static void ArrayParameter(params int[] newlist)
    {
        Console.WriteLine("There are {0} elements in array", newlist.Length);
        foreach (int i in newlist)
        {
            Console.WriteLine(i);
        }

    }

}
