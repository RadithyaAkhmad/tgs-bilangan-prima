using System;

namespace AplikasiListBilanganPrima
{
    public class Program // Ubah akses kelas menjadi publik
    {
        public static void Main(string[] args) // Ubah akses metode Main menjadi publik
        {
            Console.WriteLine("Aplikasi List Bilangan Prima");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Nama : Radithya Akhmad Prianarengga");
            Console.WriteLine("Kelas : X PPLG");
            Console.WriteLine("Absen : 27");
            Console.WriteLine("========================================================================================================================");

            for (int num = 2; num <= 1000; num++) // Melakukan looping dari bilangan 2 hingga 1000
            {
                bool isPrima = true; // Menetapkan bilangan prima menjadi isPrima dan membuat isPrima menjadi true

                // Melakukan loop dari 2 hingga ke akar kuadrat dari num
                for (int pembagi = 2; pembagi <= Math.Sqrt(num); pembagi++)
                {
                    if (num % pembagi == 0) // Jika num habis dibagi oleh angka di dalam loop 
                    {
                        isPrima = false; // Maka isPrima diatur menjadi false
                        break; // Loop dihentikan
                    }
                }

                if (isPrima) // Jika setelah melakukan loop isPrima masih true
                {
                    Console.WriteLine(num + " "); // Maka num yang telah difilter akan ditampilkan ke dalam list bilangan prima pada console
                }
            }
        }
    }
}