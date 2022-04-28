using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class UCWuerfel : UserControl
    {
        public UCWuerfel()
        {
            InitializeComponent();
        }

        private void UCWuerfel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            int w = Size.Width;
            int h = Size.Height;

            graphics.DrawRectangle(blackPen, recWuerfel);
            graphics.DrawString(wert.ToString(), Form.DefaultFont, new SolidBrush(Color.Black), 0,0);

            List<Rectangle> rectangles = new List<Rectangle>();
            int x = 0;
            int y = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int a = 1; a <= 3; a++)
                {
                    rectangles.Add(new Rectangle(new Point(x, y), wuerfelGroesse));
                    x += Width / 3;
                }
                x = 0;
                y += Size.Height/3;
            }

            foreach (Rectangle item in rectangles)
            {
                graphics.DrawRectangle(blackPen, item);
            }

            if (wert == 1)
            {
                graphics.FillEllipse(blackBrush, rectangles[4]);
            }
            else if (wert == 2)
            {
                graphics.FillEllipse(blackBrush, rectangles[2]);
                graphics.FillEllipse(blackBrush, rectangles[6]);
            }
            else if (wert == 3)
            {
                graphics.FillEllipse(blackBrush, rectangles[2]);
                graphics.FillEllipse(blackBrush, rectangles[4]);
                graphics.FillEllipse(blackBrush, rectangles[6]);
            }
            else if (wert == 4)
            {
                graphics.FillEllipse(blackBrush, rectangles[0]);
                graphics.FillEllipse(blackBrush, rectangles[2]);
                graphics.FillEllipse(blackBrush, rectangles[6]);
                graphics.FillEllipse(blackBrush, rectangles[8]);
            }
            else if (wert == 5)
            {
                graphics.FillEllipse(blackBrush, rectangles[0]);
                graphics.FillEllipse(blackBrush, rectangles[2]);
                graphics.FillEllipse(blackBrush, rectangles[4]);
                graphics.FillEllipse(blackBrush, rectangles[6]);
                graphics.FillEllipse(blackBrush, rectangles[8]);
            }
            else if (wert == 6)
            {
                graphics.FillEllipse(blackBrush, rectangles[0]);
                graphics.FillEllipse(blackBrush, rectangles[2]);
                graphics.FillEllipse(blackBrush, rectangles[3]);
                graphics.FillEllipse(blackBrush, rectangles[5]);
                graphics.FillEllipse(blackBrush, rectangles[6]);
                graphics.FillEllipse(blackBrush, rectangles[8]);
            }
        }
        private Pen blackPen = new Pen(Color.Black, 2);
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private Size wuerfelGroesse;

        private void UCWuerfel_Load(object sender, EventArgs e)
        {
            recWuerfel = new Rectangle(0,0,Size.Width, Size.Height);
            wuerfelGroesse = new Size(ClientSize.Width / 3, ClientSize.Height / 3);
            Refresh();
        }

        Rectangle recWuerfel;
        int wert = 0;

        private void UCWuerfel_DoubleClick(object sender, EventArgs e)
        {
            wert++;
            Refresh();
        }
    }
}
