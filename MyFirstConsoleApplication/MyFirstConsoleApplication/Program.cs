using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // call for user name and location input
           GetUserNameAndLocation();

            // call Christmas Countdown function
            ChristmasCountdown();

            // call GlazerApp method
            GlazerApp.RunExample();

            // terminate program
            Console.WriteLine("Please enter any key to terminate program...");
            Console.ReadKey();
        }

        private static void GetUserNameAndLocation()
        {
            Person person = new Person();

            // get user input
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();

            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();

            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.ReadKey();
        }

        private static void ChristmasCountdown()
        {
            Console.WriteLine($"Today's date is: {DateTime.Today.ToString("MM/dd/yyyy")}");

            DateTime christmas = new DateTime(DateTime.Today.Year, 12, 25);
            double daysTillChristmas = christmas.Subtract(DateTime.Today).TotalDays;

            Console.WriteLine($"Number of days until Christmas: {daysTillChristmas}");

            // end program
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
