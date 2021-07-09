using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class QuotientRem
    {
        public void QuotientRemainder()
        {
            int dividend = 100, divisor = 5;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}