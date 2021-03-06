﻿using System;

namespace GeometryObjectsWithComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var quad1 = new Quadrilateral
            {
                Side1 = 2,
                Side2 = 4,
                Side3 = 6,
                Side4 = 8
            };
            quad1.Perimeter();

            var rect1 = new Rectangle(5, 7);
            rect1.Perimeter();
            rect1.Area();
        }
    }
}
