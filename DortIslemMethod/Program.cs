using System;

namespace DortIslemMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 işlem örneği!");

            int n;
            Console.WriteLine("Kaç Sayı gireceksiniz? ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            char islem = Convert.ToChar(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i = 0; i < sayilar.Length; i++)
            {
                
                Console.WriteLine($"{i+1}. Sayıyı Giriniz:");
                sayilar[i]=Convert.ToInt32(Console.ReadLine());

            }

            float islemSonucu = Islem(islem, sayilar);

            Console.WriteLine($"İşlem sonucunuz ={islemSonucu}");

            Console.ReadKey();
        }

        private static float Islem(char islem, int[] sayilar)
        {
            float sonuc = sayilar[0];
            for(int i=1;i<sayilar.Length;i++)
            {                
                switch (islem)
                {
                    case '+': 
                        sonuc += sayilar[i]; 
                        break;
                    case '-': 
                        sonuc -= sayilar[i]; 
                        break;
                    case '*': 
                        sonuc *= sayilar[i]; 
                        break;
                    case '/': 
                        sonuc /= sayilar[i]; 
                        break;
                }                
            }
            return sonuc;
        }
    }
}
