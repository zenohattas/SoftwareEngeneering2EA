using System;
using System.Collections.Generic;
using System.Text;

namespace OefLabo2
{
    abstract class Draw
    {
        public static void draw(int _x, int _y, char _a)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_a);
        }
    }
}
