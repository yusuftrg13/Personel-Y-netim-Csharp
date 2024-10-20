/*
 * Personel Yönetim Sistemi
 * Amaç:Şirket içerisinde çalışan personel ve yöneticilerin bilgilerini tutan,bu bilgilere erişim sağlayan br sistem
 * 
 */


//Bir personel nesnesi oluşturalım
using Personel_Yönetim_Sistemi;

Personel personel = new Personel("Ahmet","Ali",52000);
personel.BilgiGoster();

Console.WriteLine();


//Yönetici Oluşturalım
Yönetici yonetici = new Yönetici("Asena", "Turgut", 100000,2);
yonetici.BilgiGoster();


//Maaş'da eksiltme yapalım yöneticinin 
yonetici.Maas = 85000;
Console.WriteLine("Maaş Güncellemesi Tamamlandı");
yonetici.BilgiGoster();
