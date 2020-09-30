using System;
using Circle;

namespace Chapter_2_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");

            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            double areaOfCircle = Math.Round((pi * Math.Pow(radius, 2)), 3);

            double circumferenceOfCircle = Math.Round((2 * pi * radius), 3);

            double diameterOfCircle = radius * 2;

            Console.WriteLine($"The area of a circle with radius {radius} is: {areaOfCircle}; \n" +
                $"The circumference is: {circumferenceOfCircle}; \n" +
                $"The diameter is: {diameterOfCircle}.");

            Console.WriteLine("How many miles per gallon do you get?");

            double milesPerGallon = 1 / double.Parse(Console.ReadLine());

            double gallonsUsed = Math.Round((milesPerGallon * radius), 2);

            Console.WriteLine($"It would take {gallonsUsed} gallons of gas to go around this circle.");

        }
    }
}
