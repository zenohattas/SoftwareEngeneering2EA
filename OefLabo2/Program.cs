using System;

namespace OefLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }
        static void Title()
        {
            Console.Clear();
            Console.WriteLine(@"
 _______  _______  _______  _______  __    _  ___   __    _  _______    ___      _______  _______  _______    _______ 
|       ||       ||       ||       ||  |  | ||   | |  |  | ||       |  |   |    |   _   ||  _    ||       |  |       |
|   _   ||    ___||    ___||    ___||   |_| ||   | |   |_| ||    ___|  |   |    |  |_|  || |_|   ||   _   |  |____   |
|  | |  ||   |___ |   |___ |   |___ |       ||   | |       ||   | __   |   |    |       ||       ||  | |  |   ____|  |
|  |_|  ||    ___||    ___||    ___||  _    ||   | |  _    ||   ||  |  |   |___ |       ||  _   | |  |_|  |  | ______|
|       ||   |___ |   |    |   |___ | | |   ||   | | | |   ||   |_| |  |       ||   _   || |_|   ||       |  | |_____ 
|_______||_______||___|    |_______||_|  |__||___| |_|  |__||_______|  |_______||__| |__||_______||_______|  |_______|
");
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
        static void Menu()
        {
            Title();
            Console.WriteLine("1. Show me a nice Quote: ");
            Console.WriteLine("");
            Console.WriteLine("Q. Quit");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    //shania
                    break;
                case "2":
                    //Jordi
                    break;
                case "3":
                    //Koen
                    break;
                case "q":
                    System.Environment.Exit(0);
                    break;
            }
        }

    }
}
