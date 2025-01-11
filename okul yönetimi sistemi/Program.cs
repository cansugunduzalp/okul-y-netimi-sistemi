using System;

namespace OkulYonetimSistemi
{
    // Person sınıfı, öğrenciler ve öğretmenler için ortak özellikler içerir.
    public class Person
    {
        // Özellikler (Properties)
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Yapıcı metot (Constructor)
        public Person(string ad, string soyad, DateTime dogumTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
        }

        // Bilgileri konsola yazdırmak için bir metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad} {Soyad}");
            Console.WriteLine($"Doğum Tarihi: {DogumTarihi.ToShortDateString()}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesneleri oluşturuluyor
            Person ogrenci1 = new Person("Ahmet", "Yılmaz", new DateTime(2005, 6, 15));
            Person ogrenci2 = new Person("Ayşe", "Kara", new DateTime(2006, 8, 22));

            // Öğretmen nesneleri oluşturuluyor
            Person ogretmen1 = new Person("Fatma", "Çelik", new DateTime(1980, 3, 30));
            Person ogretmen2 = new Person("Mehmet", "Demir", new DateTime(1975, 1, 10));

            // Öğrenci ve öğretmenlerin bilgileri konsola yazdırılıyor
            Console.WriteLine("Öğrenciler:");
            ogrenci1.BilgileriYazdir();
            ogrenci2.BilgileriYazdir();

            Console.WriteLine("Öğretmenler:");
            ogretmen1.BilgileriYazdir();
            ogretmen2.BilgileriYazdir();
        }
    }
}
