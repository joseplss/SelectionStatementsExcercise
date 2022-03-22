using System;

namespace SelectionStatementsE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------START EXCERCISE 1--------------------*/
            Console.WriteLine("Hello user! Guess my favorite number! Must be from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            if (userInput < favNumber)
            {
                Console.WriteLine("Your guess is too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else
            {
                Console.WriteLine("Nevermind...");
            }
            /*--------------------END EXCERCISE 1--------------------*/
            Console.WriteLine("\nEnter any key to continue...");
            Console.ReadLine();
            Console.Clear();
            /*--------------------START EXCERCISE 2--------------------*/
            Console.WriteLine("Hey user! What is your favorite school subject?");
            string favSub = Console.ReadLine();
            switch (favSub.ToLower())
            {
                case "math":
                    Console.WriteLine("Hey, that'll help you a lot in coding!");
                    break;

                case "science":
                    Console.WriteLine("Did you ever see that one guy in class when you were in school? His name was Billy Nye The Science Guy");
                    break;

                case "english":
                    Console.WriteLine("To be or not to be? that is the question...");
                    break;

                case "history":
                    Console.WriteLine("Goodluck trying to remember all of that!");
                    break;

                case "art":
                    Console.WriteLine("Do you think i'll become the next Picasso?");
                    break;

                case "economy":
                    Console.WriteLine("Money money money money!");
                    break;

                default:
                    Console.WriteLine("Hmm... I am not sure that I know that subject...");
                    break;
            }
            /*--------------------END EXCERCISE 2--------------------*/
        }
    }
}
