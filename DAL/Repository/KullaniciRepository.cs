using DAL.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KullaniciRepository:BaseRepository<Kullanici>
    {
        public Kullanici KullaniciVarMi(string kullanici, string sifre)
        {
            return _dbContext.Kullanıcılar.Where(x => x.KullaniciAdi == kullanici && x.Sifre == sifre).SingleOrDefault();

        }

    }
}
