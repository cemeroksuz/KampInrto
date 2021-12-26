﻿// See https://aka.ms/new-console-template for more information

using Oop2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "123456";
musteri1.Adi = "Cem";
musteri1.Soyadi = "Eröksüz";
musteri1.TcNo = "12345678910";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "321654";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "1234567890";


Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();


MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
