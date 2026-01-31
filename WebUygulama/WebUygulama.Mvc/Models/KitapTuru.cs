using System.ComponentModel.DataAnnotations;

namespace WebUygulama.Mvc.Models
{
    public class KitapTuru
    {
        [Key] // primary key
        public int ID { get; set; }
        [Required] // not null 
        public string Ad { get; set; }

    }
}



/*
 
ilk sınıfımızı ekledik

sınıfta prop ları ekleyelim bunlar sql de db de sutun olarak gelecekler entityframework ile 

şimdilik bu kadar yeter bunlar sql de sutun olarak gelecekler

id nin primarykey olması lazım nasıl yapılacagını ögrenecegız

 
 */


/*
 
VİDEO 13. Primary Key Ayarlama ve Veri Tabanı Connection String Oluşturma

bu derste db ile ilgili işlemler yapılacak ama sql e girmeden 
entityfw ile calıstıgımız için sınıf üzerinde işlem yapacagız
daha sonra db olusturmak için gerekli connectionstring i yazacagız

entityfw bir orm dir 

burda olusturdugumuz id ad veri tabanın da sutun olarak karsımıza gelecek otomatik olarak olusacak
hangisi primarykey hangisi degil hangisinde not null özelliği olmalı 
bunları Data Annotations ile ayarlıyoruz

bizim id alanımız primary key olacak
primarykey tekil yanı unique olmalı lazım aynı id den 1 den fazla olamaz

id alanın ustune [Key] yazıyoruz bir paket yukleniyor using 
using System.ComponentModel.DataAnnotations;

hangi prob un ustunde yazarsa onu etkiler

birden fazla primarykey olabilir

Ad alanıda bos olmamalı yanı not null olacak

onun içinde [Required] yazmanız lazım

ek olarak 

microsoft ID olarak bir prop var ise [Key] yazmasanız da primarykey atamasını yapıyor ID Id
class adi + Id yazarsanız da atamasını yapar 
KitapTuruId KitapTuruID

I buyuk olması lazım

ama standart olarak yazıyoruz biz

sql ile baglama kısmına gelelım sql i acalım 

svname i alalım 

DESKTOP-K88T80S\SQLEXPRESS

appsettings.json a gidelim


 
*/