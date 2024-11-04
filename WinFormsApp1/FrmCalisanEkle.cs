using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmCalisanEkle : Form
    {

        public FrmCalisanEkle()
        {
            InitializeComponent();
        }
        KullaniciService _kullaniciService=new KullaniciService();
        public void btnCalisanEkleKaydet_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = txtCalisanEkleAd.Text;
            kullanici.Soyad = txtCalisanEkleSoyad.Text;
            kullanici.KullaniciAdi = txtCalisanEkleKA.Text;
            kullanici.Sifre = txtCalisanEkleS.Text;           
            _kullaniciService.CalisanEkle(kullanici);
            MessageBox.Show("Kayıt Başarılı  "+ MessageBoxIcon.Asterisk);
            FrmYoneticiPaneli frmYoneticiPaneli = new FrmYoneticiPaneli();
            frmYoneticiPaneli.ShowDialog();
            this.Close();

        }

        private void FrmCalisanEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
