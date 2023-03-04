using System;

public class UserInput
{
    static void Main()
    {

        Console.WriteLine("Enter the input: ");
        string Firstname = Console.ReadLine();
        Console.WriteLine("Enter the input: ");
        string Lastname = Console.ReadLine();
        Console.WriteLine("Hello {0}, {1}",  Firstname,Lastname);
        Console.ReadKey();

        //Console.WriteLine("Enter the input: ");
        //string username = Console.ReadLine();
        //Console.WriteLine("Hello " + username);
        //Console.ReadKey();
    }
}
