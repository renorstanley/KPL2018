using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    internal class line:Shape
    {
        Graphics graph;
        Pen p;
        Point prevPoint;
        Point curlocation;
        int fromX, fromY, toX, toY;
        int thickness;
        public line(Pen p, Point prevpoint, Point location )
        {
            this.p = p;
            this.prevPoint = prevpoint;
            this.curlocation = location;
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
            return "Line";
        }
        public override Graphics GetGraph()
        {
            return this.graph;
        }

        public override void draw()
        {
            graph.DrawLine(p, prevPoint,curlocation);
            prevPoint = curlocation;
        }
    }
}