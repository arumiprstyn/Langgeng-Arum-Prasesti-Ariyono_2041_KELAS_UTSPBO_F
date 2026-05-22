using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UTS_PBO
{
    public abstract class PinjamBuku
    {
        private string namaAnggota;
        private string idAnggota;
        private string judulBuku;

        public PinjamBuku(string namaAnggota, string idAnggota, string judulBuku)
        {
            this.namaAnggota = namaAnggota;
            this.idAnggota = idAnggota;
            this.judulBuku = judulBuku;
        }

        public string GetNamaAnggota()
        {
            return namaAnggota;
        }

        public string GetIdAnggota()
        {
            return idAnggota;
        }

        public string GetJudulBuku()
        {
            return judulBuku;
        }
        public void TampilkanInfo()
        {
            Console.WriteLine("Nama Anggota: " + namaAnggota);
            Console.WriteLine("ID Anggota: " + idAnggota);
            Console.WriteLine("Judul Buku: " + judulBuku);
        }
        public abstract double HitungBiayaPinjam();
    }
    class BukuReguler : PinjamBuku
    {
        public int biayaPerHari = 1000;
        public int lamaHari;
        public BukuReguler(string namaAnggota, string idAnggota, string judulBuku)
            : base(namaAnggota, idAnggota, judulBuku)
        {
            this.biayaPerHari = biayaPerHari;
            this.lamaHari = lamaHari;
        }
        public override double HitungBiayaPinjam()
        {
            return biayaPerHari * lamaHari;
        }
    }
     class BukuReferensi : PinjamBuku
    {
        public int biayaPerHari = 1000;
        public int biayaAsuransi = 2000;
        public int lamaHari = 5;
        public BukuReferensi(string namaAnggota, string idAnggota, string judulBuku)
            : base(namaAnggota, idAnggota, judulBuku)
        {
            this.biayaPerHari = biayaPerHari;
            this.biayaAsuransi = biayaAsuransi;
        }
        public override double HitungBiayaPinjam()
        {
            return (biayaPerHari * lamaHari) + biayaAsuransi;
        }
    }
}
