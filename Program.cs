using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("please Enter a NUM");
            string number = Console.ReadLine();
            num = int.Parse(number);
            num *= 3;
            Console.WriteLine(num);
            Console.ReadKey();


        }
    }
}
;