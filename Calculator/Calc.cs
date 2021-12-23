using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Difference(int x, int y)
        {
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        public static int Division(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            else
                return x / y;
        }
        public static int Square(int x)
        {
            if (x < 0)
                throw new ArgumentException("Корень из отрицательного числа не существует");
            else
                return (int)Math.Sqrt(x);
        }

    }
}
