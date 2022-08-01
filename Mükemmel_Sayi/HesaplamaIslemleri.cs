using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mükemmel_Sayi
{
    
    public class HesaplamaIslemleri
    {
        ConsoleIslemleri consoleIslemleri = new ConsoleIslemleri();
        int[] bolenler;
        int toplam;
        string ispat;
        public void mukemmelSayiMiHesapla(int sayi)
        {
            toplam = 0;
            ispat = "";
            bool kontrol = true;
            bolenleriBul(sayi);
            
            for(int i = 0;i<bolenler.Length;i++)
            {
                toplam += bolenler[i];
                if(i != bolenler.Length-1)
                    ispat += bolenler[i].ToString() +" + ";
                else
                    ispat += bolenler[i].ToString() + " = " + toplam;
            }
            if(toplam != sayi) {
                kontrol = false;    
            }
            if (kontrol) 
            {
                consoleIslemleri.SonucuYazdir(sayi + " bir mükemmel sayıdır.");
                consoleIslemleri.SonucuIspatla(ispat);
            } else {
                consoleIslemleri.SonucuYazdir(sayi + " bir mükemmel sayı değildir.");
                consoleIslemleri.SonucuIspatla(ispat);
            }
        }
        public void bolenleriBul(int sayi)
        {
            bolenler = new int[0];
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Array.Resize(ref bolenler, bolenler.Length + 1);
                    bolenler[bolenler.Length - 1] = i;
                }
            }
        }
    }
}
