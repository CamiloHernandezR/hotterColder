using System;

namespace hotterColder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            BackControl mistery = new BackControl(ran.Next(0, 101));
            Console.WriteLine("random number has been chosen {0}",mistery.random);
            while (!mistery.firstGuess());
            Console.ReadKey();


        }
    }
}
