﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);

            //array - dizi

            string[] kurslar = new string[] { "Yazilim Geliştirici Yetiştirme Kampı", "Programaya başlangıç için temel kurs", "Java", "Python", "C#"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)

            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
