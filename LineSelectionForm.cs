using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint_bruh
{
    public partial class LineSelectionForm : Form
    {
        public LineSelectionForm()
        {
            InitializeComponent();   

            AddButons();;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureBoxHorizontalLine_MouseClick(object sender, MouseEventArgs e)
        {
            FormScene.lineIndex = 1;
        }
        private void pictureBoxVerticalLine_MouseClick(object sender, MouseEventArgs e)
        {
            FormScene.lineIndex = 2;
        }

        private void pictureBoxStraightLine_MouseClick(object sender, MouseEventArgs e)
        {
            FormScene.lineIndex = 3;
        }

        void AddButons()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();

            pictureBoxes.Add(pictureBoxVerticalLine);
            pictureBoxes.Add(pictureBoxStraightLine);
            pictureBoxes.Add(pictureBoxHorizontalLine);

            foreach (var pb in pictureBoxes)
            {
                pb.MouseHover += (s, e) => pb.BackColor = Color.FromArgb(186, 180, 179);
                pb.MouseLeave += (s, e) => pb.BackColor = Color.White;
            }
        }
    }
}
