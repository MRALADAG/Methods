using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            // Burada veri işlemeyle ilgili programlama yaptığımız için Backhand programlama diye adlandırılıyor.

            Product[] urunler = new Product[] { urun1, urun2 };
            // Product cinsinden class'ları bir array içerinde tutmaya çalıştık.
            // Yani ileride eklenebilecek bütün ürün bilgilerine bu şekilde saklamaya çalıştık.

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }

            Console.WriteLine("------------------Metotlar-----------------");
            // Burada bir class çağırılırken instance yani bir örneği oluşturuldu. Bu örnek SepetManager için yapıldı.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // Burada Ekle() metodunu kullanma bize reusability'i sağladı.

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}
// Do not repeat your self (DRY) method lar bu özelliği sağlıyor.