using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniatmuygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            //1- Bakiye Görüntüleme
            //2- Para Çekme
            //3- Para Yatırma
            //Q ya basarsa çıkış yaptır.

            int bakiye = 10000;
            Console.WriteLine("Evla ATM'sine Hoşgeldiniz :)!!");
            Console.WriteLine("Lütfen yapmak istediğin işlemi seçer misin tatlım!!");
            Console.WriteLine("bakiyeni görüntülemek için 1'i/ para çekmek için 2'yi/ para yatırmak için 3'ü/ çıkış yapmak için q'ya bass tatlımm");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("güncel bakiyenn: " + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("çekmek istediğin miktarı girrr tatlım: ");
                int CekilecekTutar = Convert.ToInt32(Console.ReadLine());

                if (CekilecekTutar <= bakiye)
                {
                    Console.WriteLine("bankada kalan tutar tatlım: " + (bakiye - CekilecekTutar));
                }
                else if (CekilecekTutar > bakiye)
                {
                    Console.WriteLine("upsi bakiyenden fazla tutar çekemezsin tatlımm!");
                }

                
                
            }
            else if (secim == "3")
            {
                Console.WriteLine("yatırmak istediğin miktarı girr lütfen: ");
                int YatırılacakTutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bankada oluşan genel tutar tatlım: " + (bakiye + YatırılacakTutar));
            }
            else if (secim == "q")
            {
                Console.WriteLine("atmden çıkış yapılıyorr");
                Console.WriteLine("çıkış yapıldı iyi günlerrrr");
            }
            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRR TATLIM!!!");
            }
            Console.ReadLine();
        }
    }
}
