namespace WinFormsApp1
{
    partial class FrmCalisanPaneli
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
            groupBox1 = new GroupBox();
            cmbYayinEvi = new ComboBox();
            cmbYazarAdi = new ComboBox();
            comboBox1 = new ComboBox();
            btnAra = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            cmbKategori = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBasimYili = new TextBox();
            txtKitapID = new TextBox();
            txtISBN = new TextBox();
            txtFiyat = new TextBox();
            txtBaskıSayisi = new TextBox();
            txtKitapAdi = new TextBox();
            dataGridKitaplar = new DataGridView();
            btnOduncKitapListele = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnKitapEkle = new Button();
            cmbKullanici = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbYayinEvi);
            groupBox1.Controls.Add(cmbYazarAdi);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBasimYili);
            groupBox1.Controls.Add(txtKitapID);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(txtBaskıSayisi);
            groupBox1.Controls.Add(txtKitapAdi);
            groupBox1.Location = new Point(339, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 145);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // cmbYayinEvi
            // 
            cmbYayinEvi.FormattingEnabled = true;
            cmbYayinEvi.Location = new Point(346, 110);
            cmbYayinEvi.Name = "cmbYayinEvi";
            cmbYayinEvi.Size = new Size(121, 23);
            cmbYayinEvi.TabIndex = 45;
            // 
            // cmbYazarAdi
            // 
            cmbYazarAdi.FormattingEnabled = true;
            cmbYazarAdi.Location = new Point(346, 76);
            cmbYazarAdi.Name = "cmbYazarAdi";
            cmbYazarAdi.Size = new Size(121, 23);
            cmbYazarAdi.TabIndex = 44;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(505, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 43;
            // 
            // btnAra
            // 
            btnAra.BackColor = SystemColors.Control;
            btnAra.Cursor = Cursors.Hand;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAra.ForeColor = Color.FromArgb(255, 168, 1);
            btnAra.Image = Properties.Resources.search_24;
            btnAra.ImageAlign = ContentAlignment.MiddleLeft;
            btnAra.Location = new Point(744, 19);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(101, 36);
            btnAra.TabIndex = 42;
            btnAra.Text = "Ara";
            btnAra.TextAlign = ContentAlignment.MiddleRight;
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = SystemColors.Control;
            btnGüncelle.Cursor = Cursors.Hand;
            btnGüncelle.FlatStyle = FlatStyle.Flat;
            btnGüncelle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGüncelle.ForeColor = Color.FromArgb(24, 220, 255);
            btnGüncelle.Image = Properties.Resources.available_updates_24;
            btnGüncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGüncelle.Location = new Point(744, 104);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(101, 36);
            btnGüncelle.TabIndex = 41;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.Control;
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.FromArgb(255, 56, 56);
            btnSil.Image = Properties.Resources.delete_24;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(744, 62);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 36);
            btnSil.TabIndex = 40;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click_1;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(568, 19);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(170, 23);
            cmbKategori.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(596, 58);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 38;
            label10.Text = "Listele";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(505, 24);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 37;
            label9.Text = "Kategori :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 108);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 36;
            label8.Text = "Yayın Evi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 81);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 35;
            label7.Text = "Yazar Adı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 54);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 34;
            label6.Text = "Baskı Sayısı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 27);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 33;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 32;
            label4.Text = "Basım Yılı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 81);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 31;
            label3.Text = "Fiyat :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 30;
            label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 29;
            label1.Text = "Kitap ID :";
            // 
            // txtBasimYili
            // 
            txtBasimYili.Location = new Point(75, 106);
            txtBasimYili.Name = "txtBasimYili";
            txtBasimYili.Size = new Size(170, 23);
            txtBasimYili.TabIndex = 19;
            // 
            // txtKitapID
            // 
            txtKitapID.Location = new Point(75, 16);
            txtKitapID.Name = "txtKitapID";
            txtKitapID.Size = new Size(170, 23);
            txtKitapID.TabIndex = 20;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(329, 19);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(170, 23);
            txtISBN.TabIndex = 21;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(75, 76);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(170, 23);
            txtFiyat.TabIndex = 23;
            // 
            // txtBaskıSayisi
            // 
            txtBaskıSayisi.Location = new Point(329, 47);
            txtBaskıSayisi.Name = "txtBaskıSayisi";
            txtBaskıSayisi.Size = new Size(170, 23);
            txtBaskıSayisi.TabIndex = 25;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(75, 46);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(170, 23);
            txtKitapAdi.TabIndex = 24;
            // 
            // dataGridKitaplar
            // 
            dataGridKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKitaplar.Location = new Point(12, 171);
            dataGridKitaplar.Name = "dataGridKitaplar";
            dataGridKitaplar.RowHeadersWidth = 51;
            dataGridKitaplar.Size = new Size(1181, 400);
            dataGridKitaplar.TabIndex = 32;
            // 
            // btnOduncKitapListele
            // 
            btnOduncKitapListele.BackColor = Color.FromArgb(248, 148, 6);
            btnOduncKitapListele.Cursor = Cursors.Hand;
            btnOduncKitapListele.FlatStyle = FlatStyle.Flat;
            btnOduncKitapListele.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOduncKitapListele.ForeColor = Color.White;
            btnOduncKitapListele.Location = new Point(12, 70);
            btnOduncKitapListele.Name = "btnOduncKitapListele";
            btnOduncKitapListele.Size = new Size(164, 47);
            btnOduncKitapListele.TabIndex = 34;
            btnOduncKitapListele.Text = "Ödünç Kitap Listesi";
            btnOduncKitapListele.UseVisualStyleBackColor = false;
            btnOduncKitapListele.Click += btnOduncKitapListele_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 35;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.FromArgb(248, 148, 6);
            btnKitapEkle.Cursor = Cursors.Hand;
            btnKitapEkle.FlatStyle = FlatStyle.Flat;
            btnKitapEkle.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKitapEkle.ForeColor = Color.White;
            btnKitapEkle.Location = new Point(12, 7);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(164, 47);
            btnKitapEkle.TabIndex = 36;
            btnKitapEkle.Text = "Yeni Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // cmbKullanici
            // 
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(200, 35);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(121, 23);
            cmbKullanici.TabIndex = 37;
            // 
            // FrmCalisanPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 562);
            Controls.Add(cmbKullanici);
            Controls.Add(btnKitapEkle);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnOduncKitapListele);
            Controls.Add(groupBox1);
            Controls.Add(dataGridKitaplar);
            Name = "FrmCalisanPaneli";
            Text = "FrmCalisanPaneli";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        public Button btnAra;
        public Button btnGüncelle;
        public Button btnSil;
        private ComboBox cmbKategori;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBasimYili;
        private TextBox txtKitapID;
        private TextBox txtISBN;
        private TextBox txtFiyat;
        private TextBox txtBaskıSayisi;
        private TextBox txtKitapAdi;
        private DataGridView dataGridKitaplar;
        public Button btnOduncKitapListele;
        private DateTimePicker dateTimePicker1;
        public Button btnKitapEkle;
        private ComboBox cmbYayinEvi;
        private ComboBox cmbYazarAdi;
        private ComboBox cmbKullanici;
    }
}