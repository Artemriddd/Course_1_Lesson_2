using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число. Для завершения наберите \"Выход\"");
            int exit = 0;
            while (exit == 0)
            {
                string num = Console.ReadLine();
                if (num == "Выход")
                {
                    break;
                }    
                int number = Int32.Parse(num);
                evenNumber(number);
            }
        }
        static void evenNumber(int a)
        {
            if (a % 2 != 0)
            {
                Console.WriteLine("Число нечетное!");
            }
            else
            {
                Console.WriteLine("Число четное!");
            }
        }
    }
}
