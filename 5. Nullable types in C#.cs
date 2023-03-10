using System;

public class Datatypes
{
    static void Main()
    {
        //bool? IamMajor = null;
        //bool? IamMajor = true;
        bool? IamMajor = false;
        if (IamMajor == true)
        {
            Console.WriteLine("User is Major");
        }
        else if (IamMajor == false)
        {
            Console.WriteLine("User is not major");
        }
        else
        {
            Console.WriteLine("User didn't answer the question");
        }
        Console.ReadKey();

    }
}
