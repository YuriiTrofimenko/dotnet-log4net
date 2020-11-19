using System;
using System.Collections.Generic;
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
            // MyGen<decimal> mg1 = new MyGen<decimal>();
            // System.Console.WriteLine(mg1.Calculate(new Decimal(5), new Decimal(6)));
            // System.Console.WriteLine(mg1.Calculate(5, 6));

            /* List<IPassport> passports = new List<IPassport>() {
              new ItalianPassport() {Name = "Mario", SureName="Abc", Sex=IEuPassport.Gender.Male},
              new ItalianPassport() {Name = "Luigi", SureName="A", Sex=IEuPassport.Gender.Male},
              new UkrainianPassport() {Name = "Maria", SureName="Xyz"}
            }; */

            List<IEuPassport> passports = new List<IEuPassport>() {
              new ItalianPassport() {Name = "Mario", SureName="Abc", Sex=IEuPassport.Gender.Male},
              new ItalianPassport() {Name = "Luigi", SureName="A", Sex=IEuPassport.Gender.Male}/* ,
              new UkrainianPassport() {Name = "Maria", SureName="Xyz"} */
            };

            passports.ForEach(p => System.Console.WriteLine(PassportValidator<IEuPassport>.Validate(p)));

            // MyGen<double> mg2;
            // string s1 = new string("Hello");
            // string s2 = new string("Hello");
            /* string s1 = "Hello";
            string s2 = "Hello";
            System.Console.WriteLine(s1 == s2);
            System.Console.WriteLine(Object.ReferenceEquals(s1, s2)); */
            /* // BasicConfigurator.Configure();
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

            Console.ResetColor();*/
        }
    }
}
