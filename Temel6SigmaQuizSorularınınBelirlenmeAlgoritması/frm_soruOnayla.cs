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
    public partial class frm_soruOnayla : Form
    {
        int soruID =1;
        public frm_soruOnayla()
        {
            InitializeComponent();
        }

        private void frm_soruOnayla_Load(object sender, EventArgs e)
        {
          
            sqlBaglantisi.baglanti();

            SqlCommand command = new SqlCommand($"select * from tblSorular where soruID=(select min(soruID) from tblSorular where onayliMi=0) ", sqlBaglantisi.baglanti());
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {

                soruID = Convert.ToInt16(dr["soruID"]);
                //MessageBox.Show("load kısmında soruID"+soruID);
                //label1.Text = dr["soru"].ToString();
                //label2.Text = dr["şıkA"].ToString();
                //label3.Text = dr["şıkB"].ToString();
                //label4.Text = dr["şıkC"].ToString();
                //label5.Text = dr["şıkD"].ToString();
                //label6.Text = dr["doğruŞık"].ToString();
                //if (!Convert.IsDBNull(dr["soruresmi"]))
                //{
                //    byte[] ressim = new byte[0];
                //    ressim = (byte[])(dr["soruresmi"]);
                //    MemoryStream memoryStream = new MemoryStream(ressim);
                //    pictureBox1.Image = Image.FromStream(memoryStream);

                //    command.Dispose();
                    // sqlBaglantisi.baglanti().Close();
                //}



            }
            dr.Close();
        }

        private void Btn_Onaylama_Click(object sender, EventArgs e)
        {
            if (Btn_Onaylama.ButtonText!= "Soruları Göster")
            {
                MessageBox.Show("Soru Onaylandı!");
            }
            
            
            sqlBaglantisi.baglanti();
            pictureBox1.Image = null;
            SqlCommand command = new SqlCommand($"select * from tblSorular where soruID={soruID} ", sqlBaglantisi.baglanti());
            SqlDataReader dr = command.ExecuteReader();
            bool onayliMi;
            Btn_Onaylama.ButtonText = "Soruyu Onayla";
            while (dr.Read())
            {
                onayliMi = Convert.ToBoolean(dr["OnayliMi"]);
                if (onayliMi == true)
                {
                    soruID++;
                  
                }
               
                if (onayliMi == false)
                {
                    SqlCommand commands = new SqlCommand($"update  tblSorular set OnayliMi=1 where soruID={soruID-1}", sqlBaglantisi.baglanti());
                  
                   
                    label1.Text = dr["soru"].ToString();
                    label2.Text = dr["şıkA"].ToString();
                    label3.Text = dr["şıkB"].ToString();
                    label4.Text = dr["şıkC"].ToString();
                    label5.Text = dr["şıkD"].ToString();
                    label6.Text = dr["doğruŞık"].ToString();
                  
                    soruID++; 

                 

                    if (!Convert.IsDBNull(dr["soruresmi"]))
                    {
                        byte[] ressim = new byte[0];
                        ressim = (byte[])(dr["soruresmi"]);
                        MemoryStream memoryStream = new MemoryStream(ressim);
                        pictureBox1.Image = Image.FromStream(memoryStream);

                        commands.Dispose();
                        // sqlBaglantisi.baglanti().Close();
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                    commands.ExecuteNonQuery();//önmemli açmak gerek
                   
                }
               
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

        private void frm_soruOnayla_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void frm_soruOnayla_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void frm_soruOnayla_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
