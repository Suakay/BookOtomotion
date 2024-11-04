using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KategoriService
    {
        KategoriRepository _kategoriRepo=new KategoriRepository();
        public IEnumerable<Kategori> TumKategorileriGetir()
        {
            return _kategoriRepo.GetAll();

        }
        public void KategoriEkle(Kategori kategori)
        {
            _kategoriRepo.Add(kategori);
        }
        


    }
}
