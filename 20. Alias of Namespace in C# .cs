using System;
using PATA = ProgrameA.TeamA;    // PATA is the alias of Namesapce programe A and Team A. 
using PATB = ProgrameA.TeamB;    // PATB is the alias of Namesapce programe A and Team B.

public class name
{
    public static void Main()
    {
        PATA.A.Print();         // Calling of Print function using Alias.
        PATB.B.Print();         // Calling of Print function using Alias.
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


