using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Calculator_Library
{
    public class Calculator
    {
        public int penjumlahan()
        {
            int a , b, hasil;
            string nilaia, nilaib;
            Console.WriteLine("Kalkulator Penjumlahan");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.Write("Masukkan angka 1 : ");
            nilaia = Console.ReadLine();
            Console.Write("Masukkan angka 2 : ");
            nilaib = Console.ReadLine();
            a = int.Parse(nilaia);
            b = int.Parse(nilaib);
            Console.WriteLine(a + "+" + b);
            hasil = a + b;
            Console.WriteLine("Hasil Penjumlahan = " + hasil);
            return hasil;
        }

        public int pengurangan()
        {
            int a, b, hasil;
            string nilaia, nilaib;
            Console.WriteLine("Kalkulator Pengurangan");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.Write("Masukkan angka 1 : ");
            nilaia = Console.ReadLine();
            Console.Write("Masukkan angka 2 : ");
            nilaib = Console.ReadLine();
            a = int.Parse(nilaia);
            b = int.Parse(nilaib);
            Console.WriteLine(a + "-" + b);
            hasil = a - b;
            Console.WriteLine("Hasil Pengurangan = " + hasil);
            return hasil;
        }

        public int perkalian()
        {
            int a, b, hasil;
            string nilaia, nilaib;
            Console.WriteLine("Kalkulator Perkalian");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.Write("Masukkan angka 1 : ");
            nilaia = Console.ReadLine();
            Console.Write("Masukkan angka 2 : ");
            nilaib = Console.ReadLine();
            a = int.Parse(nilaia);
            b = int.Parse(nilaib);
            Console.WriteLine(a + "x" + b);
            hasil = a * b;
            Console.WriteLine("Hasil Perkalian = " + hasil);
            return hasil;
        }

        public int pembagian()
        {
            int a, b, hasil;
            string nilaia, nilaib;
            Console.WriteLine("Kalkulator Pembagian");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.Write("Masukkan angka 1 : ");
            nilaia = Console.ReadLine();
            Console.Write("Masukkan angka 2 : ");
            nilaib = Console.ReadLine();
            a = int.Parse(nilaia);
            b = int.Parse(nilaib);
            Console.WriteLine(a + ":" + b);
            hasil = a / b;
            Console.WriteLine("Hasil Pembagian = " + hasil);
            return hasil;
        }

        public int hasil_bagi()
        {
            int a, b, hasil;
            string nilaia, nilaib;
            Console.WriteLine("Kalkulator Hasil Bagi");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.Write("Masukkan angka 1 : ");
            nilaia = Console.ReadLine();
            Console.Write("Masukkan angka 2 : ");
            nilaib = Console.ReadLine();
            a = int.Parse(nilaia);
            b = int.Parse(nilaib);
            Console.WriteLine(a + "%" + b);
            hasil = a % b;
            Console.WriteLine("Hasil Bagi = " + hasil);
            return hasil;
        }
    }

}

    
        
        
