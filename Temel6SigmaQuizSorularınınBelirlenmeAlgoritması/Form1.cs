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
using System.Data.Sql;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }


        public static string epostaStringi;
        private void btn_kayıtOl_Click(object sender, EventArgs e)
        {
            frm_kayitOl formKayitOl = new frm_kayitOl();
            formKayitOl.Show();
            

        }
        //sqlBaglantisi bgln = new sqlBaglantisi();
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("Data Source=LAPTOP-D3S9ESL2;Initial Catalog=birleştirmeDeneme2;Integrated Security=True");
          
            SqlCommand komut;
            SqlDataReader dr;
            epostaStringi = txt_girisEposta.Text;
            MessageBox.Show("epostastringi:" + epostaStringi);

            if (radioButton1.Checked)
            {
                komut = new SqlCommand($"select * from tblOgrenci where email='{txt_girisEposta.Text}' and sifre='{ txt_girisSifre.Text}'", sqlBaglantisi.baglanti());
                dr = komut.ExecuteReader();
                if (dr.Read())//ogrenci
                {
                    MessageBox.Show("giris basarili:"+radioButton1.Text);

                }
                else
                {
                    MessageBox.Show("başarısız");
                }
                dr.Close();
            }
            if (radioButton2.Checked)//admin
            {
                komut = new SqlCommand($"select * from tblAdmin where email='{txt_girisEposta.Text}' and sifre='{ txt_girisSifre.Text}'", sqlBaglantisi.baglanti());
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("giris basarili:" + radioButton2.Text);
                    frm_AdminPanel frm_AdminPanel = new frm_AdminPanel();
                    frm_AdminPanel.ShowDialog();

                }
                else
                {
                    MessageBox.Show("başarısız");
                }
                dr.Close();
                
            }
            if (radioButton3.Checked)//sorumlu
            {
                komut = new SqlCommand($"select * from tblSinavSorumlusu where email='{txt_girisEposta.Text}' and sifre='{ txt_girisSifre.Text}'", sqlBaglantisi.baglanti());
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("giris basarili:" + radioButton3.Text);

                }
                else
                {
                    MessageBox.Show("başarısız");
                }
                dr.Close();
               
            }




            sqlBaglantisi.baglanti().Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti().Open();
            if (sqlBaglantisi.baglanti().State==ConnectionState.Open)
            {
                sqlBaglantisi.baglanti().Close();
            }
            radioButton1.Checked = true;
            txt_girisEposta.Focus();
           
        }

        private void btn_sifreUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum frmSifremiUnuttum = new FrmSifremiUnuttum();
            frmSifremiUnuttum.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_kayıtOl.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btn_kayıtOl.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_kayıtOl.Visible = true;
        }
    }
}
