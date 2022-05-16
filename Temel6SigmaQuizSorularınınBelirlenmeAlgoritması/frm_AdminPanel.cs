using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class frm_AdminPanel : Form
    {
        public frm_AdminPanel()
        {
            InitializeComponent();
        }

        private void frm_AdminPanel_Load(object sender, EventArgs e)
        {
            

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_adminPanelAdminEkle_Click(object sender, EventArgs e)
        {
            Frm_AdminEkle frm_AdminEkle = new Frm_AdminEkle();
            frm_AdminEkle.ShowDialog();
        }

        private void tbl_adminPanelSorumluEkle_Click(object sender, EventArgs e)
        {
            Frm_SorumluEkle frm_SorumluEkle = new Frm_SorumluEkle();
            frm_SorumluEkle.ShowDialog();

        }

        private void btn_adminPanelOgrBilgiGuncelle_Click(object sender, EventArgs e)
        {
            Frm_ogrBilgiGuncelle frm_OgrenciGuncelle= new Frm_ogrBilgiGuncelle();
            frm_OgrenciGuncelle.ShowDialog();

        }

        private void btn_adminSoruOnayla_Click(object sender, EventArgs e)
        {
            frm_soruOnayla frm_SoruOnayla = new frm_soruOnayla();
            frm_SoruOnayla.ShowDialog();
        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void picture_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int TogMove;
        int MValX;
        int MValY;
        private void frm_AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frm_AdminPanel_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frm_AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
