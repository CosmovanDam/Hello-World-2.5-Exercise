using System;

namespace Rectangle_Dimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for rectangle dimensions
            // and calculate the area
            Console.WriteLine("What is the length and " +
                "width of the rectangle in cm?");

            int length = Convert.ToInt32(
                Console.ReadLine());

            int width = Convert.ToInt32(
                Console.ReadLine());

            double area = (length * width);

            Console.WriteLine("The area of the rectangle " +
                "is " + area + "cm squared");
        }
    }
}
