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
    public partial class FrmYazarEkle : Form
    {
        public FrmYazarEkle()
        {
            InitializeComponent();
        }

        YazarService _yazarService=new YazarService();
        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.YazarAdi=txtYazarAdi.Text;
            yazar.YazarSoyadi=txtYazarSoyad.Text;
            _yazarService.YazarEkle(yazar);
        }
    }
}
