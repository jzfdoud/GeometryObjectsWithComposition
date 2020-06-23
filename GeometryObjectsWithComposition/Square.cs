using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace GeometryObjectsWithComposition
{
    class Square
    {
        private Rectangle rect;

        public void Perimeter()
        {
            rect.Perimeter();
        }

        public void Area() { 
            rect.Area();
        }
        // can use lambda if only have one statement? if not use a contructor?

        public Square(int s)
        {
            rect = new Rectangle(s, s);
        }
    }
}
