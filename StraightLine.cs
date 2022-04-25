using System;
using System.Drawing;
using Paint_bruh.Exceptions;

namespace Paint_bruh
{
    [Serializable]
    public class StraightLine : Shape
    {
        private int _width;
        private int _height;

        protected internal Point firstPoint { get; set; }
        protected internal Point lastPoint { get; set; }

        protected internal int width
        {
            get => _width;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Number must be positive!");

                _width = value;
            }
        }

        protected internal int height
        {
            get => _height;

            set
            {
                if (value < 0)
                    throw new InvalidValueException("Number must be positive!");

                _height = value;
            }
        }

        public override int shapeNumber { get => 4; }

        public override float area { get => (float)(width * height); }

        public override void PaintShape(Graphics graphics)
        {
            var selectedColorBorder = isSelected
                ? FormScene.newColor
                : colorBorder;

            using (var brush = new SolidBrush(colorFill))
                graphics.FillRectangle(brush, location.X, location.Y, width, height);

            using (var pen = new Pen(selectedColorBorder, 2))
                graphics.DrawRectangle(pen, location.X, location.Y, width, height);

            using (var pen = new Pen(selectedColorBorder, 2))
                graphics.DrawLine(pen, firstPoint, lastPoint); //pravi prava liniq s nachalna i kraina tochka
        }

        public override bool PointInShape(Point point)
        {
            return
                location.X <= point.X && point.X <= location.X + width &&
                location.Y <= point.Y && point.Y <= location.Y + height;
        }
    }
}
