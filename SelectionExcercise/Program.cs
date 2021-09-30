using System;

namespace SelectionExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.Write("Enter the favourite number: ");
            var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (favNumber > 1)
            {
                Console.WriteLine("Your enter number is too low");
                Console.WriteLine();
             }
            else if(favNumber < 1000)
            {
                Console.WriteLine("Your enter number is too high");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
