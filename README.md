Uçak Rezervasyon Uygulaması
Bu proje, kullanıcıların uçuş arama, rezervasyon yapma ve bilet satın alma işlemlerini gerçekleştirebileceği bir uçak rezervasyon uygulamasıdır. Uygulama, kullanıcı dostu bir arayüz ve güçlü arka plan sistemi ile uçak seyahatlerini daha kolay ve hızlı hale getirir.
Havayolu Seçimi: Kullanıcı uygulamayı başlattığında, birkaç farklı havayolu seçeneği arasından birini seçer. Bu seçim, programın ana formunda bir ComboBox aracılığıyla yapılır.

Nereden ve Nereye Seçimi: Kullanıcı daha sonra seyahat edeceği havalimanını seçer. Bunun için yine ana formda ComboBox kullanılır.

Tarih ve Fiyat Seçimi: Kullanıcı, seyahat tarihini ve bilet fiyatını belirler. Tarih seçimi için bir DateTimePicker, fiyat seçimi için bir NumericUpDown kontrolü kullanılır.

Koltuk Seçimi: Kullanıcı, uçuşta tercih ettiği koltuğu seçer. Havayolu seçimine bağlı olarak koltuk düzeni değişebilir. Koltuk seçimi, dinamik olarak oluşturulan ve tıklanabilir olan butonlar aracılığıyla yapılır.

Kullanıcı Kaydı: Kullanıcı, bilet rezervasyonunu tamamlamak için kişisel bilgilerini girdikten sonra kaydetme işlemi yapar. Bu bilgiler arasında isim, soyisim, telefon numarası, cinsiyet gibi detaylar bulunabilir.

Veri Girişi ve Kaydetme: Kullanıcı bilgileri girdikten sonra, rezervasyonu tamamlamak için "Kaydet" butonuna tıklar. Bu butona tıklanmasıyla birlikte, gerekli kontroller yapılarak veriler kaydedilir. Kaydedilen veriler, ListView veya benzeri bir kontrolde gösterilebilir.
