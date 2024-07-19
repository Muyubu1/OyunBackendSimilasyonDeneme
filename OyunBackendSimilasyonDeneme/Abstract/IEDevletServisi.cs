using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Abstract
{
    internal interface IEDevletServisi
    {
        bool KimlikDogrula(string tcNo, string ad, string soyad, int dogumYili);
    }
}
