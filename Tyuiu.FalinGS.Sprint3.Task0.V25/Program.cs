using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint3.Task0.V25.Lib;

namespace Tyuiu.FalinGS.Sprint3.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #3 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №3                                                               #");
            Console.WriteLine("* Задание №0                                                              #");
            Console.WriteLine("* Вариант №25                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 14;


            Console.WriteLine("Переменная Х =" + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = "+ stopValue);


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Сумма ряда =  " + ds.GetSumSeries(value,startValue,stopValue));

            Console.ReadKey();
        }
    }
}
