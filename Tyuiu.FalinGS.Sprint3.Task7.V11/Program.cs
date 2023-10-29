using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint3.Task7.V11.Lib;

namespace Tyuiu.FalinGS.Sprint3.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №3                                                               #");
            Console.WriteLine("* Задание №7                                                              #");
            Console.WriteLine("* Вариант №11                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            DataService ds = new DataService();


            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);



            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");


            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|    X      |     F(X)  |");
            Console.WriteLine("+-----------+-----------+");

            for ( int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1, 5:f2}    |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+-----------+-----------+");


            Console.ReadKey();
        }
    }
}
