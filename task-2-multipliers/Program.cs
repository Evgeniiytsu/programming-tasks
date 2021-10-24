using System;

namespace task_2_multipliers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 3;
            const int LIMIT = 10000000;

            int [] nums = new int[SIZE];
            int min = int.MaxValue;
            int max = 0;
            for (int i = 0; i < SIZE; i++) {
                Console.Write("Введите число №" + (i+1).ToString() + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) {
                    Console.WriteLine("Ошибка! Принимаем только положительные числа!");
                    i--;
                    continue;
                }
                if (num < min) min = num;
                if (num > max) max = num;
                nums[i] = num;
            }

            if (min == 0) {
                Console.Write("НОД:0, НОК: 0");
            }

            int NOD = 0;
            for (int possibleNOD = min; possibleNOD > 0; possibleNOD--) {
                bool isOk = false;
                for (int i = 0; i < SIZE; i++) {
                    if (nums[i] % possibleNOD != 0) break;
                    if (i == SIZE - 1) isOk = true;
                }
                if (isOk) {
                    NOD = possibleNOD;
                    break;
                } 
            }
            Console.WriteLine("НОД: " + NOD.ToString());

            int NOK = 0;
            for (int possibleNOK = max; possibleNOK < LIMIT; possibleNOK += max) {
                bool isOk = false;
                for (int i = 0; i < SIZE; i++) {
                    if (possibleNOK % nums[i] != 0) break;
                    if (i == SIZE - 1) isOk = true;
                }
                if (isOk) {
                    NOK = possibleNOK;
                    break;
                }
            }
            if (NOK == 0) {
                Console.WriteLine("НОК более " + LIMIT.ToString() + "! Для безопасности программа остановлена");
                return;
            } else {
                Console.WriteLine("НОК: " + NOK.ToString());
            }
        }
    }
}
