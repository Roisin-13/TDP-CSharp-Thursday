using System;

namespace DateTimeExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read a date in from the console and store it in a variable
            //Using the date from q1, strip out the `00:00:00` time portion from the DateTime
            //object and print it out to the console
            //3.Use the DateTime object to find what day of the week it would be 5 years from now

            Console.WriteLine("Please enter date:");
            string dateInput = Console.ReadLine();
            DateTime consoleDT = DateTime.Parse(dateInput);
            Console.WriteLine(consoleDT);

            Console.WriteLine(consoleDT.ToShortDateString());

            DateTime dateNow = DateTime.Now;

            DateTime date5 = dateNow.AddYears(5);

            Console.WriteLine($"Today is {dateNow}, {dateNow.DayOfWeek}, 5 years from is  {date5}, {date5.DayOfWeek}");
        }
    }
}
