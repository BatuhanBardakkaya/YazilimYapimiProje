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
using Bunifu.Framework.UI;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class Frm_ogrBilgiGuncelle : Form
    {
        public Frm_ogrBilgiGuncelle()
        {
            InitializeComponent();
        }
        int adminID = 0;

       // SqlConnection con = new SqlConnection("Data Source=LAPTOP-D3S9ESL2;Initial Catalog=birleştirmeDeneme2;Integrated Security=True");
        string ad, soyad,telNo,email,sifre,ortalama,sinif,veliNo,ulasim,ogrenciDetay;
        private void Frm_ogrBilgiGuncelle_Load(object sender, EventArgs e)
        {
            if (sqlBaglantisi.baglanti().State==ConnectionState.Closed)
            {
                sqlBaglantisi.baglanti();
            }
            if (sqlBaglantisi.baglanti().State==ConnectionState.Open)
            {
                sqlBaglantisi.baglanti().Close();
            }
            textlabelvisible(false);
           // MessageBox.Show("e posta:"+Form1.epostaStringi);//E Postamız bu
        
            SqlCommand komutAdmin = new SqlCommand($"select * from tblAdmin where email='{Form1.epostaStringi}'", sqlBaglantisi.baglanti());
            SqlDataReader drAdmin;
            drAdmin = komutAdmin.ExecuteReader();
            while (drAdmin.Read())
            {   
                MessageBox.Show("Adi :"+drAdmin["ad"].ToString()+" soyadi:"+drAdmin["soyad"].ToString()+"admin idsi:"+drAdmin["AdminID"].ToString());
                adminID = Convert.ToInt16(drAdmin["AdminID"]);
            }
            drAdmin.Close();
            /*--------------------------------------*/
            SqlCommand komutOgrenci = new SqlCommand($"select * from tblOgrenci where AdminID={adminID}", sqlBaglantisi.baglanti());
            SqlDataReader drOgrenci = komutOgrenci.ExecuteReader();
            while (drOgrenci.Read())
            {
                cmb_ogrEmailSec.Items.Add(""+drOgrenci["email"].ToString());              
            }
            drOgrenci.Close();





            sqlBaglantisi.baglanti().Close();
        }

        private void cmb_ogrEmailSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cmb_ogrEmailSec.Text);
            textlabelvisible(true);
          //  sqlBaglantisi.baglanti().Open();
            SqlCommand ogrKomut = new SqlCommand($"select * from tblOgrenci where AdminID={adminID} and email='{cmb_ogrEmailSec.Text}'", sqlBaglantisi.baglanti());
            SqlDataReader reader=ogrKomut.ExecuteReader();
            while (reader.Read())
            {
                ad = reader["ad"].ToString();
                soyad= reader["soyad"].ToString();
                telNo = reader["telefonNo"].ToString();
                email = reader["email"].ToString();
                sifre = reader["sifre"].ToString();
                ortalama = reader["ortalama"].ToString();
                sinif = reader["sinif"].ToString();
                veliNo = reader["veliNo"].ToString();
                ulasim= reader["ulasim"].ToString(); 
                ogrenciDetay = reader["ogrenciDetay"].ToString();
                txt_guncelleAd.Text = ad;
                txt_guncelleSoyad.Text = soyad;
                txt_guncelleTelNo.Text = telNo;
                txt_guncelleEposta .Text = email;
                txt_guncelleSifre.Text = sifre;
                txt_guncelleOrtalama.Text = ortalama;
                cmb_sinifGuncelle.Text = sinif;
                txt_guncelleVeliNo.Text = veliNo;
                txt_guncelleUlasim.Text = ulasim;
                txt_guncelleBilgi.Text = ogrenciDetay;



            }
            sqlBaglantisi.baglanti().Close();

          
        }
        void textlabelvisible(bool on)
        {
            txt_guncelleAd.Visible = on;
            txt_guncelleSoyad.Visible = on;
            txt_guncelleEposta.Visible = on;
            txt_guncelleTelNo.Visible = on;
            txt_guncelleSifre.Visible = on;
            txt_guncelleOrtalama.Visible = on;
            txt_guncelleVeliNo.Visible = on;
            txt_guncelleUlasim.Visible = on;
            txt_guncelleBilgi.Visible = on;
            cmb_sinifGuncelle.Visible = on;
            bunifuCustomLabel1.Visible = on;
            bunifuCustomLabel2.Visible = on;
            bunifuCustomLabel3.Visible = on;
            bunifuCustomLabel4.Visible = on;
            bunifuCustomLabel5.Visible = on;
            bunifuCustomLabel6.Visible = on;
            bunifuCustomLabel7.Visible = on;
            bunifuCustomLabel8.Visible = on;
            bunifuCustomLabel9.Visible = on;
            bunifuCustomLabel10.Visible = on;
            btn_guncelle.Visible = on;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            sqlBaglantisi.baglanti();
         
            updateOgrVerileri(txt_guncelleAd,"ad",ad);
            updateOgrVerileri(txt_guncelleSoyad, "soyad", soyad);
            updateOgrVerileri(txt_guncelleTelNo,"telefonNo",telNo);
            updateOgrVerileri(txt_guncelleEposta, "email", email);
            updateOgrVerileri(txt_guncelleSifre, "sifre", sifre);
            updateOgrVerileri(txt_guncelleOrtalama, "ortalama", ortalama);
            //bu cmb olduğu için metoda uygulayamadık
            SqlCommand ogrUpdateKomutSinif = new SqlCommand($"update tblOgrenci set sinif='{cmb_sinifGuncelle.Text}' where sinif='{sinif}' ", sqlBaglantisi.baglanti());
            ogrUpdateKomutSinif.ExecuteNonQuery();
            updateOgrVerileri(txt_guncelleTelNo, "veliNo", veliNo);
            updateOgrVerileri(txt_guncelleTelNo, "ulasim", ulasim);
            updateOgrVerileri(txt_guncelleTelNo, "ogrenciDetay",ogrenciDetay);


            sqlBaglantisi.baglanti().Close();
            MessageBox.Show("guncellendi");
            this.Close();
        }
        void updateOgrVerileri(BunifuMetroTextbox tx,string databasename,string dataReaderdenGelenVeri)
        {
            SqlCommand command = new SqlCommand($"update tblOgrenci set {databasename}='{tx.Text}' where {databasename}='{dataReaderdenGelenVeri}' ", sqlBaglantisi.baglanti());
            command.ExecuteNonQuery();
        }
    }
}
