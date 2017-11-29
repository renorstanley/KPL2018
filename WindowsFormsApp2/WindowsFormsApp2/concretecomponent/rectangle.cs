using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class rectangle : Shape
    {
        int fromX,fromY, toX, toY;
        Graphics graph;
        Pen p;
        public rectangle(int initialX, int initialY, Pen p, int x, int y, Graphics objGraphic)
        {
            this.fromX = initialX ;
            this.fromY = initialY;
            this.p = p;
            this.toX = x;
            this.toY = y;
            this.graph = objGraphic;
        }
        // Override Area method 
        public override void draw()
        {
            Rectangle rect = new Rectangle(Math.Min(toX, fromX),
                   Math.Min(toY, fromY),
                   Math.Abs(toX - fromX),
                   Math.Abs(toY - fromY));
            graph.DrawRectangle(p, rect);

         }
    }
}
