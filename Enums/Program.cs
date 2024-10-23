namespace Enums
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Monday;
            Console.WriteLine($"Today is {today}"); // Output: Today is Monday

            if (today == DayOfWeek.Monday)
            {
                Console.WriteLine("Start of the workweek!");
            }


            today = DayOfWeek.Tuesday;
            int dayValue = (int)today;
            Console.WriteLine(dayValue);

            dayValue = 4;
            DayOfWeek day = (DayOfWeek)dayValue;
            Console.WriteLine(day);

            int invalidDayValue = 10;
            DayOfWeek invalidDay = (DayOfWeek)invalidDayValue;
            Console.WriteLine(invalidDay);

            int directionValue = 5; // Invalid value

            if (Enum.IsDefined(typeof(Direction), directionValue))
            {
                Direction dir = (Direction)directionValue;
                Console.WriteLine($"Valid direction: {dir}");
            }
            else
            {
                Console.WriteLine("Invalid direction value.");
            }

            today = DayOfWeek.Wednesday;
            if (today > DayOfWeek.Monday)
            {
                Console.WriteLine("The week is progressing.");  // Output: The week is progressing.
            }

            foreach (DayOfWeek weekday in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(weekday);
            }

            today = DayOfWeek.Friday;
            string dayString = today.ToString();
            Console.WriteLine(dayString);  // Output: Friday

            string input = "Sunday";
            day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);
            Console.WriteLine(day);  // Output: Sunday

            input = "Holiday";  // Invalid value
            DayOfWeek wday;
            if (Enum.TryParse(input, out wday))
            {
                Console.WriteLine(wday);
            }
            else
            {
                Console.WriteLine("Invalid enum value");  // Output: Invalid enum value
            }

        }
    }
}
