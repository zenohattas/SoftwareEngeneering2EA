using System;
using System.Collections.Generic;
using System.Text;

namespace OefLabo2
{
    abstract class Move
    {
        public void move()
        {
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "q":
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    break;
                case "d":
                    Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                    break;
            }
        }
        
}
}
