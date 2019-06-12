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
    public partial class frmStretching_wire : MetroFramework.Forms.MetroForm
    {
        public frmStretching_wire()
        {
            InitializeComponent();
        }
        public static double result;
        public static double meter;
        public static double price;

        private void metroButton1_Click(object sender, EventArgs e)
        {  
            try
            {
                if (metroComboBox1.SelectedIndex == 0)
                {
                    price =0.40;
                    meter = frmWire_netting.meter * 3;
                    result = meter * price;
                    this.Close();
                }
                else if (metroComboBox1.SelectedIndex == 1)
                {
                    price = Convert.ToDouble(metroTextBox1.Text);
                    if (metroTextBox1.Text != "")
                    {
                        if (metroRadioButton1.Checked == true)
                        {
                            meter = frmWire_netting.meter * 2;
                            this.Close();
                        }
                        if (metroRadioButton2.Checked == true)
                        {
                            meter = frmWire_netting.meter * 3;
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Eksik bilgi girdiniz!");
                    result = meter * price;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen hata oluştu!", ex.Message);
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

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }

        private void frmStretching_wire_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 0;
            metroLabel1.Visible = false;
            metroLabel2.Visible = false;
            metroRadioButton1.Visible = false;
            metroRadioButton2.Visible = false;
            metroTextBox1.Visible = false;
            metroButton1.Location = new Point(151, 120);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                metroLabel1.Visible = false;
                metroLabel2.Visible = false;
                metroRadioButton1.Visible = false;
                metroRadioButton2.Visible = false;
                metroTextBox1.Visible = false;
                metroButton1.Location = new Point(151, 120);
            }
            else if (metroComboBox1.SelectedIndex == 1)
            {
                metroLabel1.Visible = true;
                metroLabel2.Visible = true;
                metroRadioButton1.Visible = true;
                metroRadioButton2.Visible = true;
                metroTextBox1.Visible = true;
                metroButton1.Location = new Point(151, 198);
            }
        }
    }
}
