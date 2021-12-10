using System;
using Projek_Calculator_Library;

namespace Calculator_Projek_Kelompok
{
    class Program
    {
        static void Main(string[] args)
        {
            mengulang_1 kalkulator1 = new mengulang_1();
            try
            {
                kalkulator1.ulang();
            }
            catch (FormatException)
            {
                Console.WriteLine("Hanya dapat memasukkan angka...");
                kalkulator1.pilihan();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Bilangan tidak boleh dibagi dengan 0!");
                kalkulator1.pilihan();
            }
            finally
            {
                Console.ReadLine();
                kalkulator1.pilihan();
            }
        }
    }
}
