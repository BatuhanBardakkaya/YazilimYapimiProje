using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class frm_ogrPanel : Form
    {
        public frm_ogrPanel()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frm_ogrAyarlar frm_OgrAyarlar = new frm_ogrAyarlar();
            frm_OgrAyarlar.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            frm_sinavaBasla frm_SinavaBasla = new frm_sinavaBasla();
            frm_SinavaBasla.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            frm_eksikKonular frm_eksikkonu = new frm_eksikKonular();
            frm_eksikkonu.ShowDialog();
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
        private void frm_ogrPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frm_ogrPanel_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frm_ogrPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void frm_ogrPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
