using OyunBackendSimilasyonDeneme.Abstract;
using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Concrete
{
    public class OyuncuManager : IOyuncu
    {   
        IEDevletServisi _eDevletDogrulama;
        public OyuncuManager(IEDevletServisi eDevletDogrulama)
        {
            _eDevletDogrulama = eDevletDogrulama;
        }

        private List<Oyuncu> oyuncular = new List<Oyuncu>();

        public void OyuncuEkle(Oyuncu oyuncu)
        {
            if (_eDevletDogrulama.KimlikDogrula(oyuncu) == true)
            {
                oyuncular.Add(oyuncu);
                Console.WriteLine("Oyuncu Eklendi");


            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }



        public void OyuncuGuncelle(long tcNo, Oyuncu guncelOyuncu)
        {
            var oyuncu = oyuncular.FirstOrDefault(o => o.TcNo == tcNo);
            if (oyuncu != null)
            {

                if (_eDevletDogrulama.KimlikDogrula(oyuncu) == true)
                {
                    oyuncu.Ad = guncelOyuncu.Ad;
                    oyuncu.Soyad = guncelOyuncu.Soyad;
                    oyuncu.DogumYili = guncelOyuncu.DogumYili;
                }else
                {
                    Console.WriteLine("Doğrulama başarısız Güncellenecek Oyuncu Kayıtsız..");
                }
            }
        }

        public void OyuncuSil(long tcNo)
        {
            var oyuncu = oyuncular.FirstOrDefault(o => o.TcNo == tcNo);
            if (oyuncu != null)
            {
                oyuncular.Remove(oyuncu);
            }
        }

        public Oyuncu OyuncuGetir(long tcNo)
        {
            return oyuncular.FirstOrDefault(o => o.TcNo == tcNo);
        }
    }
}
