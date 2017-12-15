using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class rumuspersegistrategy:rumusbentukstrategy
    {
        public override double luas(int toX, int toY, int fromX, int fromY)
        {
            int px, py;
            double vector;
            px = toX - fromX; py = toY - fromY;
            vector = px * py;

            return vector;
        }
    }
}
