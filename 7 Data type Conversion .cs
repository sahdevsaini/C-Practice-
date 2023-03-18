using System;

public class Datatypes
{
    static void Main()
    {
        //int n = 45;
        //float f = 123.45F;
        //int i = (int)f;
        //int i = Convert.ToInt32(f);
        //int j = Convert.ToInt16(f);
        //decimal k = Convert.ToDecimal(n);
        //Console.WriteLine(i);
        //Console.WriteLine(j);
        //Console.WriteLine(k);
        //float strname =108.7F;
        ////int i = int.Parse(strname);
        //Console.WriteLine(i);
        bool res;
        int a;
        string myStr = "12";
        res = int.TryParse(myStr, out a);
        Console.WriteLine(res);
        Console.ReadKey();

    }
}
