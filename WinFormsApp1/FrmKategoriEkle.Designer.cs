namespace WinFormsApp1
{
    partial class FrmKategoriEkle
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
            btnKategoriKaydet = new Button();
            txtKategoriAdi = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKategoriKaydet
            // 
            btnKategoriKaydet.FlatStyle = FlatStyle.Flat;
            btnKategoriKaydet.ForeColor = Color.Black;
            btnKategoriKaydet.Image = Properties.Resources.save_as_16;
            btnKategoriKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategoriKaydet.Location = new Point(249, 103);
            btnKategoriKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKategoriKaydet.Name = "btnKategoriKaydet";
            btnKategoriKaydet.Size = new Size(114, 40);
            btnKategoriKaydet.TabIndex = 17;
            btnKategoriKaydet.Text = "Kaydet";
            btnKategoriKaydet.UseVisualStyleBackColor = true;
            btnKategoriKaydet.Click += btnKategoriKaydet_Click;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.BackColor = Color.White;
            txtKategoriAdi.ForeColor = Color.Black;
            txtKategoriAdi.Location = new Point(118, 68);
            txtKategoriAdi.Margin = new Padding(3, 4, 3, 4);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(245, 27);
            txtKategoriAdi.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 9;
            label1.Text = "Kategori Adı :";
            // 
            // FrmKategoriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 193);
            Controls.Add(btnKategoriKaydet);
            Controls.Add(txtKategoriAdi);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmKategoriEkle";
            Text = "FrmKategoriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnKategoriKaydet;
        public TextBox txtKategoriAdi;
        public Label label1;
    }
}