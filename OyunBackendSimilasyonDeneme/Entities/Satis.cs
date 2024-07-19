using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Entities
{
    public class Satis
    {
        public int satisId { get; set; }
        public Oyuncu oyuncu { get; set; }
        public Oyun oyun { get; set; }
        public Kampanya kampanya { get; set; }
        public double satisFiyati { get; set; }

        

    }
}
