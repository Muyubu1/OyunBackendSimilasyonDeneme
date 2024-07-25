using OyunBackendSimilasyonDeneme.Abstract;
using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Concrete
{
    internal class EDevletDogrulama : IEDevletServisi
    {
        public bool KimlikDogrula(Oyuncu oyuncu)
        {
            //E devlet sistemien nasıl entegre edilir bilmiyorum basit bir örnek olsun diye böyle yazdım
            if (oyuncu.TcNo == 12345678901 && oyuncu.Ad == "Ahmet" && 
                oyuncu.Soyad == "Yılmaz" && oyuncu.DogumYili == 1985)
            {
                return true;
            }
            return false;
        }
    }
}
