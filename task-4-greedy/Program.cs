using System;
using System.Collections.Generic;

namespace task_4_greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] map = {5, 6, 16, 23, 24, 26, 32, 35, 43, 44};
            int m = 10;
            
            List <int> ourPlan = new List<int>();
            int weCanGoTo = m;
            int wePassed = 0;

            for (int i = 0; i < map.Length; i++) {
                wePassed = map[i];
                if (weCanGoTo < wePassed) {
                    ourPlan.Add(i - 1);
                    weCanGoTo = map[i - 1] + m;
                }
            }

            Console.Write("Нам нужно сделать {0} остановок на: ", ourPlan.Count);
            for (int i = 0, j = 0; i < map.Length; i++) {
                Console.Write("\n" + map[i]);
                if (j < ourPlan.Count && i == ourPlan[j]) {
                    Console.Write(" <-");
                    j++;
                }
            }
        }
    }
}

// В бензобак вмещается топлива ровно на m километров.
// У вас есть карта, на которой отмечены бензоколонки вдоль маршрута, и вы знаете, что i-тая бензоколонка находится на k километре от Москвы. К счастью, расстояние между бензоколонками не превышает m.
// Сделайте наименьшее количество дозаправок и определите, на каких бензоколонках это нужно сделать.
