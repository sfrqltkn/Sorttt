using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sefercangültekin
{
    class Menu
    {
        public static void Secenekler2()//kullanıcıya sunacağım seçenekleri yazdırdım
        {
            Console.WriteLine("\t\t\t\t\tSefer Can Gültekin  1030510402\n\n");
            Console.Write("\nMatrisi Dosyadan Alıp Çözmek İçin = 1\nRandom Matris Üretmek için Üretmek için = 2\n\nGiriş: ");
            string girdi = Console.ReadLine();
            if (girdi == "1")
            {
                Console.Clear();
                Basla();
            }
            else if (girdi == "2")
            {
                Console.Clear();
                RandomLabirentUretme.RandomUretveYaz();
            }
        }
        public static void Secenekler()//kullanıcıya sunacağım seçenekleri yazdırdım
        {
            Console.WriteLine("\n");
            Console.WriteLine("Labirent yol koordinatları için : X ");
            Console.WriteLine("Labirent bomba koordinatları için : B");
            Console.WriteLine("Labirent orjinali için : L ");
            Console.WriteLine("Çıkış için : -1 ");
            Console.Write("Seçiminiz : ");
        }

        public static void Basla()
        {
            Console.Clear();//ekranı temizledim

            Console.WriteLine("\t\t\t\t\tSefer Can Gültekin  1030510402\n\n");//kimlik

            Console.Write("(Matris.txt) Labirent dosyasını giriniz : ");//kullanıcıdan işlem yapılacak dosyayı istedim
            string dosya = Console.ReadLine();
            Oku.DosyadanOku(dosya);//alınan dosyayı dosyadanoku ya parameter olarak gönderdim

            Console.Clear();//ekranı temizledim

            Bomba.Uret();//okunan dosya dan sonra matris içine bomba üretmesi için bomba üret methodunu çağırdım

            Secenekler();
            string girdi2 = Console.ReadLine();//kullanıcıdan aldığım seçeneği girdi ye atadım

            while (true) //Kullanıcı doğru tuşlama yaparsa döngü çalışır
            {
                Console.Clear();

                switch (girdi2)//kullanıcının istediği seçeneğe göre ilgili işlemi yaptırdım
                {
                    case "X":
                    case "x":
                        if (Coz.Baslat(false))//kullanıcı x girerse dogru yolu ve o yola giden koordinatları yazdırdım
                        {
                            Yazdir.dogruyol();
                            Console.WriteLine("\n\n");
                            Yazdir.CıkısKoordinat();
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("!!!!MATRİS ÜZERİNDE ÇIKIŞ BULUNAMADI!!!!");
                        break;

                    case "B"://kullanıcı b seçerse bombaların yerini gösterdim
                    case "b":
                        Bomba.Goster();
                        Console.WriteLine("\n");
                        break;

                    case "L":
                    case "l"://kullanıcı l seçerse ana matrisi gösterdim
                        Yazdir.Matris();
                        break;

                    case "-1":
                        Environment.Exit(0);
                        break;                      
                }
                Console.WriteLine("\n\n");
                Secenekler();//sonsoz döngüde bittikten sonra kullanıcya tekrar seceneğini sordum
                girdi2 = Console.ReadLine();
            }
        }
    }
}
