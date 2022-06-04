using System;
using System.Windows.Forms;
using PaintBruhLibrary;

namespace Paint_bruh
{
    public partial class FormEllipse : Form
    {
        private Ellipse _ellipse;

        public Ellipse ellipse
        {
            get
            {
                return _ellipse;
            }
            set
            {
                _ellipse = value;

                textBoxX.Text = ellipse.location.X.ToString();
                textBoxY.Text = ellipse.location.Y.ToString();

                textBoxRadius1.Text = ellipse.radius1.ToString();
                textBoxRadius2.Text = ellipse.radius2.ToString();
                textBoxArea.Text = ellipse.area.ToString();

                buttonColor.BackColor = ellipse.colorFill;
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
                if (textBoxRadius1.Text == "0" || textBoxRadius2.Text == "0")
                {
                    MessageBox.Show("Value can't be 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }

                ellipse.radius1 = int.Parse(textBoxRadius1.Text);
                ellipse.radius2 = int.Parse(textBoxRadius2.Text);
                ellipse.colorFill = buttonColor.BackColor;
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
