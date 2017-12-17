using System;
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
        private Stack<iCommand> _commandStack = new Stack<iCommand>();
        Stack<iCommand> redrawer = new Stack<iCommand>();
        int tebal = 1, initialX, initialY;
        contextrumus A = new contextrumus();
        Color wrn, wrn1, bg = Color.White;
        double luas;
        Pen p;
        SolidBrush sb;
        private Graphics objGraphic;
        private Bitmap _bitmap;
        private bool shouldPaint = false;
        Boolean line, rectang, circle, trangle;
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
            //initial color
            wrn = Color.Black;
            _bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            panel1.Image = _bitmap;

        }

        private void bg_colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            System.Windows.Forms.DialogResult myResult = new System.Windows.Forms.DialogResult();
            myResult = c.ShowDialog();
            if (myResult == System.Windows.Forms.DialogResult.OK)
            {
                bg_colorButton.BackColor = c.Color;
                A_indicator.BackColor = c.Color;
                bg = c.Color;
            }
        }

        private void fore_colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            System.Windows.Forms.DialogResult myResult = new System.Windows.Forms.DialogResult();
            myResult = c.ShowDialog();
            if (myResult == System.Windows.Forms.DialogResult.OK)
            {
                fore_colorButton.BackColor = c.Color;
                wrn = c.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            System.Windows.Forms.DialogResult myResult = new System.Windows.Forms.DialogResult();
            myResult = c.ShowDialog();
            if (myResult == System.Windows.Forms.DialogResult.OK)
            {
                button1.BackColor = c.Color;
                wrn1 = c.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tebal =Convert.ToInt32(numericUpDown1.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void erase_button_Click(object sender, EventArgs e)
        {
            if (_commandStack.Count > 0)
            {
                while(_commandStack.Count > 0)
                {
                    // Remove the last command 
                    iCommand lastCommand = _commandStack.Pop();

                    // Call the Undo method
                    lastCommand.Undo(bg);

                }
                
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (_commandStack.Count > 0)
            {
                // Remove the last command 
                iCommand lastCommand = _commandStack.Pop();

                // Call the Undo method
                lastCommand.Undo(bg);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
            objGraphic = Graphics.FromImage(panel1.Image);
        }
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
            iCommand command;
            p = new Pen(wrn, tebal);
            sb = new SolidBrush(wrn1);
            if (shouldPaint == true)
            {
                if (line == true)
                {
                    command = new linecommand(initialX, initialY, p, e.X, e.Y, objGraphic);
                    command.Do();
                    _commandStack.Push(command);
                    A.pakairumushitung(new rumusgarisstrategy());
                }
                else if (rectang == true)
                {
                    command = new rectanglecommand(initialX, initialY, p, sb, e.X, e.Y, objGraphic);
                    command.Do();

                    _commandStack.Push(command);
                    A.pakairumushitung(new rumuspersegistrategy());
                }

                else if (circle == true)
                {
                    command = new circlecommand(initialX, initialY, p, sb, e.X, e.Y, objGraphic);
                    command.Do();
                    //circle c = new circle(initialX, initialY, p,sb, e.X, e.Y, objGraphic);
                    //c.draw();
 
                    _commandStack.Push(command);
                    A.pakairumushitung(new rumuslingkaranstrategy());
                }
                else 
                {
                    command = new trianglecommand(initialX, initialY, p,sb, e.X, e.Y, objGraphic);
                    command.Do();
                    _commandStack.Push(command);
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
                    Point A = new Point(initialX + ((e.X - initialX) / 2), initialY);
                    Point B = new Point(initialX + (e.X - initialX), initialY + (e.Y - initialY));
                    Point C = new Point(initialX, initialY + (e.Y - initialY));
                    selisihX = B.X - A.X;
                    selisihY = C.Y;
                }
                luas = Math.Round(Math.Abs(A.luas(e.X, e.Y, initialX, initialY)),2);
                W_Indicator.Text = selisihX.ToString();
                H_Indicator.Text = selisihY.ToString();
                A_indicator.Text = luas.ToString();
                panel1.Refresh();
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
