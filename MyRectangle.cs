using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar1210
{
    class MyRectangle : MyFigure
    {
        int width, height;

        public MyRectangle(int x1, int y1, int x2, int y2)
        {
            x = x1;
            y = y1;
            int xx = x2;
            int yy = y2;
             
            if(xx < x && yy < y)
            {
                width = Math.Abs(xx - x);
                height = Math.Abs(yy - y);
                x = xx;
                y = yy;
            }
            else if(x < xx && y > yy)
            {
                width = Math.Abs(xx - x);
                height = Math.Abs(yy - y);
                y = yy;
            }
            else if(x > xx && y < yy)
            {
                width = Math.Abs(xx - x);
                height = Math.Abs(yy - y);
                x = xx;
            }
            else
            {
                width = xx - x;
                height = yy - y;
            }
        }

        public override void Draw(Graphics gr)
        {
            var pen1 = new Pen(Form1.MainColor, 2);
            gr.DrawRectangle(pen1, x, y, width, height);
        }

        //needs method isinside and move overrides
    }
}
