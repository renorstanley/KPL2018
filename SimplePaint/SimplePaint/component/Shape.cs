using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    public abstract class Shape
    {
        public abstract void draw();
        public abstract int getFromX();
        public abstract int getFromY();
        public abstract int getToX();
        public abstract int getToY();
        public abstract string shapetype();
        public abstract Graphics GetGraph();
    }
}
