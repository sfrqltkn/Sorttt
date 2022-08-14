using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sefercangültekin
{
    class RandomLabirentUretme
    {

        public static void RandomUretveYaz()
        {
            Random rnd = new Random();
            int[,] mtrs2 = new int[30, 30];// 30 satir 30 sütundan oluşan 2 boyutlu(dizi) bir matris ürettim
            int satir = 0; int sutun = 0;

            for (satir = 0; satir < 30; satir++)//0. satırdan başyarak 29.sütün'a kadar rastgele 1-2 arasında sayı üreten ve ürettikten sonra satırı arttıran bir döngü kurdum.
            {
                for (sutun = 0; sutun < 30; sutun++)
                {

                    mtrs2[satir, sutun] = rnd.Next(0, 2);
                    Console.Write(mtrs2[satir, sutun] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
