﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_OOP
{
    class HorizontaLine : Figure
    {


        public HorizontaLine(int xLeft, int xRight, int y, char symb)
        {
            pointList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointList.Add(p);
            }



        }
    }
}
