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
    public partial class frm_AdminPanel : Form
    {
        public frm_AdminPanel()
        {
            InitializeComponent();
        }

        private void frm_AdminPanel_Load(object sender, EventArgs e)
        {
            

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_adminPanelAdminEkle_Click(object sender, EventArgs e)
        {
            Frm_AdminEkle frm_AdminEkle = new Frm_AdminEkle();
            frm_AdminEkle.ShowDialog();
        }

        private void tbl_adminPanelSorumluEkle_Click(object sender, EventArgs e)
        {
            Frm_SorumluEkle frm_SorumluEkle = new Frm_SorumluEkle();
            frm_SorumluEkle.ShowDialog();

        }

        private void btn_adminPanelOgrBilgiGuncelle_Click(object sender, EventArgs e)
        {
            Frm_ogrBilgiGuncelle frm_OgrenciGuncelle= new Frm_ogrBilgiGuncelle();
            frm_OgrenciGuncelle.ShowDialog();

        }
    }
}
