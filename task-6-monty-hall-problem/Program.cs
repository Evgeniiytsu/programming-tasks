using System;

namespace task_6_monty_hall_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_TIMES = 500;
            const int NUMBER_OF_PLAYERS = 2;
            string [] players = {"Alice", "Bob"};
            for (int i = 0; i < NUMBER_OF_PLAYERS; i++) {
                int success = 0;
                for (int j = 0; j < NUMBER_OF_TIMES; j++) {
                    if (play(players[i])) success++;
                }
                double successPerc = Math.Round(Convert.ToDouble(success) / Convert.ToDouble(NUMBER_OF_TIMES) * 100, 2);
                Console.WriteLine("Успешность стратегии игрока " + players[i] + ": " + successPerc + "%");
            }
        }

        static bool play (string player) {
            Random rand = new Random();

            bool [] doors = {false, false, false};
            doors[rand.Next(3)] = true;
            // Console.WriteLine("Двери: " + doors[0].ToString() + ", " + doors[1].ToString() + ", " + doors[2].ToString());

            int playerChoice;
            if (player == "Alice" || player == "Bob") {
                playerChoice = 0;
            } else {
                Console.WriteLine("Неверное имя игрока");
                return false;
            }

            // Console.WriteLine("Выбор игрока:" + playerChoice.ToString());

            int possibleMontysChoice;
            if (doors[playerChoice]) {
                possibleMontysChoice = rand.Next(3);
                if (possibleMontysChoice == playerChoice) {
                    possibleMontysChoice = possibleMontysChoice == 2 ? 0 : possibleMontysChoice + 1;
                }
            } else {
                possibleMontysChoice = 0;
                while ((possibleMontysChoice == playerChoice || doors[possibleMontysChoice]) && possibleMontysChoice < 3) {
                    possibleMontysChoice++;
                }
            }
            if(possibleMontysChoice >= 3) {
                Console.WriteLine("Неизвестная ошибка при выборе Монти");
                return false;
            }
            int montysChoice = possibleMontysChoice;
            
            // Console.WriteLine("Выбор Monty:" + montysChoice.ToString());

            if (player == "Alice") {
                // Console.WriteLine("Выбор Alice:" + playerChoice.ToString());
                return doors[playerChoice];
            }else { // player == "Bob"
                int bobChoice = 0;
                while ((bobChoice == playerChoice || bobChoice == montysChoice) && bobChoice < 3) {
                    bobChoice++;
                }
                if(bobChoice >= 3) {
                    Console.WriteLine("Неизвестная ошибка при выборе Боба");
                    return false;
                }
            
                // Console.WriteLine("Выбор Bob:" + playerChoice.ToString());
                return doors[bobChoice];
            }
        }
    }
}
