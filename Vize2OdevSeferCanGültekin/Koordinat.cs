using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sefercangültekin
{
    class Koordinat
    {
        public int satirlar;
        public int sutunlar;
        public Koordinat(int satir, int sutun)  //her koordinatın satır ve sutun değişkenlerini yarattım
        {
            satirlar = satir; // Bunların sınıfın üye elemanlarına atdım
            sutunlar = sutun;
        }

        public List<Koordinat> Komsu = new List<Koordinat>();
    }
}

