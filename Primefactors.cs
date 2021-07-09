using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class PrimeFactors
    {
        int a;
        int b;
        public void Factors()
        {
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
    }
}