using OyunBackendSimilasyonDeneme.Abstract;
using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Concrete
{
    public class OyuncuManager:IOyuncu
    {
        private List<Oyuncu> oyuncular = new List<Oyuncu>();

        public void OyuncuEkle(Oyuncu oyuncu)
        {
            oyuncular.Add(oyuncu);
        }

        public void OyuncuGuncelle(string tcNo, Oyuncu guncelOyuncu)
        {
            var oyuncu = oyuncular.FirstOrDefault(o => o.TcNo == tcNo);
            if (oyuncu != null)
            {
                oyuncu.Ad = guncelOyuncu.Ad;
                oyuncu.Soyad = guncelOyuncu.Soyad;
                oyuncu.DogumYili = guncelOyuncu.DogumYili;
            }
        }

        public void OyuncuSil(string tcNo)
        {
            var oyuncu = oyuncular.FirstOrDefault(o => o.TcNo == tcNo);
            if (oyuncu != null)
            {
                oyuncular.Remove(oyuncu);
            }
        }

        public Oyuncu OyuncuGetir(string tcNo)
        {
            return oyuncular.FirstOrDefault(o => o.TcNo == tcNo);
        }
    }
}
