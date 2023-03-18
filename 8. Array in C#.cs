using System;

public class Array
{
    static void Main()
    {
        int i, j;
        int[] n = new int[10];
        //int[] Elements = new int[5];
        //Elements[0] = 10;
        //Elements[1] = 20;
        //Elements[2] = 30;
        //Elements[3] = 40;
        //int[] Elements = new int[5]   { 10,20,30,40,50};
        //for (i = 0; i < Elements.Length; i++)
        //{

        //    Console.WriteLine(Elements[i]);
        //}
        for (i = 0; i < 10; i++)
        {
            n[i] = i + 100;
        }
        for (j = 0; j < 10; j++)
        {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            Console.ReadKey();
        }


    }
}
