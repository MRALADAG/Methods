using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // Metodun ilk harfi büyük harfle başlar. (Naming convention)
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
        }
        // Burada "Product urun" denilerek Ekle() metoduna parametre aktarıldı. O parametre ise ürün bilgisi oldu.
        // "public void Ekle(Product urun)" Bu yapıya imza (signiture) deniliyor.

        public void Ekle2(string urunAdi, string aciklama, double fiyet, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }

    }
}
