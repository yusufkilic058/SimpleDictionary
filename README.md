# Sözlük Uygulaması

Bu proje, kullanıcıların Türkçe kelimeleri İngilizce karşılıklarıyla birlikte yönetebileceği basit bir konsol uygulamasıdır. Uygulama, kullanıcıya kelime ekleme, silme, güncelleme ve arama işlemleri yapma imkanı sunar.

## Özellikler

- **Kelime Bul**: Kullanıcı, sözlükte bulunan bir kelimenin İngilizce karşılığını bulabilir.
- **Kelime Ekle**: Yeni bir kelime ve karşılığı ekleyebilir.
- **Kelime Güncelle**: Var olan bir kelimenin İngilizce karşılığını güncelleyebilir.
- **Kelime Sil**: Var olan bir kelimeyi sözlükten silebilir.
- **Çıkış**: Programdan çıkabilirsiniz.

## Kullanım

Programı çalıştırdığınızda aşağıdaki gibi bir ana menü görüntülenir:

```
Sözlük Uygulaması
1. Kelime Bul
2. Kelime Ekle
3. Kelime Güncelle
4. Kelime Sil
5. Çıkış
Seçiminizi yapın:
```

### Seçenekler:

1. **Kelime Bul**: 
   - Kullanıcıdan bir kelime girmesi istenir.
   - Eğer kelime sözlükte mevcutsa, karşılığı gösterilir.
   - Eğer kelime bulunamazsa, kullanıcıya sözlükte bulunmadığı belirtilir.

2. **Kelime Ekle**:
   - Kullanıcıdan eklemek istediği kelime istenir.
   - Eğer kelime zaten sözlükte varsa, kullanıcı bilgilendirilir.
   - Eğer kelime yoksa, kullanıcıdan karşılık girilmesi istenir ve kelime eklenir.

3. **Kelime Güncelle**:
   - Kullanıcıdan güncellemek istediği kelime istenir.
   - Eğer kelime sözlükte varsa, yeni karşılık istenir ve kelime güncellenir.
   - Eğer kelime bulunamazsa, kullanıcıya hata mesajı gösterilir.

4. **Kelime Sil**:
   - Kullanıcıdan silmek istediği kelime istenir.
   - Eğer kelime sözlükte varsa, kelime silinir.
   - Eğer kelime bulunamazsa, kullanıcıya hata mesajı gösterilir.

5. **Çıkış**: 
   - Kullanıcı programdan çıkmak için bu seçeneği seçer.

## Program Çıktısı

Örnek bir çalışma sırasında kullanıcı farklı seçenekler seçerek uygulamanın nasıl çalıştığını göstermek için aşağıdaki örnek çıktıyı görebilirsiniz:

### Örnek Çıktılar:

1. **Kelime Bul**
```
Sözlük Uygulaması
1. Kelime Bul
2. Kelime Ekle
3. Kelime Güncelle
4. Kelime Sil
5. Çıkış
Seçiminizi yapın: 1
Aramak istediğiniz kelime : kitap
kitap = book
```

2. **Kelime Ekle**
```
Sözlük Uygulaması
1. Kelime Bul
2. Kelime Ekle
3. Kelime Güncelle
4. Kelime Sil
5. Çıkış
Seçiminizi yapın: 2
Eklemek istediğiniz kelime: elma
Bu kelime zaten sözlükte var.
```

3. **Kelime Güncelle**
```
Sözlük Uygulaması
1. Kelime Bul
2. Kelime Ekle
3. Kelime Güncelle
4. Kelime Sil
5. Çıkış
Seçiminizi yapın: 3
Güncellemek istediğiniz kelime: masa
Yeni karşılık: desk
Kelime güncellendi.
```

4. **Kelime Sil**
```
Sözlük Uygulaması
1. Kelime Bul
2. Kelime Ekle
3. Kelime Güncelle
4. Kelime Sil
5. Çıkış
Seçiminizi yapın: 4
Silmek istediğiniz kelime: kitap
Kelime silindi.
```

5. **Çıkış**
```
Sözlük Uygulaması
1. Kelime Bul
2. Kelime Ekle
3. Kelime Güncelle
4. Kelime Sil
5. Çıkış
Seçiminizi yapın: 5
Programdan çıkılıyor...
```

## Geliştirme

Bu uygulama, kullanıcıların sözlük yönetimini daha kolay hale getirmek için geliştirilebilir. Örneğin:

- Veritabanı desteği eklenebilir.
- Kullanıcı arayüzü (GUI) ile daha görsel hale getirilebilir.
- Dil seçenekleri eklenebilir.

## Lisans

Bu proje, açık kaynak olarak sunulmaktadır. Kullanılabilir ve dağıtılabilir.
