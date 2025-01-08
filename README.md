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
