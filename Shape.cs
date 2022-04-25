using System;
using System.Drawing;
//using Paint_bruh.Exceptions;

namespace Paint_bruh
{
    [Serializable]
    public abstract class Shape
    {
        protected internal Point location { get; set; }

        public Color colorBorder { get; set; }

        public Color colorFill { get; set; }

        public virtual float area { get; }

        public virtual int shapeNumber { get; set; }

        [NonSerialized]
        private bool _isSelected;
        public bool isSelected
        {
            get => _isSelected;
            set => _isSelected = value;
        }

        public abstract void PaintShape(Graphics graphics);

        public abstract bool PointInShape(Point point);
    }
}
