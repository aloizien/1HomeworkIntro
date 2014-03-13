using System;

class PrintaSequence
{
    static void Main()
    {
            //Using String
        Console.WriteLine("String Numbers : 2,-3,4,-5,6,-7,8,-9,10,-11,12");

            //Using Loops
        Console.Write("Loop Numbers : ");

        for (int i = 2; i < 13; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i); Console.Write(",");
            }
            else
            {
                Console.Write(i * -1); Console.Write(",");
            }
        }
    }
}