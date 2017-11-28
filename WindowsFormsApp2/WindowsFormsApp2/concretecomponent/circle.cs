using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint

{
    class circle: Shape
    {
        int initialX, initialY;
        public circle(int x, int y)
        {
            this.initialX = x;
            this.initialY = y;
        }
        public override void draw(Pen p, int x, int y, Graphics objGraphic)
        {
            Rectangle rect = new Rectangle(Math.Min(x, initialX),
                   Math.Min(y, this.initialY),
                   Math.Abs(x - this.initialX),
                   Math.Abs(y - initialY));
            objGraphic.DrawEllipse(p, rect);
          }
    }
}
