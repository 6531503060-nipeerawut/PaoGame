using System;
using System.Threading;
namespace PaoYingChoop_Game
{
    class Program
    {
        public static void Main(string[] args)//1
        {
            int mode;
            Console.WriteLine(@"
              _____                       __     __  _                        _____   _                             
             |  __ \                      \ \   / / (_)                      / ____| | |                            
             | |__) |   __ _    ___        \ \_/ /   _   _ __     __ _      | |      | |__     ___     ___    _ __  
             |  ___/   / _` |  / _ \        \   /   | | | '_ \   / _` |     | |      | '_ \   / _ \   / _ \  | '_ \ 
             | |      | (_| | | (_) |        | |    | | | | | | | (_| |     | |____  | | | | | (_) | | (_) | | |_) |
             |_|       \__,_|  \___/         |_|    |_| |_| |_|  \__, |      \_____| |_| |_|  \___/   \___/  | .__/ 
                                                                  __/ |                                      | |    
                                                                 |___/                                       |_|    
            ");
        flag1:
            Console.WriteLine("Please Enter the mode below ");
            Console.WriteLine("1) Single Player || 2) Multiplayer");

            mode = Int16.Parse(Console.ReadLine());

            switch (mode)
            {
                case 1:
                    Console.WriteLine("User has select Single Player Mode. ");
                    Console.Write("Wait for 3 seconds");
                    for (int x = 0; x <= 3; x++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);

                    }
                    Thread.Sleep(3000);
                    Console.Clear();
                    SinglePlayer();//2
                    break;
                case 2:
                    Console.WriteLine("User has select Multiplayer Mode. ");
                    Console.Write("Wait for 3 seconds");
                    for (int x = 0; x <= 3; x++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);

                    }
                    Thread.Sleep(3000);
                    Console.Clear();
                    MultiPlayer();//6
                    break;
                default:
                    Console.WriteLine("Please (enter) only 1 / 2");
                    goto flag1;
            }
        }
        private static void CountDownToGame()
        {
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }


        }

        private static void SinglePlayer()//3
        {
            string BotAction = Bot();//4
            string UserAction;
            string[] Sign = { "r", "p", "s" };
            Console.WriteLine(@"
             ____  _  _      _____ _     _____ ____  _     ____ ___  _ _____ ____              _      ____  ____  _____
            / ___\/ \/ \  /|/  __// \   /  __//  __\/ \   /  _ \\  \///  __//  __\            / \__/|/  _ \/  _ \/  __/
            |    \| || |\ ||| |  _| |   |  \  |  \/|| |   | / \| \  / |  \  |  \/|            | |\/||| / \|| | \||  \  
            \___ || || | \||| |_//| |_/\|  /_ |  __/| |_/\| |-|| / /  |  /_ |    /            | |  ||| \_/|| |_/||  /_ 
            \____/\_/\_/  \|\____\\____/\____\\_/   \____/\_/ \|/_/   \____\\_/\_\            \_/  \|\____/\____/\____\
                                                                                                           
            ");

            //Asking for Username
            Console.Write("Username: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Select your Action below");
            Console.WriteLine("p = paper");
            Console.WriteLine("r = rock");
            Console.WriteLine("s = scissors");
            Console.Write("UserAction: ");
            UserAction = Console.ReadLine();
            Console.Write("Bot: {0}", BotAction);
            Console.WriteLine();
            if (UserAction == "p" && BotAction == "p")
            {
                //Draw
                Console.WriteLine("Draw");
            }
            else if (UserAction == "p" && BotAction == "r")
            {
                //P Win
                Console.WriteLine("Player Win");
            }
            else if (UserAction == "p" && BotAction == "s")
            {
                //B Win
                Console.WriteLine("Bot Win");
            }
            else if (UserAction == "r" && BotAction == "r")
            {
                //Draw
                Console.WriteLine("Draw");
            }
            else if (UserAction == "r" && BotAction == "p")
            {
                //B Win
                Console.WriteLine("Bot Win");
            }
            else if (UserAction == "r" && BotAction == "s")
            {
                //P Win
                Console.WriteLine("Player Win");
            }
            else if (UserAction == "s" && BotAction == "s")
            {
                //Draw
                Console.WriteLine("Draw");
            }
            else if (UserAction == "s" && BotAction == "r")
            {
                //B Win
                Console.WriteLine("Bot Win");
            }
            else if (UserAction == "s" && BotAction == "p")
            {
                //P Win
                Console.WriteLine("Player Win");
            }

        }
        private static string Bot()//5
        {
            string[] Sign = { "r", "p", "s" };
            Random rnd = new Random();
            string Action = Sign[rnd.Next(0, 3)];
            return Action;

        }

        private static void MultiPlayer()//7
        {
            Console.WriteLine(@"
             _      _     _     _____  _  ____  _     ____ ___  _ _____ ____              _      ____  ____  _____
            / \__/|/ \ /\/ \   /__ __\/ \/  __\/ \   /  _ \\  \///  __//  __\            / \__/|/  _ \/  _ \/  __/
            | |\/||| | ||| |     / \  | ||  \/|| |   | / \| \  / |  \  |  \/|            | |\/||| / \|| | \||  \  
            | |  ||| \_/|| |_/\  | |  | ||  __/| |_/\| |-|| / /  |  /_ |    /            | |  ||| \_/|| |_/||  /_ 
            \_/  \|\____/\____/  \_/  \_/\_/   \____/\_/ \|/_/   \____\\_/\_\            \_/  \|\____/\____/\____\
                                                                                                      
            ");
            string[] Player1 = new string[3]; //{0,1,2} {"r","p","p"}
            string[] Player2 = new string[3]; //{0,1,2} {"p","s","r"}
            int round = 0;
            int count = 0;
            int P1Score = 0;
            int P2Score = 0;
            do
            {
                Console.WriteLine("Please Select your Action below");
                Console.WriteLine("p = paper");
                Console.WriteLine("r = rock");
                Console.WriteLine("s = scissors");
                Console.Write("Player1: ");
                string ActionP1 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please Select your Action below");
                Console.WriteLine("p = paper");
                Console.WriteLine("r = rock");
                Console.WriteLine("s = scissors");
                Console.WriteLine("Player1: Answer is Hiden");
                Player1[count] = ActionP1;
                Console.Write("Player2: ");
                string ActionP2 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please Select your Action below");
                Console.WriteLine("p = paper");
                Console.WriteLine("r = rock");
                Console.WriteLine("s = scissors");
                Console.WriteLine("Player1: Answer is Hiden");
                Console.WriteLine("Player2: Answer is Hiden");
                Player2[count] = ActionP2;
                round++; count++;
                if (round < 3)
                {
                    Console.Write("Wait for 3 seconds to round {0}", round + 1);
                }

                for (int x = 0; x <= 3; x++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);

                }
                Thread.Sleep(3000);
                Console.Clear();

            } while (round != 3); //3

            if (Player1.Length == 3 && Player2.Length == 3)
            {

                for (int index = 0; index < 3; index++)
                {
                    if (Player1[index] == "p" && Player2[index] == "p") Console.WriteLine("Draw");
                    else if (Player1[index] == "p" && Player2[index] == "r") { Console.WriteLine("Player1 win"); P1Score++; }
                    else if (Player1[index] == "p" && Player2[index] == "s") { Console.WriteLine("Player2 win"); P2Score++; }
                    else if (Player1[index] == "r" && Player2[index] == "r") { Console.WriteLine("Draw"); }
                    else if (Player1[index] == "r" && Player2[index] == "p") { Console.WriteLine("Player2 win"); P2Score++; }
                    else if (Player1[index] == "r" && Player2[index] == "s") { Console.WriteLine("Player1 win"); P1Score++; }
                    else if (Player1[index] == "s" && Player2[index] == "s") { Console.WriteLine("Draw"); }
                    else if (Player1[index] == "s" && Player2[index] == "r") { Console.WriteLine("Player2 win"); P2Score++; }
                    else if (Player1[index] == "s" && Player2[index] == "p") { Console.WriteLine("Player1 win"); P1Score++; }
                }
            }
            if (round == 3)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Score of Player1 {0}", P1Score);
                Console.WriteLine("Score of Player2 {0}", P2Score);
            }
        }
    }
}
