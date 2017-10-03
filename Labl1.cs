using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            double A, B, C, X1, X2;
            do
            {
                Console.Write("Введите коэффициент А: ");
                string str = Console.ReadLine();
                flag = double.TryParse(str, out A);
                if (flag)
                {
                    Console.WriteLine("Вы ввели число " + A.ToString("F5"));
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Повторите ввод");
                }
            } while (!flag);
            do
            {
                Console.Write("Введите коэффициент B: ");
                string str = Console.ReadLine();
                flag = double.TryParse(str, out B);
                if (flag)
                {
                    Console.WriteLine("Вы ввели число " + B.ToString("F5"));
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Повторите ввод.");
                }
            } while (!flag);
            do
            {
                Console.Write("Введите коэффициент С: ");
                string str = Console.ReadLine();
                flag = double.TryParse(str, out C);
                if (flag)
                {
                    Console.WriteLine("Вы ввели число " + C.ToString("F5"));
                }
                else
                {
                    Console.WriteLine("Вы ввели не число. Повторите ввод.");
                }
            } while (!flag);
            Console.WriteLine("Уравнение:  " + A + "x^2+" + B + "x+" + C + "=0");
            double D;
            D = B * B - 4 * A * C;
            if (A == 0 && B != 0 && C != 0)
            {
                X1 = -C / B;
                Console.WriteLine("Уравнение имеет один корень:" + X1);
            }
            else
            {
                if (D < 0 || (A == 0 && B == 0 && C != 0))
                {
                    Console.WriteLine("Уравнение не имеет корней.");
                }
                else
                {
                    if (A == 0 && B == 0 && C == 0)
                    {
                        Console.WriteLine("X-любое");
                    }
                    else
                    {
                        if (D == 0)
                        {
                            X1 = -B / (2 * A);
                            Console.WriteLine("Уравнение имеет один корень:" + X1);
                        }
                        if (D > 0)
                        {
                            X1 = (-B + Math.Sqrt(D)) / (2 * A);
                            X2 = (-B - Math.Sqrt(D)) / (2 * A);
                            Console.WriteLine("Уравнение имеет два корня:" + X1 + "   " + X2);
                        }
                    }
                }
            }
        }
    }
}