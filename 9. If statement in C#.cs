using System;

public class Array
{
    /* static void Main()
     {
         Console.WriteLine("Enter the element ");
         int var = int.Parse(Console.ReadLine()); // parse function use to convert string into integer.
         if (var == 1)
         {
             Console.WriteLine("Number is 1");
         }
         if (var == 2)
         {
             Console.WriteLine("Number is 2");
         }
         if (var == 3)
         {
             Console.WriteLine("Number is 3");
         }
         if (var == 4)
         {
             Console.WriteLine("Number is 4");
         }
         Console.ReadKey(); */

    // Check given number is integer or not 
    /*static void Main()
    {  
    Console.WriteLine("Enter the element ");
    int var = int.Parse(Console.ReadLine()); // parse function use to convert string into integer.
    if (var is int)
    {
        Console.WriteLine("Enter number is Integer");
    }
    Console.ReadKey();
    }*/

    // use of OR(||) and OR(|) Operator 
    /*static void Main()
    {
        Console.WriteLine("Enter the element ");
        int var = int.Parse(Console.ReadLine()); // parse function use to convert string into integer.
        if (var==1 || var==2)      // In || complier check both the conditions 
        {
            Console.WriteLine("Enter number is Integer");
        }
        Console.ReadKey();

        Console.WriteLine("Enter the element ");
        int var = int.Parse(Console.ReadLine()); // parse function use to convert string into integer.
        if (var == 1 | var == 2)     // In this case if first condition is true complier doesn't check the second condition 
        {
            Console.WriteLine("Enter number is Integer");
        }
        Console.ReadKey();*/


    // Use of And(&&) and And(&) Operator
    static void Main()
    {
        /* Console.WriteLine("Enter the element ");
         int var = int.Parse(Console.ReadLine()); // parse function use to convert string into integer.
         int var1 = int.Parse(Console.ReadLine());
         if (var==1 && var1==2)      // In || complier check both the conditions 
         {
             Console.WriteLine("Enter number is Integer");
         }
         Console.ReadKey();*/

        Console.WriteLine("Enter the element ");
        int var1 = int.Parse(Console.ReadLine());
        int var = int.Parse(Console.ReadLine()); // parse function use to convert string into integer.
        if (var == 1 | var1 == 2)     // In this case if first condition is true complier doesn't check the second condition 
        {
            Console.WriteLine("Enter number is Integer");
        }
        Console.ReadKey();
    }
}
