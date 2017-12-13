using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimplePaint
{
    public partial class Display : Form
    {
        int tebal = 10, initialX, initialY;

        Color wrn, wrn1;
        Pen p;
        private Graphics objGraphic;
        private bool shouldPaint = false;
        Boolean line, rectang, circle, trangle;
        double px, py, vector;
        rectangle r;
        //triangle
        private List<Point> points = new List<Point>();
        Point[] list = new Point[3];
        void buttoncolor()
        {
            line_button.BackColor = Color.Snow; rect_button.BackColor = Color.Snow;
            elips_button.BackColor = Color.Snow; triangle.BackColor = Color.Snow;
        }
        Point a, b, c;
        public Display()
        {
            InitializeComponent();
            p = new Pen(Color.Black);
         
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            objGraphic = panel1.CreateGraphics();
        }
        /*void rumusline()
        {
            px = newCoor.X; py = newCoor.Y;
            vector = Math.Sqrt((Math.Pow(px, 2)) + (Math.Pow(py, 2)));
            angle = Math.Atan(py / px) * 180 / Math.PI; //display();
        }*/
        /*void rumusrectang()
        {
            px = width; py = height;
            vector = px * py;
            if (rectang == true)
            { angle = 0; }
            //display();
        }

        void rumuscircle()
        {
            px = cirW; py = cirL;
            vector = Math.PI * 0.5 * (cirW + cirL);
            if (circle == true)
            { angle = 360; }
            //display();
        }
        void rumustriangle()
        {
            px = b.X - a.X; py = c.Y;
            vector = 0.5 * px * py;
            if (trangle == true)
            { angle = 180; }
            //display();
        }*/
        void reset()
        {
            line = false; rectang = false;
            circle = false; trangle = false;
        }
        //membuat point 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                shouldPaint = true;
                initialX = e.X;initialY = e.Y;
                /*else if (trangle == true)
                {
                    if (triangle_step == false)
                        shouldPaint = true;
                }*/
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (shouldPaint == true)
            {
                if (line == true)
                {
                    line l = new line(initialX, initialY, p, e.X, e.Y, objGraphic,3);
                    l.draw();
                    //rumusline(); 
                }
                else if (rectang == true)
                {
                    //                 width = e.X - initialX;
                    //                  height = e.Y - initialY;
                    rectangle r = new rectangle(initialX, initialY, p, e.X, e.Y, objGraphic,3);
                    r.draw();
                    //decorator b = new decorator(r);
                    //rumusrectang(); 
                }
                else if (circle == true)
                {
                    circle r = new circle(initialX, initialY, p, e.X, e.Y, objGraphic, 3);
                    //cirW = Math.Abs(e.X - initialX);
                    //cirL = Math.Abs(e.Y - initialY);
                    r.draw();   
                //cir.draw(p, e.X, e.Y, objGraphic);
                }    
                    shouldPaint = false;
                    /*else if (trangle == true)
                        {
                            if (triangle_step == false)
                            {
                                newCoor = new Point(e.X, e.Y);
                                objGraphic.DrawLine(p, preCoor, newCoor);
                                rumusline();
                                triangle_step = true;
                            }
                            if(triangle_step == true)
                            {
                                Point newCoorgain = new Point (e.X, e.Y);
                                objGraphic.DrawLine(p, preCoor, newCoorgain);
                                objGraphic.DrawLine(p, preCoor, newCoor);
                            }
                            shouldPaint = false;
                            objGraphic.DrawPolygon(p, list);
                            rumustriangle(); shouldPaint = false;
                        }*/
            }
        }
        private void rect_button_Click(object sender, EventArgs e)
        {
            reset();
            rectang = true;
            buttoncolor();
            rect_button.BackColor = Color.LightCyan;
        }
        private void line_button_Click(object sender, EventArgs e)
        {
            reset();
            line = true;
            buttoncolor();
            line_button.BackColor = Color.LightCyan;
        }
        private void elips_button_Click(object sender, EventArgs e)
        {
            reset();
            circle = true;
            buttoncolor();
            elips_button.BackColor = Color.LightCyan;
        }
        private void triangle_Click(object sender, EventArgs e)
        {
            reset();
            trangle = true;
            buttoncolor();
            triangle.BackColor = Color.LightCyan;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
