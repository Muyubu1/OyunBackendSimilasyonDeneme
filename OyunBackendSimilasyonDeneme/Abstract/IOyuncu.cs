using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Abstract
{
    internal interface IOyuncu
    {
        public void OyuncuEkle(Oyuncu oyuncu);
        public void OyuncuGuncelle(long tcNo,Oyuncu guncelOyuncu);
        public void OyuncuSil(long tcNo);
        public Oyuncu OyuncuGetir(long tcNo);

    }
}
