using BLL;
using Microsoft.EntityFrameworkCore;
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
    public partial class FrmCalisanPaneli : Form
    {
        public FrmCalisanPaneli(Kullanici loggedInUser)
        {
            InitializeComponent();
          
      

        }
        KategoriService _kategoriService = new KategoriService();
        KitapService _kitapService = new KitapService();
        YazarService _yazarService = new YazarService();
        YayinEviService _yayinEviService = new YayinEviService();
        KullaniciService _kullaniciService= new KullaniciService();
        public void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmYeniKitapKayit frmYeniKitapKayit = new FrmYeniKitapKayit(this);
            frmYeniKitapKayit.ShowDialog();
        }

        private void btnOduncKitapListele_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cmbKullanici.Text, out int kullaniciId)) // TextBox'tan ID'yi al
            {
                KullaniciGoster();
                Kullanici seciliKullanici = _kullaniciService.KullaniciGetir(kullaniciId);

            if (seciliKullanici != null)
                {
                    // Kullanıcının ödünç aldığı kitapları al
                    var oduncAlinanKitaplar = _kitapService.OduncAlinanTumKitaplar(seciliKullanici);

                    // DataGridView'e verileri bağlama
                    dataGridKitaplar.DataSource = oduncAlinanKitaplar.ToList();
                }
                else
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin.");
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtKitapID.Text, out int kitapId)) // TextBox'tan ID'yi al
            {
                ComboBoxYukle();

                Kitap kitap = _kitapService.KitapGetir(kitapId); // Kitap arama işlemi

                if (kitap != null)
                {
                    // Kitap bulunduysa bilgileri göster
                    txtKitapAdi.Text = kitap.KitapAdi;
                    txtFiyat.Text = kitap.Fiyat.ToString("C");
                    txtBasimYili.Text = kitap.BasimYili.ToString();
                    txtISBN.Text = kitap.ISBN.ToString();
                    txtBaskıSayisi.Text = kitap.BaskiSayisi.ToString();
                  //  txtYazar.Text = kitap.YazarID.(;
                   cmbYazarAdi.SelectedValue = kitap.YazarID; // Yazar ID'sine göre seç
                    cmbYayinEvi.SelectedValue = kitap.YayinEviID; // Yayınevi ID'sine göre seç
                    cmbKategori.SelectedValue = kitap.KategoriID; // Kategori ID'sine göre seç
                }
                else
                {
                    MessageBox.Show("Kitap bulunamadı.");
                }


            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID girin."); // Geçersiz ID durumunda mesaj göster
            }
        }



        public void KullaniciGoster()
        {
            cmbKullanici.DataSource = _kullaniciService.TumKullanicilariGetir();
            cmbKullanici.DisplayMember = "KullaniciAdi";
            cmbKullanici.ValueMember = "KullaniciID";
        }
        public void ComboBoxYukle()
        {
            cmbYayinEvi.DataSource = _yayinEviService.TumYayinEvleriniGetir();
            cmbYayinEvi.DisplayMember = "YayinEviAdi";
            cmbYayinEvi.ValueMember = "YayinEviID";

            cmbYazarAdi.DataSource = _yazarService.TumYazarlarıGetir()
            .Select(x => new
            {
                YazarID = x.YazarID,
                TamAd = $"{x.YazarAdi} {x.YazarSoyadi}"
            }).ToList();

            cmbYazarAdi.DisplayMember = "TamAd";
            cmbYazarAdi.ValueMember = "YazarID";

            cmbKategori.DataSource = _kategoriService.TumKategorileriGetir();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";

          
            

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtKitapID.Text, out int kitapId))
            {
                ComboBoxYukle();
                // Kitabı sil
                _kitapService.KitapSil(kitapId);
                MessageBox.Show("Kitap başarıyla silindi.");

                // Silme işleminden sonra form alanlarını temizle
                Temizle();
            }
        }
        private void Temizle()
        {
            // Form alanlarını temizle
            txtKitapAdi.Clear();
            txtFiyat.Clear();
            txtBasimYili.Clear();
            txtISBN.Clear();
            txtBaskıSayisi.Clear();
            cmbYazarAdi.SelectedIndex = -1;
            cmbYayinEvi.SelectedIndex = -1;
            cmbKategori.SelectedIndex = -1;

        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ComboBoxYukle();
            double fiyat = Convert.ToDouble(txtFiyat.Text);

            Kitap kitap = new Kitap
            {
                KitapID = int.Parse(txtKitapID.Text),
                KitapAdi = txtKitapAdi.Text,
                Fiyat = fiyat,
                BasimYili = Convert.ToInt32(txtBasimYili.Text),
                ISBN = Convert.ToInt32(txtISBN.Text),
                BaskiSayisi = Convert.ToInt32(txtBaskıSayisi.Text),
                YazarID = (int)cmbYazarAdi.SelectedValue,
                YayinEviID = (int)cmbYayinEvi.SelectedValue,
                KategoriID = (int)cmbKategori.SelectedValue
            };

            _kitapService.KitapDurumuGüncelle(kitap);
            
            MessageBox.Show("Kitap başarıyla güncellendi.");

            // Güncelleme işleminden sonra form alanlarını temizle
            Temizle();

        }

     
    }


}
