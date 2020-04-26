using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace draw_on_screen
{
    //this is the form where you are actually drawing at
    //place your buttons on this form aswell as on the other one

    public partial class Form1 : Form
    {
        Form3 canvas;

        public Form1()
        {
            InitializeComponent();
            canvas = new Form3();
            canvas.Show();
            Form2 shild = new Form2(this);
            shild.Show();
        }

        public void drawAt(Point p)
        {
            canvas.drawAt(p);
        }

        public void changeColor()
        {
            canvas.changeColor();
        }
    }
}
