using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        private List<Musteri> musteriler = new List<Musteri>(); // This is the list of customer
        public void Ekle(Musteri musteri) // This is the method for adding customer to customer list
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Id + " id numaralı " + musteri.Ad + " " + musteri.Soyad + " listeye eklendi.");
        }
        public void Listele() // This method is used for printing all customer in the list
        {
            Console.WriteLine("-------------------------------------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Yas + " " + musteri.Bakiye);
            }
            Console.WriteLine("-------------------------------------------");
        }
        public void Sil(Musteri musteri) // This method is used for remove determined customer from the list
        {
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.Id + " id numaralı " + musteri.Ad + " " + musteri.Soyad + " listeden silindi.");
        }
    }
}
