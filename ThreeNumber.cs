using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class ThreeNumber
    {
        public void FindThreeNum()
        {
            int Number1;
            int Number2;
            int Number3;

            Console.Write("Enter the 1st number :");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            Number2 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter the 3rd  number :");
            Number3 = Convert.ToInt32(Console.ReadLine());

            if (Number1 > Number2)
            {
                if (Number1 > Number3)
                {
                    Console.Write("The 1st Number is the Largest among three.");
                }
                else
                {
                    Console.Write("The 3rd Number is the Largest among three.");
                }
            }
            else if (Number2 > Number3)
                Console.Write("The 2nd Number is the Largest among three.");
            else
                Console.Write("The 3rd Number is the Largest among three.");
        }
    }
}
