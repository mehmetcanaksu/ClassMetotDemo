namespace MusteriManagers;
using MusteriOzellikleri;

public class MusteriManager
{
    public void Ekle(Musteri musteri)
    {
        Console.WriteLine(musteri.Ad+" "+musteri.Soyadı+": Müşteri Eklendi");
    }

    public void Sil(Musteri musteri)
    {
        Console.WriteLine(musteri.Ad + " " + musteri.Soyadı + ": Müşteri Silindi");
    }

    public void Listele(Musteri musteri)
    {
        Console.WriteLine("Müşteri Adı: "+musteri.Ad);
        Console.WriteLine("Müşteri Soyadı: " + musteri.Soyadı);
        Console.WriteLine("Müşteri TC: " + musteri.TC);
        Console.WriteLine("Müşteri Doğum Yeri: " + musteri.DogumYeri);
    }
}

