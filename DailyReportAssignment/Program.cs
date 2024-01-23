using System;

namespace DailyReportAssignment
{
    class Program
    {
        private const bool Yes = true;
        private const bool No = false;


        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name? Please write your first and last name:");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page number?");
            Console.ReadLine();



            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
        }
    }
}