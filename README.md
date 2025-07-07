# # 👥 Müşteri Yönetim Uygulaması

Bu proje, Windows Forms (WinForms) ve MySQL veritabanı kullanılarak geliştirilmiş bir müşteri yönetim sistemidir. Kullanıcılar müşteri bilgilerini ekleyebilir, güncelleyebilir, silebilir ve ID'ye göre arama yapabilir.

## 🚀 Özellikler

- MySQL veritabanı bağlantısı
- Müşteri kaydı ekleme (INSERT)
- Kayıt güncelleme (UPDATE)
- Kayıt silme (DELETE)
- ID ile kayıt arama (SELECT)
- Konu seçimi için ComboBox (Arıza, Talep, Yardım)
- Mesaj girişi için RichTextBox

## 🛠️ Kullanılan Teknolojiler

- C# (.NET Framework)
- Windows Forms
- MySQL
- MySql.Data kütüphanesi

## 🧱 Veritabanı Yapısı

Veritabanı adı: `db`  
Tablo adı: `musteriler`

| Alan Adı | Türü         | Açıklama         |
|----------|--------------|------------------|
| id       | int(11)      | AUTO_INCREMENT   |
| isim     | varchar(255) | Müşteri adı      |
| konu     | int(1)       | 0: Arıza, 1: Talep, 2: Yardım |
| mesaj    | text         | Mesaj içeriği    |


## 📂 Nasıl Kullanılır?

1. MySQL veritabanınızı oluşturun ve yukarıdaki tablo yapısını uygulayın.
2. `Server=localhost;Database=db;Uid=root;Pwd=;Charset=utf8` bağlantı cümlesini kendi ayarlarınıza göre düzenleyin.
3. Uygulamayı çalıştırın.
4. Form üzerinden müşteri bilgilerini girerek işlemleri gerçekleştirin.

## 🔐 Güvenlik Notu

Bu örnek uygulama, temel eğitim amaçlıdır. Gerçek projelerde:
- SQL Injection’a karşı daha güvenli yöntemler kullanılmalı
- Kullanıcı doğrulama ve yetkilendirme eklenmeli
- Veritabanı bağlantı bilgileri şifrelenmeli

Bu proje açık kaynaklıdır. Dilerseniz kendi projelerinizde kullanabilir veya geliştirebilirsiniz.
