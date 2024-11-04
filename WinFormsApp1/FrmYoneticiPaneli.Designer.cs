namespace WinFormsApp1
{
    partial class FrmYoneticiPaneli
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
            btnCalisanEkle = new Button();
            label1 = new Label();
            btnListele = new Button();
            txtMaxFiyat = new TextBox();
            txtMinFiyat = new TextBox();
            cmbYayinEvleri = new ComboBox();
            cmbKategoriler = new ComboBox();
            cmbYazarlar = new ComboBox();
            cmbRaporTuru = new ComboBox();
            dataGridRaporlama = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRaporlama).BeginInit();
            SuspendLayout();
            // 
            // btnCalisanEkle
            // 
            btnCalisanEkle.BackColor = Color.FromArgb(248, 148, 6);
            btnCalisanEkle.Cursor = Cursors.Hand;
            btnCalisanEkle.FlatStyle = FlatStyle.Flat;
            btnCalisanEkle.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCalisanEkle.ForeColor = Color.White;
            btnCalisanEkle.Location = new Point(10, 10);
            btnCalisanEkle.Name = "btnCalisanEkle";
            btnCalisanEkle.Size = new Size(116, 35);
            btnCalisanEkle.TabIndex = 14;
            btnCalisanEkle.Text = "Çalışan Ekle";
            btnCalisanEkle.UseVisualStyleBackColor = false;
            btnCalisanEkle.Click += btnCalisanEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 24;
            label1.Text = "Rapor Seçiniz :";
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(248, 148, 6);
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Verdana", 10.2F);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(10, 51);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(116, 35);
            btnListele.TabIndex = 23;
            btnListele.Text = "Rapor Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click_1;
            // 
            // txtMaxFiyat
            // 
            txtMaxFiyat.Location = new Point(616, 67);
            txtMaxFiyat.Name = "txtMaxFiyat";
            txtMaxFiyat.Size = new Size(100, 23);
            txtMaxFiyat.TabIndex = 22;
            // 
            // txtMinFiyat
            // 
            txtMinFiyat.Location = new Point(721, 67);
            txtMinFiyat.Name = "txtMinFiyat";
            txtMinFiyat.Size = new Size(100, 23);
            txtMinFiyat.TabIndex = 21;
            // 
            // cmbYayinEvleri
            // 
            cmbYayinEvleri.FormattingEnabled = true;
            cmbYayinEvleri.Location = new Point(490, 66);
            cmbYayinEvleri.Name = "cmbYayinEvleri";
            cmbYayinEvleri.Size = new Size(121, 23);
            cmbYayinEvleri.TabIndex = 20;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(364, 66);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(121, 23);
            cmbKategoriler.TabIndex = 19;
            // 
            // cmbYazarlar
            // 
            cmbYazarlar.FormattingEnabled = true;
            cmbYazarlar.Location = new Point(238, 65);
            cmbYazarlar.Name = "cmbYazarlar";
            cmbYazarlar.Size = new Size(121, 23);
            cmbYazarlar.TabIndex = 18;
            // 
            // cmbRaporTuru
            // 
            cmbRaporTuru.FormattingEnabled = true;
            cmbRaporTuru.Location = new Point(238, 17);
            cmbRaporTuru.Name = "cmbRaporTuru";
            cmbRaporTuru.Size = new Size(583, 23);
            cmbRaporTuru.TabIndex = 17;
            cmbRaporTuru.SelectedIndexChanged += cmbRaporTuru_SelectedIndexChanged_1;
            // 
            // dataGridRaporlama
            // 
            dataGridRaporlama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRaporlama.Location = new Point(8, 93);
            dataGridRaporlama.Name = "dataGridRaporlama";
            dataGridRaporlama.RowHeadersWidth = 51;
            dataGridRaporlama.Size = new Size(813, 465);
            dataGridRaporlama.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 25;
            label2.Text = "Yazar Adı ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 48);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 26;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(519, 47);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 27;
            label4.Text = "Yayın Evi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(634, 47);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 28;
            label5.Text = "Min Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(737, 47);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 29;
            label6.Text = "Max Fiyat";
            // 
            // FrmYoneticiPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 583);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListele);
            Controls.Add(txtMaxFiyat);
            Controls.Add(txtMinFiyat);
            Controls.Add(cmbYayinEvleri);
            Controls.Add(cmbKategoriler);
            Controls.Add(cmbYazarlar);
            Controls.Add(cmbRaporTuru);
            Controls.Add(dataGridRaporlama);
            Controls.Add(btnCalisanEkle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmYoneticiPaneli";
            Text = "FrmYoneticiPaneli";
            Load += FrmYoneticiPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridRaporlama).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnCalisanEkle;
        private Label label1;
        private Button btnListele;
        private TextBox txtMaxFiyat;
        private TextBox txtMinFiyat;
        private ComboBox cmbYayinEvleri;
        private ComboBox cmbKategoriler;
        private ComboBox cmbYazarlar;
        private ComboBox cmbRaporTuru;
        private DataGridView dataGridRaporlama;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}