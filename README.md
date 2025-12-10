 Bus Ticket Application System (Backend API)

Bu proje, .NET 8 kullanarak geliştirdiğim, katmanlı mimari (N-Tier / Onion Architecture) prensiplerine dayalı bir otobüs bilet satış ve rezervasyon sistemidir.

Projenin temel amacı;  SOLID prensiplerine uygun, genişletilebilir (scalable) ve bakımı kolay (maintainable) bir backend mimarisi kurmaktır. Veritabanı tutarlılığını sağlamak için Unit of Work tasarım deseni uygulanmıştır.

 Kullanılan Teknolojiler

* .NET 8.0 (Web API)
* Entity Framework Core (ORM & Code First)
* MS SQL Server
* AutoMapper (Entity-DTO dönüşümleri için)
* Swagger / OpenAPI (API dokümantasyonu ve test için)
* Dependency Injection (Built-in container)

  Mimari Yaklaşım ve Tasarım Desenleri

Projeyi geliştirirken Clean Architecture (Onion)** yapısına sadık kaldım. Bağımlılıklar dıştan içe (Merkeze/Core katmanına) doğru akacak şekilde kurgulandı.

 Katmanlar
1.  Core Layer: Projenin merkezidir. Entity'ler, DTO'lar, Interface'ler (Repository, Service, UoW) burada bulunur. Dışarıya hiçbir bağımlılığı yoktur.
2.  Data (DAL) Layer: Veritabanı erişim kodlarını içerir. `DbContext`, Migrations ve Repository implementasyonları buradadır.
3.  Service (Business) Layer: İş kurallarının (Business Logic) işlendiği katmandır. Validasyonlar ve Mapping işlemleri burada yapılır.
4.  API Layer: Controller'ların bulunduğu ve dış dünyaya açılan katmandır.

  Dependency Injection ve Extension Metot Kullanımı (Resolvers)
Projenin ölçeklenebilirliği açısından `Program.cs` dosyasının sadeliğine özellikle önem verdim. Tüm servis kayıtlarını (Dependency Injection) tek bir dosyaya yığmak yerine, Extension Method tasarım desenini kullanarak sorumlulukları katmanlara dağıttım:

* DbContextResolver: Veritabanı bağlantı ayarlarını yönetir.
* RepositoryResolver: Repository ve Unit of Work bağımlılıklarını yönetir.
* ServiceResolver: Business servislerini ve AutoMapper tanımlarını yönetir.

Bu sayede `Program.cs` dosyası, spagetti koddan arındırılarak temiz ve yönetilebilir bir yapıya kavuşturuldu.

 Uygulanan Diğer Desenler
* Generic Repository Pattern: Temel CRUD işlemleri (Ekle, Sil, Getir vs.) için kod tekrarını önlemek amacıyla `GenericRepository<T>` yapısı kuruldu.
* Unit of Work Pattern: Veritabanı işlemlerinde Transaction bütünlüğünü sağlamak için kullanıldı. `SaveChanges` metodu sadece UnitOfWork üzerinden tek seferde çağrılır; böylece bir işlem hata verirse tüm süreç güvenli bir şekilde geri alınır (Rollback).

  Veritabanı Yapısı

Sistemde bulunan temel tablolar ve ilişkileri:
* Buses: Otobüs envanteri.
* Trips: Sefer tanımları (Hangi otobüs, hangi rotada, ne zaman).
* Routes: Kalkış ve varış lokasyonları.
* Passengers: Yolcu kayıtları.
* Tickets: Satış işlemleri (Trip ve Passenger ile ilişkilidir).

*(Veritabanı şeması ve Swagger ekran görüntüleri `docs` klasöründe mevcuttur.)*

  Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için:

1.  Repoyu klonlayın:
    ```bash
    git clone [https://github.com/Kutlayyctrk/BusTicketApplication.git](https://github.com/Kutlayyctrk/BusTicketApplication.git)
    ```

2.  `BusTicketApplication.API` içindeki `appsettings.json` dosyasında Connection String'i kendi SQL Server bilginize göre düzenleyin.

3.  Veritabanını oluşturmak için Package Manager Console üzerinden şu komutu çalıştırın (Default Project: BusTicketApplication.DAL seçili olmalı):
    ```powershell
    Update-Database
    ```

4.  API projesini (Startup Project) çalıştırın. Tarayıcıda Swagger arayüzü açılacaktır.

---

Geliştirici: Kutlay Yücetürk
* GitHub: [Kutlayyctrk](https://github.com/Kutlayyctrk)
* Email: ktlyyyctrk@gmail.com

