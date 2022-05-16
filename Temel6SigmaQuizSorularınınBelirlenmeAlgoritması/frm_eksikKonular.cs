using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class frm_eksikKonular : Form
    {
        public frm_eksikKonular()
        {
            InitializeComponent();
        }
        int dakika = 9, saniye = 59;
        private void frm_eksikKonular_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            label1.Text = "9";
            label2.Text = "60";

            visibleAc(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika--;
            label1.Text = dakika.ToString();
        }
        int soruID = 5;
        int sa = 0, sayac = 0;

        private void btn_isaretle_Click(object sender, EventArgs e)
        {
            visibleAc(true);
           
            SqlCommand kom = new SqlCommand($"select * from tblSorular where onayliMi=1 and soruID={soruID}", sqlBaglantisi.baglanti());
            SqlDataReader dr = kom.ExecuteReader();
            btn_isaretle.ButtonText = "Soruyu Onayla";
            if (sa<10)
            {
                while (dr.Read())
                {
                    sa++;
                    label4.Text = dr["soru"].ToString();
                    label5.Text = dr["şıkA"].ToString();
                    label6.Text = dr["şıkB"].ToString();
                    label7.Text = dr["şıkC"].ToString();
                    label8.Text = dr["şıkD"].ToString();
                    if (!Convert.IsDBNull(dr["soruresmi"]))
                    {
                        byte[] ressim = new byte[0];
                        ressim = (byte[])(dr["soruresmi"]);
                        MemoryStream memoryStream = new MemoryStream(ressim);
                        pictureBox1.Image = Image.FromStream(memoryStream);
                    }
                    else
                        pictureBox1.Image = null;

                    string dogruSik = dr["doğruŞık"].ToString();

                    if ((radioButton1.Checked && dogruSik == "A") || (radioButton2.Checked && dogruSik == "B") || (radioButton3.Checked && dogruSik == "C") || (radioButton4.Checked && dogruSik == "D"))
                    {
                        sayac++;
                    }

                    soruID++;



                }
            }
            if (sa == 10)
            {
                MessageBox.Show($"sorular Bitti... {sayac} Doğru {sa - sayac} Yanlış");
                this.Close();
            }
            dr.Close();
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
        private void frm_eksikKonular_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frm_eksikKonular_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frm_eksikKonular_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saniye == 0)
            {
                saniye = 59;
            }
            label2.Text = saniye.ToString();
            saniye--;
            if (dakika <= 0 && saniye <= 1)
            {
                label1.Text = "0";
                label2.Text = "0";
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Sınavınız Bitti...");
                this.Hide();

            }
        }
        void visibleAc(bool on)
        {
            label1.Visible = on;
            label2.Visible = on;
            label3.Visible = on;
            label4.Visible = on;
            label5.Visible = on;
            label6.Visible = on;
            label7.Visible = on;
            label8.Visible = on;
            radioButton1.Visible = on;
            radioButton4.Visible = on;
            radioButton2.Visible = on;
            radioButton3.Visible = on;
            pictureBox1.Visible = on;
            if (on)
            {

                timer1.Start();
                timer2.Start();
            }

        }
    }
}
