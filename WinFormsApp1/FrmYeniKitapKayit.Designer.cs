namespace WinFormsApp1
{
    partial class FrmYeniKitapKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            grupBox_YeniKitapKayit = new GroupBox();
            btnYazarEkle = new Button();
            btnYayinEviEkle = new Button();
            btnKategoriEkle = new Button();
            btnKitapKaydet = new Button();
            txtISBN = new TextBox();
            cmbYazarAdi = new ComboBox();
            cmbYayinEvi = new ComboBox();
            cmbKategori = new ComboBox();
            txtKitapOzet = new TextBox();
            txtBaskiSayisi = new TextBox();
            txtBasimYili = new TextBox();
            txtFiyat = new TextBox();
            txtKitapAdi = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView_KayitliKitapListesi = new DataGridView();
            groupBox_KayitliKitapListesi = new GroupBox();
            grupBox_YeniKitapKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KayitliKitapListesi).BeginInit();
            groupBox_KayitliKitapListesi.SuspendLayout();
            SuspendLayout();
            // 
            // grupBox_YeniKitapKayit
            // 
            grupBox_YeniKitapKayit.BackColor = SystemColors.ActiveBorder;
            grupBox_YeniKitapKayit.Controls.Add(btnYazarEkle);
            grupBox_YeniKitapKayit.Controls.Add(btnYayinEviEkle);
            grupBox_YeniKitapKayit.Controls.Add(btnKategoriEkle);
            grupBox_YeniKitapKayit.Controls.Add(btnKitapKaydet);
            grupBox_YeniKitapKayit.Controls.Add(txtISBN);
            grupBox_YeniKitapKayit.Controls.Add(cmbYazarAdi);
            grupBox_YeniKitapKayit.Controls.Add(cmbYayinEvi);
            grupBox_YeniKitapKayit.Controls.Add(cmbKategori);
            grupBox_YeniKitapKayit.Controls.Add(txtKitapOzet);
            grupBox_YeniKitapKayit.Controls.Add(txtBaskiSayisi);
            grupBox_YeniKitapKayit.Controls.Add(txtBasimYili);
            grupBox_YeniKitapKayit.Controls.Add(txtFiyat);
            grupBox_YeniKitapKayit.Controls.Add(txtKitapAdi);
            grupBox_YeniKitapKayit.Controls.Add(label10);
            grupBox_YeniKitapKayit.Controls.Add(label9);
            grupBox_YeniKitapKayit.Controls.Add(label8);
            grupBox_YeniKitapKayit.Controls.Add(label7);
            grupBox_YeniKitapKayit.Controls.Add(label6);
            grupBox_YeniKitapKayit.Controls.Add(label5);
            grupBox_YeniKitapKayit.Controls.Add(label3);
            grupBox_YeniKitapKayit.Controls.Add(label2);
            grupBox_YeniKitapKayit.Controls.Add(label1);
            grupBox_YeniKitapKayit.Location = new Point(12, 12);
            grupBox_YeniKitapKayit.Name = "grupBox_YeniKitapKayit";
            grupBox_YeniKitapKayit.Size = new Size(832, 190);
            grupBox_YeniKitapKayit.TabIndex = 0;
            grupBox_YeniKitapKayit.TabStop = false;
            grupBox_YeniKitapKayit.Text = "Yeni Kitap Kayıt ";
            // 
            // btnYazarEkle
            // 
            btnYazarEkle.BackColor = SystemColors.Control;
            btnYazarEkle.Cursor = Cursors.Hand;
            btnYazarEkle.FlatStyle = FlatStyle.Popup;
            btnYazarEkle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYazarEkle.ForeColor = Color.Black;
            btnYazarEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnYazarEkle.Location = new Point(557, 117);
            btnYazarEkle.Name = "btnYazarEkle";
            btnYazarEkle.Size = new Size(94, 23);
            btnYazarEkle.TabIndex = 26;
            btnYazarEkle.Text = "Yazar Ekle";
            btnYazarEkle.UseVisualStyleBackColor = false;
            btnYazarEkle.Click += btnYazarEkle_Click;
            // 
            // btnYayinEviEkle
            // 
            btnYayinEviEkle.BackColor = SystemColors.Control;
            btnYayinEviEkle.Cursor = Cursors.Hand;
            btnYayinEviEkle.FlatStyle = FlatStyle.Popup;
            btnYayinEviEkle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYayinEviEkle.ForeColor = Color.Black;
            btnYayinEviEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnYayinEviEkle.Location = new Point(557, 88);
            btnYayinEviEkle.Name = "btnYayinEviEkle";
            btnYayinEviEkle.Size = new Size(94, 23);
            btnYayinEviEkle.TabIndex = 25;
            btnYayinEviEkle.Text = "Yayın Evi Ekle";
            btnYayinEviEkle.UseVisualStyleBackColor = false;
            btnYayinEviEkle.Click += btnYayinEviEkle_Click;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.BackColor = SystemColors.Control;
            btnKategoriEkle.Cursor = Cursors.Hand;
            btnKategoriEkle.FlatStyle = FlatStyle.Popup;
            btnKategoriEkle.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKategoriEkle.ForeColor = Color.Black;
            btnKategoriEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategoriEkle.Location = new Point(557, 60);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(94, 23);
            btnKategoriEkle.TabIndex = 24;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = false;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // btnKitapKaydet
            // 
            btnKitapKaydet.BackColor = SystemColors.Control;
            btnKitapKaydet.Cursor = Cursors.Hand;
            btnKitapKaydet.FlatStyle = FlatStyle.Flat;
            btnKitapKaydet.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKitapKaydet.ForeColor = Color.FromArgb(50, 255, 126);
            btnKitapKaydet.Image = Properties.Resources.save_as_24;
            btnKitapKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapKaydet.Location = new Point(557, 146);
            btnKitapKaydet.Name = "btnKitapKaydet";
            btnKitapKaydet.Size = new Size(94, 36);
            btnKitapKaydet.TabIndex = 22;
            btnKitapKaydet.Text = "Kaydet";
            btnKitapKaydet.TextAlign = ContentAlignment.MiddleRight;
            btnKitapKaydet.UseVisualStyleBackColor = false;
            btnKitapKaydet.Click += btnKitapKaydet_Click;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtISBN.Location = new Point(389, 28);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(162, 26);
            txtISBN.TabIndex = 20;
            // 
            // cmbYazarAdi
            // 
            cmbYazarAdi.FormattingEnabled = true;
            cmbYazarAdi.Location = new Point(389, 118);
            cmbYazarAdi.Name = "cmbYazarAdi";
            cmbYazarAdi.Size = new Size(162, 23);
            cmbYazarAdi.TabIndex = 19;
            // 
            // cmbYayinEvi
            // 
            cmbYayinEvi.FormattingEnabled = true;
            cmbYayinEvi.Location = new Point(389, 89);
            cmbYayinEvi.Name = "cmbYayinEvi";
            cmbYayinEvi.Size = new Size(162, 23);
            cmbYayinEvi.TabIndex = 18;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(389, 60);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(162, 23);
            cmbKategori.TabIndex = 17;
            // 
            // txtKitapOzet
            // 
            txtKitapOzet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKitapOzet.Location = new Point(657, 33);
            txtKitapOzet.Multiline = true;
            txtKitapOzet.Name = "txtKitapOzet";
            txtKitapOzet.Size = new Size(169, 149);
            txtKitapOzet.TabIndex = 16;
            // 
            // txtBaskiSayisi
            // 
            txtBaskiSayisi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBaskiSayisi.Location = new Point(129, 118);
            txtBaskiSayisi.Name = "txtBaskiSayisi";
            txtBaskiSayisi.Size = new Size(162, 26);
            txtBaskiSayisi.TabIndex = 15;
            // 
            // txtBasimYili
            // 
            txtBasimYili.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBasimYili.Location = new Point(129, 86);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(162, 26);
            txtBasimYili.TabIndex = 14;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFiyat.Location = new Point(129, 54);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(162, 26);
            txtFiyat.TabIndex = 13;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKitapAdi.Location = new Point(129, 22);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(162, 26);
            txtKitapAdi.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(22, 120);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 10;
            label10.Text = "Baskı Sayısı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(557, 31);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 9;
            label9.Text = "Kitap Özeti :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(307, 61);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 8;
            label8.Text = "Kategori :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(328, 31);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 7;
            label7.Text = "ISBN :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(297, 121);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 6;
            label6.Text = "Yazar Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(38, 90);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 5;
            label5.Text = "Basım Yılı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(69, 53);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 3;
            label3.Text = "Fiyatı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(302, 91);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Yayın Evi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "Kitabın Adı :";
            label1.Click += label1_Click;
            // 
            // dataGridView_KayitliKitapListesi
            // 
            dataGridView_KayitliKitapListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KayitliKitapListesi.Location = new Point(0, 22);
            dataGridView_KayitliKitapListesi.Name = "dataGridView_KayitliKitapListesi";
            dataGridView_KayitliKitapListesi.Size = new Size(826, 285);
            dataGridView_KayitliKitapListesi.TabIndex = 1;
            // 
            // groupBox_KayitliKitapListesi
            // 
            groupBox_KayitliKitapListesi.Controls.Add(dataGridView_KayitliKitapListesi);
            groupBox_KayitliKitapListesi.Location = new Point(12, 208);
            groupBox_KayitliKitapListesi.Name = "groupBox_KayitliKitapListesi";
            groupBox_KayitliKitapListesi.Size = new Size(832, 313);
            groupBox_KayitliKitapListesi.TabIndex = 2;
            groupBox_KayitliKitapListesi.TabStop = false;
            groupBox_KayitliKitapListesi.Text = "Kayıtlı Kitapların Listesi";
            // 
            // FrmYeniKitapKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 533);
            Controls.Add(groupBox_KayitliKitapListesi);
            Controls.Add(grupBox_YeniKitapKayit);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmYeniKitapKayit";
            Text = "FrmYeniKitapKayit";
            Load += FrmYeniKitapKayit_Load;
            grupBox_YeniKitapKayit.ResumeLayout(false);
            grupBox_YeniKitapKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KayitliKitapListesi).EndInit();
            groupBox_KayitliKitapListesi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public GroupBox grupBox_YeniKitapKayit;
        public Label label1;
        public Label label10;
        public Label label9;
        public Label label8;
        public Label label7;
        public Label label6;
        public Label label5;
        public Label label3;
        public Label label2;
        public TextBox txtISBN;
        public ComboBox cmbYazarAdi;
        public ComboBox cmbYayinEvi;
        public ComboBox cmbKategori;
        public TextBox txtKitapOzet;
        public TextBox txtBaskiSayisi;
        public TextBox txtBasimYili;
        public TextBox txtFiyat;
        public TextBox txtKitapAdi;
        public Button btnKitapKaydet;
        public DataGridView dataGridView_KayitliKitapListesi;
        public Button btnYazarEkle;
        public Button btnYayinEviEkle;
        public Button btnKategoriEkle;
        public GroupBox groupBox_KayitliKitapListesi;
    }
}