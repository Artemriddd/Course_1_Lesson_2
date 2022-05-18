using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            string max, min;
            Console.Write("Введите максимальную температуру за сутки Max = ");
            max = Console.ReadLine();
            a = float.Parse(max);
            Console.Write("Введите минимальную температуру за сутки Min = ");
            min = Console.ReadLine();
            b = float.Parse(min);
            c = (float)Math.Round((a + b)/2, 1);
            Console.WriteLine("Средняя температура за сутки = {0} градусов", c);
            Console.ReadKey();
        }
    }
}
