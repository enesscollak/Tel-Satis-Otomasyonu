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
    public partial class ucCustomer : MetroFramework.Controls.MetroUserControl
    {
        public ucCustomer()
        {
            InitializeComponent();
        }

        TelsatDBEntities1 telsatEntities = new TelsatDBEntities1();

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilialan = metroGrid1.SelectedCells[0].RowIndex;
                string ad = metroGrid1.Rows[secilialan].Cells[1].Value.ToString();
                string soyad = metroGrid1.Rows[secilialan].Cells[2].Value.ToString();
                string telefon = metroGrid1.Rows[secilialan].Cells[3].Value.ToString();
                string mail = metroGrid1.Rows[secilialan].Cells[4].Value.ToString();
                string adres = metroGrid1.Rows[secilialan].Cells[5].Value.ToString();
                string not = metroGrid1.Rows[secilialan].Cells[6].Value.ToString();
                string m_id = metroGrid1.Rows[secilialan].Cells[7].Value.ToString();

                maskedTextBox1.Text = ad;
                maskedTextBox2.Text = soyad;
                maskedTextBox3.Text = telefon;
                maskedTextBox4.Text = mail;
                metroTextBox5.Text = adres;
                metroTextBox6.Text = not;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.",ex.Message);
            }
}

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = Convert.ToString(maskedTextBox1.Text);
                musteri musteri1 = telsatEntities.musteri.First(f => f.musteriAd == ad);
                telsatEntities.musteri.Remove(musteri1);
                telsatEntities.SaveChanges();
                metroGrid1.DataSource = telsatEntities.musteri_fatura_View.ToList();

                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
                metroTextBox5.Clear();
                metroTextBox6.Clear();
                MessageBox.Show("Kayıt Silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = Convert.ToString(maskedTextBox1.Text);
                musteri musteri1 = telsatEntities.musteri.First(f => f.musteriAd == ad);

                musteri1.musteriAd = maskedTextBox1.Text;
                musteri1.musteriSoyad = maskedTextBox2.Text;
                musteri1.musteriTel = maskedTextBox3.Text;
                musteri1.musteriMail = maskedTextBox4.Text;
                musteri1.musteriAdres = metroTextBox5.Text;
                musteri1.musteriNotu = metroTextBox6.Text;

                double resultPrc = frmWire_netting.result + frmConcrete_post.price + frmStrut_post.result + frmStretching_wire.result + frmBarbed_wire.result + frmConcrete_stone.result + frmBinding_wire.result + frmWorker.result;
                fatura fatura1 = new fatura();
                fatura1.faturaID = Convert.ToInt16(musteri1.faturaID);
                fatura1.faturaTarih = DateTime.Now;
                fatura1.faturaTutari = Convert.ToInt32(resultPrc);

                telsatEntities.SaveChanges();
                metroGrid1.DataSource = telsatEntities.musteri_fatura_View.ToList();

                MessageBox.Show("Kayıt Güncellendi");
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
                metroTextBox5.Clear();
                metroTextBox6.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.");
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = telsatEntities.musteri_fatura_View.ToList();
        }
    }
}