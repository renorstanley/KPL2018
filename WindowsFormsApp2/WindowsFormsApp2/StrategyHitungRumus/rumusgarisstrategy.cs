using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class rumusgarisstrategy:rumusbentukstrategy
    {
        public override double luas(int toX, int toY, int fromX, int fromY)
        {
         
            int px, py;
            double vector;
            px = toX - fromX; py = toY - fromY;
            vector = Math.Sqrt((Math.Pow(px, 2)) + (Math.Pow(py, 2)));
            ;

            return vector;
        }
    }
}
