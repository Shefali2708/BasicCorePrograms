using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Factors
    {
        public void FindFactor()
        {
            int n, i;
            Console.WriteLine("Enter the Number (factor) :");
            n = Convert.ToInt32(Console.ReadLine());//form user
            Console.WriteLine("Factors:");

            for (i = 1; i <= n; i++)//var i<num entered.. 1<4 then i++
            {
                if (n % i == 0)
                  //4%1==0
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
