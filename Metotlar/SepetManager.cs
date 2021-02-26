using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax
        public void Ekle(Urun urun) //sepete ekleyeceğimiz şey Urun classından bir ürün olacak. 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : "+urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, double stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}
