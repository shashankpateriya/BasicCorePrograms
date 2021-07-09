using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void VowelConst()
        {
            char ch;

            Console.WriteLine("Enter any Alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'))
            {
                Console.WriteLine(" is Vowel");
            }
            else
            {
                Console.WriteLine(" is Consonant");
                //  Console.ReadLine();
            }
        }
    }
}