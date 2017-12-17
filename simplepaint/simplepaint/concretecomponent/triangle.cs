using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class triangle : Shape

    {
        int thickness;
        int fromX, fromY, toX, toY;
        Graphics graph;
        Pen p;
        SolidBrush sb;
        Point pointA, pointB, pointC;
        public triangle(int initialX, int initialY, Pen p, SolidBrush sb, int x, int y, Graphics objGraphic)
        {
            //this.thickness = tebal;
            this.fromX = initialX;
            this.fromY = initialY;
            this.toX = x;
            this.toY = y;
            this.graph = objGraphic;
            this.p = p;
            this.sb = sb;
        }

        

        public override void draw()
        {
            this.pointA = new Point(this.fromX + ((this.toX-this.fromX) / 2), this.fromY);
            this.pointB = new Point(this.fromX + (this.toX - this.fromX), this.fromY + (this.toY-this.fromY));
            this.pointC = new Point(this.fromX, this.fromY + (this.toY-this.fromY));
            Point[] triPoint = { pointA, pointB, pointC };
            graph.DrawPolygon(p, triPoint);
            graph.FillPolygon(sb, triPoint);
        }
        /*
        public override int getThickness()
        {
            return this.thickness;
        }
        */
        public override Graphics GetGraph()
        {
            return this.graph;
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
            return "triangle";
        }
    }
}
