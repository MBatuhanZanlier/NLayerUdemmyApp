![API](https://github.com/user-attachments/assets/7986e051-231a-4af0-9107-bc62c4ddb561)

Bu kurs Fatih Çakıroğlunun udemydeki Net 8 API/WEB | NLayer/Clean Architecture | Best Practice kursudur. 
https://www.udemy.com/course/asp-net-core-api-web-cok-katmanli-mimari-api-best-practices/learn/lecture/ 

 

## Kursun içeriği ve Amacı
- Yazılım Geliştirme Süreçlerinde En İyi Uygulamalar (best practices) konusunda derinlemesine bilgi sahibi oldum. Bu uygulamaların, kaliteli ve sürdürülebilir yazılımlar geliştirmek için nasıl uygulanması gerektiğini öğrendim.

- Mimari Desenlerin Yapı Taşları üzerinde çalışarak, gerçek dünya senaryolarında karşılaşılabilecek sorunları nasıl çözeceğimi öğrendim. Bu, yazılım geliştirme sürecinde karşılaşılacak zorlukları aşabilmek için gerekli teknik ve metodolojileri anlamama yardımcı oldu.

- Sürdürülebilir Yazılım Geliştirme için gerekli adımları atmayı öğrendim. Bu adımlar, uygulama mimarisi, kodun sürdürülebilirliği ve bakım kolaylığı gibi kritik alanlarda en iyi sonuçları elde etmeme olanak tanıyacak.

- Sonuç olarak, bu kurs bana yazılım mimarisi konusunda sağlam bir temel kazandırdı ve gerçek dünyadaki projelerde bu prensipleri etkili bir şekilde uygulama yeteneği kazandırdı.

## Projede Kullanılan Teknolojiler 
- N Layer Architecture
- Unit Of Work
- Seed Data
- DTO
- Auto Mapper
- Fluent Validation
- Global Exception Handler
- NotFoundFilter
- AutoFac
- Caching Memory

# N Layer Architecture 

Katmanlı mimari (NLayer Architecture), bir yazılım uygulamasını farklı işlevsel bileşenlere veya katmanlara ayırarak, bu bileşenlerin daha modüler, bakımı kolay ve test edilebilir hale gelmesini sağlayan bir yazılım mimarisi desenidir. Her katman, belirli bir sorumluluğa sahip olup, uygulamanın belirli bir bölümünün işlevselliğini kapsar. Bu mimari, yazılım geliştirme sürecinde karmaşıklığı yönetmek ve uygulamanın esnekliğini artırmak amacıyla kullanılır.

## Katmanlar Nelerdir?

Katmanlı mimaride genellikle dört ana katman bulunur:

## Presentation Layer (Sunum Katmanı):

- Amacı: Kullanıcı arayüzünün sağlandığı katmandır. Kullanıcı ile uygulama arasındaki etkileşimi yönetir.

## Business Logic Layer (İş Katmanı):

- Amacı: Uygulamanın iş kurallarını ve mantığını içerir.



## Data Access Layer (Veri Erişim Katmanı):

- Amacı: Uygulamanın veri kaynaklarına (veritabanları, dosya sistemleri, harici API'ler vb.) erişimini sağlar.


# Katmanlar Arasındaki İlişki

- Sunum Katmanı kullanıcıdan gelen girdileri alır ve İş Katmanına iletir.

- İş Katmanı bu girdileri iş kurallarına göre işler ve gerekli verileri almak için Veri Erişim Katmanı ile iletişim kurar.

- Veri Erişim Katmanı ise verileri Veritabanı Katmanından alır ve iş katmanına geri döner.

- Bu yapı, her katmanın kendi sorumluluk alanında çalışmasını sağlar ve katmanlar arasındaki bağımlılıkları azaltarak, uygulamanın daha modüler ve esnek olmasını mümkün kılar.
# UNIT OF WORK 
![UnitOfWork](https://github.com/user-attachments/assets/252a4f7b-6304-465b-aa9a-12147376ef01)

- Unit of Work, birçok işlemi bir arada gruplar ve tüm işlemlerin başarılı bir şekilde tamamlanmasını sağlamak için tek bir işlem (transaction) olarak yönetir. Eğer işlemlerden biri başarısız olursa, diğer işlemler de geri alınarak (rollback) bütün işlem iptal edilir. Bu, atomicity prensibini takip eder.

- Veritabanı İşlemleri: Genellikle veritabanı işlemleriyle ilişkilidir. Birden fazla tablodaki değişiklikleri tek bir işlemde birleştirir. Örneğin, birden fazla veri kaynağında (tablo veya koleksiyon) değişiklik yapılıyorsa, Unit of Work bu işlemleri birleştirir ve hepsini tek bir transaction içinde yürütür.
## öRNEK SENARYO 
Diyelim ki bir e-ticaret platformunda, bir kullanıcı siparişi verdiğinde hem sipariş hem de stok veritabanı güncellenmesi gerekiyor. Eğer sipariş kaydedilirken stok kaydı başarısız olursa, sipariş işlemi de geri alınmalıdır. Bu tür bir işlemi yönetmek için Unit of Work kullanılır. 

# SEED DATA  
![Ekran Görüntüsü (301)](https://github.com/user-attachments/assets/2f04a41e-2631-4168-abf2-3724002033bd)
- Projedeki örnek seed data.

- Seed Data, yazılım geliştirme ve özellikle veritabanı yönetimi bağlamında, bir uygulamanın veritabanına başlangıçta yüklenmesi gereken veriler için kullanılan terimdir. Bu veriler, genellikle uygulamanın çalışabilmesi için gerekli olan temel, varsayılan ya da örnek veriler olabilir. Seed data, genellikle uygulama başlatıldığında bir kez yüklenir ve bu veriler genellikle veritabanı oluşturma veya ilk yapılandırma sırasında kullanılır. 

# Fluent Validation 
![FluentValidation](https://github.com/user-attachments/assets/07cc3306-e655-4827-8b97-02938544b7bf) 
   ## Projeden örnek FluenValidation Kullanımı.
![Ekran Görüntüsü (302)](https://github.com/user-attachments/assets/1f78d268-95ad-4327-b4f6-be79670accb0)
- Apıden ProductDto türünde döndüğü için validation kurallarını direk db den değil dtodan aldım.

- Uygulama geliştirirken en zor noktalardan birisi sistemi kararlı yapıda tutmaktır. Bunu yapmanın yolu da validasyonlardan geçiyor. Peki yazılım geliştirirken validasyon yapmak ne demek? Şöyle düşünün bir post endpoint'iniz var. Input olarak aldığı obje içerisinde de integer bir özellik var. Ve bu özelliğin mantıksal olarak 0 olmaması gerekiyor. Yada boş geçilmemesi gerekiyor. Eğer servisiniz bu özelliği kontrol etmeden db'ye yazarsa, database'in hata fırlatmasına ve uygulamanızın çalışma anında kırılmasına neden olur. Daha da kötüsü kırılmadan devam eder ve data bütünlüğünün bozulmasına neden olabilir.

- Bir validasyon yapısı kurmak hem kuralların okunabilirliği hem de kuralların esnetilebilir olması açısından çok faydalıdır. Bu amaçla yaratılmış bir çok açık kaynaklı kütüphane bulunur. .Net uygulamaları için en çok kullanılan validation kütüphanesi ise FluentValidation dır.

  
