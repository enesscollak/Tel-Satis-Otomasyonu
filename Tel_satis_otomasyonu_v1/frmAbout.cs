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
    public partial class frmAbout : MetroFramework.Forms.MetroForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {  
            timer1.Interval = 50;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            label1.Top = label1.Top - 1;
            label2.Top = label2.Top - 1;
            label3.Top = label3.Top - 1;
            label4.Top = label4.Top - 1;
            label5.Top = label5.Top - 1;
            label6.Top = label6.Top - 1;
            label7.Top = label7.Top - 1;
            label8.Top = label8.Top - 1;

            if (label1.Top < 30)
            {
                label1.Top = this.Height - 30;
            }
            else if (label2.Top < 30)
            {
                label2.Top = this.Height - 30;
            }
            else if(label3.Top < 30)
            {
                label3.Top = this.Height - 30;
            }
            else if(label4.Top < 30)
            {
                label4.Top = this.Height - 30;
            }
            else if(label5.Top < 30)
            {
                label5.Top = this.Height - 30;
            }
            else if (label6.Top < 30)
            {
                label6.Top = this.Height - 30;
            }
            else if(label7.Top < 30)
            {
                label7.Top = this.Height - 30;
            }
            else if (label8.Top < 30)
            {
                label8.Top = this.Height - 30;
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
