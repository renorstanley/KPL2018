﻿namespace SimplePaint
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pen_button = new System.Windows.Forms.Button();
            this.pen_lv_combobox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.triangle = new System.Windows.Forms.Button();
            this.elips_button = new System.Windows.Forms.Button();
            this.rect_button = new System.Windows.Forms.Button();
            this.line_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fore_colorButton = new System.Windows.Forms.Button();
            this.bg_colorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.erase_button = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.y_indicator = new System.Windows.Forms.TextBox();
            this.x_indicator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(164, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 516);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pen_button);
            this.panel2.Controls.Add(this.pen_lv_combobox);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 93);
            this.panel2.TabIndex = 1;
            // 
            // pen_button
            // 
            this.pen_button.Location = new System.Drawing.Point(0, 36);
            this.pen_button.Name = "pen_button";
            this.pen_button.Size = new System.Drawing.Size(158, 23);
            this.pen_button.TabIndex = 2;
            this.pen_button.Text = "use pen";
            this.pen_button.UseVisualStyleBackColor = true;
            // 
            // pen_lv_combobox
            // 
            this.pen_lv_combobox.FormattingEnabled = true;
            this.pen_lv_combobox.Location = new System.Drawing.Point(0, 65);
            this.pen_lv_combobox.Name = "pen_lv_combobox";
            this.pen_lv_combobox.Size = new System.Drawing.Size(158, 21);
            this.pen_lv_combobox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Pens";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.triangle);
            this.panel3.Controls.Add(this.elips_button);
            this.panel3.Controls.Add(this.rect_button);
            this.panel3.Controls.Add(this.line_button);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 72);
            this.panel3.TabIndex = 3;
            // 
            // triangle
            // 
            this.triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle.BackgroundImage")));
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangle.Location = new System.Drawing.Point(123, 36);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(32, 30);
            this.triangle.TabIndex = 5;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // elips_button
            // 
            this.elips_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("elips_button.BackgroundImage")));
            this.elips_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elips_button.Location = new System.Drawing.Point(86, 36);
            this.elips_button.Name = "elips_button";
            this.elips_button.Size = new System.Drawing.Size(31, 29);
            this.elips_button.TabIndex = 4;
            this.elips_button.UseVisualStyleBackColor = true;
            this.elips_button.Click += new System.EventHandler(this.elips_button_Click);
            // 
            // rect_button
            // 
            this.rect_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rect_button.BackgroundImage")));
            this.rect_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rect_button.Location = new System.Drawing.Point(48, 36);
            this.rect_button.Name = "rect_button";
            this.rect_button.Size = new System.Drawing.Size(32, 29);
            this.rect_button.TabIndex = 3;
            this.rect_button.UseVisualStyleBackColor = true;
            this.rect_button.Click += new System.EventHandler(this.rect_button_Click);
            // 
            // line_button
            // 
            this.line_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line_button.BackgroundImage")));
            this.line_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line_button.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.line_button.Location = new System.Drawing.Point(12, 36);
            this.line_button.Name = "line_button";
            this.line_button.Size = new System.Drawing.Size(30, 29);
            this.line_button.TabIndex = 2;
            this.line_button.UseVisualStyleBackColor = true;
            this.line_button.Click += new System.EventHandler(this.line_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 30);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Shapes";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.fore_colorButton);
            this.panel4.Controls.Add(this.bg_colorButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(0, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 106);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(105, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 19);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "2D Filler";
            // 
            // fore_colorButton
            // 
            this.fore_colorButton.BackColor = System.Drawing.Color.Black;
            this.fore_colorButton.Location = new System.Drawing.Point(105, 56);
            this.fore_colorButton.Name = "fore_colorButton";
            this.fore_colorButton.Size = new System.Drawing.Size(33, 19);
            this.fore_colorButton.TabIndex = 3;
            this.fore_colorButton.UseVisualStyleBackColor = false;
            // 
            // bg_colorButton
            // 
            this.bg_colorButton.BackColor = System.Drawing.Color.White;
            this.bg_colorButton.Location = new System.Drawing.Point(105, 37);
            this.bg_colorButton.Name = "bg_colorButton";
            this.bg_colorButton.Size = new System.Drawing.Size(33, 19);
            this.bg_colorButton.TabIndex = 0;
            this.bg_colorButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "InUsePaint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "BackGround";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 30);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Coloration";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.erase_button);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Location = new System.Drawing.Point(0, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 63);
            this.panel5.TabIndex = 4;
            // 
            // erase_button
            // 
            this.erase_button.Location = new System.Drawing.Point(3, 31);
            this.erase_button.Name = "erase_button";
            this.erase_button.Size = new System.Drawing.Size(152, 32);
            this.erase_button.TabIndex = 5;
            this.erase_button.Text = "erase";
            this.erase_button.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 30);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "miscellanous";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.y_indicator);
            this.panel6.Controls.Add(this.x_indicator);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Location = new System.Drawing.Point(3, 369);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 121);
            this.panel6.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(37, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 26);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Coordinates";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "A";
            // 
            // y_indicator
            // 
            this.y_indicator.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.y_indicator.Location = new System.Drawing.Point(37, 61);
            this.y_indicator.Name = "y_indicator";
            this.y_indicator.Size = new System.Drawing.Size(121, 26);
            this.y_indicator.TabIndex = 6;
            this.y_indicator.Text = "Coordinates";
            this.y_indicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_indicator
            // 
            this.x_indicator.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.x_indicator.Location = new System.Drawing.Point(37, 36);
            this.x_indicator.Name = "x_indicator";
            this.x_indicator.Size = new System.Drawing.Size(121, 26);
            this.x_indicator.TabIndex = 5;
            this.x_indicator.Text = "Coordinates";
            this.x_indicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 30);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Size Summary";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 513);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Display";
            this.Text = "SimplePaint";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pen_button;
        private System.Windows.Forms.ComboBox pen_lv_combobox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button elips_button;
        private System.Windows.Forms.Button rect_button;
        private System.Windows.Forms.Button line_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fore_colorButton;
        private System.Windows.Forms.Button bg_colorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button erase_button;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox y_indicator;
        private System.Windows.Forms.TextBox x_indicator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

