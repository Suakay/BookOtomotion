using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Yazar
    {
        public int YazarID { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int KitapID { get; internal set; }
        public ICollection<Kitap>? Kitaplar { get; set; }

       
    }
}
