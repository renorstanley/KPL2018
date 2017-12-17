using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace SimplePaint
{
    class circlecommand : iCommand
    {
         private int _fromX, _fromY, _toX, _toY;
        private Pen _p;
        private SolidBrush _sb;
        private Graphics _objGraphic;
        private Bitmap _Bitmap;
        Form colorextract = new Display();
        public circlecommand(int initialX, int initialY, Pen p, SolidBrush sb, int x, int y, Graphics objGraphic, Bitmap bitmap)
        {
            _fromX = initialX;
            _fromY = initialY;
            _p = p;
            _sb = sb;
            _toX = x;
            _toY = y;
            _objGraphic = objGraphic;
            _Bitmap = bitmap;

        }
        public void Do()
        {
            savepreviouspixel();
            circle c = new circle(_fromX, _fromY, _p, _sb, _toX, _toY, _objGraphic);
            c.draw();
            
        }
        private IList<Color> _colors = new List<Color>();
        private int Width,Height; 
        public void savepreviouspixel()
        {
<<<<<<< HEAD
            Width = (Math.Abs(_toX - _fromX))+2;
            Height = (Math.Abs(_toY - _fromY))+2;
            for (int i = _fromX; i < _fromX + Width; i++)
                for (int j = _fromY; j < _fromY + Height; j++)
                    _colors.Add(_Bitmap.GetPixel(i, j));
        }
        public void Undo()
        {
            int ix = 0;
            for (int i = _fromX; i < _fromX + Width; i++)
                for (int j = _fromY; j < _fromY + Height; j++)
                    _Bitmap.SetPixel(i, j, _colors[ix++]);
             
=======
            _p.Color = bg;
            _sb.Color = bg;
           circle c = new circle(_fromX, _fromY, _p, _sb, _toX, _toY, _objGraphic);
            c.draw();
>>>>>>> bec65d789c9efe7d15f91b4325f99933de86dcea
        }

    }
}
