// Katı Sıvı Gaz Olduğunu Bulan Algoritma
using System;
public class KatiSiviGaz
{
    public static void Main()
    {
        Console.Write("Kaç Derece: ");
        int derece = Convert.ToInt32(Console.ReadLine());

        if (derece >= 100)
        {
            Console.Write("\n" + derece + " Derece Gazdır.");
        }
        else if (derece <= 100 && derece > 0)
        {
            Console.Write("\n" + derece + " Derece Sıvıdır.");
        }
        else
        {
            Console.Write("\n" + derece + " Derece Katıdır.");
        }
    }
}
