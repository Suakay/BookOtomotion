namespace WinFormsApp1
{
    partial class FrmCalisanEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCalisanEkleAd = new TextBox();
            txtCalisanEkleSoyad = new TextBox();
            txtCalisanEkleKA = new TextBox();
            txtCalisanEkleS = new TextBox();
            btnCalisanEkleKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(233, 239, 236);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(233, 239, 236);
            label2.Location = new Point(44, 40);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(233, 239, 236);
            label3.Location = new Point(10, 70);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(233, 239, 236);
            label4.Location = new Point(53, 99);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Şifre :";
            // 
            // txtCalisanEkleAd
            // 
            txtCalisanEkleAd.BackColor = Color.FromArgb(106, 156, 137);
            txtCalisanEkleAd.ForeColor = Color.FromArgb(233, 239, 236);
            txtCalisanEkleAd.Location = new Point(95, 9);
            txtCalisanEkleAd.Name = "txtCalisanEkleAd";
            txtCalisanEkleAd.Size = new Size(100, 23);
            txtCalisanEkleAd.TabIndex = 4;
            // 
            // txtCalisanEkleSoyad
            // 
            txtCalisanEkleSoyad.BackColor = Color.FromArgb(106, 156, 137);
            txtCalisanEkleSoyad.ForeColor = Color.FromArgb(233, 239, 236);
            txtCalisanEkleSoyad.Location = new Point(95, 37);
            txtCalisanEkleSoyad.Name = "txtCalisanEkleSoyad";
            txtCalisanEkleSoyad.Size = new Size(100, 23);
            txtCalisanEkleSoyad.TabIndex = 5;
            // 
            // txtCalisanEkleKA
            // 
            txtCalisanEkleKA.BackColor = Color.FromArgb(106, 156, 137);
            txtCalisanEkleKA.ForeColor = Color.FromArgb(233, 239, 236);
            txtCalisanEkleKA.Location = new Point(95, 67);
            txtCalisanEkleKA.Name = "txtCalisanEkleKA";
            txtCalisanEkleKA.Size = new Size(100, 23);
            txtCalisanEkleKA.TabIndex = 6;
            // 
            // txtCalisanEkleS
            // 
            txtCalisanEkleS.BackColor = Color.FromArgb(106, 156, 137);
            txtCalisanEkleS.ForeColor = Color.FromArgb(233, 239, 236);
            txtCalisanEkleS.Location = new Point(95, 96);
            txtCalisanEkleS.Name = "txtCalisanEkleS";
            txtCalisanEkleS.Size = new Size(100, 23);
            txtCalisanEkleS.TabIndex = 7;
            // 
            // btnCalisanEkleKaydet
            // 
            btnCalisanEkleKaydet.FlatStyle = FlatStyle.Flat;
            btnCalisanEkleKaydet.ForeColor = Color.FromArgb(233, 239, 236);
            btnCalisanEkleKaydet.Image = Properties.Resources.save_as_16;
            btnCalisanEkleKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalisanEkleKaydet.Location = new Point(95, 125);
            btnCalisanEkleKaydet.Name = "btnCalisanEkleKaydet";
            btnCalisanEkleKaydet.Size = new Size(100, 30);
            btnCalisanEkleKaydet.TabIndex = 8;
            btnCalisanEkleKaydet.Text = "Kaydet";
            btnCalisanEkleKaydet.UseVisualStyleBackColor = true;
            btnCalisanEkleKaydet.Click += btnCalisanEkleKaydet_Click;
            // 
            // FrmCalisanEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 66, 60);
            ClientSize = new Size(233, 167);
            Controls.Add(btnCalisanEkleKaydet);
            Controls.Add(txtCalisanEkleS);
            Controls.Add(txtCalisanEkleKA);
            Controls.Add(txtCalisanEkleSoyad);
            Controls.Add(txtCalisanEkleAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCalisanEkle";
            Text = "CalisanEkle";
            Load += FrmCalisanEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public TextBox txtCalisanEkleAd;
        public TextBox txtCalisanEkleSoyad;
        public TextBox txtCalisanEkleKA;
        public TextBox txtCalisanEkleS;
        public Button btnCalisanEkleKaydet;
    }
}