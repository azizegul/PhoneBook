# PhoneBook

Proje Code First mantığıyla oluşturulmuştur. Veritabanı olarak PostgreSql ve MongoDb kullanıldı. Her service için farklı bir veri tabanı kullanıldığından dolayı tek bir veri tabanına bağımlılık ortadan kaldırılmıştır.

add-migration Initial -> .net core console için : dotnet ef migrations add Initial
update-database -> .net core console için : dotnet ef database update Not: Projede içerisindeki mevcut migration'lar otomatik olarak ayağa kalktığından herhangi bir işlem yapılmasına gerek yoktur.
Genel Yapı


* Api Gateway -> Ocelot 
* Message Broker -> Rabbitmq 
* Service Bus -> Mass Transit 
* Databases -> PostgreSql and MongoDb 
* Open Doc -> Swagger and SwaggerForOcelot
* Applied Pattern ->Mediator, CQRS,Clean Architecture 

# Microservisler

* Ocelot - Gateway, .net6 - Report ve Contact microserviceler arasındaki iletişimi sağlar. 
* Contact - Postgre, .net6 - Person ve Contact bilgileriyle ilgili CRUD işlemleri yapılabilmektedir. 
* Report - MongoDb, .net6 - Rehberdeki kişiler ve lokasyonlarla ilgili rapor oluşturmaktadır. Message Broker aracı olarak RabbitMQ tercih edilmiştir.

Kurulum docker-compose.yml dosyası sayesinde hem kullanılan araçlar hem veri tabanları ayağa kalkacaktır.

* docker-compose up -d -> yapmak yeterli olacaktır. Bir sorun yaşanması halinde kodu çekip çalıştırabilirsiniz.
