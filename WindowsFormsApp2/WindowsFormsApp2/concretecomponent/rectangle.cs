using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class rectangle : basic2DShapecomponent
    {
        int initialX, initialY;
        public rectangle(int x, int y)
        {
            this.initialX = x;
            this.initialY = y;
        }
        // Override Area method 
        public override void draw(Pen p,int x, int y,Graphics objGraphic)
        {
            Rectangle rect = new Rectangle(Math.Min(x, initialX),
                   Math.Min(y, this.initialY),
                   Math.Abs(x - this.initialX),
                   Math.Abs(y - initialY));
            objGraphic.DrawRectangle(p, rect);
            SolidBrush b;
            b = new SolidBrush(Color.Magenta);

            objGraphic.FillRectangle(b, rect);
        }
    }
}
