using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_OOP
{
    class Wall
    {
        List<Figure> wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontaLine top = new HorizontaLine(0, 80, 0, '-');
            VerticalLine left = new VerticalLine(0, 25, 0, '|');
            HorizontaLine bottom = new HorizontaLine(0, 80, 25, '-');
            VerticalLine right = new VerticalLine(0, 25, 80, '|');
            HorizontaLine obstacle = new HorizontaLine(59, 79, 10, '-');
            VerticalLine obstacle1 = new VerticalLine(18, 24, 10, '|');



            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(obstacle);
            wallList.Add(obstacle1);
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
