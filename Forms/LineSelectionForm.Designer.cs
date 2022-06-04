namespace Paint_bruh
{
    partial class LineSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineSelectionForm));
            this.pictureBoxStraightLine = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxVerticalLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorizontalLine = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStraightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerticalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorizontalLine)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStraightLine
            // 
            this.pictureBoxStraightLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStraightLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStraightLine.Image")));
            this.pictureBoxStraightLine.Location = new System.Drawing.Point(193, 12);
            this.pictureBoxStraightLine.Name = "pictureBoxStraightLine";
            this.pictureBoxStraightLine.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxStraightLine.TabIndex = 3;
            this.pictureBoxStraightLine.TabStop = false;
            this.pictureBoxStraightLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxStraightLine_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(198, 189);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBoxVerticalLine
            // 
            this.pictureBoxVerticalLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVerticalLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVerticalLine.Image")));
            this.pictureBoxVerticalLine.Location = new System.Drawing.Point(103, 12);
            this.pictureBoxVerticalLine.Name = "pictureBoxVerticalLine";
            this.pictureBoxVerticalLine.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxVerticalLine.TabIndex = 14;
            this.pictureBoxVerticalLine.TabStop = false;
            this.pictureBoxVerticalLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVerticalLine_MouseClick);
            // 
            // pictureBoxHorizontalLine
            // 
            this.pictureBoxHorizontalLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHorizontalLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHorizontalLine.Image")));
            this.pictureBoxHorizontalLine.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHorizontalLine.Name = "pictureBoxHorizontalLine";
            this.pictureBoxHorizontalLine.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxHorizontalLine.TabIndex = 15;
            this.pictureBoxHorizontalLine.TabStop = false;
            this.pictureBoxHorizontalLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHorizontalLine_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Horizontal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vertical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "2 Points";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(117, 189);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // LineSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHorizontalLine);
            this.Controls.Add(this.pictureBoxVerticalLine);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBoxStraightLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStraightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerticalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorizontalLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStraightLine;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxVerticalLine;
        private System.Windows.Forms.PictureBox pictureBoxHorizontalLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
    }
}