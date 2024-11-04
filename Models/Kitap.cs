namespace Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat {  get; set; }
        public int BasimYili { get; set; }

        public int BaskiSayisi { get; set; }
        public int ISBN { get; set; }
        public string KitapOzeti {  get; set; }
        public DateTime? AlmaTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }

        public int KategoriID { get; set; }
        public Kategori? Kategori { get; set; }

        public int YayinEviID { get; set; }
        public YayinEvi? YayinEvi { get; set; }

   
        public int YazarID { get;  set; }
        public ICollection<Yazar>? Yazarlar { get; set; }


    }
}
