using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciService
    {
        KullaniciRepository _kullaniciRepo = new KullaniciRepository();
        KitapRepository kitapRepo=new KitapRepository();
        public void KullaniciEkle(Kullanici kullanici)
        {
            kullanici.Sifre = SifreHasle(kullanici.Sifre);
            _kullaniciRepo.Add(kullanici);


        }
        public Kullanici KullaniciGetir(int kullaniciId)
        {
            return _kullaniciRepo.Find(kullaniciId);
        }
        public int Login(string uye, string sifre)
        {
            Kullanici kullanici = _kullaniciRepo.KullaniciVarMi(uye, SifreHasle(sifre));

            if (kullanici == null)
                return -1; 

           
            return kullanici.KullaniciID;


        }
        private string SifreHasle(string sifre)
        {
            
            MD5 md5 = MD5.Create();
            byte[] hashedSifre = md5.ComputeHash(UTF32Encoding.UTF8.GetBytes(sifre));
            string strSifre = "";
            foreach (byte b in hashedSifre)
                strSifre += b.ToString("X2");
            return strSifre;
        }

        // Sistemde en az bir calısanın olması için yazdık...
      
        public void CalisanEkle(Kullanici kullanici)
        {
            kullanici.KullaniciTipi = KullaniciTipi.Calisan; 
            KullaniciEkle(kullanici);
        }
        public Kullanici KullaniciGiris(string kullaniciAdi, string sifre)
        {
            return _kullaniciRepo.KullaniciVarMi(kullaniciAdi, SifreHasle(sifre));
        }
     
        public IEnumerable<Kullanici> TumKullanicilariGetir()
        {
            return _kullaniciRepo.GetAll();
        }

        public void KitapOduncAl(Kullanici kullanici, Kitap kitap)
        {
            
            if (kullanici.OduncAlinanKitaplar == null)
            {
                kullanici.OduncAlinanKitaplar = new List<Kitap>();
            }

            kitap.AlmaTarihi = DateTime.Now;
            kullanici.OduncAlinanKitaplar.Add(kitap);

            _kullaniciRepo.Update(kullanici);
        }
        //private List<Kullanici> kullanicilar;
        //public List<string> TumCalisanKitapListeleriniGetir()
        //{

        //    return kullanicilar
        //        .Where(k => k.KullaniciTipi == KullaniciTipi.Calisan)
        //        .SelectMany(k => k.KitapListesi)
        //        .ToList();
        //}

        public void KitapIadeEt(Kullanici kullanici, Kitap kitap)
        {
            kitap.IadeTarihi = DateTime.Now;
            kullanici.OduncAlinanKitaplar.Remove(kitap);
            _kullaniciRepo.Update(kullanici); 
           
        }
        public Kullanici GetKullaniciById(int kullaniciId)
        {
            return _kullaniciRepo.GetAll().FirstOrDefault(x => x.KullaniciID == kullaniciId);
        }

        public int Find(int kullaniciID)
        {
            throw new NotImplementedException();
        }
    }
}
