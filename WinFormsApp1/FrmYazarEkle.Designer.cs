namespace WinFormsApp1
{
    partial class FrmYazarEkle
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
            btnYazarKaydet = new Button();
            txtYazarSoyad = new TextBox();
            txtYazarAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYazarKaydet
            // 
            btnYazarKaydet.FlatStyle = FlatStyle.Flat;
            btnYazarKaydet.ForeColor = Color.Black;
            btnYazarKaydet.Image = Properties.Resources.save_as_16;
            btnYazarKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnYazarKaydet.Location = new Point(248, 106);
            btnYazarKaydet.Margin = new Padding(3, 4, 3, 4);
            btnYazarKaydet.Name = "btnYazarKaydet";
            btnYazarKaydet.Size = new Size(114, 40);
            btnYazarKaydet.TabIndex = 26;
            btnYazarKaydet.Text = "Kaydet";
            btnYazarKaydet.UseVisualStyleBackColor = true;
            btnYazarKaydet.Click += btnYazarKaydet_Click;
            // 
            // txtYazarSoyad
            // 
            txtYazarSoyad.BackColor = Color.White;
            txtYazarSoyad.ForeColor = Color.Black;
            txtYazarSoyad.Location = new Point(117, 71);
            txtYazarSoyad.Margin = new Padding(3, 4, 3, 4);
            txtYazarSoyad.Name = "txtYazarSoyad";
            txtYazarSoyad.Size = new Size(245, 27);
            txtYazarSoyad.TabIndex = 23;
            // 
            // txtYazarAdi
            // 
            txtYazarAdi.BackColor = Color.White;
            txtYazarAdi.ForeColor = Color.Black;
            txtYazarAdi.Location = new Point(117, 33);
            txtYazarAdi.Margin = new Padding(3, 4, 3, 4);
            txtYazarAdi.Name = "txtYazarAdi";
            txtYazarAdi.Size = new Size(245, 27);
            txtYazarAdi.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 19;
            label2.Text = "Yazar Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 18;
            label1.Text = "Yazar Adı :";
            // 
            // FrmYazarEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 193);
            Controls.Add(btnYazarKaydet);
            Controls.Add(txtYazarSoyad);
            Controls.Add(txtYazarAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmYazarEkle";
            Text = "FrmYazarEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnYazarKaydet;
        public TextBox txtYazarSoyad;
        public TextBox txtYazarAdi;
        public Label label2;
        public Label label1;
    }
}