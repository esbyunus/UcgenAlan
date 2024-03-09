namespace UcgenHesap
{
     
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ucgen Alan Hesaplama programina hosgeldiniz! \n Programi kullanmak ister misiniz? (evet/hayir) ");
                string istek = Console.ReadLine().ToLower();

                if (istek == "evet")
                {
                    Console.WriteLine("Hangi metodu kullanmak istersiniz? \n Sinus \n Dik Ucgen \n U ");
                    string UcgenIstek = Console.ReadLine().ToLower();

                    switch (UcgenIstek)
                    {
                        case "dik ucgen":
                            Console.WriteLine("Bilgilendirme: Bir kenar uzunlugu ve o kenara ait inen dikin(yuksekligin) çarpımının yarısına bölünmesiyle bulunur.");
                           
                            Console.WriteLine("Yüksekligi h = giriniz: ");
                            double dikyukseklik = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Yükseklige ait taban uzunlugunu giriniz: ");
                            double diktaban = Convert.ToDouble(Console.ReadLine());

                            double dikalan = dikyukseklik * diktaban / 2;
                            Console.WriteLine($"Ucgenin alani = {dikalan}");
                            break;

                        case "sinus":
                            Console.WriteLine("Bilgilendirme: İki kenar uzunlugu ve bu kenarlar arasındaki aci ile hesaplanir.");
                            
                            Console.WriteLine("Birinci kenari giriniz: ");
                            double sinuskenara = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("İkinci kenari giriniz: ");
                            double sinuskenarb = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Aciyi giriniz: ");
                            double sinusaci = Convert.ToDouble(Console.ReadLine());

                            double aciRadyan = sinusaci * Math.PI / 180; // aciyi radyana dönüstürme islemi
                            double sinusalan = sinuskenara * sinuskenarb * Math.Sin(aciRadyan) / 2;
                            Console.WriteLine($"Ucgenin alani = {sinusalan}");
                            break;

                        case "u":
                            Console.WriteLine("Bilgilendirme : Üc kenarinin bilinmesiyle hesaplanır. Heron formulu olarak da bilinir.");

                            Console.WriteLine("Birinci kenari giriniz");
                            double ukenara = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Ikinci kenari giriniz");
                            double ukenarb = Convert.ToDouble(Console.ReadLine());
                            
                            Console.WriteLine("Ucuncu kenari giriniz");
                            double ukenarc = Convert.ToDouble(Console.ReadLine());

                            double ubirim = ukenara * ukenarb * ukenarc / 2;
                            double uhepsi = ubirim * (ubirim - ukenara) * (ubirim - ukenarb) * (ubirim - ukenarc);
                            double ualan = Math.Sqrt(uhepsi);

                            Console.WriteLine($"Ucgenin alani = {ualan}");
                            break;

                        default:
                            Console.WriteLine("Hatali Secim");
                            continue;
                    }
                }
                else if (istek == "hayir")
                {
                    Console.WriteLine("Programi kullandiginiz icin tesekkürler. \n İyi gunler!");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatali Yazim!");
                }
            }
        }
    }
}
