using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tel_satis_otomasyonu_v1
{
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        ControlClass controlClass = new ControlClass();       
        TelsatDBEntities1 telsatEntities = new TelsatDBEntities1();
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {          
            frmWire_netting frmWireNetting = new frmWire_netting();
            controlClass.ControlChk(checkBox1, frmWireNetting, frmWire_netting.meter, frmWire_netting.result);
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            frmConcrete_post concretePost = new frmConcrete_post();
            controlClass.ControlChk(checkBox2, concretePost, frmConcrete_post.piece, frmConcrete_post.price);
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            frmStrut_post strutPost = new frmStrut_post();
            controlClass.ControlChk(checkBox3, strutPost, frmStrut_post.result, frmStrut_post.piece);
        }

        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            frmStretching_wire stretchingWire = new frmStretching_wire();
            controlClass.ControlChk(checkBox4, stretchingWire, frmStretching_wire.meter, frmStretching_wire.result);
        }

        private void checkBox5_MouseClick(object sender, MouseEventArgs e)
        {
            frmBarbed_wire barbedWire = new frmBarbed_wire();
            controlClass.ControlChk(checkBox5, barbedWire, frmBarbed_wire.result, frmBarbed_wire.meter);
        }

        private void checkBox6_MouseClick(object sender, MouseEventArgs e)
        {
            frmConcrete_stone concreteStone = new frmConcrete_stone();
            controlClass.ControlChk(checkBox6, concreteStone, frmConcrete_stone.result, frmConcrete_stone.m3);
        }

        private void checkBox7_MouseClick(object sender, MouseEventArgs e)
        {
            frmBinding_wire bindingWire = new frmBinding_wire();
            controlClass.ControlChk(checkBox7, bindingWire, frmBinding_wire.result, frmBinding_wire.price);
        }

        private void checkBox8_MouseClick(object sender, MouseEventArgs e)
        {
            frmWorker worker = new frmWorker();
            controlClass.ControlChk(checkBox8, worker, frmWorker.meter, frmWorker.result);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Satışı onaylamak istediğinizden emin misiniz?", "Satış Onayı", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                frmSales musterifaturafrm = new frmSales();
                musterifaturafrm.ShowDialog();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == false)
                {
                    frmConcrete_post.result = 0;
                    frmConcrete_post.piece = 0;
                }
                if (checkBox3.Checked == false)
                {
                    frmStrut_post.result = 0;
                    frmStrut_post.piece = 0;
                }
                if (checkBox4.Checked == false)
                {
                    frmStretching_wire.result = 0;
                    frmStretching_wire.meter = 0;
                }
                if (checkBox5.Checked == false)
                {
                    frmBarbed_wire.result = 0;
                    frmBarbed_wire.meter = 0;
                }
                if (checkBox6.Checked == false)
                {
                    frmConcrete_stone.result = 0;
                    frmConcrete_stone.m3 = 0;
                }
                if (checkBox7.Checked == false)
                {
                    frmBinding_wire.result = 0;
                    frmBinding_wire.meter = 0;
                }
                if (checkBox8.Checked == false)
                {
                    frmWorker.result = 0;
                    frmWorker.meter = 0;
                }
                if (checkBox1.Checked == true)
                {
                    string wireNetting = frmWire_netting.result.ToString("0.##" + " ₺");
                    string concretePost = frmConcrete_post.result.ToString("0.##" + " ₺");
                    string strutPost = frmStrut_post.result.ToString("0.##" + " ₺");
                    string stretchingWire = frmStretching_wire.result.ToString("0.##" + " ₺");
                    string barbedWire = frmBarbed_wire.result.ToString("0.##" + " ₺");
                    string concretStone = frmConcrete_stone.result.ToString("0.##" + " ₺");
                    string bindingWire = frmBinding_wire.result.ToString("0.##" + " ₺");
                    string worker = frmWorker.result.ToString("0.##" + " ₺");
                    double result = frmWire_netting.result + frmConcrete_post.price + frmStrut_post.result + frmStretching_wire.result + frmBarbed_wire.result + frmConcrete_stone.result + frmBinding_wire.result + frmWorker.result;
                    string resultPrc = string.Format("{0:c}", result);
                    table.Rows.Add(wireNetting, concretePost, strutPost, stretchingWire, barbedWire, concretStone, bindingWire, worker);
                    metroGrid1.DataSource = table;
                    label2.Text = resultPrc;

                    string wireNettingMet = frmWire_netting.meter.ToString("0.##" + " m");
                    string concretPostPie = frmConcrete_post.piece.ToString("0.##" + " Adet");
                    string strutPostPie = frmStrut_post.piece.ToString("0.##" + " Adet");
                    string stretchingWireMet = frmStretching_wire.meter.ToString("0.##" + " m");
                    string barbedWireMet = frmBarbed_wire.meter.ToString("0.##" + " m");
                    string concretStoneM3 = frmConcrete_stone.m3.ToString("0.##" + " m3");
                    string bindingWireMet = frmBinding_wire.meter.ToString("0.##" + " m");
                    string workerMet = frmWorker.meter.ToString("0.##" + " m");
                    table2.Rows.Add(wireNettingMet, concretPostPie, strutPostPie, stretchingWireMet, barbedWireMet, concretStoneM3, bindingWireMet, workerMet);
                    metroGrid2.DataSource = table2;
                }
                else
                {
                    MessageBox.Show("Lütfen seçim yapınız!");
                }

                metroGrid1.Visible = true;
                metroGrid2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                panel1.Visible = true;

                metroGrid1.Columns[0].Width = 128;
                metroGrid1.Columns[1].Width = 128;
                metroGrid1.Columns[2].Width = 128;
                metroGrid1.Columns[3].Width = 128;
                metroGrid1.Columns[4].Width = 128;
                metroGrid1.Columns[5].Width = 128;
                metroGrid1.Columns[6].Width = 120;

                metroGrid2.Columns[0].Width = 128;
                metroGrid2.Columns[1].Width = 128;
                metroGrid2.Columns[2].Width = 128;
                metroGrid2.Columns[3].Width = 128;
                metroGrid2.Columns[4].Width = 128;
                metroGrid2.Columns[5].Width = 128;
                metroGrid2.Columns[6].Width = 120;

                CheckBox[] chkArr = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8 };
                for (int i = 0; i < 8; i++)
                {
                    if (chkArr[i].Checked == true)
                        chkArr[i].Checked = false;
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu! Program kapatılacak.", ex.Message);
                Environment.Exit(0);
            }
}

        private void metroTile4_Click(object sender, EventArgs e)
        {
            CheckBox[] chkArr = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7,checkBox8 };
            for (int i = 0; i < 8; i++)
            {
                if (chkArr[i].Checked == true)
                    chkArr[i].Checked = false;
            }
        }

        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in metroGrid2.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= metroGrid2.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = metroGrid2.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new Font(metroGrid2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(metroGrid2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(metroGrid2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(metroGrid2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new Font(new Font(metroGrid2.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in metroGrid2.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in metroGrid2.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Kafes Tel Örgü", typeof(string));
            table.Columns.Add("Beton Direk", typeof(string));
            table.Columns.Add("Payanda Direk", typeof(string));
            table.Columns.Add("Gerdirme Teli", typeof(string));
            table.Columns.Add("Dikenli Tel", typeof(string));
            table.Columns.Add("Beton ve Taş", typeof(string));
            table.Columns.Add("Bağlama Teli", typeof(string));
            table.Columns.Add("İşçilik", typeof(string));
            metroGrid1.DataSource = table;

            table2.Columns.Add("Kafes Tel Örgü", typeof(string));
            table2.Columns.Add("Beton Direk", typeof(string));
            table2.Columns.Add("Payanda Direk", typeof(string));
            table2.Columns.Add("Gerdirme Tel", typeof(string));
            table2.Columns.Add("Dikenli Tel", typeof(string));
            table2.Columns.Add("Beton ve Taş", typeof(string));
            table2.Columns.Add("Bağlama Teli", typeof(string));
            table2.Columns.Add("İşçilik", typeof(string));
            metroGrid2.DataSource = table2;
        }
    }
}
