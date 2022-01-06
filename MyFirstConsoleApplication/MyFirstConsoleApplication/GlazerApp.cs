using System;
namespace MyFirstConsoleApplication
{
    public class GlazerApp
    {
        

        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;


            Console.WriteLine("Enter a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            // calculations
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            // output
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
