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
    public partial class frmSales : MetroFramework.Forms.MetroForm
    {
        public frmSales()
        {
            InitializeComponent();
        }

        TelsatDBEntities1 telsatEntities = new TelsatDBEntities1();

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                urunMik urun_miktar = new urunMik();
                urun_miktar.telorguM = Convert.ToInt32(frmWire_netting.meter);
                urun_miktar.betondirekA = Convert.ToInt32(frmConcrete_post.piece);
                urun_miktar.payandadirekA = Convert.ToInt32(frmStrut_post.piece);
                urun_miktar.gerdirmetelM = Convert.ToInt32(frmStretching_wire.meter);
                urun_miktar.dikenlitelM = Convert.ToInt32(frmBarbed_wire.meter);
                urun_miktar.betontasM3 = Convert.ToInt32(frmConcrete_stone.m3);
                urun_miktar.baglamatelM = Convert.ToInt32(frmBinding_wire.meter);
                urun_miktar.iscilikM = Convert.ToInt32(frmWorker.meter);
                telsatEntities.urunMik.Add(urun_miktar);

                urunTL urun_fiyat = new urunTL();
                urun_fiyat.telorguTL = Convert.ToInt32(frmWire_netting.result);
                urun_fiyat.betondirekTL = Convert.ToInt32(frmConcrete_post.price);
                urun_fiyat.payandadirekTL = Convert.ToInt32(frmStrut_post.result);
                urun_fiyat.gerdirmetelTL = Convert.ToInt32(frmStretching_wire.result);
                urun_fiyat.dikenlitelTL = Convert.ToInt32(frmBarbed_wire.result);
                urun_fiyat.betontasTL = Convert.ToInt32(frmConcrete_stone.result);
                urun_fiyat.baglamatelTL = Convert.ToInt32(frmBinding_wire.result);
                urun_fiyat.iscilikTL = Convert.ToInt32(frmWorker.result);
                telsatEntities.urunTL.Add(urun_fiyat);

                double resultPrc = frmWire_netting.result + frmConcrete_post.price + frmStrut_post.result + frmStretching_wire.result + frmBarbed_wire.result + frmConcrete_stone.result + frmBinding_wire.result + frmWorker.result;
                fatura fatura1 = new fatura();
                fatura1.urun_id = urun_fiyat.urunfiyatID;
                fatura1.faturaTarih = DateTime.Now;
                fatura1.faturaTutari = Convert.ToInt32(resultPrc);
                fatura1.urun_id = urun_miktar.urunlermikID;

                musteri musteri1 = new musteri();
                musteri1.musteriAd = metroTextBox1.Text;
                musteri1.musteriSoyad = metroTextBox2.Text;
                musteri1.musteriTel = metroTextBox3.Text;
                musteri1.musteriMail = metroTextBox4.Text;
                musteri1.musteriAdres = metroTextBox5.Text;
                musteri1.musteriNotu = metroTextBox6.Text;
                musteri1.faturaID = fatura1.faturaID;

                telsatEntities.fatura.Add(fatura1);
                telsatEntities.musteri.Add(musteri1);
                telsatEntities.SaveChanges();

                MessageBox.Show("Satış Tamamlandı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.",ex.Message);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (metroTextBox6.Text.Length == 50)
            {
                e.Handled = true;
            }
        }
        private void masked(object sender, KeyPressEventArgs e)
        {
            ControlClass controlClass = new ControlClass();
            controlClass.MaskedTxt(sender, e);
        }
    }
}
