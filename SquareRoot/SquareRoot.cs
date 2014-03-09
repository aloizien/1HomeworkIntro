using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            ushort ToBeSquareRooted = 12345;
            double SquareRooted = Math.Sqrt(ToBeSquareRooted);
            Console.WriteLine ("Square Root of 12345 is {0}",SquareRooted);
        }
    }
}
