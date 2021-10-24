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
                        Console.WriteLine(a + b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "**":
                        Console.WriteLine(Math.Pow(a, b));
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "/":
                        if (b == 0) {
                            Console.WriteLine("Бесконечность");
                            continue;
                        } 
                        Console.WriteLine(a / b);
                        break;
                    default: 
                        Console.WriteLine("Неверный оператор");

                }
                Console.Write("============");
            }
        }
    }
}
