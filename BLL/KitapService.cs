using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Models;

namespace BLL
{
    public class KitapService
    {
        KitapRepository _kitapRepo= new KitapRepository();
        
       
       
        public void KitapDurumuGüncelle(Kitap kitap)
        {
            _kitapRepo.Update(kitap);

        }
        public void KitapSil(int id)
        {
            _kitapRepo.Delete(id);
        }
        public Kitap KitapGetir(int kitapId)
        {
            return _kitapRepo.Find(kitapId); 
        }

        public void KitapEkle(Kitap kitap)
        {
           
            _kitapRepo.Add(kitap);
        }
        public IEnumerable<Kitap> TumKitaplariGetir()
        {
            return _kitapRepo.GetAll();
        }
        public IEnumerable<Kitap> YazarlarinKitaplariniGetir(int yazarId)
        {
            // return _kitapRepo.GetAll().Where(x => x.KitapYazarları.Select(x => new { x.Yazar.YazarID, x.Yazar.YazarAdi }).Contains(yazarId)).ToList();
            return _kitapRepo.GetAll().Where(x => x.YazarID == yazarId).ToList(); ;

        }


        public IEnumerable<Kitap> KategoridekiKitaplariGetir(int kategoriId)
        {
            return _kitapRepo.GetAll().Where(x => x.KategoriID == kategoriId);
        }

       
    
        public IEnumerable<Kitap> YayinEvindekiKitaplariGetir(int yayinEviId)
        {
            return _kitapRepo.GetAll().Where(x => x.YayinEviID == yayinEviId);
        }
        public IEnumerable<Kitap> EnSonEklenenKitaplariGetir()
        {
            return _kitapRepo.GetAll().OrderByDescending(x => x.KitapID).Take(10);
        }

        public IEnumerable<Kitap> FiyatAraligiKitaplariniGetir(double minFiyat, double maxFiyat)
        {
            return _kitapRepo.GetAll()
        .Where(x => x.Fiyat >= minFiyat && x.Fiyat <= maxFiyat)
        .ToList();

        }
        //public List<Kitap> FiyatAraligiKitaplariniGetir(double minFiyat, double maxFiyat)
        //{
        //    return _kitap
        //            .Where(x => x.Fiyat >= (decimal)minFiyat && x.Fiyat <= (decimal)maxFiyat)
        //            .ToList();
        //}

        public IEnumerable<Kitap> OduncAlinanTumKitaplar(Kullanici kullanici)
        {
            
            return kullanici.OduncAlinanKitaplar;
        }

        public Kitap GetKitapById(int kitapId)
        {
            return _kitapRepo.GetAll().FirstOrDefault(x => x.KitapID == kitapId);
        }
    }
}
