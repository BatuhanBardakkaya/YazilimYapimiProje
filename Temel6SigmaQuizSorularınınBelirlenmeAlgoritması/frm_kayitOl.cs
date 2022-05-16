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
    public partial class frm_kayitOl : Form
    {   // Data Source=LAPTOP-D3S9ESL2;Initial Catalog=altiSigmaProblemi;Integrated Security=True
        public frm_kayitOl()
        {
            InitializeComponent();
        }
     

        private void btn_frmKayitOl_Click(object sender, EventArgs e)
        {

            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti();

            string kayit = "insert into tblOgrenci(ad,soyad,email,telefonNo,sifre,cinsiyet,ortalama,sinif,veliNo,ulasim,ogrenciDetay,AdminID,SorumluID)" +
                  "values(@ad,@soyad,@email,@telefonNo,@sifre,@cinsiyet,@ortalama,@sinif,@veliNo,@ulasim,@ogrenciDetay,@AdminID,@SorumluID)";
            SqlCommand komut = new SqlCommand(kayit, sqlBaglantisi.baglanti());
            bool epostaKayitliMi = true;

            #region cmb'den ad soyadd çekme


            int sorumluID = 0, adminID = 0;
            string cmbsorumluStringi = cmb_sorumluSec.Text;
            string sorumluAd = "", sorumluSoyad = "";
            string[] cmbstringAyirSorumlu = cmbsorumluStringi.Split(' ');
            if (cmbstringAyirSorumlu.Length == 2)
            {
                sorumluAd = cmbstringAyirSorumlu[0];
                sorumluSoyad = cmbstringAyirSorumlu[1];
            }
            else if (cmbstringAyirSorumlu.Length == 3)
            {
                sorumluAd = cmbstringAyirSorumlu[0] + " " + cmbstringAyirSorumlu[1];
                sorumluSoyad = cmbstringAyirSorumlu[2];
            }

            string cmbAdminStringi = cmb_adminSec.Text;
            string adminAd = "", adminSoyad = "";
            string[] cmbstringAyirAdmin = cmbAdminStringi.Split(' ');
            if (cmbstringAyirAdmin.Length == 2)
            {
                adminAd = cmbstringAyirAdmin[0];
                adminSoyad = cmbstringAyirAdmin[1];
            }
            else if (cmbstringAyirAdmin.Length == 3)
            {
                adminAd = cmbstringAyirAdmin[0] + " " + cmbstringAyirAdmin[1];
                adminSoyad = cmbstringAyirAdmin[2];
            }
            SqlCommand sorumluIDalma = new SqlCommand($"select * from tblSinavSorumlusu where ad='{sorumluAd}' and soyad='{sorumluSoyad}'", sqlBaglantisi.baglanti());
            SqlDataReader Sorumlureader = sorumluIDalma.ExecuteReader();
            while (Sorumlureader.Read())
            {
                sorumluID = Convert.ToInt32(Sorumlureader["SorumluID"]);
            }
            Sorumlureader.Close();

            SqlCommand adminIDalma = new SqlCommand($"select * from tblAdmin where ad='{adminAd}' and soyad='{adminSoyad}'", sqlBaglantisi.baglanti());
            SqlDataReader Adminreader = adminIDalma.ExecuteReader();
            while (Adminreader.Read())
            {
                adminID = Convert.ToInt32(Adminreader["AdminID"]);
            }
            Adminreader.Close();
            #endregion

            #region insert into dalgaları 

            if (txt_kayitOlAd.Text != "" && txt_kayitOlSoyad.Text != "" && txt_kayitOlEposta.Text != "" && txt_KayitOlTelNo.Text != "" &&
                txt_kayitOlSifre.Text != "" && txt_kayitOlOrtalama.Text != "" && txt_kayitOlVeliNo.Text != "")
            {
                SqlCommand mailKontrolKomut = new SqlCommand("select * from tblOgrenci", sqlBaglantisi.baglanti());
                SqlDataReader read = mailKontrolKomut.ExecuteReader();

                while (read.Read())
                {
                    if (read["email"].ToString() == txt_kayitOlEposta.Text)
                    {
                        MessageBox.Show("böyle bir kayıt var.Tekrar deneyin.");
                        epostaKayitliMi = false;
                        break;
                    }


                }
                read.Close();
                mailKontrolKomut.ExecuteNonQuery();



                if (epostaKayitliMi == true)
                {

                    komut.Parameters.AddWithValue("@ad", txt_kayitOlAd.Text.ToString());
                    komut.Parameters.AddWithValue("@soyad", txt_kayitOlSoyad.Text.ToString());
                    komut.Parameters.AddWithValue("@email", txt_kayitOlEposta.Text.ToString());
                    komut.Parameters.AddWithValue("@telefonNo", txt_KayitOlTelNo.Text.ToString());
                    komut.Parameters.AddWithValue("@sifre", txt_kayitOlSifre.Text.ToString());
                    if (radio_KayitOlErkek.Checked)
                        komut.Parameters.AddWithValue("@cinsiyet", 1);
                    else if (radio_KayitOlKadin.Checked)
                        komut.Parameters.AddWithValue("@cinsiyet", 0);
                    komut.Parameters.AddWithValue("@ortalama", txt_kayitOlOrtalama.Text.ToString());
                    komut.Parameters.AddWithValue("@sinif", cmb_KayitOlSinif.Text.ToString());
                    komut.Parameters.AddWithValue("@veliNo", txt_kayitOlVeliNo.Text.ToString());
                    komut.Parameters.AddWithValue("@ulasim", txt_kayitOlUlasim.Text.ToString());
                    komut.Parameters.AddWithValue("@ogrenciDetay", txt_KayitOlBilgi.Text.ToString());
                    MessageBox.Show("adminID:" + adminID + "sorumluID" + sorumluID);
                    komut.Parameters.AddWithValue("@AdminID", adminID);

                    komut.Parameters.AddWithValue("@SorumluID", sorumluID);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("kayıt eklendi");

                    return;

                }



            }
            else
            {
                MessageBox.Show("boş yerleri doldurunuz.kayıt eklemenedi");
            }
            #endregion

            #region txt bosalt

            txt_kayitOlAd.Text = "";
            txt_kayitOlSoyad.Text = "";
            txt_KayitOlTelNo.Text = "";
            txt_kayitOlEposta.Text = "";
            txt_kayitOlSifre.Text = "";
            txt_kayitOlOrtalama.Text = "";
            txt_kayitOlVeliNo.Text = "";
            txt_kayitOlUlasim.Text = "";
            txt_KayitOlBilgi.Text = "";
            #endregion
            sqlBaglantisi.baglanti().Close();
        }
        private void frm_kayitOl_Load(object sender, EventArgs e)
        {
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti().Open();
            if (sqlBaglantisi.baglanti().State == ConnectionState.Open)
                sqlBaglantisi.baglanti().Close();

            #region cmb içersine sorumlu ve admin yazma

            SqlCommand cmbAdminAdiCekmeKomutu = new SqlCommand($"select * from tblAdmin ", sqlBaglantisi.baglanti());
            SqlDataReader reader = cmbAdminAdiCekmeKomutu.ExecuteReader();
            while (reader.Read())
            {
                cmb_adminSec.Items.Add(reader["ad"].ToString() + " " + reader["soyad"].ToString());
            }
            reader.Close();
            cmbAdminAdiCekmeKomutu.ExecuteNonQuery();

            SqlCommand cmbSorumluAdiCekmeKomutu = new SqlCommand($"select * from tblSinavSorumlusu", sqlBaglantisi.baglanti());
            SqlDataReader reader2 = cmbSorumluAdiCekmeKomutu.ExecuteReader();
            while (reader2.Read())
            {
                cmb_sorumluSec.Items.Add(reader2["ad"].ToString() + " " + reader2["soyad"].ToString());
            }
            reader2.Close();
            cmbSorumluAdiCekmeKomutu.ExecuteNonQuery();
            #endregion


            radio_KayitOlErkek.Checked = true;
            cmb_KayitOlSinif.SelectedIndex = 0;
            cmb_adminSec.SelectedIndex = 0;
            cmb_sorumluSec.SelectedIndex = 0;


            sqlBaglantisi.baglanti().Close();
        }

        private void cmb_sorumluSec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmb_adminSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

