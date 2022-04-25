﻿using System;
using System.Drawing;
using Paint_bruh.Exceptions;

namespace Paint_bruh
{
    [Serializable]
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public override int shapeNumber { get => 1; }

        public override float area { get => width * height; }

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

        public override void PaintShape(IGraphics graphics)
        {
            var selectedColorBorder = isSelected
                ? FormScene.newColor
                : colorBorder;

            graphics.DrawRectangle(selectedColorBorder, colorFill, location.X, location.Y, width, height);
        }

        public override bool PointInShape(Point point)
        {
            return
                location.X <= point.X && point.X <= location.X + width &&
                location.Y <= point.Y && point.Y <= location.Y + height;
        }
    }
}
