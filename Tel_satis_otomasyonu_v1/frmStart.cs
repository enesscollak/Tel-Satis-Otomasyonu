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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        TelsatDBEntities1 telsatEntities = new TelsatDBEntities1();

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if ((metroTextBox1.Text == "admin") && (metroTextBox2.Text == "admin"))
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    var user = telsatEntities.kullanici.FirstOrDefault(u => u.kullaniciAdi == metroTextBox1.Text);
                    if (user.kullaniciSifre == metroTextBox2.Text)
                    {
                        frmMain frmMain = new frmMain();
                        frmMain.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yanlış veya eksik tuşladınız!", ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            metroTextBox1.Focus();
        }

        private void metroTextBox1_MouseHover(object sender, EventArgs e)
        {
            metroToolTip1.SetToolTip(metroTextBox1, "Kullanıcı adı, büyük veya küçük harfe duyarlı değildir.");
        }
    }
}
