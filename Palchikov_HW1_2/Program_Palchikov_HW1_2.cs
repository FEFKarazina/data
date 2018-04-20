using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palchikov_HW1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1,x2,d;
            
            Console.WriteLine("Задайте квадратное уравнение вида: ax^2 + bx + c = 0");
            Console.WriteLine("Введите значение a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            double c = Convert.ToDouble(Console.ReadLine());

            d = (b * b) - (4 * a * c);
                        
            if (d<0)
            {
                Console.WriteLine("Корней нет, дискриминант отрицателен!");
            }
            else
            {
                double d1 = Math.Sqrt(d);
                x1 = (-b + d1) / (2 * a);
                x2 = (-b - d1) / (2 * a);
                Console.WriteLine("Корни уравнения");
                Console.WriteLine("x1");
                Console.WriteLine(x1);
                Console.WriteLine("x2");
                Console.WriteLine(x2);
            }
            

        }
    }
}
