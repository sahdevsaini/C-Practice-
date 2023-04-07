using System;
using ProgrameA.TeamA;
using ProgrameA.TeamB;

public class name
{
    public static void Main()
    {
        A.Print();
        B.Print();
        Console.ReadKey();
    }
}
namespace ProgrameA
{
    namespace TeamA
    {
        public class A
        {
            public static void Print()
            {
                Console.WriteLine("This is Team A");
            }
        }
    }
}

namespace ProgrameA
{
    namespace TeamB
    {
        public class B
        {
            public static void Print()
            {
                Console.WriteLine("This is Team B");
            }
        }
    }
}


