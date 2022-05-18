using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 100;
            int c = 150;
            int d = 25;
            int cash = 1000;
            int summa = a + b + c + d;
            string name = "========Чек=======";
            string adress = "г.Москва ул.Тверская 1";
            string place = "ТЦ Вегас Сити Молл";
            Console.WriteLine("{0}\n{1}\n{2}",name, adress,place);
            Console.WriteLine("-------------------");
            Console.WriteLine("Чизбургер = {0} руб.", a);
            Console.WriteLine("-------------------");
            Console.WriteLine("Картошка фри = {0} руб.", b);
            Console.WriteLine("-------------------");
            Console.WriteLine("Наггетсы 9 = {0}", c);
            Console.WriteLine("-------------------");
            Console.WriteLine("Соус сырный = {0}", d);
            Console.WriteLine("-------------------");
            Console.WriteLine("ИТОГ: {0}",summa);
            Console.WriteLine("-------------------");
            Console.WriteLine("Сумма НДС: {0}", 0.2*summa);
            Console.WriteLine("-------------------");
            Console.WriteLine("Наличные: {0}", cash);
            Console.WriteLine("-------------------");
            Console.WriteLine("Cдача: {0}", cash-summa);
            Console.WriteLine("-------------------");
            Console.WriteLine("==СПАСИБО ЗА ПОКУПКУ!==");
            Console.ReadKey();
        }
    }
}
