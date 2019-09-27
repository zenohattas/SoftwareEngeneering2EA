using System;

namespace OefLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw.draw(30, 20, '*');
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
            Console.WriteLine("1. Show me a nice Quote");
            Console.WriteLine("2. Show me more Qoutes");
            Console.WriteLine("3. Boop!");
            Console.WriteLine("Q. Quit");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    //shania
                    llama();
                    break;
                case "2":
                    //Jordi
                    Carl();
                    break;
                case "3":
                    //Koen
                    boop();
                    break;
                case "q":
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void llama()
        {
            Console.WriteLine("I rather have a Lavish Princess Llama than Carl!");
            Console.ReadLine();
        }

        static void Carl()
        {
            Console.WriteLine("Paul: Carl, there is a dead human in our house.");
            Console.WriteLine("Carl: Oh,hey,how did it get there?");
            Console.WriteLine("Paul:Caaarrrrllll,what did you do ;^;");
            Console.ReadLine();
        }

        static void boop()
        {
            Console.WriteLine("boop!");
        }
    }
}
