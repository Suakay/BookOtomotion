using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class YayinEvi
    {
        public int YayinEviID { get; set; }
        public string YayinEviAdi { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }

    }
}
