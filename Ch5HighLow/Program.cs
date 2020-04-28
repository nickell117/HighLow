using System;

namespace Ch5HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 100);

            int guess;

            do
            {
                Console.Write("Try and guess the number: ");
                guess = int.Parse(Console.ReadLine());

                if(guess > randomNumber)
                {
                    Console.WriteLine("Thats too High!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Thats too Low!");
                }
            } while (guess != randomNumber);


            Console.WriteLine("You guessed it!!");
        }
    }
    
}
