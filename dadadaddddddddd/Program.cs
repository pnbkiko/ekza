using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadadaddddddddd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double x=0;
            if (a > b)
            {
                x = a * b + 1;
            }
            else if (a == b)
            {
                x = 25;
            }
            else 
            {
                if (b != 0)
                {
                    x = (a - 5) / b;
                }
                else
                {
                    Console.WriteLine("Нельзя делить на ноль");
                }
            }
            Console.WriteLine($"Ответ:x = {x} ");
        }
    }
}
