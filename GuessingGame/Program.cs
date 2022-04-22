using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    //FOR REPETITION PURPOSES
                    //This will allow for the prompt to keep appearing until the word is guessed
                    Console.Write("Enter Word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.Write("You Win!");
            }

            //CHALLENGE: Code using a Do While loop instead

            Console.ReadLine();
        }
    }
}
