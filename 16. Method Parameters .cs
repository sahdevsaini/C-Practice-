using System;

public class ParameterClass
{

    //public static void Main()
    // {
    //     int i = 0;
    //     ParameterClass.parameter(i);
    //     Console.WriteLine(i);
    //     Console.ReadKey();
    // }
    // public static void parameter(int j)
    // {
    //     j = 101;

    // }

    public static void Main()
    {
        int i = 0;
        ParameterClass.parameter(ref i);
        Console.WriteLine(i);
        Console.ReadKey();
    }
    public static void parameter(ref int j)
    {
        j = 101;

    }
}
