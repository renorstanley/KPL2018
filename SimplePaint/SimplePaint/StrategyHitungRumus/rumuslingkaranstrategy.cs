﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class rumuslingkaranstrategy:rumusbentukstrategy
    {

        public override double luas(int toX, int toY, int fromX, int fromY)
        {
            int px, py;
            double vector;
            px = toX-fromX; py = toY - fromY;
            vector = 3.14 * 0.5 * px*py;
         
            return vector;
        }
    }
}
