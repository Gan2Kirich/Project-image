using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flag03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(300, 200);// размеры
            this.Text = "Flag";// название
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // размеры флага
            int flagWidth = this.ClientSize.Width;// ширина
            int flagHeight = this.ClientSize.Height;//  высота
            int stripeHeight = flagHeight / 3; 

            Rectangle whiteStripe = new Rectangle(0, 0, flagWidth, flagHeight);
            using (Brush whiteBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(whiteBrush, whiteStripe);
            }

            Rectangle blueStripe = new Rectangle(0, stripeHeight, flagWidth, stripeHeight);
            using (Brush blueBrush = new SolidBrush(Color.Blue))
            {
                g.FillRectangle(blueBrush, blueStripe);
            }

            Rectangle redStripe = new Rectangle(0, 2 * stripeHeight, flagWidth, flagHeight - 2 * stripeHeight); 
            using (Brush redBrush = new SolidBrush(Color.Red))
            {
                g.FillRectangle(redBrush, redStripe);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
