using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sefercangültekin
{
    class Bomba: Oku//Okuyu Miras Aldım
    {
        public static void Uret()
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                mtrs[rnd.Next(0, 30), rnd.Next(0, 30)] = 2;//mtrs matris dizini için 3 kez satır ve sutun koordinatlarını alarak o noktaların değerini 2 yaptım bunlar bombyaı ifade edecek
            }
        }
        public static void Goster()//mtrs matris dizinin karakter karakter okuyarak 2 olan değerlerin olduğu yere B yazarak Kullanıcıya bomba bilgisini verdim
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    switch (mtrs[i, j])
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("B ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case 3:
                        case 4:
                            Console.Write("0 ");
                            break;
                        default:
                            Console.Write(mtrs[i, j] + " ");
                            break;
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
