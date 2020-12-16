using System;

namespace Gas_Mileage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the number of miles they
            // have driven and the amount of gas they've
            // consumed
            Console.WriteLine("How many miles have you " +
                "driven?");

            int milesdriven = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("and how many gallons of gas " +
                "has your car used?");

            int gallonsused = Convert.ToInt32(
                Console.ReadLine());

            double mpg = (milesdriven / gallonsused);

            Console.WriteLine("Your car has a mileage of " +
                mpg + "mpg."); 
        }
    }
}
