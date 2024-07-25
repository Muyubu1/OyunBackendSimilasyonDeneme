using OyunBackendSimilasyonDeneme.Concrete;
using OyunBackendSimilasyonDeneme.Entities;

OyuncuManager oyuncuManager = new OyuncuManager(new EDevletDogrulama());
oyuncuManager.OyuncuEkle(new Oyuncu { TcNo = 12345678901, Ad = "Ahmet", Soyad = "Yılmaz", DogumYili = 1985 });