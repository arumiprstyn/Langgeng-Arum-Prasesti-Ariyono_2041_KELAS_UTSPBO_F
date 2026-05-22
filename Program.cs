using System;
using UTS_PBO;

namespace UTS_PBO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BukuReferensi buku2 = new BukuReferensi("Rumi", "A102", "To Kill a Mockingbird");

            buku2.TampilkanInfo();
            Console.WriteLine("Total Biaya Pinjam: " + buku2.HitungBiayaPinjam() + " rupiah");
        }
    }
}