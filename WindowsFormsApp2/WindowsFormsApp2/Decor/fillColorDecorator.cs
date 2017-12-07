using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class fillColorDecorator:decorator
    {
        public fillColorDecorator(Shape baseComponent, Color color)
            : base(baseComponent)
        {
            this.c = color;
            this.toDoFill = true;
          }
    }
}
