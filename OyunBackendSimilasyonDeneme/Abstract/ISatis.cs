using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Abstract
{
    internal interface ISatis
    {
        public int satisId();
        public Oyuncu oyuncu();
        public Oyun oyun();
        public Kampanya kampanya();
        public double satisFiyati();
    }
}
