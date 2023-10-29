using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint3.Task6.V14.Lib;

namespace Tyuiu.FalinGS.Sprint3.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №3                                                               #");
            Console.WriteLine("* Задание №6                                                              #");
            Console.WriteLine("* Вариант №14                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            DataService ds = new DataService();


            int startValue = 7;
            int stopValue = 16;



            Console.WriteLine("Start otrezok = " + startValue);
            Console.WriteLine("Stop otrezok = " + stopValue);


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Summ deliteley =  " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
