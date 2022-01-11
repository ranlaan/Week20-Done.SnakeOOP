using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_OOP
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char symb;

        Random rnd = new Random();

        public FoodGenerator(int _mapWidth, int _mapHeight, char _symb)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            symb = _symb;
        }

        public Point GenerateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            Console.Beep();
            return new Point(x, y, symb);
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
