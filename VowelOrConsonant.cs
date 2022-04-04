using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class VowelOrConsonant
    {
        public static void FindVowelOrConsonant()
            
        {
            Char input;
            Console.WriteLine("Enter a character :  ");
            input = Convert.ToChar(Console.ReadLine().ToUpper());

            if (input == 'a' | input == 'A'| input == 'e' | input == 'E' | input == 'i' | input == 'I' | input == 'o'
                    | input == 'O' | input == 'u' | input == 'U')
            {
                Console.WriteLine("Its a vowel");
            }
            else
            {
                Console.WriteLine("Its a consonant");
            }
        }
    }
}
