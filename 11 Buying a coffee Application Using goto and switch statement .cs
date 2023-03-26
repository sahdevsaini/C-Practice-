using System;

public class Array
{
    static void Main()
    {
        int TotalCoffeCost = 0;
    Start:
        Console.WriteLine("1. Samll  2.Medium  3.Large");
        int userchoice = int.Parse(Console.ReadLine());
        switch (userchoice)
        {
            case 1:
                TotalCoffeCost += 20;
                break;
            case 2:
                TotalCoffeCost += 40;
                break;
            case 3:
                TotalCoffeCost += 50;
                break;
            default:
                goto Start;
        }

        Console.WriteLine("Total bill {0}", TotalCoffeCost);

    Decision:
        Console.WriteLine("Do you want to buy another coffee 1. Yes 2. No");
        String userdecision = Console.ReadLine();
        switch (userdecision.ToUpper())
        {
            case "YES":
                goto Start;

            case "NO":
                break;
            default:
                goto Decision;
        }
        Console.WriteLine("Thanks for shopping");
        Console.ReadKey();
    }

}
