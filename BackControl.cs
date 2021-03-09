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
        public bool firstGuess()
        {
            Console.WriteLine("Please make a guess");
            var input = Console.ReadLine();
            //validations process
            int guess = Convert.ToInt32(input);

            if (guess <= (random + 10) && guess >= (random - 10))
            {
                Console.WriteLine("hot");
                return true;
            }
            else
            {
                Console.WriteLine("Cold");
                return false;
            }
        }
        
    }
}
