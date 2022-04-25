using System;
using System.Drawing;
using Paint_bruh.Exceptions;

namespace Paint_bruh
{
    [Serializable]
    public class Triangle : Shape
    {
        private int _side;

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public override int shapeNumber { get => 3; }

        public override float area { get => (float)(Math.Sqrt(3) / 4 * Math.Pow(side, 2)); }

        protected internal int side
        {
            get => _side;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Number must be positive!");

                _side = value;
            }
        }

        public override void PaintShape(IGraphics graphics)
        { 
            var selectedColorBorder = isSelected
                ? FormScene.newColor
                : colorBorder;

            graphics.DrawTriangle(selectedColorBorder, colorFill, A, B, C);
        }

        public override bool PointInShape(Point point)
        {
            var side1 = (A.X - C.X) * (point.Y - C.Y) - (A.Y - C.Y) * (point.X - C.X);
            var side2 = (B.X - A.X) * (point.Y - A.Y) - (B.Y - A.Y) * (point.X - A.X);

            if ((side1 < 0) != (side2 < 0) && side1 != 0 && side2 != 0)
                return false;

            var side3 = (C.X - B.X) * (point.Y - B.Y) - (C.Y - B.Y) * (point.X - B.X);

            return side3 == 0 || (side3 < 0) == (side1 + side2 <= 0);
        }
    }
}
