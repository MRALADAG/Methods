using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        // Buradaki bütün satırlar o class ile ilgili property'i belirtir.
        public int Id { get; set; }
        public String Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }
        // Buradaki (Class) yapi  ilerideki değişimlere karşı dinamiktir.
        // Örneğin ileride eklemeyi düşündüğümüz bir özellik için metod kullandığımızı düşünelim.
        // Metodun imzasını yani parametrelerini değiştirdiğimizde o motedu kullandığımız bütün sayfalarda güncelleme
        // yapmamız gerekecekti.
        // Fakat bunu buradaki gibi Product Class'ı içerisine "public int stokAdedi" adedi gibi bir özelliği
        // property olarak eklediğimizde bütün yapıda böyle bir güncelleme yapma zorunluluğu ortadan kalkıyor.
        // Bu işleme encapsulation deniliyor.
    }
}
