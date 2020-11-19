using System;
using log4net;
using log4net.Config;

namespace org.tyaa.demo.dotnet.logging
{
    class Program
    {
        private static ILog logger = LogManager.GetLogger(typeof(Program));
        static Random rand = new Random();
       static int[] num = new int[5];
        public static void GetRand()
        {
            for (int i = 0; i < num.Length; i++)
            {
                 num[i] = rand.Next(50);                
            }
        }
        public static void ShowRand()
        {
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(50);
                Console.WriteLine(num[i]);
            }
        }

        public static void GetSortirovka()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" до сортировки ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(50);
                Console.Write(num[i] + "  ");
            }
            Console.WriteLine("\n после сортировки ");
            for (int i = 0; i < num.Length; i++)
            {
                Array.Sort(num);
                Console.Write(num[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            // BasicConfigurator.Configure();
            log4net.Config.XmlConfigurator.Configure();
            Console.Title = "Александр, ПСВ - 31-18/1";
            Console.ForegroundColor = ConsoleColor.Red;
            // Console.WindowHeight = Console.WindowHeight;
            // Console.WindowWidth = Console.WindowWidth;
            string greetings = "Привет, мои милые лягушатки!";
            // TODO Log
            logger.Info("greetings = " + greetings);
            
            Console.SetCursorPosition(Console.WindowWidth / 2 - greetings.Length / 2,
                Console.WindowHeight / 2);//выводим текст по центру
            Console.WriteLine(greetings);
            Console.ResetColor();

            ConsoleKeyInfo mykey;
            mykey = Console.ReadKey();
            if (mykey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
            Console.WriteLine("");

            int number = 0;
            ConsoleKeyInfo myk;

            string[] menu = { " MENU ", " 1.Заполнить массив случайными значениями", " 2.Вывести список", " 3.отсортировать" };
            int myH = Console.WindowHeight / 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < menu.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2, myH + i);//выводим текст по центру]
                Console.Write(menu[i]);
            }

            do
            {
                do
                {
                    myk = Console.ReadKey();
                    if (myk.Key == ConsoleKey.DownArrow)
                    {
                        if (number == 3)
                        {
                            number = 1;
                        }
                        else
                            number++;
                    }
                    if (myk.Key == ConsoleKey.UpArrow)
                    {
                        if (number <= 1)
                        {
                            number = 3;
                        }
                        else
                            number--;
                    }

                    for (int i = 0; i < menu.Length; i++)
                    {

                        if (i == number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2, myH + i);//выводим текст по центру]
                        Console.Write(menu[i]);
                    }

                } while (myk.Key != ConsoleKey.Enter);

                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[number].Length / 2, myH);
                Console.WriteLine(menu[number]);

                if (number == 1)
                {
                    GetRand();
                    Console.ReadKey();
                }

                if (number == 2)
                {
                    ShowRand();
                    Console.ReadKey();
                }
                if (number == 3)
                {
                    GetSortirovka();
                    Console.ReadKey();
                }
                Console.Clear();

            } while (myk.Key != ConsoleKey.Escape);

            Console.ResetColor();
        }
    }
}
