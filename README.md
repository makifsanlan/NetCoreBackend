Projem Business, Core , DataAcccess Entities ve WebAPI katmanlarından oluşmaktadır. Projemde tamamen Microservis tabanlı kurumsal bir mimari oluşturdum. SOLID işlemlerine sıkı sıkıya bağlı kalarak kodlarımı temiz ve modüler hale getirdim.
Projemde OOP ve AOP yapısını kullandım. AOP için Autofac teknolojisini kullandım. Gelecekte bu teknoloji değil de farklı bir teknoloji kullanma ihtimalime karşın yapımı da ona göre kurdum. 
Projemdeki Dependency İnjection işlemleri için hem Business katmanında hem de Core katmanında DependencyResolvers klasörü oluşturdum. Business katmanındaki Dependency işlemleri sadece bu projeye özelken, Core katmanında oluşturduğum Dependency işlemleri tüm projelerde kullanabileceğim işlemlerdir
Projemi daha kurumsal ve güvenli bir hale getirmek için Security kısmını da oluşturdum ve bu security kısmını bütün projelerde kullanabileceğim için Core katmanında oluşturdum. Burada Hashing, Encrypton, ve JWT işlemleri bulunmaktadır.
Projemde Northwind adında hazır bir veritabanıyla çalıştım. Ve projemi Controller ve PostMan ile de test ettim.
WebAPI katmanının program.cs'inde yapılandırma ve Midleware'leri oluşturdum.
Projemi Angular ile destekleyip Controller ile iletişim halinde tuttum.
Projemde Microsoft'un hazır verdiği şeyleri bile kendime göre değiştirdim bu sayede ona bağımlı olmaktan kurtulup, bana bağımlı hale getirdim.
Projemde gelecekte değişebilecek durumları göz önünde bulundurarak; kolay ve anlaşılır aynı zamanda karışıklığı önleyecek bir yapı kurdum.

