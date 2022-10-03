using System;

namespace P2_2_1214063
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //mendeklarasi dan menginisialisasi variabel
            Console.Write("Masukkan Gaji Pokok : ");
            var gajiPokok = Console.Read();

            var tunjangan = (gajiPokok * 20)/100;
            var bonus = (gajiPokok * 15) / 100;
            var pph = (gajiPokok * 3.5) / 100;
            var totalGaji = gajiPokok + tunjangan + bonus;
            var gajiBersih = totalGaji - pph;
            
            //menampilkan output
            Console.WriteLine("Tunjangan : " + tunjangan);
            Console.WriteLine("Bonus : " + bonus);
            Console.WriteLine("PPH : " + pph);
            Console.WriteLine("Total Gaji : " + totalGaji);
            Console.WriteLine("Gaji Bersih : " + gajiBersih);
            




        } //end public static void Main(string[] args)
    } //end internal class Program
} //end namespace P2_2_1214063