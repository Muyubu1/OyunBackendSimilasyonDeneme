using OyunBackendSimilasyonDeneme.Abstract;
using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Concrete
{
    internal class KampanyaManager : IKampanya
    {
        private List<Kampanya> kampanyalar = new List<Kampanya>();
        public void KampanyaEkle(Kampanya kampanya)
        {
            kampanyalar.Add(kampanya);
        }

        public Kampanya KampanyaGetir(int kampanyaId)
        {
            return kampanyalar.FirstOrDefault(k => k.KampanyaId == kampanyaId);
        }

        public void KampanyaGuncelle(int kampanyaId, Kampanya guncelKampanya)
        {
            var kampanya = kampanyalar.FirstOrDefault(k => k.KampanyaId == kampanyaId);
            if (kampanya != null)
            {
                kampanya.KampanyaAdi = guncelKampanya.KampanyaAdi;
                kampanya.IndirimOrani = guncelKampanya.IndirimOrani;
            }
        }

        public void KampanyaSil(int kampanyaId)
        {
            var kampanya = kampanyalar.FirstOrDefault(k => k.KampanyaId == kampanyaId);
            if (kampanya != null)
            {
                kampanyalar.Remove(kampanya);
            }
        }
    }
}
