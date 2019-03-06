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

        // TODO:
        // Если есть возвращаемое значение, то лучше переименовать метод, на что-то вроде "GetRandomNumber". 
        // Сейчас по контексту названия выглядит будто инициализируется какое-то поле с типом "Random"
        private static int RandomInitialization()
        {
            Random random = new Random();
            // TODO:
            // 0 и 100 стоит вынести в параметры метода. любые подобные штуки лучше выносить в параметры
            int rndnum = random.Next(0, 100);
            // TODO:
            // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-parameters - код конвеншен по названию переменных, rndNum
            return rndnum;
        }

        // TODO:
        // Не совсем понятно зачем здесь возвращаемом значение
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
                // TODO:
                // Все обьявленные конструкции if - else if - else выполняются в том порядке в котором они были обьявлены. 
                // Соответственно сейчас последний else if никогда не отрабатывает, поскольку при вводе, к примеру, 
                // 101 сработает просто  "else if (inputnum > rndnum)".
                // Вот эту проверку на вообще допустимое значение введеного числа стоит сделать первым if, 
                // проверять в нем на ((inputnum < minValue)||(inputnum > maxValue)), а minValue и maxValue сделать параметрами метода
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
