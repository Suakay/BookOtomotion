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
    public partial class FrmYayinEvi : Form
    {
        public FrmYayinEvi()
        {
            InitializeComponent();
        }

        YayinEviService _yayinEviService=new YayinEviService();
        private void btnYayinEviKaydet_Click(object sender, EventArgs e)
        {
            YayinEvi yayinEvi = new YayinEvi();
            yayinEvi.YayinEviAdi=txtYayinEviAdi.Text;
            _yayinEviService.YayinEviEkle(yayinEvi);
        }
    }
}
