using System;
using System.Windows.Forms;
using PaintBruhLibrary;

using StraightLine = PaintBruhLibrary.StraightLine;

namespace Paint_bruh
{
    public partial class FormStraightLine : Form
    {
        private StraightLine _straightLine;

        public StraightLine straightLine
        {
            get
            {
                return _straightLine;
            }
            set
            {
                _straightLine = value;

                textBoxX.Text = _straightLine.location.X.ToString();
                textBoxY.Text = _straightLine.location.Y.ToString();

                textBoxWidth.Text = _straightLine.width.ToString();
                textBoxHeight.Text = _straightLine.height.ToString();

                buttonColor.BackColor = straightLine.colorFill;

                textBoxArea.Text = _straightLine.area.ToString();
            }
        }

        public FormStraightLine()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            straightLine.colorBorder = buttonColor.BackColor;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }
    }
}
