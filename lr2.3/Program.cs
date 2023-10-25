using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool error = true;//aboba
            while (error)//asfsdafsd.,fms.a,mfd.as,mf
            {
                Console.WriteLine("введите число от 1 до 4");
                double m = double.Parse(Console.ReadLine());//qweqwrqrasd
                switch (m)
                {
                    case 1:
                        Console.WriteLine("пики");
                        error = false;
                        break;
                    case 2:
                        Console.WriteLine("трефы");
                        error = false;
                        break;
                    case 3:
                        Console.WriteLine("бубны");
                        error = false;
                        break;
                    case 4:
                        Console.WriteLine("червы");
                        error = false;
                        break;
                    default:
                        Console.WriteLine("ошибка, число находиться за пределами диапозона");
                        break;
                }
            }
        }
    }
}
