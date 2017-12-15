﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Drawing2D;

namespace SimplePaint
{
    public partial class Display : Form
    {
        int tebal = 10, initialX, initialY;
        contextrumus A = new contextrumus();
        Color wrn, wrn1;
        double luas;
        Pen p;
        private Graphics objGraphic;
        private bool shouldPaint = false;
        Boolean line, rectang, circle,trangle;
        double px, py, vector;
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
          
        }
      
       */
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
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (shouldPaint == true)
            {
                if (line == true)
                {
                    line l = new line(initialX, initialY, p, e.X, e.Y, objGraphic, 3);
                    l.draw();
                    A.pakairumushitung(new rumusgarisstrategy());
                }
                else if (rectang == true)
                {
                    rectangle r = new rectangle(initialX, initialY, p, e.X, e.Y, objGraphic, 3);
                    r.draw();
                    A.pakairumushitung(new rumuspersegistrategy());
                }

                else if (circle == true)
                {
                    circle c = new circle(initialX, initialY, p, e.X, e.Y, objGraphic, 3);
                    c.draw();
                    A.pakairumushitung(new rumuslingkaranstrategy());
                }
                else 
                {
                    triangle t = new triangle(initialX, initialY, p, e.X, e.Y, objGraphic, 3);
                    t.draw();
                    A.pakairumushitung(new rumustrianglestrategy());
                }

                int selisihX, selisihY;
                if(circle == true || rectang ==true ||line==true)
                {
                    selisihX =Math.Abs( e.X - initialX);
                    selisihY =Math.Abs(e.Y - initialY);
                }
                else
                {
                    Point A = new Point(initialX + (e.X / 2), initialY);
                    Point B = new Point(initialX+e.X, initialY + e.Y);
                    Point C = new Point(initialX, initialY +e.Y);
                    selisihX = B.X - A.X;
                    selisihY = C.Y;
                }
                luas = Math.Round(Math.Abs(A.luas(e.X, e.Y, initialX, initialY)),2);
                W_Indicator.Text = selisihX.ToString();
                H_Indicator.Text = selisihY.ToString();
                A_Indicator.Text = luas.ToString();
                }
                shouldPaint = false;
                    
            
        }
        private void rect_button_Click(object sender, EventArgs e)
        {
            reset();
            rectang = true;
            buttoncolor();
            rect_button.BackColor = Color.LightCyan;
            changinglabel.Text = "A";
        }
        private void line_button_Click(object sender, EventArgs e)
        {
            reset();
            line = true;
            buttoncolor();
            line_button.BackColor = Color.LightCyan;
            changinglabel.Text = "D";
        }
        private void elips_button_Click(object sender, EventArgs e)
        {
            reset();
            circle = true;
            buttoncolor();
            elips_button.BackColor = Color.LightCyan;
            changinglabel.Text = "A";
        }
        private void trianglebutton_click(object sender, MouseEventArgs e)
        {
            reset();
            trangle = true;
            buttoncolor();
            triangle.BackColor = Color.LightCyan;
            changinglabel.Text = "A";
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
