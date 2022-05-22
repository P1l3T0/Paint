using System;
using System.Windows.Forms;
using PaintBruhLibrary;

namespace Paint_bruh
{
    public partial class FormRecangle : Form
    {
        private Rectangles _rectangle;
        public Rectangles Rectangle 
        {
            get => _rectangle;
            
            set
            {
                _rectangle = value;

                textBoxX.Text = _rectangle.location.X.ToString();
                textBoxY.Text = _rectangle.location.Y.ToString();

                textBoxWidth.Text = _rectangle.width.ToString();
                textBoxHeight.Text = _rectangle.height.ToString();
                textBoxArea.Text = _rectangle.area.ToString();

                buttonColor.BackColor = Rectangle.colorFill;
            }
        }

        public FormRecangle()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle.width = int.Parse(textBoxWidth.Text);
                Rectangle.height = int.Parse(textBoxHeight.Text);
                Rectangle.colorFill = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
