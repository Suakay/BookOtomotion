using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YazarService
    {
        YazarRepository _yazarRepo = new YazarRepository();

        public IEnumerable<Yazar> TumYazarlarıGetir()
        {
            return _yazarRepo.GetAll();
        }
        public void YazarEkle(Yazar yazar)
        {
            _yazarRepo.Add(yazar);
        }
    }
}
