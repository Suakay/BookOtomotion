using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YayinEviService
    {
        YayinEviRepository _yayinEviRepo =new YayinEviRepository();
        public IEnumerable<YayinEvi> TumYayinEvleriniGetir()
        {
            return _yayinEviRepo.GetAll();

        }
        public void YayinEviEkle(YayinEvi yayinEvi)
        {
            _yayinEviRepo.Add(yayinEvi);
        }

    }
}
