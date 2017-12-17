using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class rumustrianglestrategy:rumusbentukstrategy
    {

        public override double luas(int toX, int toY, int fromX, int fromY)
        {
            int px, py;
            double vector;
            Point A = new Point(fromX + ((toX - fromX) / 2), fromY);
            Point B = new Point(fromX + (toX - fromX), fromY + (toY - fromY));
            Point C = new Point(fromX, fromY + (toY - fromY));
            px = B.X - A.X; py = C.Y;
            vector = 0.5 * py * px;         
            return vector;
        }
    }
}
