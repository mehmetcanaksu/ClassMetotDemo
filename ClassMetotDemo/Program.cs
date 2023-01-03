using MusteriOzellikleri;
using MusteriManagers;


Musteri musteri1 = new Musteri();
musteri1.Ad = "Mehmet Can";
musteri1.Soyadı = "Aksu";
musteri1.TC = 139821739813;
musteri1.DogumYeri = "Ordu";

Musteri musteri2 = new Musteri();
musteri2.Ad = "Duhan";
musteri2.Soyadı = "Karakoç";
musteri2.TC = 131234739127;
musteri2.DogumYeri = "Ordu";

Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };

MusteriManager musteriManager = new MusteriManager();


musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Sil(musteri1);
musteriManager.Sil(musteri2);

foreach (var x in musteriler)
{
    musteriManager.Listele(x);
}