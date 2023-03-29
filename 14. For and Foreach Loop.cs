using System;

public class Loop
{

    static void Main()
    {
        //int[] num = new int[5] { 3, 4, 5, 6, 8 };
        //for(int i =0; i<=num.Length; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //foreach(int k in num)
        //{
        //    Console.WriteLine(k);
        //}
        //Console.ReadKey();

        //int j = 0;
        //while(j<num.Length)
        //{
        //    Console.WriteLine(j);
        //    j++;
        // }

        // program to print Even numbers

        //for (int i=0; i<=20;i++)
        //{
        //    if (i % 2 == 0)
        //        continue;
        //    Console.WriteLine(i);
        //}
        //Console.ReadKey();

        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);
        }
        Console.ReadKey();

    }
}
