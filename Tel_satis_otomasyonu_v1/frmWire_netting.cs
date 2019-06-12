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
    public partial class frmWire_netting : MetroFramework.Forms.MetroForm
    {
        public frmWire_netting()
        {
            InitializeComponent();
        }

        public static double meter;
        public static double result;
        public static double height;
        public static double interval;
        public static double price;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            meter = Convert.ToDouble(metroTextBox1.Text);
            try
            {
                if (metroRadioButton1.Checked == true)
                {
                    metroTextBox1.Focus();
                    height=1.5;
                    interval = 1.348;
                    price = 12.5;
                    result = meter * height * interval * price;
                    this.Close();
                }
                else if (metroRadioButton2.Checked == true)
                {
                    
                    height = Convert.ToDouble(metroTextBox2.Text);
                    price = Convert.ToDouble(metroTextBox3.Text);
                    if (metroComboBox1.SelectedIndex == 0)
                    {
                        interval = 1.035;
                    }
                    if (metroComboBox1.SelectedIndex == 1)
                    {
                        interval = 1.369;
                    }
                    if (metroComboBox1.SelectedIndex == 2)
                    {
                        interval = 1.618;
                    }
                    if (metroComboBox1.SelectedIndex == 3)
                    {
                        interval = 0.863;
                    }
                    if (metroComboBox1.SelectedIndex == 4)
                    {
                        interval = 1.141;
                    }
                    if (metroComboBox1.SelectedIndex == 5)
                    {
                        interval = 1.348;
                    }
                    if (metroComboBox1.SelectedIndex == 6)
                    {
                        interval = 0.796;
                    }
                    if (metroComboBox1.SelectedIndex == 7)
                    {
                        interval = 1.053;
                    }
                    if (metroComboBox1.SelectedIndex == 8)
                    {
                        interval = 1.244;
                    }
                    result = meter * height * interval * price;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eksik bilgi girdiniz!",ex.Message);
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

        private void frmWire_netting_Shown(object sender, EventArgs e)
        {
            metroTextBox1.Focus();
        }

        private void metroTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
        }

        private void masked(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }

        private void frmWire_netting_Load(object sender, EventArgs e)
        {
            metroTextBox1.Focus();
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroTextBox2.Visible = false;
            metroTextBox3.Visible = false;
            metroComboBox1.Visible = false;
            metroButton1.Location = new Point(120, 159);
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                metroTextBox1.Focus();
                metroLabel2.Visible = true;
                metroLabel3.Visible = true;
                metroLabel4.Visible = true;
                metroTextBox2.Visible = true;
                metroTextBox3.Visible = true;
                metroComboBox1.Visible = true;
                metroButton1.Location = new Point(120, 278);
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                metroLabel2.Visible = false;
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                metroTextBox2.Visible = false;
                metroTextBox3.Visible = false;
                metroComboBox1.Visible = false;
                metroButton1.Location = new Point(120, 159);
            }
        }

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
        }
    }
}
