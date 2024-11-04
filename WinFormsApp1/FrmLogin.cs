using BLL;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Models;

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        KullaniciService _kullaniciService = new KullaniciService();

        Color select_color = Color.FromArgb(46, 49, 49);

        public void btnGiris_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            pnlGirisBar.BackColor = Color.Yellow;
            pnlKayitOlBar.BackColor = select_color;
            btnGiris.BackColor = select_color;
            btnKayitOl.BackColor = Color.Black;


        }

        public void btnKayitOl_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            pnlKayitOlBar.BackColor = Color.Yellow;
            pnlGirisBar.BackColor = select_color;
            btnKayitOl.BackColor = select_color;
            btnGiris.BackColor = Color.Black;
        }

        public void picBoxCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Kullanici kullanici = new Kullanici();
        public void btnGirisYap_Click(object sender, EventArgs e)
        {
            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            kullanici.Sifre = txtSifre.Text;


            kullanici = _kullaniciService.KullaniciGiris(kullanici.KullaniciAdi, kullanici.Sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
                return;
            }
            switch (kullanici.KullaniciTipi)
            {
                case KullaniciTipi.Calisan:
                    if (kullanici != null)
                    {

                        FrmCalisanPaneli frmCalisanPaneli = new FrmCalisanPaneli(kullanici);
                        frmCalisanPaneli.ShowDialog();
                    }
                    break;

                case KullaniciTipi.Uye:
                    if (kullanici != null)
                    {
                        
                        FrmKullaniciPaneli frmKullaniciPaneli = new FrmKullaniciPaneli(kullanici); 
                        frmKullaniciPaneli.ShowDialog();
                    }
                    break;

                case KullaniciTipi.Yonetici:
                    FrmYoneticiPaneli frmYoneticiPaneli = new FrmYoneticiPaneli();
                    frmYoneticiPaneli.ShowDialog();
                    break;

                default:
                    MessageBox.Show("Geçersiz kullanýcý türü!");
                    break;
            }

            
        }

        private void btnKullaniciKayitOl_Click(object sender, EventArgs e)
        {
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.KullaniciAdi = txtKayitKullaniciAdi.Text;
            kullanici.Sifre = txtKayitSifre.Text;
            kullanici.KullaniciTipi = KullaniciTipi.Calisan;
            _kullaniciService.KullaniciEkle(kullanici);



        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
