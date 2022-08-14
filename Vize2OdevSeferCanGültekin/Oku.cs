using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//File icin ekledim

namespace sefercangültekin
{
    class Oku
    {
        public static int[,] mtrs = new int[30, 30];//2 boyutlu 30 satır 30 sütunluk bir dizi oluşturdum
        public static void DosyadanOku(string Alınandosya)
        {
            string[] Filee = File.ReadAllLines(Alınandosya); //File sınıfının ReadAllLines metodu sayesinde Alınan dosyanın tüm satırlarını okudum

            int satir = 0;
            int sutun = 0;

            foreach (string dgr in Filee)  //file dizisi içindeki verileri teker teker okudum ve gerekli koşullara göre mtrs matris dizinine atadım
            {
                foreach (char karakter in dgr)  // neden 2 tane foreach kullandık?
                {
                    switch (satir)
                    {
                        case 30:
                        break;
                    }                
                    //Burada 0. satırdan okumaya başlar 29. satıra kadar okur. Okunan elamanlara göre bir değer atanır.
                    //Sütün 29 olunca satır arttırılır sütün tekrar 0 olur.
                    if (karakter == '0' || karakter == '1')
                    {
                        switch (karakter)
                        {
                            case '0':
                                mtrs[satir, sutun] = 0;
                                break;
                            case '1':
                                mtrs[satir, sutun] = 1;
                                break;
                        }
                        switch (sutun)
                        {
                            case 29:
                                sutun = 0;
                                satir++;
                                break;
                            default:
                                sutun++;
                                break;
                        }
                    }
                }
            }
        }
    }
}