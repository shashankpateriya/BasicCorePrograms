using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class EvenOrOdd
    {
        public void EvenOdd()
        {
            int i;
            Console.WriteLine("enter the number");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}