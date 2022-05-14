using System;
using System.Windows.Forms;
using PaintBruhLibrary;

namespace Paint_bruh
{
    public partial class FormEllipse : Form
    {
        private Ellipse _ellipse;

        public Ellipse Ellipse
        {
            get
            {
                return _ellipse;
            }
            set
            {
                _ellipse = value;

                textBoxX.Text = Ellipse.location.X.ToString();
                textBoxY.Text = Ellipse.location.Y.ToString();

                textBoxRadius1.Text = Ellipse.radius1.ToString();
                textBoxRadius2.Text = Ellipse.radius2.ToString();

                textBoxArea.Text = Ellipse.area.ToString();

                buttonColor.BackColor = Ellipse.colorFill;
            }
        }

        public FormEllipse()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Ellipse.radius1 = int.Parse(textBoxRadius1.Text);
                Ellipse.radius2 = int.Parse(textBoxRadius2.Text);
                Ellipse.colorFill = buttonColor.BackColor;
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
