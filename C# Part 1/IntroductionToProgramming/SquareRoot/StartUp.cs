namespace SquareRoot
{
    using System;
    
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please insert a number");

            string input = Console.ReadLine();
            int number = int.Parse(input);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
        }
    }
}
