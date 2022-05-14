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
            List<PictureBox> pb = new List<PictureBox>
            {
                pictureBoxVerticalLine,
                pictureBoxStraightLine,
                pictureBoxHorizontalLine
            };

            pb.ForEach(x => x.MouseHover += (c, e) => x.BackColor = Color.FromArgb(186, 180, 179));
            pb.ForEach(x => x.MouseLeave += (c, e) => x.BackColor = Color.White);
        }
    }
}
