using System;
using System.Collections.Generic;

namespace Calendar.HappyNewYearTheme
{

    class Program
    {
        static void Main()
        {
            Calendar calendar = new Calendar();
            calendar.ConsoleCalendar();



            List<TimeSpan> timeSpans = new List<TimeSpan>
            {
                new TimeSpan(6, 7, 2, 3),
                new TimeSpan(8, 5, 6, 9)

            };

            foreach (TimeSpan time in timeSpans)
            {
                Console.WriteLine("\n");
                calendar.DateShift(time);
                calendar.ConsoleCalendar();

                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}