Bu projeyi ASP.NET Core 8.0 ve SignalR teknolojilerini kullanarak geliştirdim. Restoran sipariş yönetimini kolaylaştırmak amacıyla tasarladığım bu sistemde, kullanıcılar QR kodlarını tarayarak menüye erişebilir, sipariş verebilir ve rezervasyon oluşturabilir. Siparişler, anlık olarak mutfağa iletilirken, tüm süreçler gerçek zamanlı yönetilebiliyor.

Teknik Detaylar:
N katmanlı mimari (Entity, DataAccess, Business, DTO, API, UI) ve SOLID prensiplerine uygun olarak geliştirdim.
MSSQL Server üzerinde Entity Framework Core (Code-First) kullanarak veritabanını yönettim.
CRUD işlemlerini API katmanı üzerinden gerçekleştirdim ve MVC tarafında dinamik bir yapıya entegre ettim.
SignalR kullanarak anlık sipariş, rezervasyon, bildirim ve istatistik yönetimini sağladım.
AutoMapper ile DTO katmanını kullanarak verileri daha güvenli hale getirdim.
Fluent Validation ile veri doğrulama işlemlerini gerçekleştirdim.
Docker ile projeyi konteynerize ederek dağıtımı kolaylaştırdım.
Öne Çıkan Özellikler:
✔ QR kod ile sipariş verme
✔ Gerçek zamanlı sipariş ve rezervasyon yönetimi
✔ Anlık bildirim ve istatistikler
✔ Kupon kodu sistemi
✔ Ürün ve kategori yönetimi (CRUD işlemleri)
✔ Masalara özel QR kod oluşturma
✔ Identity ile kullanıcı hesap yönetimi

Bu projeyi geliştirirken gerçek zamanlı iletişimi en verimli şekilde sağlamak için SignalR’ı aktif olarak kullandım. Ayrıca Docker ile konteyner ortamına taşıyarak, farklı sistemlerde sorunsuz çalışmasını sağladım. Kullanıcı deneyimini ön planda tutarak hızlı, güvenli ve ölçeklenebilir bir sipariş yönetim sistemi oluşturmayı hedefledim. 🚀
