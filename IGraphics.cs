using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_bruh
{
    public interface IGraphics
    {
        void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height);

        void DrawEllipse(Color colorBorder, Color colorFill, int x, int y, int radius1, int radius2);

        void DrawStraightLine(Color colorBorder, Color colorFill, int x, int y, int width, int height, Point first, Point last);

        void DrawTriangle(Color colorBorder, Color colorFill, Point a, Point b, Point c);

    }
}
