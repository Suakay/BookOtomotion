Bu proje, bir sahaf için kitaplarla ilgili bilgilerin yönetimini sağlayan bir uygulamadır. Entity Framework Core kullanılarak geliştirilen bu uygulama, kitap bilgilerini veritabanında tutar ve kullanıcıların veri üzerinde CRUD işlemleri yapmasına olanak tanır. Yalnızca yetkili çalışanlar tarafından erişilebilecek şekilde güvenlik önlemleri alınmıştır.

Proje Özellikleri
Bu projede gerçekleştirilen özellikler:

Kitap Bilgileri:

Kitap adı, yazar(lar), kategorisi, fiyatı, basım yılı, yayınevi, baskı sayısı gibi temel kitap bilgileri tutulur.
Kapak yazısı ya da kitap özeti gibi ek bilgilerin kaydı da yapılır.
Çoklu Yazar Desteği:

Bir kitap birden fazla yazara sahip olabilir.
Kategori ve Yayınevi Bilgisi:

Her kitap için bir kategori ve bir yayınevi belirlenir.
Kullanıcı Doğrulama ve Yetkilendirme:

Sisteme sadece yetkili çalışanlar kullanıcı adı ve şifre ile giriş yapabilir.
Şifreler güvenlik amacıyla hash’lenmiş şekilde veritabanında saklanır; şifreler açık olarak tutulmaz.
CRUD İşlemleri:

Kitaplar, yazarlar, kategoriler ve yayınevi bilgileri üzerinde CRUD (Oluşturma, Okuma, Güncelleme, Silme) işlemleri yapılabilir.
Geliştirilen Raporlar
Sahafın talebi doğrultusunda aşağıdaki raporlar geliştirilmiştir:

En Çok Satılan Kitaplar: Belirli bir süre içinde en çok satılan kitapları listeleyen rapor.
Yazar Bazında Kitap Satış Raporu: Her yazar için kitap satış bilgilerini gösteren rapor.
Kategoriye Göre Kitap Dağılımı: Kitapların kategoriye göre dağılımını gösteren rapor.
Yayınevi Bazında Satış Raporu: Yayınevi bazında satış raporlarını gösterir.
