using System;

namespace ConsoleSumOfMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new NumbersCalculation();
            cal.getListOfMultiples(3, 5);
            cal.sumNumbers();
            
            Console.WriteLine($"The sum of multiples of 3 and 5 below 1000 is: {cal.sumOfMultiples}");
        }
    }
}
