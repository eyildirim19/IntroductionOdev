namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console'dan alınan ay'ın mevsimini yazdıran prorgramı yapınız.
            Console.WriteLine("Lütfen ay giriniz");
            string ay = Console.ReadLine();




            // eğer ay;  aralık-ocak-şubat      girilirse ekrana KIŞ 
            // mart-nisan-mayıs       girilirse ekrana İLK BAHAR
            // haziran-temmuz-ağustos girilirse ekrana YAZ 
            // eylük-ekim-kasım       girilirse ekrana SON BAHAR
            // mesajlarını veren programı yazınız.. Girilen ay için kaçıncı ay olduunu yazınız ekrana n. Ay şeklinde yazınız..

            // örnek;
            // klavyeden girilen ocak ayı için çıktı aşağıdaki gibi olmalıdır;
            // KIŞ
            // 1. Ay


            // todo: bütün  istenilenleri switch-case ve if karar mekanizmaları kullanarak yapınız

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}