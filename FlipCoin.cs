using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public void FlipCoinCount()
        {
            int heads = 0;
            int tails = 0;
            int result = 0;
            Random coinflip = new Random();

            Console.WriteLine("How many times would you like to flip a coin? ");
            result = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < result; i++)
            {
                int flip = coinflip.Next(1, 3);
                if (flip == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("heads was flipped {0} times", heads);
            Console.WriteLine("tails was flipped {0} times", tails);
        }
    }
}
