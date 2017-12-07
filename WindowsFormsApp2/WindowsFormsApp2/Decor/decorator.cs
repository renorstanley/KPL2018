using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    class decorator: Shape
    {
        protected Shape m_BaseComponent = null;
        protected Color c= Color.Black;
        protected bool toDoFill = false;
        Graphics g;
       
       
        public decorator(Shape baseComponent)
        {
            this.m_BaseComponent = baseComponent;
        }
        public override int getThickness()
        {
            return this.m_BaseComponent.getThickness();
        }
        public override int getFromX()
        {
            return this.m_BaseComponent.getFromX();
        }
        public override int getFromY()
        {
            return this.m_BaseComponent.getFromY();
        }
        public override int getToX()
        {
            return this.m_BaseComponent.getFromX();
        }
        public override int getToY()
        {
            return this.m_BaseComponent.getFromY();
        }
        public override string shapetype()
        {
            return this.m_BaseComponent.shapetype();
        }
        public override Graphics GetGraph()
        {
            return this.m_BaseComponent.GetGraph();
        }
        public override void draw()
        {
           //this.m_BaseComponent.draw();
            SolidBrush bru = new SolidBrush(c);
            Pen p = new Pen(c);
            p.Width = this.m_BaseComponent.getThickness();
            Point from = new Point(this.m_BaseComponent.getFromX(), this.m_BaseComponent.getFromY());
            Point to = new Point(this.m_BaseComponent.getToX(), this.m_BaseComponent.getToY());
            Point prev;
            Point cur;
            Rectangle rect = new Rectangle(Math.Min(this.m_BaseComponent.getToX(), this.m_BaseComponent.getFromX()),
                      Math.Min(this.m_BaseComponent.getToY(), this.m_BaseComponent.getFromY()),
                      Math.Abs(this.m_BaseComponent.getToX() - this.m_BaseComponent.getFromX()),
                      Math.Abs(this.m_BaseComponent.getToY() - this.m_BaseComponent.getFromY()));
            
            g = this.GetGraph();

            if (this.m_BaseComponent.shapetype() == "circle")
            {
                if (toDoFill == false)
                {
                    g.DrawEllipse(p, rect);
                }
                else
                    g.FillEllipse(bru, rect);

            }
            else if (this.m_BaseComponent.shapetype() == "rectangle")
            {
                if (toDoFill == false)
                {
                    g.DrawRectangle(p, rect);
                }
                else
                    g.FillRectangle(bru, rect);
            }
            else if (this.m_BaseComponent.shapetype() == "Line")
            {
                g.DrawLine(p, from, to);
            }

        }
    }
}
