namespace WinFormsApp1
{
    partial class FrmKullaniciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciPaneli));
            btnOduncKitapAl = new Button();
            cmbKullaniciListele = new ComboBox();
            btnOdunKitapVer = new Button();
            gBOduncKitapAl = new GroupBox();
            btnSorgula = new Button();
            cmbKullanici = new ComboBox();
            btnYenile = new Button();
            dateTimeteslimTarihi = new DateTimePicker();
            cmbSecilenRapor = new ComboBox();
            label12 = new Label();
            dateTimeAlmaTarihi = new DateTimePicker();
            label11 = new Label();
            dataGridKullanici = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            gBOduncKitapAl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridKullanici).BeginInit();
            SuspendLayout();
            // 
            // btnOduncKitapAl
            // 
            btnOduncKitapAl.BackColor = SystemColors.Control;
            btnOduncKitapAl.Cursor = Cursors.Hand;
            btnOduncKitapAl.FlatStyle = FlatStyle.Flat;
            btnOduncKitapAl.Font = new Font("Verdana", 11.25F);
            btnOduncKitapAl.ForeColor = Color.FromArgb(248, 148, 6);
            btnOduncKitapAl.Image = Properties.Resources.arrow_32_24;
            btnOduncKitapAl.ImageAlign = ContentAlignment.MiddleLeft;
            btnOduncKitapAl.Location = new Point(6, 22);
            btnOduncKitapAl.Name = "btnOduncKitapAl";
            btnOduncKitapAl.Size = new Size(170, 28);
            btnOduncKitapAl.TabIndex = 36;
            btnOduncKitapAl.Text = "Ödünç Kitap Al";
            btnOduncKitapAl.TextAlign = ContentAlignment.MiddleRight;
            btnOduncKitapAl.UseVisualStyleBackColor = false;
            btnOduncKitapAl.Click += btnOduncKitapAl_Click;
            // 
            // cmbKullaniciListele
            // 
            cmbKullaniciListele.FormattingEnabled = true;
            cmbKullaniciListele.Location = new Point(6, 128);
            cmbKullaniciListele.Name = "cmbKullaniciListele";
            cmbKullaniciListele.Size = new Size(342, 23);
            cmbKullaniciListele.TabIndex = 43;
            cmbKullaniciListele.SelectedIndexChanged += cmbKullaniciListele_SelectedIndexChanged;
            // 
            // btnOdunKitapVer
            // 
            btnOdunKitapVer.BackColor = SystemColors.Control;
            btnOdunKitapVer.Cursor = Cursors.Hand;
            btnOdunKitapVer.FlatStyle = FlatStyle.Flat;
            btnOdunKitapVer.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOdunKitapVer.ForeColor = Color.FromArgb(248, 148, 6);
            btnOdunKitapVer.Image = Properties.Resources.arrow_32_24___reverse;
            btnOdunKitapVer.ImageAlign = ContentAlignment.MiddleRight;
            btnOdunKitapVer.Location = new Point(514, 22);
            btnOdunKitapVer.Name = "btnOdunKitapVer";
            btnOdunKitapVer.Size = new Size(177, 28);
            btnOdunKitapVer.TabIndex = 39;
            btnOdunKitapVer.Text = "Ödünç Kitap Ver";
            btnOdunKitapVer.TextAlign = ContentAlignment.MiddleLeft;
            btnOdunKitapVer.UseVisualStyleBackColor = false;
            btnOdunKitapVer.Click += btnOdunKitapVer_Click;
            // 
            // gBOduncKitapAl
            // 
            gBOduncKitapAl.Controls.Add(btnSorgula);
            gBOduncKitapAl.Controls.Add(cmbKullanici);
            gBOduncKitapAl.Controls.Add(cmbSecilenRapor);
            gBOduncKitapAl.Controls.Add(btnYenile);
            gBOduncKitapAl.Controls.Add(dateTimeteslimTarihi);
            gBOduncKitapAl.Controls.Add(cmbKullaniciListele);
            gBOduncKitapAl.Controls.Add(label12);
            gBOduncKitapAl.Controls.Add(dateTimeAlmaTarihi);
            gBOduncKitapAl.Controls.Add(label11);
            gBOduncKitapAl.Controls.Add(btnOdunKitapVer);
            gBOduncKitapAl.Controls.Add(btnOduncKitapAl);
            gBOduncKitapAl.ForeColor = Color.White;
            gBOduncKitapAl.Location = new Point(12, 282);
            gBOduncKitapAl.Name = "gBOduncKitapAl";
            gBOduncKitapAl.Size = new Size(697, 166);
            gBOduncKitapAl.TabIndex = 38;
            gBOduncKitapAl.TabStop = false;
            gBOduncKitapAl.Text = "Ödünç Kitap ";
            // 
            // btnSorgula
            // 
            btnSorgula.BackColor = SystemColors.Control;
            btnSorgula.Cursor = Cursors.Hand;
            btnSorgula.FlatStyle = FlatStyle.Flat;
            btnSorgula.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSorgula.ForeColor = Color.FromArgb(248, 148, 6);
            btnSorgula.Image = Properties.Resources.search_24;
            btnSorgula.ImageAlign = ContentAlignment.MiddleRight;
            btnSorgula.Location = new Point(6, 64);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(101, 30);
            btnSorgula.TabIndex = 54;
            btnSorgula.Text = "Sorgula";
            btnSorgula.TextAlign = ContentAlignment.MiddleLeft;
            btnSorgula.UseVisualStyleBackColor = false;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // cmbKullanici
            // 
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(182, 27);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(326, 23);
            cmbKullanici.TabIndex = 53;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = SystemColors.Control;
            btnYenile.Cursor = Cursors.Hand;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYenile.ForeColor = Color.FromArgb(248, 148, 6);
            btnYenile.Image = Properties.Resources.available_updates_24;
            btnYenile.ImageAlign = ContentAlignment.MiddleRight;
            btnYenile.Location = new Point(602, 64);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(89, 30);
            btnYenile.TabIndex = 39;
            btnYenile.Text = "Yenile";
            btnYenile.TextAlign = ContentAlignment.MiddleLeft;
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // dateTimeteslimTarihi
            // 
            dateTimeteslimTarihi.Location = new Point(259, 90);
            dateTimeteslimTarihi.Margin = new Padding(3, 2, 3, 2);
            dateTimeteslimTarihi.Name = "dateTimeteslimTarihi";
            dateTimeteslimTarihi.Size = new Size(249, 23);
            dateTimeteslimTarihi.TabIndex = 48;
            // 
            // cmbSecilenRapor
            // 
            cmbSecilenRapor.FormattingEnabled = true;
            cmbSecilenRapor.Location = new Point(349, 128);
            cmbSecilenRapor.Name = "cmbSecilenRapor";
            cmbSecilenRapor.Size = new Size(342, 23);
            cmbSecilenRapor.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(241, 242, 246);
            label12.Location = new Point(169, 92);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 47;
            label12.Text = "Teslim Tarihi :";
            // 
            // dateTimeAlmaTarihi
            // 
            dateTimeAlmaTarihi.Location = new Point(259, 60);
            dateTimeAlmaTarihi.Margin = new Padding(3, 2, 3, 2);
            dateTimeAlmaTarihi.Name = "dateTimeAlmaTarihi";
            dateTimeAlmaTarihi.Size = new Size(249, 23);
            dateTimeAlmaTarihi.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(241, 242, 246);
            label11.Location = new Point(175, 64);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 45;
            label11.Text = "Alma Tarihi :";
            // 
            // dataGridKullanici
            // 
            dataGridKullanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridKullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKullanici.Location = new Point(12, 21);
            dataGridKullanici.Name = "dataGridKullanici";
            dataGridKullanici.RowHeadersWidth = 51;
            dataGridKullanici.Size = new Size(697, 255);
            dataGridKullanici.TabIndex = 37;
            // 
            // FrmKullaniciPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 84, 96);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 458);
            Controls.Add(gBOduncKitapAl);
            Controls.Add(dataGridKullanici);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmKullaniciPaneli";
            Text = "FrmKullaniciPaneli";
            Load += FrmKullaniciPaneli_Load;
            gBOduncKitapAl.ResumeLayout(false);
            gBOduncKitapAl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridKullanici).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public PictureBox pictureBox2;
        private PictureBox pictureBox1;
        public Button btnOduncKitapAl;
        private ComboBox cmbKullaniciListele;
        public Button btnOdunKitapVer;
        private GroupBox gBOduncKitapAl;
        private DataGridView dataGridKullanici;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimeAlmaTarihi;
        private Label label2;
        private DateTimePicker dateTimeteslimTarihi;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        public Button btnYenile;
        private MonthCalendar monthCalendar1;
        private ComboBox cmbKullanici;
        public Button btnSorgula;
        private ComboBox cmbSecilenRapor;
    }
}