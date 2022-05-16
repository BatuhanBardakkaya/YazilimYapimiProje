using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }
        bool kayitVarMi = false;
        private void Btn_SifreYenileme_Click(object sender, EventArgs e)
        {   
            //sqlBaglantisi bgln = new sqlBaglantisi();
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
            {
                sqlBaglantisi.baglanti().Open();
            }

            #region BöyleBirKayıtVarMı
            //unuttuma basınca böyle bir kayıt olup olmadığını kontrol eder
            //SqlCommand s = new SqlCommand("select * from tblOgrenci ", bgln.baglanti());
            //SqlDataReader drr;
            //drr = s.ExecuteReader();
            //while (drr.Read())
            //{
            //    if (drr["email"].ToString() == Txt_SifremiUnuttum.Text && kayitVarMi == false)
            //    {
            //        MessageBox.Show("Başarılı.Böyle bir kayıt var.Lütfen Bekleyiniz.");
            //        kayitVarMi = true;
            //        break;
            //    }
            //    if (drr["email"].ToString() != Txt_SifremiUnuttum.Text)
            //    {
            //        kayitVarMi = false;

            //    }

            //}
            //if (!kayitVarMi)
            //{
            //    MessageBox.Show("böyle kayıt yok");
            //}
            //drr.Close();
          
               


            #endregion

            SqlCommand komut;
            SqlDataReader oku;
            if (radioButton1.Checked)
            {
                komut = new SqlCommand($"select * from tblOgrenci where email='{Txt_SifremiUnuttum.Text.ToString()}'", sqlBaglantisi.baglanti());
                boyleBirKayitVarMi("tblOgrenci", sqlBaglantisi.baglanti());
            }
            else if (radioButton2.Checked)
            {
                komut = new SqlCommand($"select * from tblAdmin where email='{Txt_SifremiUnuttum.Text.ToString()}'", sqlBaglantisi.baglanti());
                boyleBirKayitVarMi("tblAdmin", sqlBaglantisi.baglanti());
            }
            else
            {
                komut = new SqlCommand($"select * from tblSinavSorumlusu where email='{Txt_SifremiUnuttum.Text.ToString()}'", sqlBaglantisi.baglanti());
                boyleBirKayitVarMi("tblSinavSorumlusu", sqlBaglantisi.baglanti());
            }

            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                try
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadres = ("trombosit169@gmail.com");
                    String sifre = "22417531274";//benim mail şifresi...https://www.youtube.com/watch?v=sVGGj1Ya_qU güvenliği düşürmeleiyiz
                    String smtpsrvr = "smtp.gmail.com";
                    String kime = (oku["email"].ToString());
                    String konu = "Şifre Hatırlatma Talebi";
                    String yaz = ("Sayın " + oku["ad"].ToString() + " " + oku["soyad"].ToString() + "\n" + "Bizden " + tarih + " tarihinde şifre hatırlatma talebinde bulundunuz \nParolanız:" +
                        oku["sifre"].ToString() + "\nİyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadres, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadres);
                    mail.To.Add(kime);
                    mail.Subject = (konu);
                    mail.Body = (yaz);
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Bilgiler Uyuşuyor.Şifreniz Mail'e gönderildi.");
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Mail Gönderilemedi.Hata\n" + hata.Message);

                }
            }
           
            oku.Close();
        }
        void boyleBirKayitVarMi(string tabloAdi,SqlConnection con)
        {
            SqlCommand s = new SqlCommand($"select * from {tabloAdi}", con);
            SqlDataReader drr;
            drr = s.ExecuteReader();
            while (drr.Read())
            {
                if (drr["email"].ToString() == Txt_SifremiUnuttum.Text && kayitVarMi == false)
                {
                    MessageBox.Show("Başarılı.Böyle bir kayıt var.Lütfen Bekleyiniz.");
                    kayitVarMi = true;
                    break;
                }
                if (drr["email"].ToString() != Txt_SifremiUnuttum.Text)
                {
                    kayitVarMi = false;

                }

            }
            if (!kayitVarMi)
            {
                MessageBox.Show("böyle kayıt yok");
            }
            drr.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}

