using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace SimplePaint
{
    class rectanglecommand : iCommand
    {
        private int _fromX, _fromY, _toX, _toY;
        private Pen _p;
        private SolidBrush _sb;
        private Graphics _objGraphic;

        Form colorextract = new Display();
        public rectanglecommand(int initialX, int initialY, Pen p, SolidBrush sb, int x, int y, Graphics objGraphic)
        {
            _fromX = initialX;
            _fromY = initialY;
            _p = p;
            _sb = sb;
            _toX = x;
            _toY = y;
            _objGraphic = objGraphic;

        }
        public void Do()
        {
            rectangle r = new rectangle(_fromX, _fromY, _p, _sb, _toX, _toY, _objGraphic);
            r.draw();
        }
        public void Undo(Color bg)
        {
            _p.Color = bg;
            _sb.Color = bg;
            rectangle r = new rectangle(_fromX, _fromY, _p, _sb, _toX, _toY, _objGraphic);
            r.draw();
        }
    }
}
