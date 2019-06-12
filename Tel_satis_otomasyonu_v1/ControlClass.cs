using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tel_satis_otomasyonu_v1
{
    class ControlClass
    {   //Textbox maske kontrolü
        public void MaskedTxt(object obt, KeyPressEventArgs evt)
        {
            try
            {
                if ((int)evt.KeyChar >= 48 && (int)evt.KeyChar <= 57)
                {
                    evt.Handled = false;
                }
                else if ((int)evt.KeyChar == 8)
                {
                    evt.Handled = false;
                }
                else
                {
                    evt.Handled = !char.IsDigit(evt.KeyChar) && !char.IsControl(evt.KeyChar) && evt.KeyChar != ',';
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmeyen bir hata oluştu.");             
            }

        }
        //ucDashboardda checkboxların kontrolü ve formların açılması
        public object ControlChk(CheckBox chk, Form frm, double db1, double db2)
        {
            try
            {
                if (chk.Checked == true)
                {
                    frm.ShowDialog();
                }
                else if (chk.Checked == false)
                {
                    db1 = 0;
                    db2 = 0;
                    MessageBox.Show("Seçim kaldırıldı!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu! Program kapatılıyor.", error.ToString());
                Application.Exit();
            }
            return frm;
        }
    }
}
