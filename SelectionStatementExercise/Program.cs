using System.Runtime.ExceptionServices;
using System.Text.Json.Nodes;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Number Guessing Game
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            int UserInput;
            var counter = 0;

            do
            {

                Console.WriteLine("Pick a number 1-1000");
                UserInput = int.Parse(Console.ReadLine());

                if (UserInput < favNumber)
                {
                    Console.WriteLine($"{UserInput} is too low");
                }
                else if (UserInput > favNumber)
                {
                    Console.WriteLine($"{UserInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                counter++;

                Console.WriteLine($"You have guessed {counter} times");

            } while (UserInput != favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                case "gym":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("PE is the best!");
                    break;
                case "history":
                    Console.WriteLine("History is fun!");
                    break;
                case "english":
                    Console.WriteLine("English is boring");
                    break;
                    default:
                    Console.WriteLine("I dont know that subject.");
                    break;
            }
        }
    }
}
