using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assessment2Maria
{
    public partial class formGraphics : Form
    {
        public formGraphics()
        {
            InitializeComponent();
            this.Text = "2D Drawing - house";
            this.BackColor = Color.White;
            this.DoubleBuffered = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            
            //Drawing grass
            using (SolidBrush grassBrush = new SolidBrush(Color.LightGreen))
            {
                g.FillRectangle(grassBrush, 0, 260, this.ClientSize.Width, 100);
            }

            //SystemDrawingSection Body
            Rectangle housebody = new Rectangle(100, 140, 200, 120);
            using (SolidBrush wallBrush = new SolidBrush(Color.BurlyWood))
            using (Pen wallPen = new Pen(Color.SaddleBrown, 3))
            {
                g.FillRectangle(wallBrush, housebody);
                g.DrawRectangle(wallPen, housebody);
            }

            //Drawing roof
            Point roofPt1 = new Point(90, 140); //left
            Point roofPt2 = new Point(310, 140);// right
            Point roofPt3 = new Point(200, 80);//top
            Point[] roofPoints = { roofPt1, roofPt2, roofPt3 };

            using (SolidBrush roofBrush = new SolidBrush(Color.Maroon))
            using (Pen roofPen = new Pen(Color.DarkRed, 3))
            {
                g.FillPolygon(roofBrush, roofPoints);
                g.DrawPolygon(roofPen, roofPoints);
            }

            //drawing door
            Rectangle door = new Rectangle(190, 190, 40, 70);
            using (SolidBrush doorBrush = new SolidBrush(Color.Sienna))
            using (Pen doorPen = new Pen(Color.Brown, 2))
            {
                g.FillRectangle(doorBrush, door);
                g.DrawRectangle(doorPen, door);
            }

            Rectangle winLeft = new Rectangle(120, 170, 50, 40);
            DrawWindow(g, winLeft);
            Rectangle winRight = new Rectangle(230, 170, 50, 40);
            DrawWindow(g, winRight);


        }

       private void DrawWindow(Graphics g, Rectangle r)
        {
            using (SolidBrush windowBrush = new SolidBrush(Color.LightSkyBlue))
            using (Pen windowPen = new Pen(Color.Navy, 2))
            {
                g.FillRectangle(windowBrush, r);
                g.DrawRectangle(windowPen, r);
            }
        }
        
    private void formgraphics_Load(object sender, EventArgs e)
        {

        }
    }
}
