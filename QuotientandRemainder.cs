using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientandRemainder
    {
        public void QandR()
        {
    
            Console.Write("Enter a number for Divisor :");//input from User
            int Divisor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number for Dividend :");//input from User
            int Dividend = Convert.ToInt32(Console.ReadLine());

            int rem = Dividend % Divisor; //rem
            Console.Write("Remainder is : " + rem );

            int que = Dividend / Divisor; //que
            Console.Write("  Quotient is : " + que);
            Console.ReadLine();
        }
    }
}
