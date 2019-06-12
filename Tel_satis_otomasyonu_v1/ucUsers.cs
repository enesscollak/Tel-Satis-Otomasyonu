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
    public partial class ucUsers : MetroFramework.Controls.MetroUserControl
    {
        public ucUsers()
        {
            InitializeComponent();
        }
        TelsatDBEntities1 telsatEntities = new TelsatDBEntities1();
        private void ucUsers_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = telsatEntities.kullanici.ToList();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilialan = metroGrid1.SelectedCells[0].RowIndex;
                string k_id = metroGrid1.Rows[secilialan].Cells[0].Value.ToString();
                string k_ad = metroGrid1.Rows[secilialan].Cells[1].Value.ToString();
                string k_sifre = metroGrid1.Rows[secilialan].Cells[2].Value.ToString();

                metroTextBox1.Text = k_id;
                metroTextBox2.Text = k_ad;
                metroTextBox3.Text = k_sifre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.", ex.Message);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                kullanici user = new kullanici();
                user.kullaniciID = Convert.ToInt16(metroTextBox1.Text);
                user.kullaniciAdi = metroTextBox2.Text;
                user.kullaniciSifre = metroTextBox3.Text;
                telsatEntities.kullanici.Add(user);
                telsatEntities.SaveChanges();
                metroGrid1.DataSource = telsatEntities.kullanici.ToList();
                metroTextBox1.Clear();
                metroTextBox2.Clear();
                metroTextBox3.Clear();
                MessageBox.Show("Yeni Kullanıcı Eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.", ex.Message);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                int k_id = Convert.ToInt16(metroTextBox1.Text);
                kullanici user = telsatEntities.kullanici.First(f => f.kullaniciID == k_id);

                user.kullaniciAdi = metroTextBox2.Text;
                user.kullaniciSifre = metroTextBox3.Text;

                telsatEntities.SaveChanges();
                metroGrid1.DataSource = telsatEntities.kullanici.ToList();

                metroTextBox1.Clear();
                metroTextBox2.Clear();
                metroTextBox3.Clear();
                MessageBox.Show("Kullanıcı Güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.", ex.Message);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                int k_id = Convert.ToInt16(metroTextBox1.Text);
                kullanici user = telsatEntities.kullanici.First(f => f.kullaniciID == k_id);
                telsatEntities.kullanici.Remove(user);

                telsatEntities.SaveChanges();
                metroGrid1.DataSource = telsatEntities.kullanici.ToList();

                metroTextBox1.Clear();
                metroTextBox2.Clear();
                metroTextBox3.Clear();

                MessageBox.Show("Kullanıcı Silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.", ex.Message);
            }
        }
    }
}
