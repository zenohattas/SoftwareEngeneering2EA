using System;

namespace OefLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            Console.ReadKey();
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
            Console.WriteLine("");
            string inp = Console.ReadLine();
            switch (inp)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
        }
    }
}
