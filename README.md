# Flappy Bird Oyunu - C# Windows Forms

## Proje Hakkında
Bu proje, klasik Flappy Bird oyununun C# Windows Forms kullanılarak geliştirilmiş bir versiyonudur.  
Oyuncu, space tuşu ile kuşu kontrol eder ve borular arasından geçerek puan toplar.

## Özellikler

Oyun Mekanikleri
- Kuş Kontrolü: Space tuşu ile kuşu uçurma.
- Yerçekimi Sistemi: Kuş sürekli aşağı doğru düşer.
- Borular: Rastgele yüksekliklerde borular arasından geçiş.
- Zemin: Sabit, hareket etmez.

Zorluk Sistemi
- Hız Artışı: Her 5 puanda bir boru hızı 1 artar.
- Bu sayede oyun giderek daha zor hale gelir.

Skor Sistemi
- Anlık Skor: Mevcut oyun skoru.
- Skor Kaydı: En yüksek skor tutulmaz.

Oyun Bitiş ve Yeniden Başlatma
- Çarpışma Tespiti: Borular, zemin ve ekran dışı kontrolü.
- Oyun Bitti Paneli: Oyun durur ve "Game Over" mesajı gösterilir.
- Yeniden Başlatma: Space tuşuna basarak oyun yeniden başlar.

## Teknik Özellikler

Geliştirme Ortamı
- Platform: Windows Forms
- Dil: C#
- Framework: .NET Framework

Kullanıcı Arayüzü
- Skor Görüntüsü: Ekranın üstünde anlık skor.
- Oyun Bitti Mesajı: Skor metni üzerinde gösterilir.
- Butonlar: Oyun başladığında space ile kuş uçurulur, oyun bittiğinde space ile başlatılır.

Kontroller
- Klavye Girdisi: Space tuşu ile kontrol.

## Kurulum ve Çalıştırma

Gereksinimler
- Visual Studio (2019 veya üzeri)
- .NET Framework 4.5 veya üzeri

Çalıştırma Adımları
1. Projeyi klonlayın veya indirin
2. Visual Studio'da açın
3. Projeyi derleyin ve çalıştırın
Not: FlappyBird Clone dosyasının içindeki FlappyBird Clone.exe kısayolu ile de başlatabilirsiniz.

Oyun Kontrolleri
| Tuş | Aksiyon |
|-----|---------|
| Space | Kuşu zıplat ve oyun bitti ise yeniden başlat |

## Oyun Kuralları
- Borulara veya zemine çarpmadan mümkün olduğunca ilerleyin.
- Her boru setinden geçişte 1 puan kazanılır.
- Boru hızı her 5 puanda 1 artar.

## Geliştirici Notları

Kod Yapısı
- OOP Prensipleri: Sınıf tabanlı yapı
- Olay Yönetimi: Zamanlayıcı ve klavye olayları
- Çarpışma Tespiti: Bounds.IntersectsWith metodu

Genişletilebilirlik
- Yeni boru setleri eklenebilir.
- Farklı zorluk artış sistemleri tanımlanabilir.
- Görsel iyileştirmeler yapılabilir.

Sınıf Yapısı
- Ana Form (Form1.cs)
  - Değişkenler: gap(iki boru arası boşluk), pipeSpeed(boruların hareket hızı), gravity(yerçekimi), score(skor), isGameOver(oyun durumu)
  - Metotlar:
    gameTimerEvent(object sender, EventArgs e): Oyun döngüsü; kuşun yerçekimiyle hareketi, boruların sola kayması, skor güncelleme ve çarpışma kontrolünü yapar.
     placePipes(): Boruları ekrana yerleştirir; üst borunun yüksekliği rastgele seçilir ve alt boru boşluklu şekilde konumlanır.
     gameKeyIsDown(object sender, KeyEventArgs e): Space tuşuna basıldığında kuşun zıplamasını sağlar (gravity negatif yapılır).
     gameKeyIsUp(object sender, KeyEventArgs e): Space tuşu bırakıldığında kuşun tekrar aşağı düşmesini sağlar (gravity pozitif yapılır).
     endGame(): Oyun bittiğinde timer’ı durdurur ve ekranda "Game Over" mesajı gösterir.
     restartGame(): Oyun yeniden başlatıldığında kuş ve boruları başlangıç konumuna getirir, skor sıfırlanır, gravity varsayılan değerine döner ve timer tekrar başlar.
  - Olaylar: Klavye işleyicileri, zamanlayıcı tik olayları

Oyun Bileşenleri
- Borular: Rastgele yüksekliklerde iki boru seti
- Kuş: Oyuncu kontrollü karakter
- Zemin: Sabit
- Arayüz Elemanları: Skor metni, oyun bitti mesajı
