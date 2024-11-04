using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }      
    
        public  KullaniciTipi KullaniciTipi { get; set; }
        
        //public ICollection<Kitap> OduncAlinanKitaplar { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; } = new List<Kitap>();
    }
}
