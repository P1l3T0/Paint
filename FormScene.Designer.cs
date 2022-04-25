﻿namespace Paint_bruh
{
    partial class FormScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScene));
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.pictureBoxStraightLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBaclgroundColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCursor = new System.Windows.Forms.PictureBox();
            this.pictureBoxPalette = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStraightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCircle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCircle.Image")));
            this.pictureBoxCircle.Location = new System.Drawing.Point(84, 9);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxCircle.TabIndex = 0;
            this.pictureBoxCircle.TabStop = false;
            this.pictureBoxCircle.Click += new System.EventHandler(this.pictureBoxCircle_Click);
            // 
            // pictureBoxStraightLine
            // 
            this.pictureBoxStraightLine.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStraightLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStraightLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStraightLine.Image")));
            this.pictureBoxStraightLine.Location = new System.Drawing.Point(246, 9);
            this.pictureBoxStraightLine.Name = "pictureBoxStraightLine";
            this.pictureBoxStraightLine.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxStraightLine.TabIndex = 2;
            this.pictureBoxStraightLine.TabStop = false;
            this.pictureBoxStraightLine.Click += new System.EventHandler(this.pictureBoxStraightLine_Click);
            // 
            // pictureBoxTriangle
            // 
            this.pictureBoxTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTriangle.Image")));
            this.pictureBoxTriangle.Location = new System.Drawing.Point(165, 9);
            this.pictureBoxTriangle.Name = "pictureBoxTriangle";
            this.pictureBoxTriangle.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxTriangle.TabIndex = 3;
            this.pictureBoxTriangle.TabStop = false;
            this.pictureBoxTriangle.Click += new System.EventHandler(this.pictureBoxTriangle_Click);
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRectangle.Image")));
            this.pictureBoxRectangle.Location = new System.Drawing.Point(3, 9);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxRectangle.TabIndex = 4;
            this.pictureBoxRectangle.TabStop = false;
            this.pictureBoxRectangle.Click += new System.EventHandler(this.pictureBoxRectangle_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1150, 21);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 33);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.buttonColor);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonBaclgroundColor);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBoxPalette);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 113);
            this.panel2.TabIndex = 8;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.White;
            this.buttonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonColor.Location = new System.Drawing.Point(328, 32);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(50, 50);
            this.buttonColor.TabIndex = 15;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(1150, 63);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 33);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBaclgroundColor
            // 
            this.buttonBaclgroundColor.BackColor = System.Drawing.Color.White;
            this.buttonBaclgroundColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBaclgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaclgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaclgroundColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBaclgroundColor.Location = new System.Drawing.Point(403, 32);
            this.buttonBaclgroundColor.Name = "buttonBaclgroundColor";
            this.buttonBaclgroundColor.Size = new System.Drawing.Size(50, 50);
            this.buttonBaclgroundColor.TabIndex = 13;
            this.buttonBaclgroundColor.Text = "background";
            this.buttonBaclgroundColor.UseVisualStyleBackColor = false;
            this.buttonBaclgroundColor.Click += new System.EventHandler(this.buttonBackgroundColor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxCursor);
            this.panel1.Controls.Add(this.pictureBoxRectangle);
            this.panel1.Controls.Add(this.pictureBoxCircle);
            this.panel1.Controls.Add(this.pictureBoxStraightLine);
            this.panel1.Controls.Add(this.pictureBoxTriangle);
            this.panel1.Location = new System.Drawing.Point(708, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 89);
            this.panel1.TabIndex = 11;
            // 
            // pictureBoxCursor
            // 
            this.pictureBoxCursor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCursor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCursor.Image")));
            this.pictureBoxCursor.Location = new System.Drawing.Point(327, 9);
            this.pictureBoxCursor.Name = "pictureBoxCursor";
            this.pictureBoxCursor.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxCursor.TabIndex = 7;
            this.pictureBoxCursor.TabStop = false;
            this.pictureBoxCursor.Click += new System.EventHandler(this.pictureBoxCursor_Click);
            // 
            // pictureBoxPalette
            // 
            this.pictureBoxPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPalette.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPalette.Image")));
            this.pictureBoxPalette.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPalette.Name = "pictureBoxPalette";
            this.pictureBoxPalette.Size = new System.Drawing.Size(319, 109);
            this.pictureBoxPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPalette.TabIndex = 10;
            this.pictureBoxPalette.TabStop = false;
            this.pictureBoxPalette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPalette_MouseClick);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormScene";
            this.Text = "Paint bruh (vektorna grafika edition)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStraightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCircle;
        private System.Windows.Forms.PictureBox pictureBoxStraightLine;
        private System.Windows.Forms.PictureBox pictureBoxTriangle;
        private System.Windows.Forms.PictureBox pictureBoxRectangle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxPalette;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBaclgroundColor;
        private System.Windows.Forms.PictureBox pictureBoxCursor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonColor;
    }
}

