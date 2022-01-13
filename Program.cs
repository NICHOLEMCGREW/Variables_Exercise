using System;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Keeper";
            int dogAge = 1;
            char dogRating = 'A';
            bool isExcited = true;
            double price = 529.72;
            decimal discountPrice = 500.50m;

            Console.WriteLine($"My dogs name is {dogName}, and she is {dogAge} years old.");
            Console.WriteLine($"{dogName} is an {dogRating} rated dog that originally cost {price}, but was on sale for {discountPrice}.");
            Console.WriteLine($"Am I excited? I'd say yes, that is {isExcited}!");
        }
    }
}
