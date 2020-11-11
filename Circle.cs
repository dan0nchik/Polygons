﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Многоугольники.Form1;

namespace Многоугольники
{
    public class Circle : Shape
    {
        public Circle(int xx, int yy) : base(xx, yy)
        {
        }
        public override void Draw(Graphics g, Color color)
        {
            g.FillEllipse(new SolidBrush(color), new Rectangle(x - R, y - R, 2 * R, 2 * R));
        }
        public override bool IsInside(int xx, int yy)
        {
            return Math.Sqrt(Math.Pow(x - xx, 2) + Math.Pow(y - yy, 2)) <= R;
        }

    }
}