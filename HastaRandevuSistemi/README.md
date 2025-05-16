# 🏥 Hasta Randevu Sistemi

Bu proje, Windows Forms ile hazırlanmış basit bir **Hasta Randevu Sistemi**dir. Kullanıcılar branş ve doktor seçerek, tarih ve saat bilgisiyle birlikte randevu oluşturabilir.

---

## 🔧 Özellikler

- Branş ve doktor seçimi
- Tarih (DateTimePicker) ve saat (ComboBox) seçimi
- Hasta adı ve soyadı girerek randevu alma
- Aynı doktorun aynı saat için ikinci randevu alması engellenir
- Veriler SQL Server veritabanında saklanır

---

## 🗄️ Veritabanı Tabloları

### Branslar
- `Id` (int)
- `BransAdi` (nvarchar)

### Doktorlar
- `Id` (int)
- `DoktorAdi` (nvarchar)
- `DoktorSoyadi` (nvarchar)
- `BransId` (int)

### Randevular
- `Id` (int)
- `HastaAdi` (nvarchar)
- `HastaSoyadi` (nvarchar)
- `BransId` (int)
- `DoktorId` (int)
- `Tarih` (datetime)

---

## 🧪 Nasıl Kullanılır?

1. Projeyi Visual Studio ile aç.
2. `Form1.cs` dosyasındaki bağlantı cümlesini (connection string) kendi veritabanına göre düzenle.
3. Veritabanında tabloları oluştur.
4. Uygulamayı çalıştır ve test et.
