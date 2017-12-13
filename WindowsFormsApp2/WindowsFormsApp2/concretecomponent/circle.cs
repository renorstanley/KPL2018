﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint

{
    class circle: Shape
    {
        int fromX, fromY, toX, toY;
        Graphics graph;
        Pen p;
        int thickness;
        public circle(int initialX, int initialY, Pen p, int x, int y, Graphics objGraphic, int tebal)
        {
            this.fromX = initialX;
            this.fromY = initialY;
            this.p = p;
            this.toX = x;
            this.toY = y;
            this.graph = objGraphic;
            this.thickness = tebal;
        }
        public override int getThickness()
        {
            return this.thickness;
        }
        public override int getFromX()
        {
            return this.fromX;
        }
        public override int getFromY()
        {
            return this.fromY;
        }
        public override int getToX()
        {
            return this.toX;
        }
        public override int getToY()
        {
            return this.toY;
        }
        public override string shapetype()
        {
            return "circle";
        }
        public override Graphics GetGraph()
        {
            return this.graph;
        }
        public override void draw()
        {
            Rectangle rect = new Rectangle(Math.Min(toX, fromX),
                  Math.Min(toY, fromY),
                  Math.Abs(toX - fromX),
                  Math.Abs(toY - fromY));
            graph.DrawEllipse(p, rect);
    
          }
    }
}
