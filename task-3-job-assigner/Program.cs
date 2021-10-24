using System;
using System.Collections.Generic;

namespace task_3_job_assigner
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 4;
            int[,] prices = {
                { 9, 2, 7, 8 },
                { 6, 4, 3, 7 },
                { 5, 8, 1, 8 },
                { 7, 6, 9, 4 }};
            bestCombination = new int [] {-1, -1, -1, -1};

            Console.WriteLine("Минимальная сумма: " + getSumm(prices, new int [] {-1, -1, -1, -1}, N));

            char [] letters = {'A', 'B', 'C', 'D'};
            for (int i = 0; i < bestCombination.Length; i++) {
                Console.WriteLine("Компания " + letters[i] + " получает задачу #" + (bestCombination[i] + 1) + " по цене " + prices[i, bestCombination[i]]);
            }
        }

        static int[] bestCombination;
        static int globalMinSum = int.MaxValue;

        static int getSumm(int[,] prices, int[] blocked, int N, int level = 0, int sum = 0) {
            int minSum = int.MaxValue;
            for (int i = 0; i < N; i++) {
                bool blockedI = Array.Exists(blocked, el => {
                    return el == i;
                });
                if (blockedI) continue;

                int thisPrice = prices[level, i];
                blocked[level] = i;

                int newSum;
                if (level != N - 1) {
                    newSum = getSumm(prices, blocked, N, level + 1, thisPrice + sum);
                } else {
                    newSum = thisPrice + sum;  

                    // Без этого блока можно реилизовать полноценное рекурсивное дерево
                    // Но без ООП легче сделать так
                    if (globalMinSum > newSum) {
                        Array.Copy(blocked, bestCombination, N);
                        globalMinSum = newSum;
                    } 
                }
                
                if (newSum < minSum) minSum = newSum;
            }
            blocked[level] = -1;
            return minSum;
        }
    }
}
