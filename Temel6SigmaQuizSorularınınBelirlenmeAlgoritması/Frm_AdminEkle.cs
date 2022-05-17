using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class Frm_AdminEkle : Form
    {
        public Frm_AdminEkle()
        {
            InitializeComponent();
        }

    

        private void Frm_AdminEkle_Load(object sender, EventArgs e)
        {
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti();
            if (sqlBaglantisi.baglanti().State == ConnectionState.Open)
                sqlBaglantisi.baglanti().Close();
            tablodakiDegerleriOku();
            Rb_AdminErkek.Checked = true;
            txt_AdminAd.Focus();
        }




        void tablodakiDegerleriOku()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ad,soyad,telefonNo,email,sifre,cinsiyet,iseBaslamaTarihi,maas,adres,calismaYili,yetkiSeviyesi,gunlukCalismaSaati from tblAdmin" +
              "", sqlBaglantisi.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            Dtgw_AdminEkle.DataSource = ds.Tables[0];
        }
        private void Btn_KayitEkleAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand kayitekle = new SqlCommand("insert into tblAdmin (ad,soyad,telefonNo,email,sifre,cinsiyet,iseBaslamaTarihi,maas,adres,calismaYili,yetkiSeviyesi,gunlukCalismaSaati) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", sqlBaglantisi.baglanti());
            bool adminKayitliMi = true;
            if (txt_AdminAd.Text!="" && txt_AdminSoyAd.Text != "" && txt_AdminTelNo.Text != "" && txt_AdminEposta.Text != "" && txt_AdminSifre.Text != "" &&
                txt_AdminMaas.Text != "" && txt_AdminAdres.Text != "" && txt_AdminCalismaYili.Text != "" && txt_AdminYetkiSev.Text != "" && txt_AdminGunlukSaat.Text != "" )
            {
                SqlCommand adminMailKontrolKomut = new SqlCommand("select * from tblAdmin", sqlBaglantisi.baglanti());
                SqlDataReader read = adminMailKontrolKomut.ExecuteReader();
                while (read.Read())
                {
                    if (read["email"].ToString() == txt_AdminEposta.Text)
                    {
                        MessageBox.Show("Böyle bir kayıt var.Tekrar Deneyin.");
                        adminKayitliMi = false;
                        break;
                    }
                }
                read.Close();
                adminMailKontrolKomut.ExecuteNonQuery();

                if (adminKayitliMi)
                {
                    kayitekle.Parameters.AddWithValue("@p1", txt_AdminAd.Text);
                    kayitekle.Parameters.AddWithValue("@p2", txt_AdminSoyAd.Text);
                    kayitekle.Parameters.AddWithValue("@p3", txt_AdminTelNo.Text);
                    kayitekle.Parameters.AddWithValue("@p4", txt_AdminEposta.Text);
                    kayitekle.Parameters.AddWithValue("@p5", txt_AdminSifre.Text);
                    if (Rb_AdminErkek.Checked)
                        kayitekle.Parameters.AddWithValue("@p6", 1);
                    else if (Rb_AdminKadin.Checked)
                        kayitekle.Parameters.AddWithValue("@p6", 0);

                    kayitekle.Parameters.AddWithValue("@p7", Dtp_Admin.Value.Month + "." + Dtp_Admin.Value.Day + "." + Dtp_Admin.Value.Year);
                    kayitekle.Parameters.AddWithValue("@p8", txt_AdminMaas.Text);
                    kayitekle.Parameters.AddWithValue("@p9", txt_AdminAdres.Text);
                    kayitekle.Parameters.AddWithValue("@p10", txt_AdminCalismaYili.Text);
                    kayitekle.Parameters.AddWithValue("@p11", txt_AdminYetkiSev.Text);
                    kayitekle.Parameters.AddWithValue("@p12", txt_AdminGunlukSaat.Text);
                    kayitekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi.");
                    //return;
                }
              
            }
            else
            {
                MessageBox.Show("Boş Yerleri doldurunuz.");
            }




            tablodakiDegerleriOku();

            txt_AdminAd.Text = "";
            txt_AdminSoyAd.Text = "";
            txt_AdminTelNo.Text = "";
            txt_AdminEposta.Text = "";
            txt_AdminSifre.Text = "";
            txt_AdminMaas.Text = "";
            txt_AdminAdres.Text = "";
            txt_AdminCalismaYili.Text = "";
            txt_AdminYetkiSev.Text = "";
            txt_AdminGunlukSaat.Text = "";
            sqlBaglantisi.baglanti().Close();
        }
        int TogMove;
        int MValX;
        int MValY;
        private void Frm_AdminEkle_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Frm_AdminEkle_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Frm_AdminEkle_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
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
    }
}
