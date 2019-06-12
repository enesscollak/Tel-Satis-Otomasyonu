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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {

        static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            _instance = this;
            ucDashboard ucD = new ucDashboard();
            ucD.Dock = DockStyle.Fill;
            mPanel.Controls.Add(ucD);
            mPanel.Controls["ucDashboard"].BringToFront();
        }

        public void metroTile2_Click(object sender, EventArgs e)
        {
            _instance = this;
            ucCustomer ucC = new ucCustomer();
            ucC.Dock = DockStyle.Fill;
            mPanel.Controls.Add(ucC);
            mPanel.Controls["ucCustomer"].BringToFront();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            _instance = this;
            ucPictureview ucpi = new ucPictureview();
            ucpi.Dock = DockStyle.Fill;
            mPanel.Controls.Add(ucpi);
            mPanel.Controls["ucPictureview"].BringToFront();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            _instance = this;
            ucUsers ucU = new ucUsers();
            ucU.Dock = DockStyle.Fill;
            mPanel.Controls.Add(ucU);
            mPanel.Controls["ucUsers"].BringToFront();
        }
        private void metroTile7_Click(object sender, EventArgs e)
        {
            frmAbout frmA = new frmAbout();
            frmA.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            frmReport rapor = new frmReport();
            rapor.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            ucDashboard ucD = new ucDashboard();
            ucD.Dock = DockStyle.Fill;
            mPanel.Controls.Add(ucD);
            mPanel.Controls["ucDashboard"].BringToFront();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
        private void metroTile10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
