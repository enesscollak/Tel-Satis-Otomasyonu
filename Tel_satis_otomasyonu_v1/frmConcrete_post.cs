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
    public partial class frmConcrete_post : MetroFramework.Forms.MetroForm
    {
        public frmConcrete_post()
        {
            InitializeComponent();
        }

        public static double result;
        public static double piece;
        public static double price;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            { 
                double meter = frmWire_netting.meter;
                piece = Convert.ToDouble(metroTextBox1.Text);
                price = Convert.ToDouble(metroTextBox2.Text);
                result = price * piece;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu!",ex.Message);
                this.Close();
            }
        }

        private void frmConcrete_post_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
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
