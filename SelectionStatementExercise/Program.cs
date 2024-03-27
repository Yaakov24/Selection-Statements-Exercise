using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNum = 752;
            Console.WriteLine("What is your favorite number?");
            var input = int.Parse(Console.ReadLine());
            if (input == favNum)
            {
                Console.WriteLine("You got it!");
            }
            else if (input > favNum)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too low!");
            }

        }    
    }
};
