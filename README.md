# Hafta 1
Controllerde ekleme,silme,güncelleme gibi işlemleri karşılayan bir API yazıldı.

Veriler ilk etapta bir liste yapısında tutuldu.

![alt text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/1.png)

Bu liste yapısı üzerinde ekleme silme gibi işlemler yazıldı.

![alt text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/2.png)

# Hafta 2
Yazılan API metotları postman aracılığıyla test edildi.

Oluşturduğumuz uçak listesindeki tüm nesneleri dönen metot.

![getListhepsi](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/pstmn1.png)

Parametre olarak girilen Id ile eşleşen uçağı getiren metot.

![get1](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/pstmn2.png)

Uçak ekleme metotu.

![ucakGerccekteneklendi](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/pstmn3.png)

Kontrollü ekleme.

![ucakEkleme](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/pstmn4.png)

Paramtere olarak girilen Id'ye göre uçak bilgilerini güncelleyen metot.

![guncelleme](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/pstmn5.png)
# Hafta 3
Yazılan API için gerekli veritabani varlıkları oluşturuldu.

Veritabani ve tablolari olusturmak icin script yazildi. Planes ve Brands tablosu foreign key ile baglandi.

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/scrpt.png)

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/sqlAR.png)


# Hafta 4
API ile veritabanının haberleşmesi için EntityFramewrok paketi nuget ile projeye yüklendi gerekli konfigurasyonlar yapılarak veritabani ile bağlantı sağlandı.

Interface ve Repository mantığı kullanılarak tekrarlı kod yazmadan kaçınıldı ve CRUD operasyonları bir kez yazılarak jenerik bir yapıya çekildi.

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/dt1.png)

IEntityRepository temel şablon interface

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/dt2.png)

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/dt3.png)

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/dt4.png)



Veritabani varliklari ile projedeki nesneleri eşleştirdiğimiz ve bağlantı yaptığımız context sinifi.

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/context.png)

postman ile veritabanına veri ekleme

Brand ekleme (Id identity oldugu icin onu burdan vermiyoruz.)

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/markaEKLEpOstman.png)

Brand tablosu

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/sqlMarkaEklenm%C5%9Fs.png)

Plane ekleme.

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/ucakEklemePostman.png)

Plane tablosu

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/vtUcakEkleme.png)
# Hafta 5
## Yetkilendirme ve Paging işlemleri

login create

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/authCREATE.png)

token uretildi.

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/lgnTOKENURETILDI.png)

yetki gerektiren islem:

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/yetkiYOK.png)

uretilen tokenı kullanarak yetki sayesinde islem gerceklestirildi. 

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/yetkiileGeldi.png)

Paging 

![script](https://github.com/AKBANK-Patika-FullStack-Bootcamp/EsmaKaragulle_Homeworks/blob/master/images/paging.png)

