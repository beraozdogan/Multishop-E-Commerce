# 🛒 MultiShop E-Commerce

Bu proje, .NET 6 ve mikroservis mimarisi kullanılarak sıfırdan geliştirilmiş modüler ve ölçeklenebilir bir e-ticaret platformudur. Projede her servis bağımsız olarak yapılandırılmış ve Docker ile konteynerleştirilmiştir. Eğitim sürecinde modern yazılım geliştirme ilkeleri derinlemesine uygulanmıştır.

## 🚀 Özellikler

### 👤 Kullanıcı İşlevleri
- Kayıt ve giriş
- Ürün arama, inceleme ve puanlama
- Canlı destek mesajlaşma

### 🛠️ Yönetici Paneli Özellikleri
- Ürün ve kategori yönetimi
- Kampanya/indirim yönetimi
- Öne çıkan ürün yönetimi
- Gerçek zamanlı sistem takibi

## 🧱 Kullanılan Teknolojiler ve Mimariler

### 🔙 Backend
- C# & .NET 6
- ASP.NET Core Web API
- Mikroservisler (Onion & N-Tier Architecture)
- CQRS, MediatR, Repository Pattern

### 💾 Veritabanları & ORM
- SQL Server, PostgreSQL, MongoDB, Redis
- Entity Framework Core, Dapper

### 🔐 Güvenlik
- IdentityServer4, JWT
- Role-based access control

### 🌐 Frontend & UI
- Razor Pages
- HTML, CSS, Bootstrap, JavaScript, jQuery, AJAX

### 🔁 API Gateway & Gerçek Zamanlı
- Ocelot API Gateway
- SignalR (Gerçek zamanlı yönetim paneli)

### ☁️ Diğer Entegrasyonlar
- Google Cloud Storage (Image servisinde)
- RapidAPI (Hava durumu ve dış API'ler)
- MailKit & SMTP (Mail gönderimi)

---

## 🧩 Mikroservisler

| Servis       | Açıklama                               | Teknolojiler                          |
|--------------|-----------------------------------------|----------------------------------------|
| Catalog      | Ürün ve kategori yönetimi              | MongoDB + Docker                      |
| Basket       | Sepet işlemleri                        | Redis + Docker                        |
| Discount     | İndirim işlemleri                      | MSSQL + Dapper                        |
| Order        | Sipariş yönetimi                       | PostgreSQL + Docker                   |
| Identity     | Kimlik & Roller                        | IdentityServer4 + MSSQL              |
| Message      | Mail gönderimi                         | SMTP + MailKit                        |
| Image        | Görsel yükleme & saklama               | Google Cloud Storage                  |
| Web UI       | Kullanıcı arayüzü                      | Razor Pages + Bootstrap               |
| API Gateway  | Mikroservis yönlendirme                | Ocelot                                 |
| Real-time    | Canlı yönetim paneli                   | SignalR                                |
| RapidAPI     | Dış API bağlantıları (ör: hava durumu) | RapidAPI                               |

---

## 🖼️ Ekran Görüntüleri

Tüm proje adımlarına ve ekran görüntülerine buradan ulaşabilirsiniz:  
🔗 [ReadMe ScreenShots - GitHub Issue](https://github.com/beraozdogan/Multishop-E-Commerce/issues/1)

---

## 🎓 Eğitim Kaynağı

Bu proje, Murat Yücedağ tarafından hazırlanan [**Asp.Net Core MultiShop Mikroservis E-Ticaret**] kursu kapsamında tamamlanmıştır. Geliştirme süreci boyunca birçok yeni teknolojiyi uygulamalı olarak öğrenme fırsatı elde ettim.

GitHub üzerinden kaynak kodlara ulaşmak isterseniz:  
🔗 [https://github.com/beraozdogan/Multishop-E-Commerce](https://github.com/beraozdogan/Multishop-E-Commerce)
