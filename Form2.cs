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
    public partial class Form2 : Form
    {
        Form1 parent;

        bool draw;

        public Form2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();

            draw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.changeColor();
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                parent.drawAt(e.Location);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
