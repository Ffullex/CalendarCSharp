using System;
namespace Calendar
{
    public class Calendar
    {
        public DateTime actualTime = DateTime.Now;

        public void DateShift(TimeSpan timeSpan)
        {
            actualTime += timeSpan;
        }

        public void ConsoleCalendar()
        {
            DateTime weekDay;
            bool firstIteration = true;

            Console.WriteLine($"{actualTime.ToString("MMMMMMMM yyy")}\nПн\tВт\tСр\tЧт\tПт\tСб\tВс");

            for (int day = 1; day <= DateTime.DaysInMonth(actualTime.Year, actualTime.Month); ++day)
            {
                weekDay = new DateTime(actualTime.Year, actualTime.Month, day);

                if (firstIteration)
                {
                    if (weekDay.DayOfWeek == DayOfWeek.Sunday)
                    {
                        for (int firstDay = 5; firstDay >= 0; --firstDay)
                        {
                            Console.Write("\t");
                        }
                    }
                    else
                    {
                        for (int firstDay = (int)weekDay.DayOfWeek - 1; firstDay > 0; --firstDay)
                        {
                            Console.Write("\t");
                        }
                    }
                    firstIteration = false;
                }
                /*
                 * Описатель для полного названия месяца MMMM
                 * 
                 */

                {
                    if (weekDay.Day == actualTime.Day)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write((int)weekDay.Day + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write((int)weekDay.Day + "\t");
                    }


                    if (weekDay.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}