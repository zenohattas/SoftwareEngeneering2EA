using System;

namespace OefLes1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Koen
        {
            public int PropOfKoen { get; set; }
        }
        abstract class Position
        {
            abstract public int X { get; set; }
            abstract public int Y { get; set; }
        }
    }
    abstract class Philosophy
    {
        public String IThink()
        {
            return "Therefore I am.";
        }
    }
}
