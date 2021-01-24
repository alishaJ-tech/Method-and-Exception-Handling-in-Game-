using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string level; 

            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("You are welcome to the Guessing Game "+ name );
            Console.WriteLine("You can always select from the following Levels available : \r\n Level 1: EASY \r\n Level 2: INTERMEDIATE \r\n Level 3: HARD");

            Console.WriteLine("Now pick a level by typing either of the following : \r\n EASY \r\n INTERMEDIATE \r\n HARD");
            level = Console.ReadLine();

           if (level == "EASY")
            {
                Console.WriteLine("Welcome to level1 \r\nGuess a number between 1-10 \r\nYou have only 6 trials! \r\nSTART GUESSING NOW !!!!");
                try
                {
                    Gamer(6,1,10);
                }
                catch (FormatException e)
                {
                    
                    Console.WriteLine(e.Message);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine($"One of the provided strings is null!: {e.ToString()}");
                }
                
            }
            else if (level == "INTERMEDIATE")
            {
                Console.WriteLine("Welcome to level2 \r\nGuess a number between 1-20 \r\nYou have only 4 trials! \r\nSTART GUESSING NOW !!!!");
                try
                {
                    Gamer(4,1,20);
                }
                catch (FormatException e)
                {
                    
                    Console.WriteLine(e.Message);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine($"One of the provided strings is null!: {e.ToString()}");
                }
               
            }
            else if (level == "HARD")
            {
                Console.WriteLine("Welcome to level2 \r\nGuess a number between 1-50 \r\nYou have only trials! \r\nSTART GUESSING NOW !!!!");
                try
                {
                    Gamer(3,1,50);
                }
                catch (FormatException e)
                {
                    
                    Console.WriteLine(e.Message);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine($"One of the provided strings is null!: {e.ToString()}");
                }
               
            }
            else
            {
                level = "";
            }
          
        
        static void Gamer (int trials, int Min, int Max)
        {
            Random random = new Random();
            int guess = random.Next(Min, Max);
            int Trials = 1;
            Console.Write("Enter a guess: ");
            int Guess = int.Parse(Console.ReadLine());
            do 
            {
                if(Trials == trials)
                {
                    Console.WriteLine("Sorry you loose");
                    break;

                }
                if (Guess != guess)
                {
                    Console.Write("Sorry, wrong number , Try again: ");
                    Guess = int.Parse(Console.ReadLine());
                    Trials++;
                }
                if (Guess == guess)
                {
                    Console.WriteLine($"Hey, You won, The number was {guess}");
                    break;
                } 
            }
            while(Guess != guess);

        }

    }
    }
}