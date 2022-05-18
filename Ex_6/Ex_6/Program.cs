using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    class Program
    {
        [Flags]
        enum Week
        {
            Monday = 1,
            Tueshday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
        static void Main(string[] args)
        {
            Week workOffice1 = Week.Monday | Week.Tueshday | Week.Wednesday | Week.Thursday | Week.Friday;
            Week workOffice2 = Week.Saturday | Week.Sunday;
            int i = 0;
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            Console.WriteLine("=====Расписание офиса 1=====");
            foreach (Week week in Enum.GetValues(typeof(Week)))
            {
                bool b = workOffice1.HasFlag(week);
                if (b == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - Рабочий день!", days[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} - Выходной", days[i]);
                    Console.ResetColor();
                }
                i++;
            }
            i = 0;
            Console.WriteLine("\n=====Расписание офиса 2=====");
            foreach (Week week in Enum.GetValues(typeof(Week)))
            {
                bool b = workOffice2.HasFlag(week);
                if (b == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - Рабочий день!", days[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} - Выходной", days[i]);
                    Console.ResetColor();
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
