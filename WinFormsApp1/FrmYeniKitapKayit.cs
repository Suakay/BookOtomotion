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
    public partial class FrmYeniKitapKayit : Form
    {
        public FrmYeniKitapKayit(FrmCalisanPaneli frmCalisanPaneli)
        {
            InitializeComponent();
        }

        KategoriService _kategoriService = new KategoriService();
        KitapService _kitapService = new KitapService();
        YazarService _yazarService = new YazarService();
        YayinEviService _yayinEviService = new YayinEviService();
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
             Kitap kitap = new Kitap();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.Fiyat = double.Parse(txtFiyat.Text);
            kitap.BasimYili = int.Parse(txtBasimYili.Text);
            kitap.BaskiSayisi = int.Parse(txtBaskiSayisi.Text);
            kitap.ISBN = int.Parse(txtISBN.Text);
            kitap.KategoriID = (int)cmbKategori.SelectedValue;
            kitap.YayinEviID = (int)cmbYayinEvi.SelectedValue;
            kitap.YazarID= (int)cmbYazarAdi.SelectedValue;
            kitap.KitapOzeti = txtKitapOzet.Text;
            _kitapService.KitapEkle(kitap);
            ComboBoxYukle();
            _kitapService.EnSonEklenenKitaplariGetir();
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


        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriEkle frmKategoriEkle = new FrmKategoriEkle();
            frmKategoriEkle.ShowDialog();
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            FrmYayinEvi frmYayinEvi = new FrmYayinEvi();
            frmYayinEvi.ShowDialog();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            FrmYazarEkle frmYazarEkle = new FrmYazarEkle();
            frmYazarEkle.ShowDialog();
        }

        private void FrmYeniKitapKayit_Load(object sender, EventArgs e)
        {
            ComboBoxYukle();
        }
    }
}
