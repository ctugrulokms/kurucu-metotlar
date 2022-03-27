using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SınıfAdı
            // {
            //     [ErişimBelirleyici] [VeriTipi] ÖzellikAdı;
            //     [ErişimBelirleyici] [GeriDönüşTipi] MetotAdı([ParametreListesi])
            //     {
            //         Metot Komutları
            //     }
            // }

            // Erişim Belirleyiciler
            // * public
            // * private
            // * internal
            // * protected

            Console.WriteLine("****** Çalışan 1 ******");

            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23415634, "İnsan Kaynakları");

            calisan1.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 2 ******");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satış";

            calisan2.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 3 ******");

            Calisan calisan3 = new Calisan("Tuğrul", "Okumuş");

            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(){}

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı: {0}", Ad);
            Console.WriteLine("Çalışan soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan numarası: {0}", No);
            Console.WriteLine("Çalışanın departmanı: {0}", Departman);
        }
    }
}
