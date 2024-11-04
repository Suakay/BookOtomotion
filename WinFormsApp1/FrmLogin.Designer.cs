namespace WinFormsApp1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            btnGiris = new Button();
            btnKayitOl = new Button();
            panel1 = new Panel();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtKayitSifre = new TextBox();
            label5 = new Label();
            txtKayitKullaniciAdi = new TextBox();
            label6 = new Label();
            btnKullaniciKayitOl = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label4 = new Label();
            picBox_Cikis = new PictureBox();
            pnlKayitOlBar = new Panel();
            pnlGirisBar = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Cikis).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(46, 49, 49);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderColor = Color.FromArgb(46, 49, 49);
            btnGiris.FlatAppearance.BorderSize = 0;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(1, 50);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(205, 71);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.FromArgb(46, 49, 49);
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.FlatAppearance.BorderColor = Color.FromArgb(46, 49, 49);
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(208, 50);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(205, 71);
            btnKayitOl.TabIndex = 1;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(btnGirisYap);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 314);
            panel1.TabIndex = 2;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(248, 148, 6);
            btnGirisYap.Cursor = Cursors.Hand;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(25, 190);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(372, 44);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(132, 132);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(265, 26);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 135);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(132, 76);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(265, 26);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 79);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 49, 49);
            panel2.Controls.Add(txtKayitSifre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtKayitKullaniciAdi);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnKullaniciKayitOl);
            panel2.Controls.Add(txtSoyad);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtAd);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 314);
            panel2.TabIndex = 5;
            // 
            // txtKayitSifre
            // 
            txtKayitSifre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKayitSifre.Location = new Point(132, 161);
            txtKayitSifre.Name = "txtKayitSifre";
            txtKayitSifre.Size = new Size(265, 26);
            txtKayitSifre.TabIndex = 8;
            txtKayitSifre.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(76, 161);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Şifre :";
            // 
            // txtKayitKullaniciAdi
            // 
            txtKayitKullaniciAdi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKayitKullaniciAdi.Location = new Point(132, 121);
            txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            txtKayitKullaniciAdi.Size = new Size(265, 26);
            txtKayitKullaniciAdi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 122);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Kullanıcı Adı :";
            // 
            // btnKullaniciKayitOl
            // 
            btnKullaniciKayitOl.BackColor = Color.FromArgb(52, 152, 219);
            btnKullaniciKayitOl.Cursor = Cursors.Hand;
            btnKullaniciKayitOl.FlatStyle = FlatStyle.Flat;
            btnKullaniciKayitOl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKullaniciKayitOl.ForeColor = Color.White;
            btnKullaniciKayitOl.Location = new Point(25, 220);
            btnKullaniciKayitOl.Name = "btnKullaniciKayitOl";
            btnKullaniciKayitOl.Size = new Size(372, 44);
            btnKullaniciKayitOl.TabIndex = 4;
            btnKullaniciKayitOl.Text = "Kayıt Ol";
            btnKullaniciKayitOl.UseVisualStyleBackColor = false;
            btnKullaniciKayitOl.Click += btnKullaniciKayitOl_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(132, 81);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(265, 26);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 83);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Soayd :";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(132, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(265, 26);
            txtAd.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 44);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 0;
            label4.Text = "Ad :";
            // 
            // picBox_Cikis
            // 
            picBox_Cikis.Cursor = Cursors.Hand;
            picBox_Cikis.ImageLocation = "../../../IMAGES/x.png";
            picBox_Cikis.Location = new Point(401, 3);
            picBox_Cikis.Name = "picBox_Cikis";
            picBox_Cikis.Size = new Size(16, 16);
            picBox_Cikis.TabIndex = 6;
            picBox_Cikis.TabStop = false;
            picBox_Cikis.Click += picBoxCikis_Click;
            // 
            // pnlKayitOlBar
            // 
            pnlKayitOlBar.Location = new Point(211, 112);
            pnlKayitOlBar.Name = "pnlKayitOlBar";
            pnlKayitOlBar.Size = new Size(205, 4);
            pnlKayitOlBar.TabIndex = 1;
            // 
            // pnlGirisBar
            // 
            pnlGirisBar.Location = new Point(4, 113);
            pnlGirisBar.Name = "pnlGirisBar";
            pnlGirisBar.Size = new Size(205, 4);
            pnlGirisBar.TabIndex = 1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 49);
            ClientSize = new Size(420, 446);
            Controls.Add(pnlKayitOlBar);
            Controls.Add(pnlGirisBar);
            Controls.Add(picBox_Cikis);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Cikis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button btnGiris;
        public Button btnKayitOl;
        public Panel panel1;
        public Label label1;
        public Button btnGirisYap;
        public TextBox txtSifre;
        public Label label2;
        public TextBox txtKullaniciAdi;
        public Panel panel2;
        public TextBox txtKayitSifre;
        public Label label5;
        public TextBox txtKayitKullaniciAdi;
        public Label label6;
        public Button btnKullaniciKayitOl;
        public TextBox txtSoyad;
        public Label label3;
        public TextBox txtAd;
        public Label label4;
        public PictureBox picBox_Cikis;
        public Panel pnlKayitOlBar;
        public Panel pnlGirisBar;
    }
}
