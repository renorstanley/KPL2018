using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimplePaint
{
    class freehandcommand:iCommand
    {
        Point _from, _to;
        private Pen _p;
        private Graphics _objGraphic;
        private int pixelvoyager_fromx, pixelvoyager_tox, pixelvoyager_fromy, pixelvoyager_toy;
        private Bitmap _Bitmap;
        public freehandcommand(Point from, Point to, Pen p, Graphics objGraphic, Bitmap bitmap)
        {
            _from = from;
            _to = to;
            _p = p;
            _objGraphic = objGraphic;
            _Bitmap = bitmap;
        }
        public void Do()
        {
            savepreviouspixel();
            _objGraphic.DrawLine(_p, _from, _to);
            _objGraphic.SmoothingMode = SmoothingMode.HighQuality;
        }
        private IList<Color> _colors = new List<Color>();
        private static int extender = 10;
        public void savepreviouspixel()
        {
            // memindahkan titik apabila shape di gambar dengan arah yang kebalikan sehingga tetap bisa di undo
            if (_to.X > _from.X)
            {
                pixelvoyager_fromx = _from.X - extender;
                pixelvoyager_tox = _to.X + extender;
            }
            else
            {
                pixelvoyager_fromx = _to.X - extender;
                pixelvoyager_tox = _from.X + extender;
            }
            if (_to.Y > _from.Y)
            {
                pixelvoyager_fromy = _from.Y - extender;
                pixelvoyager_toy = _to.Y + extender;
            }
            else
            {
                pixelvoyager_fromy = _to.Y - extender;
                pixelvoyager_toy = _from.Y + extender;
            }
            for (int i = pixelvoyager_fromx; i < pixelvoyager_tox; i++)
                for (int j = pixelvoyager_fromy; j < pixelvoyager_toy; j++)
                    _colors.Add(_Bitmap.GetPixel(i, j));

        }
        //agar tidak melewati batas
            if(pixelvoyager_fromx<0)
            {
                pixelvoyager_fromx = 0;
            }
            if(pixelvoyager_fromy<0)
            {
                pixelvoyager_fromx = 0;
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
