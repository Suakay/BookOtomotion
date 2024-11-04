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
    public partial class FrmKategoriEkle : Form
    {
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        KategoriService _kategoriService=new KategoriService();
        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriAdi=txtKategoriAdi.Text;
            _kategoriService.KategoriEkle(kategori);
        }
    }
}
