using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daddaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = 0;
            double a = 4;
            double b = 5;
            
            for (int i = 1; i <= n; i++)
            {
                x += (a) / (b + (b + 2));
                a += 2;
                b += 5;

            }
            Console.WriteLine($"Ответ:{x:f6}");
        }
    }
}
