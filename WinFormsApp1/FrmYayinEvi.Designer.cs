namespace WinFormsApp1
{
    partial class FrmYayinEvi
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
            btnYayinEviKaydet = new Button();
            txtYayinEviAdi = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYayinEviKaydet
            // 
            btnYayinEviKaydet.FlatStyle = FlatStyle.Flat;
            btnYayinEviKaydet.ForeColor = Color.Black;
            btnYayinEviKaydet.Image = Properties.Resources.save_as_16;
            btnYayinEviKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnYayinEviKaydet.Location = new Point(248, 84);
            btnYayinEviKaydet.Margin = new Padding(3, 4, 3, 4);
            btnYayinEviKaydet.Name = "btnYayinEviKaydet";
            btnYayinEviKaydet.Size = new Size(114, 40);
            btnYayinEviKaydet.TabIndex = 26;
            btnYayinEviKaydet.Text = "Kaydet";
            btnYayinEviKaydet.UseVisualStyleBackColor = true;
            btnYayinEviKaydet.Click += btnYayinEviKaydet_Click;
            // 
            // txtYayinEviAdi
            // 
            txtYayinEviAdi.BackColor = Color.White;
            txtYayinEviAdi.ForeColor = Color.Black;
            txtYayinEviAdi.Location = new Point(117, 49);
            txtYayinEviAdi.Margin = new Padding(3, 4, 3, 4);
            txtYayinEviAdi.Name = "txtYayinEviAdi";
            txtYayinEviAdi.Size = new Size(245, 27);
            txtYayinEviAdi.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 18;
            label1.Text = "Yayın Evi Adı :";
            // 
            // FrmYayinEvi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 193);
            Controls.Add(btnYayinEviKaydet);
            Controls.Add(txtYayinEviAdi);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmYayinEvi";
            Text = "FrmYayinEvi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnYayinEviKaydet;
        public TextBox txtYayinEviAdi;
        public Label label1;
    }
}