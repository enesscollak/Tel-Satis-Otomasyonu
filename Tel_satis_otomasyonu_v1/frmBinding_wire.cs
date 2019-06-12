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
    public partial class frmBinding_wire : MetroFramework.Forms.MetroForm
    {
        public frmBinding_wire()
        {
            InitializeComponent();
        }

        public static double price;
        public static double result;
        public static double meter;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroRadioButton1.Checked == true)
                {
                    if (frmStretching_wire.meter != 0)
                    {
                        price = 0.40;
                        meter = frmStretching_wire.meter / 2;
                        this.Close();
                    }
                    else
                    {
                        price = 0.40;
                        meter = Convert.ToDouble(metroTextBox2.Text);
                        this.Close();
                    }
                }
                else if (metroRadioButton2.Checked == true)
                {
                    if (frmStretching_wire.meter != 0)
                    {
                        price = Convert.ToDouble(metroTextBox1.Text);
                        meter = frmStretching_wire.meter / 2;
                        this.Close();
                    }
                    else
                    {
                        price = Convert.ToDouble(metroTextBox1.Text);
                        meter = Convert.ToDouble(metroTextBox2.Text);
                        this.Close();
                    }

                }
                result = meter * price;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata!", ex.Message);
            }
        } 

        private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                metroButton1_Click(sender, e);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.SetToolTip(metroTile2, "İşlemi iptal etmek için tıklayınız.");
        }

        private void frmBinding_wire_Shown(object sender, EventArgs e)
        {
            metroTextBox1.Focus();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }

        private void frmBinding_wire_Load(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                if (frmStretching_wire.meter != 0)
                {
                    metroLabel1.Visible = false;
                    metroTextBox1.Visible = false;
                    metroButton1.Location = new Point(24, 108);
                    metroTextBox2.Visible = false;
                }
                else if (frmStretching_wire.meter == 0)
                {
                    metroButton1.Location = new Point(24, 142);
                    metroTextBox1.Visible = false;
                    metroTextBox2.Visible = true;
                    metroTextBox2.Location = new Point(24, 108);
                }
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Text = "";
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                if (frmStretching_wire.meter != 0)
                {
                    metroLabel1.Visible = false;
                    metroTextBox1.Visible = false;
                    metroButton1.Location = new Point(24, 108);
                    metroTextBox2.Visible = false;
                }
                else if (frmStretching_wire.meter == 0)
                {
                    metroButton1.Location = new Point(24, 142);
                    metroTextBox1.Visible = false;
                    metroTextBox2.Visible = true;
                    metroTextBox2.Location = new Point(24, 108);
                }
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                if (frmStretching_wire.meter != 0)
                {
                    metroLabel1.Visible = true;
                    metroTextBox1.Visible = true;
                    metroButton1.Location = new Point(116, 133);
                    metroTextBox2.Visible = false;
                }
                else if (frmStretching_wire.meter == 0)
                {
                    metroTextBox1.Visible = true;
                    metroTextBox1.Visible = true;
                    metroLabel1.Visible = true;
                    metroButton1.Location = new Point(116, 163);
                    metroTextBox2.Location = new Point(116, 133);
                }
            }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }
    }
}
