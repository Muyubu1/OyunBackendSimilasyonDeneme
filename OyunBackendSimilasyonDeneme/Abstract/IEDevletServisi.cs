using OyunBackendSimilasyonDeneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunBackendSimilasyonDeneme.Abstract
{
    public interface IEDevletServisi
    {
        bool KimlikDogrula(Oyuncu oyuncu);
    }
}