// Mükemmel Sayıları Bulan Algoritma					
using System;
public class MukemmelSayilar
{

    public static void Main()
    {

        Console.Write("Sayınızı Giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {

            if (sayi % i == 0)
            {

                toplam = toplam + i;
            }
        }
        if (toplam == sayi)
        {
            Console.Write("\n" + sayi + " Mükemmel bir sayıdır.");
        }

        else
        {
            Console.Write("\n" + sayi + " mükemmel bir sayı degildir.");
        }
    }
}