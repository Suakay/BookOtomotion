using BLL;
using DAL;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmKullaniciPaneli : Form
    {
        KitapService _kitapService = new KitapService();
        YayinEviService _yayinEviService = new YayinEviService();
        YazarService _yazarService = new YazarService();
        KategoriService _kategoriService = new KategoriService();
        KullaniciService _kullaniciService = new KullaniciService();
        Kullanici kullanici;

        public FrmKullaniciPaneli(Kullanici loggedInUser)
        {
            InitializeComponent();
            kullanici = loggedInUser;
        }
        private void btnOdunKitapVer_Click(object sender, EventArgs e)
        {
            if (dataGridKullanici.SelectedRows.Count > 0)
            {
                int kitapId = (int)dataGridKullanici.SelectedRows[0].Cells["KitapID"].Value;
                Kitap kitap = _kitapService.GetKitapById(kitapId);

                
                if (cmbKullanici.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                int kullaniciId = (int)cmbKullanici.SelectedValue;
                Kullanici kullanici = _kullaniciService.GetKullaniciById(kullaniciId);

                if (kitap != null && kullanici != null)
                {
                    _kullaniciService.KitapOduncAl(kullanici, kitap);
                    MessageBox.Show("Kitap başarıyla ödünç verildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kitap veya kullanıcı seçimi yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödünç verilecek kitabı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KitaplariYukle();
            MessageBox.Show("Kitap listesi başarıyla yenilendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridKullanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnOduncKitapAl_Click(object sender, EventArgs e)
        {
            if (dataGridKullanici.SelectedRows.Count > 0)
            {

                int kitapId = (int)dataGridKullanici.SelectedRows[0].Cells["KitapID"].Value;
                Kitap kitap = _kitapService.GetKitapById(kitapId);
                if (kitap != null)
                {
                    _kullaniciService.KitapOduncAl(kullanici, kitap);
                    MessageBox.Show("Kitap başarıyla ödünç alındı.");
                }
                else
                {
                    MessageBox.Show("Kitap seçimi yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KitaplariYukle()
        {
            var kitapListesi = _kitapService.TumKitaplariGetir();
            dataGridKullanici.DataSource = kitapListesi;
        }
        private void KullaniciYukle()
        {
            var kullaniciListesi = _kullaniciService.TumKullanicilariGetir();
            cmbKullanici.DataSource = kullaniciListesi;
            cmbKullanici.DisplayMember = "KullaniciAdi";
            cmbKullanici.ValueMember = "KullaniciID";
        }


        public void FrmKullaniciPaneli_Load(object sender, EventArgs e)
        {

            cmbKullaniciListele.Items.AddRange(new string[]
   {
        "Tüm Kitaplar",
        "Yazarın Kitapları",
        "Kategorideki Kitaplar",
        "Yayın Evindeki Kitaplar",
        "En Son Eklenen Kitaplar",
   });
            cmbKullaniciListele.SelectedIndex = 0;
        }
        public void RaporuOlustur()
        {
            
            string secilenRapor = cmbKullaniciListele.SelectedItem.ToString();

            // İkinci ComboBox'u (cmbSecilenRapor) temizliyoruz
            

            switch (secilenRapor)
            {
                case "Tüm Kitaplar":
                    // Eğer "Tüm Kitaplar" seçilirse, ikinci combo box'ı boş bırakabiliriz
                    cmbSecilenRapor.Items.Add("Tüm kitaplar seçildi, ek detay yok.");
                    break;

                case "Yazarın Kitapları":
                    // Eğer "Yazarın Kitapları" seçildiyse, ikinci combo box'a yazarları dolduruyoruz
                    List<Yazar> yazarListesi = (List<Yazar>)_yazarService.TumYazarlarıGetir();
                    cmbSecilenRapor.DataSource = yazarListesi;
                    cmbSecilenRapor.DisplayMember = "YazarAdi"; // Görüntülenecek olan isim
                    cmbSecilenRapor.ValueMember = "YazarID"; // ID, seçili değer olacak
                    break;

                case "Kategorideki Kitaplar":
                    // Eğer "Kategorideki Kitaplar" seçildiyse, kategorileri dolduruyoruz
                    List<Kategori> kategoriListesi = (List<Kategori>)_kategoriService.TumKategorileriGetir();
                    cmbSecilenRapor.DataSource = kategoriListesi;
                    cmbSecilenRapor.DisplayMember = "KategoriAdi";
                    cmbSecilenRapor.ValueMember = "KategoriID";
                    break;

                case "Yayın Evindeki Kitaplar":
                    // Eğer "Yayın Evindeki Kitaplar" seçildiyse, yayın evlerini dolduruyoruz
                    List<YayinEvi> yayinEviListesi = (List<YayinEvi>)_yayinEviService.TumYayinEvleriniGetir();
                    cmbSecilenRapor.DataSource = yayinEviListesi;
                    cmbSecilenRapor.DisplayMember = "YayinEviAdi";
                    cmbSecilenRapor.ValueMember = "YayinEviID";
                    break;

                case "En Son Eklenen Kitaplar":
                    // En son eklenen kitaplar seçildiyse, sadece bir mesaj ekleyebiliriz
                    cmbSecilenRapor.Items.Add("Son eklenen kitaplar listelendi.");
                    break;

                default:
                    MessageBox.Show("Geçersiz rapor seçimi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            dataGridKullanici.DataSource = cmbSecilenRapor;
        }

        private void cmbKullaniciListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaporuOlustur();

        }
    }
}
        


