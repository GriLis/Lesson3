using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1210
{
    class MyPoint
    {

        public MyPoint()
        {
            X = 0;
            Y = 0;
        }

        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

    }
}
