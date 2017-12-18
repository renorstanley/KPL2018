using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace SimplePaint
{
    class linecommand : iCommand
    {
        private int _fromX, _fromY, _toX, _toY;
        private Pen _p;
        private SolidBrush _sb;
        private Graphics _objGraphic;
        private int pixelvoyager_fromx, pixelvoyager_tox, pixelvoyager_fromy, pixelvoyager_toy;
        private Bitmap _Bitmap;

        Form colorextract = new Display();
        public linecommand(int initialX, int initialY, Pen p, int x, int y, Graphics objGraphic, Bitmap bitmap)
        {
            _fromX = initialX;
            _fromY = initialY;
            _p = p;
            _toX = x;
            _toY = y;
            _objGraphic = objGraphic;
            _Bitmap = bitmap;

        }
        public void Do()
        {
            savepreviouspixel();
            line l = new line(_fromX, _fromY, _p, _toX, _toY, _objGraphic);
            l.draw();
        }
        private IList<Color> _colors = new List<Color>();
        private static int extender = 10;
        public void savepreviouspixel()
        {
            // memindahkan titik apabila shape di gambar dengan arah yang kebalikan sehingga tetap bisa di undo
            if (_toX > _fromX)
            {
                pixelvoyager_fromx = _fromX - extender;
                pixelvoyager_tox = _toX + extender;
            }
            else
            {
                pixelvoyager_fromx = _toX - extender;
                pixelvoyager_tox = _fromX + extender;
            }
            if (_toY > _fromY)
            {
                pixelvoyager_fromy = _fromY - extender;
                pixelvoyager_toy = _toY + extender;
            }
            else
            {
                pixelvoyager_fromy = _toY - extender;
                pixelvoyager_toy = _fromY + extender;
            }
            for (int i = pixelvoyager_fromx; i < pixelvoyager_tox; i++)
                for (int j = pixelvoyager_fromy; j < pixelvoyager_toy; j++)
                    _colors.Add(_Bitmap.GetPixel(i, j));

        }
        public void Undo()
        {
            int ix = 0;
            for (int i = pixelvoyager_fromx; i < pixelvoyager_tox; i++)
                for (int j = pixelvoyager_fromy; j < pixelvoyager_toy; j++)
                    _Bitmap.SetPixel(i, j, _colors[ix++]);


        }
    }
}
