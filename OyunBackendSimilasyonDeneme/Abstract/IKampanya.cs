using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Abstract
{
    public interface IKampanya
    {
        public void KampanyaEkle(Kampanya kampanya);
        public void KampanyaGuncelle(int kampanyaId, Kampanya guncelKampanya);
        public void KampanyaSil(int kampanyaId);
        public Kampanya KampanyaGetir(int kampanyaId);
    }
}
