using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "HAITSAM", "FAUZAN", "KUKUH", "NIZAR" };
            int[] arrNim = { 4812, 4817, 4871, 4813 };
            int[] arrNilai = { 95, 88, 80, 75 };

            Console.WriteLine("===============================");
            Console.WriteLine("No\tNama\tNIM\tNilai");
            Console.WriteLine("===============================");

            //menampilkan semua elemen array
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine((i + 1) + ".\t" + arrNama[i] + "\t" + arrNim[i] + "\t  " + arrNilai[i]);
            }
            Console.ReadKey();
        }
    }
}