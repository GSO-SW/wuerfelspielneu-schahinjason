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

            int w = ClientSize.Width;
            int h = ClientSize.Height;

            graphics.DrawRectangle(new Pen(Color.Black), recWuerfel);
            graphics.DrawString(wuerfel.LetztesErgebnis.ToString(), Form.DefaultFont, new SolidBrush(Color.Black), 0,0);
        }

        private void UCWuerfel_Load(object sender, EventArgs e)
        {
            recWuerfel = new Rectangle(0,0,btnWuerfeln.Location.X, btnWuerfeln.Location.Y);
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
