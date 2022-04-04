using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapTowNum
    {
        public int first, second, temp = 0;
        public void SwapTwoNumber()
        {
            Console.WriteLine("Enter First Number :- ");
            first = Convert.ToInt32(Console.ReadLine()); //"20"

            Console.WriteLine("Enter Second Number :- ");
            second = Convert.ToInt32(Console.ReadLine()); //"30"

            Console.WriteLine("Before Swapping :");
            Console.WriteLine("First :- {0} Second :- {1}", first, second);
            //temp-->B-->A-->temp
            //0      20       20
            temp = first; // temp=20;
            //0       30       30
            first = second; //first=30;
            //0       20        20
            second = temp; //second=20;

            Console.WriteLine("After Swapping :");
            Console.WriteLine("First :- {0} Second :- {1}", first, second);
        }
    }
}
