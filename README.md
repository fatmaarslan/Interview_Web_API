# Interview_Web_API

 Models Services Ve Controller sınıflarında Try_Web_API Örneğindeki dinamik mantığı ile hareket ettim ;
 
 ama bu projem içerisinde veri tabanı ile çalışmak istediğim için , Migration yaratıp veri tabanı ile bağladım projeyi.

 Projem içerisinde DataBase Klasörü yarattım , DataContext ve DesignTimeDbContextFactory sınıflarını oluşturdum.
 DataContext sınıfı içerisinde DbContext sınıfından kalıtsallık alıp , gerekli veri tabanı işlemlerini gerçekleştirmeyi sağladım.
 sınıf içerisinde yer alan   public DbSet<"">"" { get; set; }  property sayesinde veri tabanında oluşturucağım tabloya karşılık olarak gelen  ayarlamayı yapmış oldum.

 Migration yarattığım kısımda problem yasadıgım için DesignTimeDbContextFactory sınıfını oluşturdum.Bu sınıf içerisindeki CreateDbContext metodu sayesinde tasarım zamanında bir DataContext örneği oluşturdum.

 Proje içerisinde servisler le çalıştığım için , servis sınıfları içerisinde veri tabanı işlemlerini gerçekleştirmesi adına gerekli bağlamı kurdum.
 ve yine aynı sınıflar içerisinde , controller içerisindeki işlemler için  kullanıcağım metodları , _context den gelen bilgiler doğrultusunda uygulanmasını sağlıcak sorguları yazdım.
