using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type-safe : tip güvenli 

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---");
            }

            Console.WriteLine("---Metotlar---");
            //instance - örnek oluşturma
            //encapsulation(ayrı ayrı yazılan şeyleri bir bütünün içine sokmaktır.)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10); //böyle de ilave edebilirdim. ama bir değişiklikte hepsini değiştirmek zorunda kalacağım
            sepetManager.Ekle2("Karpuz", "Adana karpuzu", 12,9);// stok adedi de eklemeyi deneyelim.
            sepetManager.Ekle2("Elma", "Amasya elması", 12,8);
        }
    }
}


//Dont repeat yourself = DRY - Clean Code - Best Practice(Doğru Uygulama Teknikleri)