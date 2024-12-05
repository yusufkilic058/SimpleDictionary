using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sözlük
        Dictionary<string, string> sozluk = new Dictionary<string, string>
        {
            { "elma", "apple" },
            { "kitap", "book" },
            { "masa", "table" }
        };
        
        while (true)
        {
            Console.WriteLine("\nSözlük Uygulaması");
            Console.WriteLine("1. Kelime Bul");
            Console.WriteLine("2. Kelime Ekle");
            Console.WriteLine("3. Kelime Güncelle");
            Console.WriteLine("4. Kelime Sil");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminizi yapın: ");

            string secim = Console.ReadLine();

            if (secim == "1") // Kelime Bul
            {
                Console.Write("Aramak istediğiniz kelime : ");
                string kelime = Console.ReadLine();

                if (sozluk.ContainsKey(kelime))
                {
                    Console.WriteLine($"{kelime} = {sozluk[kelime]}");
                }
                else
                {
                    Console.WriteLine("Bu kelime sözlükte yok.");
                }
            }
            
            else if (secim == "2") // Kelime Ekle
            {
                Console.Write("Eklemek istediğiniz kelime: ");
                string kelime = Console.ReadLine();

                if (sozluk.ContainsKey(kelime))
                {
                    Console.WriteLine("Bu kelime zaten sözlükte var.");
                }
                else
                {
                    Console.Write("Bu kelimenin karşılığı: ");
                    string karsilik = Console.ReadLine();
                    sozluk.Add(kelime, karsilik);
                    Console.WriteLine("Kelime başarıyla eklendi.");
                }
            }
            else if (secim == "3") // Kelime Güncelle
            {
                Console.Write("Güncellemek istediğiniz kelime: ");
                string kelime = Console.ReadLine();

                if (sozluk.ContainsKey(kelime))
                {
                    Console.Write("Yeni karşılık: ");
                    string yeniKarsilik = Console.ReadLine();
                    sozluk[kelime] = yeniKarsilik;
                    Console.WriteLine("Kelime güncellendi.");
                }
                else
                {
                    Console.WriteLine("Bu kelime sözlükte yok.");
                }
            }
            else if (secim == "4") // Kelime Sil
            {
                Console.Write("Silmek istediğiniz kelime: ");
                string kelime = Console.ReadLine();

                if (sozluk.ContainsKey(kelime))
                {
                    sozluk.Remove(kelime);
                    Console.WriteLine("Kelime silindi.");
                }
                else
                {
                    Console.WriteLine("Bu kelime sözlükte yok.");
                }
            }
            else if (secim == "5") // Çıkış
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
            }
        }
    }
}