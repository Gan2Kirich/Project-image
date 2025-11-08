using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace flag02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = "b8b66ade1bca0e80c4823447ff2c4b49.png";
            string imagep = Path.Combine(Application.StartupPath, name);

            pictureBox1.Image = Image.FromFile(imagep);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
