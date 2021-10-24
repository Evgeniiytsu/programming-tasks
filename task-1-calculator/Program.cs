using System;

namespace task_1_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите операцию: ");
                string operatop = Console.ReadLine();
                Console.Write("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Ваш резуьтат: ");
                switch(operatop) {
                    case "+":
                        Add(a, b);
                        break;
                    case "*":
                        Multiply(a, b);
                        break;
                    case "**":
                        Power(a, b);
                        break;
                    case "-":
                        Subtract(a, b);
                        break;
                    case "/":
                        Divide(a, b);
                        break;
                    default: 
                        Console.WriteLine("Неверный оператор");
                        break;
                }
                Console.WriteLine("============");
            }
        }

        static double Add(double x, double y) { 
            return x + y;
        }

        static double Subtract(double x, double y) { 
            return x - y;
        }

        static double Multiply(double x, double y) {
            return x * y;
        }

        static double Divide(double x, double y) {
            if (y == 0) {
                Console.Write("Ошибка! Деление на ноль! ");
                return Double.MaxValue;
            }
            return x / y;
        }
        static double Power(double x, double power) {
            return Math.Pow(x, power);
        }
    }
}
