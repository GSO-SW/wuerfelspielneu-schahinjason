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
            graphics.DrawString(wuerfel.LetztesErgebnis.ToString(), Form.DefaultFont, new SolidBrush(Color.Black), 0,0);

            while (wuerfel.LetztesErgebnis != 1)
            {
                wuerfel.Wuerfeln();
            }

            if (wuerfel.LetztesErgebnis == 1)
            {
                graphics.FillEllipse(blackBrush, recWuerfel.Width /2 - wuerfelPunkt.Width/2, recWuerfel.Height /2 - wuerfelPunkt.Height, wuerfelPunkt.Width, wuerfelPunkt.Height);
            }
            else if (wuerfel.LetztesErgebnis == 2)
            {

            }
            else if (wuerfel.LetztesErgebnis == 3)
            {

            }
            else if (wuerfel.LetztesErgebnis == 4)
            {

            }
            else if (wuerfel.LetztesErgebnis == 5)
            {

            }
            else if (wuerfel.LetztesErgebnis == 6)
            {

            }
        }
        private Pen blackPen = new Pen(Color.Black, 2);
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        private Size wuerfelPunkt;

        private void UCWuerfel_Load(object sender, EventArgs e)
        {
            recWuerfel = new Rectangle(0,0,ClientSize.Width, btnWuerfeln.Location.Y);
            wuerfelPunkt = new Size(ClientSize.Width / 10, ClientSize.Height / 10);
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            wuerfel.Wuerfeln();
            Refresh();

        }
        Rectangle recWuerfel;
        Wuerfel wuerfel = new Wuerfel();
        public int anzahlSeiten;
    }
}
