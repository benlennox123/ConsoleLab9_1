using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab9_1
{
    class Lab9_1
    {
        static void Main(string[] args)
        {
            int count = 1;
            double A = input(count);
            count = 2;
            double B = input(count);
            int ch = choice();
            double Result = 0;
            switch (ch)
            {
                case 1:
                    Result = CalcSum(A, B);
                    break;
                case 2:
                    Result = CalcSub(A, B);
                    break;
                case 3:
                    Result = CalcMul(A, B);
                    break;
                case 4:
                    Result = CalcSep(A, B);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Результат = {0}", Result);
            Console.ReadKey();
        }

        static double input(double count)
        {
            double N = 0;
            Console.Write("Введите {0}-е целое число: ", count);
            try
            {
                N = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                N = input(count);
            }
            return N;
        }

        static int choice()
        {
            int CH = 0;
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            Console.Write("Сделайте выбор:");
            try
            {
                CH = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                CH=choice();
            }
            if (CH < 1 || CH > 4)
            {
                Console.WriteLine("Выберите от 1 до 4");
                CH=choice();
            }
            return CH;
        }

        static double CalcSum(double A, double B)
        {
            double C = A + B;
            return C;
        }

        static double CalcSub(double A, double B)
        {
            double C = A - B;
            return C;
        }

        static double CalcMul(double A, double B)
        {
            double C = A * B;
            return C;
        }

        static double CalcSep(double A, double B)
        {
            double C = 0;
            try
            {
                C = A / B;
            }
            catch
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            return C;
        }
    }
}
