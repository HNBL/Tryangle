using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tryangle
{




    public class Square
    {


        public static void Tryangle(int side)
        {

            double P = side * 3;//значение периметра
            double Side;
            Side = P / 3; //Значение строны
            

            double p2 = P / 2 - Side;//Полупериметр
            double pow = Math.Pow(p2, 3);// возведения в куб по формуле Герона
            double s = pow * P / 2;
            double S = Math.Sqrt(s);//корень крвадратный по формуле герона

            Console.WriteLine("Сторона   Площадь\n {0: 0.00}   {1: 0.00}", Side, S);

            
        }

        public static void Tryangle(double a,double b, double c) 
        {

            if (Square.TryangleExit(a,b,c))
            {


                double p = (a + b + c) / 2; ///значенее полупериметра

                double p2 = p * (p - a) * (p - b) * (p - c);
                double S = Math.Sqrt(p2);
                Console.WriteLine("Сторона А, Сторона Б, Сторона С  Площадь\n {0: 0.00}      {1: 0.00}     {2: 0.00}    {3: 0.00}", a, b, c, S);

            }
            else
            {
                Console.WriteLine("Треугольник не существует, повторите ввод значений");

            }

        }

        private static bool TryangleExit(double a, double b, double c)
        {

            if (a > 0 && b > 0 && c > 0)
            {
                return true;
            }

            else return false;
        }

    }

}

