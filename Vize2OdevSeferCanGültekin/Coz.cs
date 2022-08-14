using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sefercangültekin
{
    class Coz:Oku//Okuyu Miras Aldım
    {
        public static bool Baslat(bool dgr)  // Satır ve sütünların 0 olup olmadığını kontrol edip boolean değer döndüren bir metot
        {
            for (int i = 0; i < 30; i++)
            {
                switch (mtrs[i, 0])
                {
                    case 0:
                    Koordinat ilk = new Koordinat(i, 0); // case 0: ise mtrs de ki Satır ve sütün bilgilerini Koordinat metodu içerisindeki liste ekliyoruz
                    if (Cozme(ilk) == true)  
                        return true;
                        break;
                }
            }
            return false;
        }

        public static List<Koordinat> cikis = new List<Koordinat>();
        public static bool Cozme(Koordinat ilk) 
        {

            if (mtrs[ilk.satirlar, ilk.sutunlar] == 2)//ilgili satır ve stunda 2 rakamına denk gelince bomba olduğunu anlayıp kullanıcının oyununa son verdim 
            {                                         //ve döngü içinde kullanıca yeni bir oyun veya çıkış seçeneğini sundum
                Console.WriteLine("\t\t\t\t\t!!!!!Bombaya Bastın!!!!!");
                Console.Beep(2000, 2000);//bombaya basarsa beep sesini verdirdim
                Console.Write("\n\nYeni Oyun için= 1\nÇıkış için = 2\n\nGiriş: "); //Yeni Oyun İçin Seçenekleri Sundum
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Menu.Basla();
                }
                else if (a == 2)
                {
                    Environment.Exit(0);
                }
            }
            mtrs[ilk.satirlar, ilk.sutunlar] = 3; //Çıkış yolunda gezdiği noktalar
            if (ilk.sutunlar == 29) //Çıkış yolundaki koordinatları cikis adlı List dizisine ekleyen koşul(=4)
            {
                mtrs[ilk.satirlar, ilk.sutunlar] = 4;
                cikis.Add(ilk);
                return true;
            }

           Hareket(ilk);

            foreach (Koordinat Hareket in ilk.Komsu)//Koordinatta ki komşu adlı List yapısında ki satir ve sütünları okuyup 2 boyutlu mtrs adlı diziye bu bilgileri ekler. 
            {
                switch (mtrs[Hareket.satirlar, Hareket.sutunlar])
                {
                    case 0:
                    case 2:
                        bool bulundu = Cozme(Hareket);
                        if (bulundu == true)
                        {
                            mtrs[ilk.satirlar, ilk.sutunlar] = 4;
                            cikis.Add(ilk);
                            return true;
                        }
                        break;
                }
            }
            return false;
        }
        public static void Hareket(Koordinat ilk)//Etrafı kontrol eder 0 mı değil mi diye 
        {
            if (ilk.satirlar - 1 >= 0)
            {
                Koordinat üst = new Koordinat(ilk.satirlar - 1, ilk.sutunlar);
                ilk.Komsu.Add(üst);
            }
            if (ilk.sutunlar + 1 < 30)
            {
                Koordinat sag = new Koordinat(ilk.satirlar, ilk.sutunlar + 1);
                ilk.Komsu.Add(sag);
            }
            if (ilk.satirlar + 1 < 30)
            {
                Koordinat alt = new Koordinat(ilk.satirlar + 1, ilk.sutunlar);
                ilk.Komsu.Add(alt);
            }
            if (ilk.sutunlar - 1 >= 0)
            {
                Koordinat sol = new Koordinat(ilk.satirlar, ilk.sutunlar - 1);
                ilk.Komsu.Add(sol);
            }
        }
    }
}
