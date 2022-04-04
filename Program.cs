using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            FlipCoin Coin = new FlipCoin();
            Coin.FlipCoinCount();

            LeapYear Year = new LeapYear();
            Year.FindLeapYear();

            PowerOfTwo Power = new PowerOfTwo();
            Power.PowerOf();

            HarmonicNumber numOfHarmonic = new HarmonicNumber();
            numOfHarmonic.HarmonicSeries();

            Factors factorOf = new Factors();
            factorOf.FindFactor();

            QuotientandRemainder FindQandR = new QuotientandRemainder();
            FindQandR.QandR();

            SwapTowNum TwoNum = new SwapTowNum();
            TwoNum.SwapTwoNumber();

            EvenOdd NumberIsEvenOdd = new EvenOdd();
            NumberIsEvenOdd.FindEvenOdd();

            VowelOrConsonant.FindVowelOrConsonant();

            ThreeNumber Largest = new ThreeNumber();
            Largest.FindThreeNum();

        }
    }
}
