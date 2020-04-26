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
    public partial class Form3 : Form
    {
        Color c;

        public Form3()
        {
            InitializeComponent();

            c = Color.Blue;
        }

        public void drawAt(Point p)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawEllipse(new Pen(c), p.X - 2, p.Y - 2, 4, 4);
            }
        }

        public void changeColor()
        {
            if (c == Color.Blue)
            {
                c = Color.Fuchsia;
            }
            else
            {
                c = Color.Blue;
            }
        }
    }
}
