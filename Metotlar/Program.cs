// See https://aka.ms/new-console-template for more information

using Metotlar;



Urun urun1 = new Urun();

urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";
urun1.StokAdedi = 10;


Urun urun2 = new Urun();

urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";
urun2.StokAdedi = 20;


Urun[] urunler = new Urun[] {urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------------------");


}

Console.WriteLine("----------Metotlar----------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);



