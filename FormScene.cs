using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using PaintBruhLibrary;

namespace Paint_bruh
{
    public partial class FormScene : Form, IGraphics
    { 
        //listi figyri
        List<Shape> shapes = new List<Shape>(); //list of vsichki figyri
        List<Triangle> triangles = new List<Triangle>(); //list samo ot triugulnici (trqbva mi za da gi murdam, leko e zaburkano)

        //ramki
        Rectangles frameRectangle; 
        Ellipse frameEllipse;
        Triangle frameTriangle;
        StraightLine frameStraightLine;

        //ne znam kakuv komentar da sloja tyk
        Point mouseLocation; //lokaciqta na mishkata v realno vreme
        public static Color newColor; //cvqt za ramkite i moliva

        Graphics onPaintGraphics; //grafichen obekt, s koito prechertavam figyrite

        //raboti za moliv/kartinka
        Bitmap bitmap; //bitmap koito mi trqbva za razmerite na kartinite
        Graphics graphics; //grafichen obekt za izchertavane na liniq kato moliv (trqbva mi i ne moga da polzvam onPaintGraphis) :(
        bool canDraw; //da proverqva dali zadurjam mishakta

        //chast ot informaciqta za figyri (nyjna mi e)
        int buttonIndex; //indeksa na daden byton za figyra
        bool isShapeMoving; //dali se murda figyra
        public static int lineIndex; //indeksa na horizontalna/vertikalna/2Point liniq 🐣
        public static bool moveA, moveB, moveC; //murdane ne triugulnik, raboti po mnogo inovativen i ynikalen nachin ;) 

        public FormScene()
        {
            InitializeComponent();

            Buttons();
            BitmapImage();
            FixDialogBox();           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            onPaintGraphics = e.Graphics;

            foreach (var s in shapes)
                s.PaintShape(this);

            frameRectangle?.PaintShape(this);
            frameEllipse?.PaintShape(this);
            frameTriangle?.PaintShape(this);
            frameStraightLine?.PaintShape(this);

            onPaintGraphics = null;
        }

        private void PictureBoxScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //klikash s mishkata i suzdava ramkata na selektiranata figyra
            {
                canDraw = true;
                mouseLocation = e.Location;

                switch (buttonIndex)
                {
                    default:
                        return;

                    case 1:
                        frameRectangle = new Rectangles(newColor) { colorBorder = newColor };
                        break;

                    case 2:
                        frameEllipse = new Ellipse(newColor) { colorBorder = newColor };
                        break;

                    case 3:
                        frameTriangle = new Triangle(newColor) { colorBorder = newColor };
                        break;

                    case 4:
                        frameStraightLine = new StraightLine(newColor) { colorBorder = newColor };
                        break;
                }
            }
            else
            {
                var unselectShapes = shapes
                                    .Take(shapes.Count())
                                    .ToList();
                unselectShapes.ForEach(s => s.isSelected = false); //figyrata se deselktira sled kato kliknesh izvun neq

                for (int s = shapes.Count() - 1; s >= 0; s--)
                    if (shapes[s].PointInShape(e.Location))
                    {
                        shapes[s].isSelected = true;
                        break;
                    }
            }
        }

        private void PictureBoxScene_MouseMove(object sender, MouseEventArgs e)
        {
            isShapeMoving = true;

            Pen pen = new Pen(newColor, 5)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };

            switch (buttonIndex)
            {
                case 5:
                    if (canDraw)
                    {
                        Point pointX = e.Location;
                        graphics.DrawLine(pen, pointX, mouseLocation);
                        mouseLocation = pointX;
                    }
                    break;

                case 6:
                    if (e.Button == MouseButtons.Left)
                    {
                        for (int i = shapes.Count() - 1; i >= 0; i--) //murdane na figyrite s mishkata
                            if (shapes[i].isSelected && isShapeMoving)
                                shapes[i].location = e.Location;
                            else 
                                shapes[i].isSelected = false;

                        for (int i = triangles.Count() - 1; i >= 0; i--) //murdane na triugulnicite po mnogo inovativen nachin bruh
                            if (triangles[i].isSelected)
                            {
                                if (moveA)
                                    triangles[i].A = e.Location;
                                else if (moveB)
                                    triangles[i].B = e.Location;
                                else if (moveC)
                                    triangles[i].C = e.Location;
                            }
                    }
                    break;
            }

            if (frameRectangle != null) //koordinati, razmeri i tochki na novosuzdadenite figyri
            {
                frameRectangle.location = new Point
                {
                    X = Math.Min(mouseLocation.X, e.Location.X),
                    Y = Math.Min(mouseLocation.Y, e.Location.Y),
                };

                frameRectangle.width = Math.Abs(mouseLocation.X - e.Location.X);
                frameRectangle.height = Math.Abs(mouseLocation.Y - e.Location.Y);
            }

            if (frameEllipse != null)
            {
                frameEllipse.location = new Point
                {
                    X = Math.Min(mouseLocation.X, e.Location.X),
                    Y = Math.Min(mouseLocation.Y, e.Location.Y)
                };

                frameEllipse.radius1 = Math.Abs(mouseLocation.X - e.Location.X);
                frameEllipse.radius2 = Math.Abs(mouseLocation.Y - e.Location.Y);
            }

            if (frameTriangle != null)
            {
                frameTriangle.location = new Point
                {
                    X = Math.Min(mouseLocation.X, e.Location.X),
                    Y = Math.Min(mouseLocation.Y, e.Location.Y)
                };

                float mid = (mouseLocation.X + e.Location.X) / 2;

                Point a = new Point(mouseLocation.X, mouseLocation.Y);
                Point b = new Point((int)mid, e.Location.Y);
                Point c = new Point(e.Location.X, mouseLocation.Y);

                frameTriangle.A = a;
                frameTriangle.B = b;
                frameTriangle.C = c;

                frameTriangle.side = Math.Abs(mouseLocation.X - e.Location.X);
            }

            if (frameStraightLine != null)
                switch (lineIndex)
                {
                    default: return;

                    case 1:
                        frameStraightLine.location = new Point
                        {
                            X = Math.Min(mouseLocation.X, e.Location.X),
                            Y = Math.Min(mouseLocation.Y, mouseLocation.Y)
                        };

                        frameStraightLine.width = Math.Abs(mouseLocation.X - e.Location.X);
                        frameStraightLine.height = 1;
                    break;

                    case 2:
                        frameStraightLine.location = new Point
                        {
                            X = Math.Min(mouseLocation.X, mouseLocation.X),
                            Y = Math.Min(mouseLocation.Y, e.Location.Y)
                        };

                        frameStraightLine.width = 1;
                        frameStraightLine.height = Math.Abs(mouseLocation.Y - e.Location.Y);
                    break;

                    case 3:
                        frameStraightLine.location = new Point
                        {
                            X = Math.Min(mouseLocation.X, e.Location.X),
                            Y = Math.Min(mouseLocation.Y, e.Location.Y)
                        };

                        Point start = new Point(mouseLocation.X, mouseLocation.Y);
                        Point end = new Point(e.Location.X, e.Location.Y);

                        frameStraightLine.firstPoint = start;
                        frameStraightLine.lastPoint = end;
                    break;
                }
            Invalidate();
        }

        private void PictureBoxScene_MouseUp(object sender, MouseEventArgs e)
        {
            var rng = new Random();

            if (e.Button == MouseButtons.Right)
            {
                canDraw = false;
                isShapeMoving = false;

                if (frameRectangle != null) //zapulva figyrite s random cvqt i gi dobavq kum listite
                {
                    frameRectangle.colorBorder = Color.FromArgb(rng.Next(255), rng.Next(255), rng.Next(255));
                    frameRectangle.colorFill = Color.FromArgb(150, frameRectangle.colorBorder);

                    var selecteShapes = shapes
                                        .Take(shapes.Count())
                                        .ToList();
                    selecteShapes.ForEach(x => x.isSelected = false);

                    shapes.Add(frameRectangle);
                    frameRectangle.isSelected = true;
                    frameRectangle = null;
                }

                if (frameEllipse != null)
                {
                    frameEllipse.colorBorder = Color.FromArgb(rng.Next(255), rng.Next(255), rng.Next(255));
                    frameEllipse.colorFill = Color.FromArgb(150, frameEllipse.colorBorder);

                    var selecteShapes = shapes
                                        .Take(shapes.Count())
                                        .ToList();
                    selecteShapes.ForEach(x => x.isSelected = false);

                    shapes.Add(frameEllipse);
                    frameEllipse.isSelected = true;
                    frameEllipse = null;
                }

                if (frameTriangle != null)
                {
                    frameTriangle.colorBorder = Color.FromArgb(rng.Next(255), rng.Next(255), rng.Next(255));
                    frameTriangle.colorFill = Color.FromArgb(150, frameTriangle.colorBorder);

                    var selecteShapes = shapes
                                        .Take(shapes.Count())
                                        .ToList();
                    selecteShapes.ForEach(x => x.isSelected = false);

                    shapes.Add(frameTriangle);
                    triangles.Add(frameTriangle);
                    frameTriangle.isSelected = true;
                    frameTriangle = null;
                }

                if (frameStraightLine != null)
                {
                    frameStraightLine.colorBorder = Color.FromArgb(rng.Next(255), rng.Next(255), rng.Next(255));
                    frameStraightLine.colorFill = Color.FromArgb(150, frameStraightLine.colorBorder);

                    var selecteShapes = shapes
                                        .Take(shapes.Count())
                                        .ToList();
                    selecteShapes.ForEach(x => x.isSelected = false);

                    shapes.Add(frameStraightLine);
                    frameStraightLine.isSelected = true;
                    frameStraightLine = null;
                }
                //posledno napravenata figyra vinagi e selektirana
            }
            Invalidate();
        }

        private void FixDialogBox() //opravq gadnoto premigvane, koeto mi dokarva epilepsiq
        {
            SetStyle(ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Buttons() //dobavq bytonite na figyrite v list i pravi gotin efekt kogato mishkata e vurhy tqh :)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pictureBoxStraightLine,
                pictureBoxTriangle,
                pictureBoxCircle,
                pictureBoxRectangle,
                pictureBoxPencil,
                pictureBoxCursor
            };

            pictureBoxes.ForEach(x => x.MouseHover += (c, e) => x.BackColor = Color.FromArgb(186, 180, 179));
            pictureBoxes.ForEach(x => x.MouseLeave += (c, e) => x.BackColor = Color.White);
        }

        private void BitmapImage()
        {
            bitmap = new Bitmap(this.Width, this.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Transparent);
            PictureBoxScene.Image = bitmap;
        }

        private void SelectShapes(IEnumerable<Shape> shapes)
        {
            foreach (var shape in shapes)
                shape.isSelected = true;

            Invalidate();
        }

        private void FormScene_KeyDown(object sender, KeyEventArgs e) //delete byton
        {
            if (e.KeyCode == Keys.Delete)
                for (int s = shapes.Count() - 1; s >= 0; s--)
                    if (shapes[s].isSelected)
                        shapes.RemoveAt(s); 

            Invalidate();
        }

        //bytoni

        private void ButtonColor_Click(object sender, EventArgs e) //smenq cveta newColor)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.ShowDialog();
            newColor = colorDialog.Color;

            buttonColor.BackColor = newColor;
        }

        private void ButtonBGColor_Click(object sender, EventArgs e) //smenq background cveta
        {
            var bgColor = new ColorDialog();

            if (bgColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = bgColor.Color;
                buttonBGColor.BackColor = bgColor.Color;
            }

            if (bgColor.Color == Color.Black)
                buttonBGColor.ForeColor = Color.White;
            else
                buttonBGColor.ForeColor = Color.Black;
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;
            var leftShapes = shapes.Where(s => s.location.X <= centerX);

            SelectShapes(leftShapes);
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            var centerX = Width / 2;
            var rightShapes = shapes.Where(s => s.location.X >= centerX);

            SelectShapes(rightShapes);
        }

        private void ButtonClear_Click(object sender, EventArgs e) //chisti vsi4ki figyri
        {
            for (int i = shapes.Count() - 1; i >= 0; i--)
                if (shapes[i].isSelected)
                    shapes.RemoveAt(i);

            graphics.Clear(Color.Transparent);
        }

        private void ButtonImage_Click(object sender, EventArgs e) //zapazva kato snimka
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Image(*.joeg) | *.jpeg | (*.*|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var bmp = new Bitmap(PictureBoxScene.Width, PictureBoxScene.Height))
                    {
                        PictureBoxScene.DrawToBitmap(bmp, new Rectangle(0, 0, PictureBoxScene.Width, PictureBoxScene.Height));
                        bmp.Save(sfd.FileName);
                    }
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e) //zapazva dannite na figyrite
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Data(*.data) | *.data | (*.*|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();

                    using (var fileStream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        formatter.Serialize(fileStream, shapes);
                        formatter.Serialize(fileStream, this.BackColor);
                    }
                }
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();

                    using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        shapes = (List<Shape>)formatter.Deserialize(fileStream); //prochita zapisanite figyri
                        this.BackColor = (Color)formatter.Deserialize(fileStream);
                        buttonBGColor.BackColor = this.BackColor;
                    }
                    Invalidate();
                }
            }
        } //otvarq bitovite danni na vechezapisani figyri

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pointX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pointY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(point.X * pointX), (int)(point.Y * pointY));
        } //nujno e za paletite na cvetovete

        //picturebox
        private void PictureBoxScene_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var shape in shapes)
                if (shape.isSelected && e.Button == MouseButtons.Left)
                    switch (shape.shapeNumber)
                    {
                        case 1:
                            using (var fr = new FormRecangle())
                            {
                                fr.Rectangle = (Rectangles)shape;
                                fr.ShowDialog();
                            }
                        break;

                        case 2:
                            using (var fe = new FormEllipse())
                            {
                                fe.Ellipse = (Ellipse)shape;
                                fe.ShowDialog();
                            }
                        break;

                        case 3:
                            using (var ft = new FormTriangle())
                            {
                                ft.Triangle = (Triangle)shape;
                                ft.ShowDialog();
                            }
                        break;

                        case 4:
                            using (var fsl = new FormStraightLine())
                            {
                                fsl.StraightLine = (StraightLine)shape;
                                fsl.ShowDialog();
                            }
                        break;
                    }
            Invalidate();
        }

        private void PictureBoxPalette_MouseClick(object sender, MouseEventArgs e) //vzema pikselite na picture boks-a i zadava cveta im kum newColor
        {
            Point point = SetPoint(pictureBoxPalette, e.Location);

            buttonColor.BackColor = ((Bitmap)pictureBoxPalette.Image).GetPixel(point.X, point.Y);
            newColor = buttonColor.BackColor;
        }

        private void PictureBoxRectangle_Click(object sender, EventArgs e)
        {
            buttonIndex = 1;
        }

        private void PictureBoxCircle_Click(object sender, EventArgs e)
        {
            buttonIndex = 2;
        }

        private void PictureBoxTriangle_Click(object sender, EventArgs e)
        {
            buttonIndex = 3;
        }

        private void PictureBoxStraightLine_Click(object sender, EventArgs e)
        {
            buttonIndex = 4;

            var lsf = new LineSelectionForm();
            lsf.ShowDialog();
        }

        private void PictureBoxPencil_Click(object sender, EventArgs e)
        {
            buttonIndex = 5;
        }

        private void PictureBoxCursor_Click(object sender, EventArgs e)
        {
            buttonIndex = 6;
        }

        //fynkcii za nachertavane ot bibliotekata

        public void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height)
        {
            if (onPaintGraphics != null)
            {
                using (var brush = new SolidBrush(colorFill))
                    onPaintGraphics.FillRectangle(brush, x, y, width, height);

                using (var pen = new Pen(colorBorder, 3))
                    onPaintGraphics.DrawRectangle(pen, x, y, width, height);
            }
        } //metodi ot IGraphics za izchertavane na figyrite

        public void DrawEllipse(Color colorBorder, Color colorFill, int x, int y, int radius1, int radius2)
        {
            if (onPaintGraphics != null)
            {
                using (var brush = new SolidBrush(colorFill))
                    onPaintGraphics.FillEllipse(brush, x, y, radius1, radius2);

                using (var pen = new Pen(colorBorder, 3))
                    onPaintGraphics.DrawEllipse(pen, x, y, radius1, radius2);
            }
        }

        public void DrawStraightLine(Color colorBorder, Color colorFill, int x, int y, int width, int height, Point firstPoint, Point lastPoint)
        {
            if (onPaintGraphics != null)
            {
                using (var brush = new SolidBrush(colorFill))
                    onPaintGraphics.FillRectangle(brush, x, y, width, height);

                using (var pen = new Pen(colorBorder, 2))
                    onPaintGraphics.DrawRectangle(pen, x, y, width, height);

                using (var pen = new Pen(colorBorder, 2))
                    onPaintGraphics.DrawLine(pen, firstPoint, lastPoint); //pravi prava liniq s nachalna i kraina tochka
            }
        }

        public void DrawTriangle(Color colorBorder, Color colorFill, Point a, Point b, Point c)
        {
            Point[] points = new Point[] { a, b, c };

            if (onPaintGraphics != null)
            {
                using (var brush = new SolidBrush(colorFill))
                    onPaintGraphics.FillPolygon(brush, points); //ne se zapulva vse oshte a ne znam zashto (shte go opravq po natatuka)

                using (var pen = new Pen(colorBorder, 3))
                    onPaintGraphics.DrawPolygon(pen, points);
            }
        }
    }
}
