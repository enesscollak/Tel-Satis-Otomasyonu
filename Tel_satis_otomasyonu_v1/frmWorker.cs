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
    public partial class frmWorker : MetroFramework.Forms.MetroForm
    {
        public frmWorker()
        {
            InitializeComponent();
        }

        public static double result;
        public static double meter;
        public static double price;

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            meter = frmWire_netting.meter;
            
            
            try
            {
                if (metroRadioButton1.Checked == true)
                {
                    price = 8;
                    result = meter * price;
                }
                else if (metroRadioButton2.Checked == true)
                {
                    price = Convert.ToDouble(metroTextBox1.Text);
                    if (metroTextBox1.Text != "")
                    {
                        result = meter * price;
                    }
                    else
                        MessageBox.Show("Eksik bilgi girdiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu!", ex.Message);
                this.Close();
            }
            this.Close();
        }

        private void metroTile1_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.SetToolTip(metroTile1, "İşlemi iptal etmek için tıklayınız.");
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }

        private void frmWorker_Load(object sender, EventArgs e)
        {
            metroLabel1.Visible = false;
            metroTextBox1.Visible = false;
            metroButton1.Location = new Point(23,114);
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroRadioButton1.Checked==true)
            {
                metroLabel1.Visible = false;
                metroTextBox1.Visible = false;
                metroButton1.Location = new Point(23, 114);
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                metroLabel1.Visible = true;
                metroTextBox1.Visible = true;
                metroButton1.Location = new Point(144, 153);
            }
        }
    }
}
