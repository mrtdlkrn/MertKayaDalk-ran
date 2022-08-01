using Mükemmel_Sayi;

namespace Mukemmel_Sayi
{
    public class Program
    {
        /*
        1) .Net Framework Windows işletim sistemine bağlı bir geliştirme ortamıdır. .Net Core ise ortamdan bağımsızdır. Asp.Net Core en trendleridir bence.
        2) Veri tekrarından kurtulmalıyız
        3) WordPress yada html kullanılabilir. Wordpress site yapımı için basic bir dilidir.Htmlle de yapılabilir ama css giydirmesi bizi zorlayabilir.
        Database olarak mysql yada mssql kullanılabilir. Online sistemlerde genelde bunlar kullanılıyor diye biliyorum ve script olarak javascript kullanılabilir.Web sayfalarda 
        javascript ve jquery çok kullanışlı olduğundan kaynaklı.
        4) İlk önce Youtube , udemy veya konu anlatımı yapan sitelerden komutlarını öğrenirim sonrasında ise github'tan örnek projeleri incelerim.
        5) Bazen arkadaşlarla toplanıp valorant oynuyoruz ama bu zaman genelde haftasonları oluyor.
         */
        public static HesaplamaIslemleri hesaplamaIslemleri = new HesaplamaIslemleri();
        public static void Main(string[] args)
        {
            string sayiStr;
            int sayi;

            while (true)
            {
                Console.WriteLine("0 mükemmel sayı değildir. Çıkmak için 0 giriniz");
                Console.WriteLine("Mükemmel sayı kontrolü için bir sayı giriniz :");
                sayiStr = Console.ReadLine();
                if (sayiStr == "0") { break; }
                sayi = Int32.Parse(sayiStr);
                hesaplamaIslemleri.mukemmelSayiMiHesapla(sayi);
            }
            Console.WriteLine("\nÇıkma Başarılı.İyi günler");
            Console.ReadKey();
        }
    }
}
