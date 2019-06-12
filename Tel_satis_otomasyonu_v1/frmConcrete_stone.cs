using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tel_satis_otomasyonu_v1
{
    public partial class frmConcrete_stone : MetroFramework.Forms.MetroForm
    {
        public frmConcrete_stone()
        {
            InitializeComponent();
        }

        public static double result;
        public static double m3;
        double width, height, price, length, piece;

        private void metroButton1_Click(object sender, EventArgs e)
        {
                width = Convert.ToDouble(metroTextBox1.Text);
                height = Convert.ToDouble(metroTextBox2.Text);
                price = Convert.ToDouble(metroTextBox3.Text);         
                
                try
                {
                    if (metroRadioButton1.Checked == true)
                    {
                        piece = 1;
                        length = frmWire_netting.meter;

                        this.Close();
                    }

                    if (metroRadioButton2.Checked == true)
                    {
                        piece = Convert.ToDouble(metroTextBox5.Text);
                        length = Convert.ToDouble(metroTextBox4.Text);
                        this.Close();
                    }

                    m3 = width * height * length;
                    result = m3 * price * piece;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata! Lütfen bilgileri kontrol ediniz.", ex.Message);
                }
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.SetToolTip(metroTile1, "İşlemi iptal etmek için tıklayınız.");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {                   
            this.Close();
        }

        private void maske(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }

        private void frmConcrete_stone_Load(object sender, EventArgs e)
        {
            metroTextBox4.Visible = false;
            metroTextBox5.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                metroLabel5.Visible = true;
                metroTextBox4.Visible = true;
                metroTextBox5.Visible = true;
                metroLabel6.Visible = true;

                metroButton1.Location = new Point(117, 283);
                metroTextBox3.Location = new Point(117, 209);
                metroTextBox4.Location = new Point(117, 175);
                metroLabel4.Location = new Point(23, 212);
                metroLabel5.Location= new Point(23, 179);

                metroTextBox1.Text = "0,40";
                metroTextBox2.Text = "0,40";
                metroTextBox3.Text = "200";
                metroTextBox4.Text = "0,40";
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                metroLabel5.Visible = false;
                metroTextBox4.Visible = false;
                metroTextBox5.Visible = false;
                metroLabel6.Visible = false;

                metroButton1.Location = new Point(117, 208);
                metroTextBox3.Location = new Point(117, 175);
                metroLabel4.Location = new Point(23, 179);
            }
        }
    }
}
