using System;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите функцию");
            Console.WriteLine("1. Сумма");
            Console.WriteLine("2. Разница");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Квадратный корень");
            int variant;
            CheckToInt(Console.ReadLine(), out variant);
            int a;
            int b;
            switch (variant)
            {
                case 1:
                    Console.WriteLine("Введите первое число");
                    CheckToInt(Console.ReadLine(), out a);
                    Console.WriteLine("Введите второе число");
                    CheckToInt(Console.ReadLine(), out b);
                    Calc.Sum(a, b);
                    break;
                case 2:
                    Console.WriteLine("Введите первое число");
                    CheckToInt(Console.ReadLine(), out a);
                    Console.WriteLine("Введите второе число");
                    CheckToInt(Console.ReadLine(), out b);
                    Calc.Difference(a, b);
                    break;
                case 3:
                    Console.WriteLine("Введите первое число");
                    CheckToInt(Console.ReadLine(), out a);
                    Console.WriteLine("Введите второе число");
                    CheckToInt(Console.ReadLine(), out b);
                    Calc.Multiplication(a, b);
                    break;
                case 4:
                    Console.WriteLine("Введите первое число");
                    CheckToInt(Console.ReadLine(), out a);
                    Console.WriteLine("Введите второе число");
                    CheckToInt(Console.ReadLine(), out b);
                    Calc.Division(a, b);
                    break;
                case 5:
                    Console.WriteLine("Введите число");
                    CheckToInt(Console.ReadLine(),out a);
                    Calc.Square(a);
                    break;
            }
        }
       
        public static void CheckToInt(string str, out int a)
        {
            if (!int.TryParse(Console.ReadLine(), out  a))
                throw new ArgumentException("Это не число");
            
        }

    }
}
