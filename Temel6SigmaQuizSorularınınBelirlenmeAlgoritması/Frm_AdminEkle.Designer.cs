
namespace Temel6SigmaQuizSorularınınBelirlenmeAlgoritması
{
    partial class Frm_AdminEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdminEkle));
            this.Dtgw_AdminEkle = new System.Windows.Forms.DataGridView();
            this.tblAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birleştirmeDeneme2DataSet4 = new Temel6SigmaQuizSorularınınBelirlenmeAlgoritması.birleştirmeDeneme2DataSet4();
            this.birleştirmeDeneme2DataSet2 = new Temel6SigmaQuizSorularınınBelirlenmeAlgoritması.birleştirmeDeneme2DataSet2();
            this.birleştirmeDeneme2DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAdminTableAdapter = new Temel6SigmaQuizSorularınınBelirlenmeAlgoritması.birleştirmeDeneme2DataSet4TableAdapters.tblAdminTableAdapter();
            this.Btn_KayitEkleAdmin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_AdminAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminTelNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminEposta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminSoyAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Rb_AdminErkek = new System.Windows.Forms.RadioButton();
            this.Rb_AdminKadin = new System.Windows.Forms.RadioButton();
            this.txt_AdminGunlukSaat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminYetkiSev = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminAdres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminCalismaYili = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_AdminMaas = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Dtp_Admin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iseBaslamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calismaYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiSeviyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunlukCalismaSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgw_AdminEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birleştirmeDeneme2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birleştirmeDeneme2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birleştirmeDeneme2DataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtgw_AdminEkle
            // 
            this.Dtgw_AdminEkle.AutoGenerateColumns = false;
            this.Dtgw_AdminEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgw_AdminEkle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewCheckBoxColumn,
            this.iseBaslamaTarihiDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.calismaYiliDataGridViewTextBoxColumn,
            this.yetkiSeviyesiDataGridViewTextBoxColumn,
            this.gunlukCalismaSaatiDataGridViewTextBoxColumn});
            this.Dtgw_AdminEkle.DataSource = this.tblAdminBindingSource;
            this.Dtgw_AdminEkle.Location = new System.Drawing.Point(1, 302);
            this.Dtgw_AdminEkle.Name = "Dtgw_AdminEkle";
            this.Dtgw_AdminEkle.Size = new System.Drawing.Size(1064, 150);
            this.Dtgw_AdminEkle.TabIndex = 20;
            // 
            // tblAdminBindingSource
            // 
            this.tblAdminBindingSource.DataMember = "tblAdmin";
            this.tblAdminBindingSource.DataSource = this.birleştirmeDeneme2DataSet4;
            // 
            // birleştirmeDeneme2DataSet4
            // 
            this.birleştirmeDeneme2DataSet4.DataSetName = "birleştirmeDeneme2DataSet4";
            this.birleştirmeDeneme2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birleştirmeDeneme2DataSet2
            // 
            this.birleştirmeDeneme2DataSet2.DataSetName = "birleştirmeDeneme2DataSet2";
            this.birleştirmeDeneme2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birleştirmeDeneme2DataSet2BindingSource
            // 
            this.birleştirmeDeneme2DataSet2BindingSource.DataSource = this.birleştirmeDeneme2DataSet2;
            this.birleştirmeDeneme2DataSet2BindingSource.Position = 0;
            // 
            // tblAdminTableAdapter
            // 
            this.tblAdminTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_KayitEkleAdmin
            // 
            this.Btn_KayitEkleAdmin.ActiveBorderThickness = 1;
            this.Btn_KayitEkleAdmin.ActiveCornerRadius = 20;
            this.Btn_KayitEkleAdmin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_KayitEkleAdmin.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_KayitEkleAdmin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_KayitEkleAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_KayitEkleAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_KayitEkleAdmin.BackgroundImage")));
            this.Btn_KayitEkleAdmin.ButtonText = "Verileri Kaydet";
            this.Btn_KayitEkleAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_KayitEkleAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_KayitEkleAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_KayitEkleAdmin.IdleBorderThickness = 1;
            this.Btn_KayitEkleAdmin.IdleCornerRadius = 20;
            this.Btn_KayitEkleAdmin.IdleFillColor = System.Drawing.Color.White;
            this.Btn_KayitEkleAdmin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_KayitEkleAdmin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_KayitEkleAdmin.Location = new System.Drawing.Point(14, 65);
            this.Btn_KayitEkleAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_KayitEkleAdmin.Name = "Btn_KayitEkleAdmin";
            this.Btn_KayitEkleAdmin.Size = new System.Drawing.Size(181, 41);
            this.Btn_KayitEkleAdmin.TabIndex = 12;
            this.Btn_KayitEkleAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_KayitEkleAdmin.Click += new System.EventHandler(this.Btn_KayitEkleAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(265, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(236, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(145, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(223, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(250, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(223, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(590, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "İşe Başlama Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(576, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Günlük Çlışma Saati";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(626, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Yetki Seviyesi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(641, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "Çalışma Yılı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(691, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 22);
            this.label12.TabIndex = 7;
            this.label12.Text = "Adres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(691, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 22);
            this.label13.TabIndex = 8;
            this.label13.Text = "Maas";
            // 
            // txt_AdminAd
            // 
            this.txt_AdminAd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminAd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminAd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminAd.BorderThickness = 3;
            this.txt_AdminAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminAd.isPassword = false;
            this.txt_AdminAd.Location = new System.Drawing.Point(304, 13);
            this.txt_AdminAd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminAd.Name = "txt_AdminAd";
            this.txt_AdminAd.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminAd.TabIndex = 1;
            this.txt_AdminAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminTelNo
            // 
            this.txt_AdminTelNo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminTelNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminTelNo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminTelNo.BorderThickness = 3;
            this.txt_AdminTelNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminTelNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminTelNo.isPassword = false;
            this.txt_AdminTelNo.Location = new System.Drawing.Point(304, 111);
            this.txt_AdminTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminTelNo.Name = "txt_AdminTelNo";
            this.txt_AdminTelNo.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminTelNo.TabIndex = 3;
            this.txt_AdminTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminEposta
            // 
            this.txt_AdminEposta.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminEposta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminEposta.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminEposta.BorderThickness = 3;
            this.txt_AdminEposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminEposta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminEposta.isPassword = false;
            this.txt_AdminEposta.Location = new System.Drawing.Point(304, 159);
            this.txt_AdminEposta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminEposta.Name = "txt_AdminEposta";
            this.txt_AdminEposta.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminEposta.TabIndex = 4;
            this.txt_AdminEposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminSifre
            // 
            this.txt_AdminSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminSifre.BorderThickness = 3;
            this.txt_AdminSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminSifre.isPassword = false;
            this.txt_AdminSifre.Location = new System.Drawing.Point(304, 201);
            this.txt_AdminSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminSifre.Name = "txt_AdminSifre";
            this.txt_AdminSifre.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminSifre.TabIndex = 5;
            this.txt_AdminSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminSoyAd
            // 
            this.txt_AdminSoyAd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminSoyAd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminSoyAd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminSoyAd.BorderThickness = 3;
            this.txt_AdminSoyAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminSoyAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminSoyAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminSoyAd.isPassword = false;
            this.txt_AdminSoyAd.Location = new System.Drawing.Point(304, 64);
            this.txt_AdminSoyAd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminSoyAd.Name = "txt_AdminSoyAd";
            this.txt_AdminSoyAd.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminSoyAd.TabIndex = 2;
            this.txt_AdminSoyAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Rb_AdminErkek
            // 
            this.Rb_AdminErkek.AutoSize = true;
            this.Rb_AdminErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Rb_AdminErkek.Location = new System.Drawing.Point(304, 250);
            this.Rb_AdminErkek.Name = "Rb_AdminErkek";
            this.Rb_AdminErkek.Size = new System.Drawing.Size(85, 29);
            this.Rb_AdminErkek.TabIndex = 20;
            this.Rb_AdminErkek.Text = "Erkek";
            this.Rb_AdminErkek.UseVisualStyleBackColor = true;
            // 
            // Rb_AdminKadin
            // 
            this.Rb_AdminKadin.AutoSize = true;
            this.Rb_AdminKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Rb_AdminKadin.Location = new System.Drawing.Point(395, 251);
            this.Rb_AdminKadin.Name = "Rb_AdminKadin";
            this.Rb_AdminKadin.Size = new System.Drawing.Size(86, 29);
            this.Rb_AdminKadin.TabIndex = 20;
            this.Rb_AdminKadin.Text = "Kadın";
            this.Rb_AdminKadin.UseVisualStyleBackColor = true;
            // 
            // txt_AdminGunlukSaat
            // 
            this.txt_AdminGunlukSaat.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminGunlukSaat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminGunlukSaat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminGunlukSaat.BorderThickness = 3;
            this.txt_AdminGunlukSaat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminGunlukSaat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminGunlukSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminGunlukSaat.isPassword = false;
            this.txt_AdminGunlukSaat.Location = new System.Drawing.Point(767, 234);
            this.txt_AdminGunlukSaat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminGunlukSaat.Name = "txt_AdminGunlukSaat";
            this.txt_AdminGunlukSaat.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminGunlukSaat.TabIndex = 11;
            this.txt_AdminGunlukSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminYetkiSev
            // 
            this.txt_AdminYetkiSev.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminYetkiSev.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminYetkiSev.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminYetkiSev.BorderThickness = 3;
            this.txt_AdminYetkiSev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminYetkiSev.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminYetkiSev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminYetkiSev.isPassword = false;
            this.txt_AdminYetkiSev.Location = new System.Drawing.Point(767, 192);
            this.txt_AdminYetkiSev.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminYetkiSev.Name = "txt_AdminYetkiSev";
            this.txt_AdminYetkiSev.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminYetkiSev.TabIndex = 10;
            this.txt_AdminYetkiSev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminAdres
            // 
            this.txt_AdminAdres.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminAdres.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminAdres.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminAdres.BorderThickness = 3;
            this.txt_AdminAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminAdres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminAdres.isPassword = false;
            this.txt_AdminAdres.Location = new System.Drawing.Point(767, 99);
            this.txt_AdminAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminAdres.Name = "txt_AdminAdres";
            this.txt_AdminAdres.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminAdres.TabIndex = 8;
            this.txt_AdminAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminCalismaYili
            // 
            this.txt_AdminCalismaYili.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminCalismaYili.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminCalismaYili.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminCalismaYili.BorderThickness = 3;
            this.txt_AdminCalismaYili.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminCalismaYili.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminCalismaYili.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminCalismaYili.isPassword = false;
            this.txt_AdminCalismaYili.Location = new System.Drawing.Point(767, 147);
            this.txt_AdminCalismaYili.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminCalismaYili.Name = "txt_AdminCalismaYili";
            this.txt_AdminCalismaYili.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminCalismaYili.TabIndex = 9;
            this.txt_AdminCalismaYili.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_AdminMaas
            // 
            this.txt_AdminMaas.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_AdminMaas.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminMaas.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_AdminMaas.BorderThickness = 3;
            this.txt_AdminMaas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminMaas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_AdminMaas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AdminMaas.isPassword = false;
            this.txt_AdminMaas.Location = new System.Drawing.Point(767, 52);
            this.txt_AdminMaas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AdminMaas.Name = "txt_AdminMaas";
            this.txt_AdminMaas.Size = new System.Drawing.Size(176, 34);
            this.txt_AdminMaas.TabIndex = 7;
            this.txt_AdminMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Dtp_Admin
            // 
            this.Dtp_Admin.BackColor = System.Drawing.Color.Black;
            this.Dtp_Admin.BorderRadius = 0;
            this.Dtp_Admin.ForeColor = System.Drawing.Color.White;
            this.Dtp_Admin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtp_Admin.FormatCustom = null;
            this.Dtp_Admin.Location = new System.Drawing.Point(767, 12);
            this.Dtp_Admin.Name = "Dtp_Admin";
            this.Dtp_Admin.Size = new System.Drawing.Size(176, 35);
            this.Dtp_Admin.TabIndex = 6;
            this.Dtp_Admin.Value = new System.DateTime(2022, 4, 27, 2, 26, 47, 287);
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 50;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 50;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "telefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "telefonNo";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 50;
            // 
            // cinsiyetDataGridViewCheckBoxColumn
            // 
            this.cinsiyetDataGridViewCheckBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.Name = "cinsiyetDataGridViewCheckBoxColumn";
            this.cinsiyetDataGridViewCheckBoxColumn.Width = 50;
            // 
            // iseBaslamaTarihiDataGridViewTextBoxColumn
            // 
            this.iseBaslamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "iseBaslamaTarihi";
            this.iseBaslamaTarihiDataGridViewTextBoxColumn.HeaderText = "iseBaslamaTarihi";
            this.iseBaslamaTarihiDataGridViewTextBoxColumn.Name = "iseBaslamaTarihiDataGridViewTextBoxColumn";
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "maas";
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.Width = 50;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 75;
            // 
            // calismaYiliDataGridViewTextBoxColumn
            // 
            this.calismaYiliDataGridViewTextBoxColumn.DataPropertyName = "calismaYili";
            this.calismaYiliDataGridViewTextBoxColumn.HeaderText = "calismaYili";
            this.calismaYiliDataGridViewTextBoxColumn.Name = "calismaYiliDataGridViewTextBoxColumn";
            this.calismaYiliDataGridViewTextBoxColumn.Width = 75;
            // 
            // yetkiSeviyesiDataGridViewTextBoxColumn
            // 
            this.yetkiSeviyesiDataGridViewTextBoxColumn.DataPropertyName = "yetkiSeviyesi";
            this.yetkiSeviyesiDataGridViewTextBoxColumn.HeaderText = "yetkiSeviyesi";
            this.yetkiSeviyesiDataGridViewTextBoxColumn.Name = "yetkiSeviyesiDataGridViewTextBoxColumn";
            this.yetkiSeviyesiDataGridViewTextBoxColumn.Width = 75;
            // 
            // gunlukCalismaSaatiDataGridViewTextBoxColumn
            // 
            this.gunlukCalismaSaatiDataGridViewTextBoxColumn.DataPropertyName = "gunlukCalismaSaati";
            this.gunlukCalismaSaatiDataGridViewTextBoxColumn.HeaderText = "gunlukCalismaSaati";
            this.gunlukCalismaSaatiDataGridViewTextBoxColumn.Name = "gunlukCalismaSaatiDataGridViewTextBoxColumn";
            // 
            // Frm_AdminEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.Dtp_Admin);
            this.Controls.Add(this.txt_AdminGunlukSaat);
            this.Controls.Add(this.txt_AdminYetkiSev);
            this.Controls.Add(this.txt_AdminAdres);
            this.Controls.Add(this.txt_AdminCalismaYili);
            this.Controls.Add(this.txt_AdminMaas);
            this.Controls.Add(this.Rb_AdminKadin);
            this.Controls.Add(this.Rb_AdminErkek);
            this.Controls.Add(this.txt_AdminSifre);
            this.Controls.Add(this.txt_AdminEposta);
            this.Controls.Add(this.txt_AdminSoyAd);
            this.Controls.Add(this.txt_AdminTelNo);
            this.Controls.Add(this.txt_AdminAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_KayitEkleAdmin);
            this.Controls.Add(this.Dtgw_AdminEkle);
            this.Name = "Frm_AdminEkle";
            this.Text = "Frm_AdminEkle";
            this.Load += new System.EventHandler(this.Frm_AdminEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgw_AdminEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birleştirmeDeneme2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birleştirmeDeneme2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birleştirmeDeneme2DataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtgw_AdminEkle;
        private System.Windows.Forms.BindingSource birleştirmeDeneme2DataSet2BindingSource;
        private birleştirmeDeneme2DataSet2 birleştirmeDeneme2DataSet2;
        private birleştirmeDeneme2DataSet4 birleştirmeDeneme2DataSet4;
        private System.Windows.Forms.BindingSource tblAdminBindingSource;
        private birleştirmeDeneme2DataSet4TableAdapters.tblAdminTableAdapter tblAdminTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_KayitEkleAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminTelNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminEposta;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminSifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminSoyAd;
        private System.Windows.Forms.RadioButton Rb_AdminErkek;
        private System.Windows.Forms.RadioButton Rb_AdminKadin;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminGunlukSaat;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminYetkiSev;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminAdres;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminCalismaYili;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_AdminMaas;
        private Bunifu.Framework.UI.BunifuDatepicker Dtp_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iseBaslamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calismaYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiSeviyesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunlukCalismaSaatiDataGridViewTextBoxColumn;
    }
}