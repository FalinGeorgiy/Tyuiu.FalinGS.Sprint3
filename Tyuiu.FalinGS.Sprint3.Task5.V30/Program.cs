using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint3.Task5.V30.Lib;

namespace Tyuiu.FalinGS.Sprint3.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №3                                                               #");
            Console.WriteLine("* Задание №5                                                              #");
            Console.WriteLine("* Вариант №30                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;


            Console.WriteLine("Старт шага 1 Summ  = " + startValue1);
            Console.WriteLine("Конец шага 1 Summ = " + stopValue1);
            Console.WriteLine("Старт шага 2 Summ  = " + startValue2);
            Console.WriteLine("Конец шага 2 Summ = " + stopValue2);


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Сумма ряда =  " + ds.GetSumSumSeries(x, startValue1,stopValue1,startValue2,stopValue2));

            Console.ReadKey();
        }
    }
}
