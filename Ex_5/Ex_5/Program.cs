using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x == 1)
            {
                Console.Write("Введите номер месяца. Для выхода наберите \"Выход\": ");
                string now = Console.ReadLine();
                if (now == "Выход")
                {
                    break;
                }
                int a = Int32.Parse(now);
                Month(a);
                float c = MiddleTemp();
                if (c > 0 && (a == 12 || a == 1 || a == 2))
                {
                    Console.WriteLine("Дождливая зима!");
                }
            }
        }
        static float MiddleTemp()
        {
            float a, b, c;
            string max, min;
            Console.Write("Введите максимальную температуру за сутки Max = ");
            max = Console.ReadLine();
            a = float.Parse(max);
            Console.Write("Введите минимальную температуру за сутки Min = ");
            min = Console.ReadLine();
            b = float.Parse(min);
            c = (float)Math.Round((a + b) / 2, 1);
            Console.WriteLine("Средняя температура за сутки = {0} градусов", c);
            return c;
        }
        static void Month(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Неверно указан номер месяца");
                    break;
            }
        }
    }
}
