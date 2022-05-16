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
    public partial class frm_ogrAyarlar : Form
    {
        public frm_ogrAyarlar()
        {
            InitializeComponent();
        }
        public static int kacsoruOlacak=0;
        private void frm_ogrAyarlar_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 6;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 1;
            comboBox7.SelectedIndex = 2;
            comboBox8.SelectedIndex = 1;
            comboBox9.SelectedIndex = 5;
            comboBox10.SelectedIndex = 1;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 2;
            

        }

        private void btn_ogrAyarlarKayit_Click(object sender, EventArgs e)
        {   
            
            if (comboBox13.Text!="" && comboBox14.Text != "")
            {
                MessageBox.Show("Ayarlar Kaydedildi...");
                kacsoruOlacak = Convert.ToInt16(comboBox14.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş Kısımları Doldurunuz.");
            }
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
        private void frm_ogrAyarlar_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frm_ogrAyarlar_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frm_ogrAyarlar_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
