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
using System.IO;

namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    public partial class frm_Sorumlu : Form
    {
        public frm_Sorumlu()
        {
            InitializeComponent();
        }
        string resimYolu;
        private void frm_Sorumlu_Load(object sender, EventArgs e)
        {
            txt_soru.Focus();
            cmb_dogruSik.SelectedIndex = 0;
            //SqlCommand kom = new SqlCommand("select soruresmi from tblSorular", sqlBaglantisi.baglanti());
            //SqlDataReader dr = kom.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (dr["soruresmi"] != null)
            //    {
            //        byte[] ressim = new byte[0];
            //        ressim = (byte[])(dr["soruresmi"]);
            //        MemoryStream memoryStream = new MemoryStream(ressim);
            //        pictureBox2.Image = Image.FromStream(memoryStream);
            //        dr.Close();
            //        kom.Dispose();
            //        sqlBaglantisi.baglanti().Close();
            //    }

            //}
           // sqlBaglantisi.baglanti().Close();

        }

       
        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Sec";
            openFileDialog1.Filter = "Jpeg dosyaları(*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpeg | Png Dosyaları(*.png) | *.png ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimYolu = openFileDialog1.FileName;
            }
        }

        private void btn_soruyuKaydet_Click(object sender, EventArgs e)
        {
            byte[] resim=null;
            if (pictureBox1.Image != null)
            {
                FileStream fileStream = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
                BinaryReader binaryreader = new BinaryReader(fileStream);
               
                resim = binaryreader.ReadBytes((int)fileStream.Length);
                binaryreader.Close();
                fileStream.Close();

            }
           
            if (sqlBaglantisi.baglanti().State == ConnectionState.Closed)
                sqlBaglantisi.baglanti();
            if (sqlBaglantisi.baglanti().State == ConnectionState.Open)
                sqlBaglantisi.baglanti().Close();
            SqlCommand komut = new SqlCommand();
          
            komut.Connection = sqlBaglantisi.baglanti();


          
            if (pictureBox1.Image!=null)
            {
                komut.CommandText = "insert into tblSorular(soru,soruresmi,şıkA,şıkB,şıkC,şıkD,doğruŞık) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                komut.Parameters.AddWithValue("@p1", txt_soru.Text);
                komut.Parameters.Add         ("@p2", SqlDbType.Image, resim.Length).Value = resim;
                komut.Parameters.AddWithValue("@p3", txt_şıkA.Text);
                komut.Parameters.AddWithValue("@p4", txt_şıkB.Text);
                komut.Parameters.AddWithValue("@p5", txt_şıkC.Text);
                komut.Parameters.AddWithValue("@p6", txt_şıkD.Text);
                komut.Parameters.AddWithValue("@p7", cmb_dogruSik.Text);
            }
            else
            {
                komut.CommandText = "insert into tblSorular(soru,şıkA,şıkB,şıkC,şıkD,doğruŞık) values (@p1,@p2,@p3,@p4,@p5,@p6)";
                komut.Parameters.AddWithValue("@p1", txt_soru.Text);
                komut.Parameters.AddWithValue("@p2", txt_şıkA.Text);
                komut.Parameters.AddWithValue("@p3", txt_şıkB.Text);
                komut.Parameters.AddWithValue("@p4", txt_şıkC.Text);
                komut.Parameters.AddWithValue("@p5", txt_şıkD.Text);
                komut.Parameters.AddWithValue("@p6", cmb_dogruSik.Text);
            }

            komut.ExecuteNonQuery();
            MessageBox.Show("eklendi");
            txt_soru.Text = "";
            txt_şıkA.Text = "";
            txt_şıkB.Text = "";
            txt_şıkC.Text = "";
            txt_şıkD.Text = "";
            pictureBox1.Image = null;
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
        private void frm_Sorumlu_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frm_Sorumlu_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frm_Sorumlu_MouseMove(object sender, MouseEventArgs e)
        {
            if(TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
