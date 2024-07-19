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
        public bool KimlikDogrula(string tcNo, string ad, string soyad, int dogumYili)
        {
            //E devlet sistemien nasıl entegre edilir bilmiyorum basit bir örnek olsun diye böyle yazdım
            if (tcNo == "12345678901" && ad == "Ahmet" && soyad == "Yılmaz" && dogumYili == 1985)
            {
                return true;
            }
            return false;
        }
    }
}
