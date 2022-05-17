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
    public partial class Frm_SorumluEkle : Form
    {
        public Frm_SorumluEkle()
        {
            InitializeComponent();
        }
        void tablodakiDegerleriOku()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ad,soyad,telefonNo,email,sifre,cinsiyet,iseBaslamaTarihi,dali,maas,adres,calismaYili,calismaSaati from tblSinavSorumlusu" +
              "", sqlBaglantisi.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds);
            Dtgw_Sorumlu.DataSource = ds.Tables[0];
        }
        private void Frm_SorumluEkle_Load(object sender, EventArgs e)
        {
            if (sqlBaglantisi.baglanti().State==ConnectionState.Closed)
                sqlBaglantisi.baglanti();
            if (sqlBaglantisi.baglanti().State==ConnectionState.Open)
                sqlBaglantisi.baglanti().Close();
            tablodakiDegerleriOku();
            Rb_SorumluErkek.Checked = true;
            Txt_SorumluAd.Focus();

        }
       // SqlConnection connect = new SqlConnection("Data Source=LAPTOP-D3S9ESL2;Initial Catalog=birleştirmeDeneme2;Integrated Security=True");
        private void Btn_KayitEkleAdmin_Click(object sender, EventArgs e)
        {
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti();
            if (sqlBaglantisi.baglanti().State==ConnectionState.Open)
            {
                sqlBaglantisi.baglanti().Close();
            }
            SqlCommand kayitekle = new SqlCommand("insert into tblSinavSorumlusu (ad,soyad,telefonNo,email,sifre,cinsiyet,iseBaslamaTarihi,dali,maas,adres,calismaYili,calismaSaati) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", sqlBaglantisi.baglanti());
            bool adminKayitliMi = true;
            if (Txt_SorumluAd.Text != "" && txt_SorumluSoyAd.Text != "" && txt_SorumluTelNo.Text != "" && txt_SorumluEposta.Text != "" && txt_SorumluSifre.Text != "" &&
                txt_SorumluMaas.Text != "" && Txt_SorumluAdres.Text != "" && Txt_SorumluCalismaYili.Text != "" && txt_SorumluDali.Text != "" && txt_SorumluGunlukSaat.Text != "")
            {
                SqlCommand adminMailKontrolKomut = new SqlCommand("select * from tblSinavSorumlusu", sqlBaglantisi.baglanti());
                SqlDataReader read = adminMailKontrolKomut.ExecuteReader();
                while (read.Read())
                {
                    if (read["email"].ToString() == txt_SorumluEposta.Text)
                    {
                        MessageBox.Show("böyle bir kayıt var.Tekrar deneyin.");
                        adminKayitliMi = false;
                        break;
                    }
                }
                read.Close();
                adminMailKontrolKomut.ExecuteNonQuery();

                if (adminKayitliMi)
                {
                    kayitekle.Parameters.AddWithValue("@p1", Txt_SorumluAd.Text);
                    kayitekle.Parameters.AddWithValue("@p2", txt_SorumluSoyAd.Text);
                    kayitekle.Parameters.AddWithValue("@p3", txt_SorumluTelNo.Text);
                    kayitekle.Parameters.AddWithValue("@p4", txt_SorumluEposta.Text);
                    kayitekle.Parameters.AddWithValue("@p5", txt_SorumluSifre.Text);
                    if (Rb_SorumluErkek.Checked)
                        kayitekle.Parameters.AddWithValue("@p6", 1);
                    else if (Rb_SorumluKadin.Checked)
                        kayitekle.Parameters.AddWithValue("@p6", 0);

                    kayitekle.Parameters.AddWithValue("@p7", Dtp_Sorumlu.Value.Month + "." + Dtp_Sorumlu.Value.Day + "." + Dtp_Sorumlu.Value.Year);
                    kayitekle.Parameters.AddWithValue("@p8", txt_SorumluDali.Text);
                    kayitekle.Parameters.AddWithValue("@p9", txt_SorumluMaas.Text);
                    kayitekle.Parameters.AddWithValue("@p10", Txt_SorumluAdres.Text);
                    kayitekle.Parameters.AddWithValue("@p11", Txt_SorumluCalismaYili.Text);
                    kayitekle.Parameters.AddWithValue("@p12", txt_SorumluGunlukSaat.Text);
                    kayitekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Eklendi.");
                    //return;
                }

            }
            else
            {
                MessageBox.Show("Lütfen Boş Yerleri Doldurunuz.");
            }




            tablodakiDegerleriOku();

            Txt_SorumluAd.Text = "";
            txt_SorumluSoyAd.Text = "";
            txt_SorumluTelNo.Text = "";
            txt_SorumluEposta.Text = "";
            txt_SorumluSifre.Text = "";
            txt_SorumluMaas.Text = "";
            Txt_SorumluAdres.Text = "";
            Txt_SorumluCalismaYili.Text = "";
            txt_SorumluDali.Text = "";
            txt_SorumluGunlukSaat.Text = "";
            sqlBaglantisi.baglanti().Close();
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
        private void Frm_SorumluEkle_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Frm_SorumluEkle_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Frm_SorumluEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
    

    

