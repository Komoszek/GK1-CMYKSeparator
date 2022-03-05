using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1_P3_komoszynskil
{
    public partial class SeparatedColorsForm : Form
    {
        public SeparatedColorsForm()
        {
            InitializeComponent();
        }

        public void setImages(Bitmap cyan, Bitmap magenta, Bitmap yellow, Bitmap black)
        {
            cyanPictureBox.Image = cyan;
            magentaPictureBox.Image = magenta;
            yellowPictureBox.Image = yellow;
            blackPictureBox.Image = black;
        }
    }
}
