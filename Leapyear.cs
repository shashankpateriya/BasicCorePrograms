using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class Leapyear
    {
        int year = 0;
        public void Leapyr()
        {
            Console.WriteLine("Enter the year");
            year = int.Parse(Console.ReadLine());
            if ((year % 400 == 0) && (year % 100 == 0) && (year % 4 == 0))
                Console.WriteLine("Is a leap year" + year);
            else
                Console.WriteLine("Is not a leapyear" + year);
        }
    }
}