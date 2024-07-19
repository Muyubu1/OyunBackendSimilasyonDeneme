using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Concrete
{
    public class SatisManager:Satis
    {
        public void SatisYap(Oyuncu oyuncu, Oyun oyun, Kampanya kampanya = null)
        {
            this.oyuncu = oyuncu;
            this.oyun = oyun;
            this.kampanya = kampanya;
            if (kampanya != null)
            {
                satisFiyati = oyun.Fiyat - (oyun.Fiyat * kampanya.IndirimOrani / 100);
            }
            else
            {
                satisFiyati = oyun.Fiyat;
            }
        }
        public void SatisiYapilanOyunlar(Oyun oyun,)
        {
            List<Oyun> oyunlar = new List<Oyun>();
            oyunlar.Add(oyun);

        }
    }
}
