using System;
using System.Collections.Generic;
using System.Text;
using Projek_Calculator_Library;

namespace Calculator_Projek_Kelompok
{
    //abstract class
    abstract class Pengulangan
    {
        //abstract method
        public abstract void ulang();
    }

    class mengulang_1 : Pengulangan
    {
        public override void ulang()
        {
            Console.WriteLine("PROGRAM KALKULATOR");
            Console.WriteLine("==================");
            Console.WriteLine("");
            int pilih;
            Console.WriteLine("1. Program Penjumlahan");
            Console.WriteLine("2. Program Pengurangan");
            Console.WriteLine("3. Program Perkalian");
            Console.WriteLine("4. Program Pembagian");
            Console.WriteLine("5. Program Hasil Bagi");
            Console.WriteLine("======================");
            Console.WriteLine("");
            Console.WriteLine("Masukkan Pilihan Anda : ");
            pilih = int.Parse(Console.ReadLine());
            Calculator hitung = new Calculator();
            if (pilih == 1)
            {
                hitung.penjumlahan();
            }
            else if (pilih == 2)
            {
                hitung.pengurangan();
            }
            else if (pilih == 3)
            {
                hitung.perkalian();
            }
            else if (pilih == 4)
            {
                hitung.pembagian();
            }
            else if (pilih == 5)
            {
                hitung.hasil_bagi();
            }
            else
            {
                Console.WriteLine("Maaf pilihan anda tidak tersedia, silahkan ulang kembali...");
                Console.ReadLine();
                ulang();
            }
        }
        public void pilihan()
        {
            string pilih2;
            Console.Write("Apakah anda mau menghitung lagi? (Y/N) =  ");
            pilih2 = Console.ReadLine().ToLower();

            if (pilih2 == "y")
            {
                Console.WriteLine("Enter Untuk Memulai Lagi");
                Console.ReadLine();
                ulang();
            }
            else
            {
                Console.WriteLine("Terimakasih!");
            }
        }
    }
}
