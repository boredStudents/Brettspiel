using System;
using GameLib;

namespace BrettspielTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GameField gf = new GameField("AFelder.csv", 25);

            Console.ReadKey();
        }
    }
}
