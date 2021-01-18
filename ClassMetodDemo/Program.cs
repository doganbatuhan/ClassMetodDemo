using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Batuhan";
            musteri1.Soyad = "Doğan";
            musteri1.Yas = 24;
            musteri1.Bakiye = 367.25;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 61;
            musteri2.Ad = "Onur";
            musteri2.Soyad = "Alan";
            musteri2.Yas = 25;
            musteri2.Bakiye = 517.6;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 153;
            musteri3.Ad = "Yasin";
            musteri3.Soyad = "Pelit";
            musteri3.Yas = 24;
            musteri3.Bakiye = 452.8;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 157;
            musteri4.Ad = "Berkay";
            musteri4.Soyad = "Çit";
            musteri4.Yas = 24;
            musteri4.Bakiye = 885.3;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 246;
            musteri5.Ad = "İhsan";
            musteri5.Soyad = "Aydın";
            musteri5.Yas = 24;
            musteri5.Bakiye = 122.5;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            musteriManager.Listele();

            musteriManager.Sil(musteri5);
            musteriManager.Sil(musteri1);
            musteriManager.Listele();
            Console.ReadLine();


        }
    }
}
