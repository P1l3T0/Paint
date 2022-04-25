using System;
using System.Windows.Forms;

namespace Paint_bruh
{
    public partial class FormTriangle : Form
    {
        private Triangle _triangle;

        public Triangle triangle
        {
            get
            {
                return _triangle;
            }
            set
            {
                _triangle = value;

                textBoxA.Text = triangle.A.ToString();
                textBoxB.Text = triangle.B.ToString();
                textBoxC.Text = triangle.C.ToString();

                textBoxSide.Text = triangle.side.ToString();

                textBoxArea.Text = triangle.area.ToString();

                buttonColor.BackColor = triangle.colorFill;
            }
        }
        public FormTriangle()
        {
            InitializeComponent();
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            try
            {
                triangle.side = int.Parse(textBoxSide.Text);
                triangle.colorFill = buttonColor.BackColor;
            }
            catch
            {
                MessageBox.Show("Invalid Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = cd.Color;
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            FormScene.moveA = true;
            FormScene.moveB = false;
            FormScene.moveC = false;
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            FormScene.moveA = false;
            FormScene.moveB = true;
            FormScene.moveC = false;
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            FormScene.moveA = false;
            FormScene.moveB = false;
            FormScene.moveC = true;
        }
    }
}