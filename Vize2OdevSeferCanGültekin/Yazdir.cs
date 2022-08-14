using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sefercangültekin
{
    class Yazdir
    {
        public static void Matris() //mtrs ye aktarılan matris dizinimi ekrana yazdırdım
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    switch (Oku.mtrs[i, j])
                    {
                        case 2:
                        case 3:
                        case 4:
                            Console.Write("0 ");
                            break;
                        default:
                            Console.Write(Oku.mtrs[i, j] + " ");
                            break;
                    }
                }
                Console.WriteLine(" ");
            }
        }

        public static void dogruyol()
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    //başlangıçtan çıkısa kadar giden doğru yolu kırmızı yaprak kullanıcaya sundum
                    switch (Oku.mtrs[i, j])
                    {
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case 3:
                            Console.Write("0 ");
                            break;
                        default:
                            Console.Write(Oku.mtrs[i, j] + " ");
                            break;
                    }
                }
                Console.WriteLine(" ");
            }
        }

        public static void CıkısKoordinat()//çıkısa giden yolun koordinatlarını adım adım ekrana bastım
        {
            Coz.cikis.Reverse();
            int t = 1;
            foreach (Koordinat yol in Coz.cikis)
            {
                Console.WriteLine("{0}.adım : ({1},{2})", t, yol.satirlar, yol.sutunlar);
                t++;
            }
        }
    }
}
