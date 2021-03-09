using System;

namespace hotterColder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();            
            BackControl mistery = new BackControl(ran.Next(0, 101));
            Console.WriteLine("random number has been chosen {0}", mistery.random);
            Console.WriteLine("Make a guess");            
            bool win = mistery.FirstGuess(mistery.OnlyNumbers());
            while (!win)
            {
                Console.WriteLine("Please make a guess");               
                win = mistery.Guess(mistery.OnlyNumbers());
            }
            Console.WriteLine("You got it!’");

        }
    }
}
