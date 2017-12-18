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
        Boolean line, rectang, circle, trangle,freehand=true;
        double px, py, vector;
        Point lastPoint = Point.Empty;
        bool isMouseDown = new Boolean();

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
            _bitmap = new Bitmap(1920, 1080);
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
                panel1.BackColor = c.Color;
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
                    iCommand lastCommand = _commandStack.Pop();
                 
                        lastCommand.Undo();
                }
                panel1.Refresh();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (_commandStack.Count > 0)
            {
                // Remove the last command 
                iCommand lastCommand = _commandStack.Pop();
               
                //jika command adalah freehandcommand
                if (Convert.ToString(lastCommand).Contains("freehand"))
                {
                    while (Convert.ToString(lastCommand).Contains("freehand")&& _commandStack.Count>0)
                    {
                        lastCommand.Undo();
                        lastCommand = _commandStack.Pop();
                        //jika ternyata lastcommand tidak freehand lagi
                        if (!Convert.ToString(lastCommand).Contains("freehand"))
                        {
                            //kembalikan ke stack
                            _commandStack.Push(lastCommand);
                        }
                    }
                   
                }
                else
                    lastCommand.Undo();
                panel1.Refresh();
               
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
            freehand = false;
        }
        //membuat point 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                shouldPaint = true;
                initialX = e.X;initialY = e.Y;
                lastPoint = e.Location;
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            iCommand command;
            p = new Pen(wrn, tebal);
            if (isMouseDown == true)//check to see if the mouse button is down
            {
                if (freehand == true)//if our last point is not null, which in this case we have assigned above
                {                    
                  
                    command = new freehandcommand(lastPoint, e.Location, p, objGraphic, _bitmap);
                    command.Do();
                    _commandStack.Push(command);
                    panel1.Refresh();//refreshes the picturebox
                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position
                    
                }

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
                    
                    command = new linecommand(initialX, initialY, p, e.X, e.Y, objGraphic, _bitmap);
                    command.Do();
                    _commandStack.Push(command);
                    A.pakairumushitung(new rumusgarisstrategy());
                    
                }
                else if (rectang == true)
                {
                    
                    command = new rectanglecommand(initialX, initialY, p, sb, e.X, e.Y, objGraphic, _bitmap);
                    command.Do();

                    _commandStack.Push(command);
                    A.pakairumushitung(new rumuspersegistrategy());
                    
                }

                else if (circle == true)
                {
                    command = new circlecommand(initialX, initialY, p, sb, e.X, e.Y, objGraphic, _bitmap);
                    command.Do();
                    //circle c = new circle(initialX, initialY, p,sb, e.X, e.Y, objGraphic);
                    //c.draw();
 
                    _commandStack.Push(command);
                    A.pakairumushitung(new rumuslingkaranstrategy());
                }
                else if (trangle == true)
                {
                    
                    command = new trianglecommand(initialX, initialY, p,sb, e.X, e.Y, objGraphic, _bitmap);
                    command.Do();
                    _commandStack.Push(command);
                    A.pakairumushitung(new rumustrianglestrategy());
                    
                }
                else
                {
                    //do nothing
                }

                if(freehand == false)
                {
                    int selisihX, selisihY;
                    if (circle == true || rectang == true || line == true)
                    {
                        selisihX = Math.Abs(e.X - initialX);
                        selisihY = Math.Abs(e.Y - initialY);
                    }
                    else
                    {
                        Point A = new Point(initialX + ((e.X - initialX) / 2), initialY);
                        Point B = new Point(initialX + (e.X - initialX), initialY + (e.Y - initialY));
                        Point C = new Point(initialX, initialY + (e.Y - initialY));
                        selisihX = B.X - A.X;
                        selisihY = C.Y;
                    }
                    luas = Math.Round(Math.Abs(A.luas(e.X, e.Y, initialX, initialY)), 2);
                    W_Indicator.Text = selisihX.ToString();
                    H_Indicator.Text = selisihY.ToString();
                    A_indicator.Text = luas.ToString();
                }
                
                panel1.Refresh();
                }
                shouldPaint = false;
                isMouseDown = false;
                lastPoint = Point.Empty;


        }
        private void pen_button_Click(object sender, EventArgs e)
        {
            reset();
            buttoncolor();
            freehand = true;
        }

        private void rect_button_Click(object sender, EventArgs e)
        {
            reset();
            rectang = true;
            buttoncolor();
            changinglabel.Text = "A";
        }
        private void line_button_Click(object sender, EventArgs e)
        {
            reset();
            line = true;
            buttoncolor();
            changinglabel.Text = "D";
        }
        private void elips_button_Click(object sender, EventArgs e)
        {
            reset();
            circle = true;
            buttoncolor();
            changinglabel.Text = "A";
        }
        private void trianglebutton_click(object sender, MouseEventArgs e)
        {
            reset();
            trangle = true;
            buttoncolor();
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
