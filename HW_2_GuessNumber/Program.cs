using System;


namespace HW_2_GuessNumber
{
    class GuessGame
    {
        public static void Main(string[] args)
        {
            bool win = false;
            int rndnum = RandomInitialization();
            Console.WriteLine("Hello! Pick a number between 0 and 100:");
            win = NumberChecking(win, rndnum);

            Console.ReadKey();
        }

        private static int RandomInitialization()
        {
            Random random = new Random();
            int rndnum = random.Next(0, 100);
            return rndnum;
        }

        private static bool NumberChecking(bool win, int rndnum)
        {
            while (win == false)
            {
                int inputnum = Convert.ToInt32(Console.ReadLine());
                if (inputnum == rndnum)
                {
                    win = true;
                    Console.WriteLine("My congratulations! You are the winner!");
                }
                else if (inputnum > rndnum)
                {
                    win = false;
                    Console.WriteLine("Your number is bigger than mine. Try again");
                }
                else if (inputnum < rndnum)
                {
                    win = false;
                    Console.WriteLine("Your number is less than mine. Try again");
                }
                else if (inputnum > 100)
                {
                    win = false;
                    Console.WriteLine("Please, enter a number that ranges from 0 to 100");
                }
            }

            return win;
        }
    }
}