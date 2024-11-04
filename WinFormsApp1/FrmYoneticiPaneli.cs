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
    public partial class FrmYoneticiPaneli : Form
    {
        public FrmYoneticiPaneli()
        {
            InitializeComponent();
        }


        KitapService _kitapService = new KitapService();
        YayinEviService _yayinEviService = new YayinEviService();
        YazarService _yazarService = new YazarService();
        KategoriService _kategoriService = new KategoriService();


        public void RaporuOlustur()
        {
            string secilenRapor = cmbRaporTuru.SelectedItem.ToString();
            IEnumerable<Kitap> kitaplar = null;

            switch (secilenRapor)
            {
                case "Tüm Kitaplar":
                    kitaplar = _kitapService.TumKitaplariGetir();
                    break;
                case "Yazarın Kitapları":
                    int yazarId = (int)cmbYazarlar.SelectedValue; // Yazar ID
                    kitaplar = _kitapService.YazarlarinKitaplariniGetir(yazarId);
                    break;
                case "Kategorideki Kitaplar":
                    int kategoriId = (int)cmbKategoriler.SelectedValue; // Kategori ID
                    kitaplar = _kitapService.KategoridekiKitaplariGetir(kategoriId);
                    break;
                case "Yayın Evindeki Kitaplar":
                    int yayinEviId = (int)cmbYayinEvleri.SelectedValue; // Yayın Evi ID
                    kitaplar = _kitapService.YayinEvindekiKitaplariGetir(yayinEviId);
                    break;
                case "En Son Eklenen Kitaplar":
                    kitaplar = _kitapService.EnSonEklenenKitaplariGetir();
                    break;
                case "Fiyat Aralığına Göre Kitaplar":
                    double minFiyat = double.Parse(txtMinFiyat.Text); // Minimum fiyatı al
                    double maxFiyat = double.Parse(txtMaxFiyat.Text); // Maksimum fiyatı al
                    kitaplar = _kitapService.FiyatAraligiKitaplariniGetir(minFiyat, maxFiyat);
                    break;
            }

            dataGridRaporlama.DataSource = kitaplar.ToList();
        }


        public void ComboBoxYukle()
        {
            cmbYayinEvleri.DataSource = _yayinEviService.TumYayinEvleriniGetir();
            cmbYayinEvleri.DisplayMember = "YayinEviAdi";
            cmbYayinEvleri.ValueMember = "YayinEviID";

            cmbYazarlar.DataSource = _yazarService.TumYazarlarıGetir()
            .Select(x => new
            {
                YazarID = x.YazarID,
                TamAd = $"{x.YazarAdi} {x.YazarSoyadi}"
            }).ToList();

            cmbYazarlar.DisplayMember = "TamAd";
            cmbYazarlar.ValueMember = "YazarID";

            cmbKategoriler.DataSource = _kategoriService.TumKategorileriGetir();
            cmbKategoriler.DisplayMember = "KategoriAdi";
            cmbKategoriler.ValueMember = "KategoriID";
        }

        public void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            FrmCalisanEkle frmCalisanEkle = new FrmCalisanEkle();
            frmCalisanEkle.ShowDialog();
        }

    
        private void FrmYoneticiPaneli_Load(object sender, EventArgs e)
        {

            ComboBoxYukle();
            cmbRaporTuru.Items.AddRange(new string[]
   {
        "Tüm Kitaplar",
        "Yazarın Kitapları",
        "Kategorideki Kitaplar",
        "Yayın Evindeki Kitaplar",
        "En Son Eklenen Kitaplar",
        "Fiyat Aralığına Göre Kitaplar"
   });


            cmbYazarlar.Visible = false;
            cmbKategoriler.Visible = false;
            cmbYayinEvleri.Visible = false;
            txtMinFiyat.Visible = false;
            txtMaxFiyat.Visible = false;


            cmbRaporTuru.SelectedIndex = 0;
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            RaporuOlustur();
        }

        private void cmbRaporTuru_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string secilenRapor = cmbRaporTuru.SelectedItem.ToString();
            cmbYazarlar.Visible = secilenRapor == "Yazarın Kitapları";
            cmbKategoriler.Visible = secilenRapor == "Kategorideki Kitaplar";
            cmbYayinEvleri.Visible = secilenRapor == "Yayın Evindeki Kitaplar";
            txtMinFiyat.Visible = secilenRapor == "Fiyat Aralığına Göre Kitaplar";
            txtMaxFiyat.Visible = secilenRapor == "Fiyat Aralığına Göre Kitaplar";
        }
    }
}
    

