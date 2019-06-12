using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tel_satis_otomasyonu_v1
{
    public partial class ucPictureview : MetroFramework.Controls.MetroUserControl
    {
        public ucPictureview()
        {
            InitializeComponent();
        }

        private void ucPictureview_Load(object sender, EventArgs e)
        {
            if ((metroRadioButton1.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullhatil.png");
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((metroRadioButton1.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullhatil.png");
            }
            else if ((metroRadioButton1.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizhatıl.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullparcabeton.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizparcabeton.png");
            }
        }
        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((metroRadioButton1.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullhatil.png");
            }
            else if ((metroRadioButton1.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizhatıl.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullparcabeton.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizparcabeton.png");
            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((metroRadioButton1.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullhatil.png");
            }
            else if ((metroRadioButton1.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizhatıl.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullparcabeton.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizparcabeton.png");
            }
        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if ((metroRadioButton1.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullhatil.png");
            }
            else if ((metroRadioButton1.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizhatıl.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton3.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Fullparcabeton.png");
            }
            else if ((metroRadioButton2.Checked == true) && (metroRadioButton4.Checked == true))
            {
                pictureBox1.Image = new Bitmap(@"Images\Dikensizparcabeton.png");
            }
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton5.Checked == true)
            {
                pictureBox1.Image = new Bitmap(@"Images\Mapdikensiz.png");
            }
        }

        private void metroRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton6.Checked == true)
            {
                pictureBox1.Image = new Bitmap(@"Images\Map.png");
            }
        }
    }
}
