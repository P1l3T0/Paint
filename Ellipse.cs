using System;
using System.Drawing;
using Paint_bruh.Exceptions;

namespace Paint_bruh
{
    [Serializable]
    public class Ellipse : Shape
    {
        private int _radius1;
        private int _radius2;

        protected internal int radius1
        {
            get => _radius1;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Number must be positive!");

                _radius1 = value;
            }
        }

        protected internal int radius2
        {
            get => _radius2;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Number must be positive!");

                _radius2 = value;
            }
        }

        public override int shapeNumber { get => 2; }

        public override float area { get => (float)(Math.PI * Math.Pow(radius1 + radius2, 2)); }

        public override void PaintShape(Graphics graphics)
        {
            var selectedColorBorder = isSelected
                ? FormScene.newColor
                : colorBorder;

            using (var brush = new SolidBrush(colorFill))
                graphics.FillEllipse(brush, location.X, location.Y, radius1, radius2);

            using (var pen = new Pen(selectedColorBorder, 5))
                graphics.DrawEllipse(pen, location.X, location.Y, radius1, radius2);
        }

        public override bool PointInShape(Point point)
        {
            return
                location.X <= point.X && point.X <= location.X + radius1 &&
                location.Y <= point.Y && point.Y <= location.Y + radius2;
        }
    }
}
