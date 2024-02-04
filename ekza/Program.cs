using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekza
{
    class Program
    {
        static void Main(string[] args)
        {
            void el(double elecktric_mon, int gaz_ele,out double x)
            { 
                if (gaz_ele == 0)
                {
                    x = elecktric_mon * 2.5;
                }
                else
                {
                    x = elecktric_mon * 2;
                }
            }
            double ras = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 1 электрическая, введите 0 если газовая плита");
            int a = int.Parse(Console.ReadLine());
            el(ras, a, out double c);
            Console.WriteLine($"Ответ:сумма оплаты за месяц {c}");

        }
    }
}
