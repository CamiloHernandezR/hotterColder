using System;
using System.Collections.Generic;
using System.Text;

namespace hotterColder
{
    class BackControl
    {
        public int random { get; set; }
        public int lastGuess { get; set; }

        public BackControl(int random)
        {
            this.random = random;
        }
        public int OnlyNumbers()
        {

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    int num = Convert.ToInt32(input);
                    return num;
                }
                catch (Exception e)
                {
                   
                    Console.WriteLine("Please type a valid integer number");

                }
            }
        }
        public bool FirstGuess(int guess)
        {

            if (guess == random) { return true; }

            else if (guess <= (random + 10) && guess >= (random - 10))
            {
                Console.WriteLine("hot"); 
            }
            else
            {
                Console.WriteLine("Cold");                
            }
            lastGuess = guess;
            return false;
        }
        public int Difference(int num)
        {
           int dif = Math.Abs( num - random);
            return dif;
        }
        public bool Guess(int input)
        {
            if (input == random)
            {
                
                return true;
            }
            else if (Difference(input)<Difference(lastGuess))
            {
                Console.WriteLine("hotter");
            }
            else
            {
                Console.WriteLine("Colder");
            }
            lastGuess = input;
                return false;
        }
        
    }
}
