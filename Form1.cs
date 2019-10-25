using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar1210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainColor = Color.Black;
        }

        public static Color MainColor = new Color();

        int fid = 1;

        Graphics gr;
        
        int p1x, p1y, p2x, p2y;

        List<MyFigure> figs = new List<MyFigure>();

        private void RectBtn_Click(object sender, EventArgs e)
        {
            fid = 1;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            fid = 2;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            p1x = e.X;
            p1y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            p2x = e.X;
            p2y = e.Y;
            DrawFigure(fid);
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                MainColor = colorDialog1.Color;
            colorBtn.BackColor = MainColor;
        }

        void DrawFigure(int id)
        {
            gr = panel1.CreateGraphics();

            switch (id)
            {
                case 1:

                    MyRectangle rect = new MyRectangle(p1x, p1y, p2x, p2y);
                    figs.Add(rect);
                    rect.Draw(gr);

                    break;

                case 2:

                    int cx, cy;
                    double r = Math.Sqrt(Math.Pow(p2x - p1x, 2) + Math.Pow(p2y - p1y, 2));
                    cx = p1x - (int)r;
                    cy = p1y - (int)r;
                    MyCircle circ = new MyCircle(cx, cy, r);
                    figs.Add(circ);
                    circ.Draw(gr);

                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (MyFigure rect in figs)
            {
                rect.Draw(gr);
            }
        }

        private bool IsOnFigure(int x, int y)
        {
            return false;
        }
    }
}
