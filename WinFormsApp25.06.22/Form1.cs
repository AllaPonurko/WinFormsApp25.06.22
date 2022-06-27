using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp25._06._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Rectangle rect = new Rectangle(20, 20, 200, 40);
            //LinearGradientBrush linear = new LinearGradientBrush(rect, Color.BlueViolet,
            //    Color.Bisque, 0.0f, true);
            //g.FillRectangle(linear, rect);
            //Rectangle rect1 = new Rectangle(20, 80, 200, 40);
            //HatchBrush hatch = new HatchBrush(HatchStyle.Cross, Color.Azure);
            //g.FillRectangle(hatch, rect1);
            //TextureBrush texture = new TextureBrush(new Bitmap("Background.bmp"));
            //Rectangle rect2 = new Rectangle(20, 140, 200, 40);
            //g.FillRectangle(texture, rect2);
            //Point[] points = { new Point(20, 30), new Point(60, 120) };
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            //path.AddCurve(points, 0.5F);
            //path.AddArc(100, 50, 100, 100, 0, 120);
            path.AddLine(2, 0, 2, 400);
            path.CloseFigure();
            path.StartFigure();
            path.AddLine(2, 400, 600,400);
            path.CloseFigure();
            g.DrawPath(new Pen(Color.Blue, 3), path);
            List<Point> points = new List<Point>(); 
            Default_Length();
            Random r = new Random();
              int x = 2, y = 300;
            foreach (Point item in points)
            {while (points.Count!=length)
                {
                    Point p = new Point(x, y);
                    points.Add(p);
                    x += 40; y = 300 + r.Next(1, 5); 
                }
            }
            //foreach (Point item in points)
            //{
            //    g.DrawLine(new Pen(Color.Red, 3), item, item.);
            //}
            foreach (Point item in points)
            {
                g.FillEllipse(Brushes.Black,item.X,item.Y,5f,5f);
            }

            //path.AddArc(180, 30, 60, 60, 0, -170);

            g.Dispose();
        }
          public int length ;
        private void Default_Length()
        {
            length = 30;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 0)
            { 
                length = Convert.ToInt32(txtNumber.Text); 

            }
            else
            {
                MessageBox.Show("Enter the number!");
            }
        }
    }
}
