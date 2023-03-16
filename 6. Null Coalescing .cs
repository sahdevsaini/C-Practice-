using System;

public class Datatypes
{
    static void Main()
    {
        int ? ticketonsale = 100;
        int ticketavailable= ticketonsale ?? 0;

        //if (ticketonsale == 0)
        //{
        //    ticketavailable = 0;
        //}
        //else
        //{
        //    ticketavailable = (int) ticketonsale;
        //}
        Console.WriteLine("ticketavailable {0}", ticketavailable);
        Console.ReadKey();

    }
}
