using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT_1
{
    public struct Point2D
    {
        int x;
        int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return String.Format("[{0};{1}]", x, y);
        }
    }
}
