using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public int num = 0;
        public void PowerOf()
        {

            Console.Write("Enter a number to check Power of :");//input from User
            int num = Convert.ToInt32(Console.ReadLine());

            int result = num * num; //num*num if 10*10==100
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
