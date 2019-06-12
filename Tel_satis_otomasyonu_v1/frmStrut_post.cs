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
    public partial class frmStrut_post : MetroFramework.Forms.MetroForm
    {
        public frmStrut_post()
        {
            InitializeComponent();
        }

        public static double result;
        public static double meter;
        public static double piece;

        private void metroButton1_Click(object sender, EventArgs e)
        { 
            meter = frmWire_netting.meter;
            piece= Convert.ToDouble(metroTextBox1.Text);
            double price = Convert.ToDouble(metroTextBox2.Text);
            try
            {
                result = price * piece;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen hata oluştu!",ex.Message);
                this.Close();
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

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }

        private void metroTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }
    }
}
