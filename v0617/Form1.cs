using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        int vx = -10, vy = -10;
        int score = 100;
        string temp, face = "('ω')";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            score--;

            label2.Text = "score " + score;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
                temp = label1.Text;
                label1.Text = face;
                face = temp;
            }

            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
                temp = label1.Text;
                label1.Text = face;
                face = temp;
            }

            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
                temp = label1.Text;
                label1.Text = face;
                face = temp;
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
                temp = label1.Text;
                label1.Text = face;
                face = temp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
