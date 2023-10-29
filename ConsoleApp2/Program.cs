using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "12rt ojt c45";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {

                    str = str.Replace(c, '¡');
                }
            }
                Console.WriteLine(str);


                Console.ReadKey();


        }
            
        
    }
}
