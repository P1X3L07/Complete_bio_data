using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complete_bio_data
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Berapa data = ");
            int data = Convert.ToInt32(Console.ReadLine());

            bool repeat = true;
            int counter = 1;
            int status = 1;
            while(repeat = true)
            {
                string[,] info = new string[data, 6];
                for(int i = 0; i < data; i++)
                {
                    Console.WriteLine($"data ke - { i + status}");

                    Console.Write("NIM : ");
                    info[i, 0] = Console.ReadLine();

                    Console.Write("NAMA : ");
                    info[i, 1] = Console.ReadLine();

                    Console.Write("JENIS KELAMIN : ");
                    info[i, 2] = Console.ReadLine();

                    Console.Write("TAHUN MASUK : ");
                    info[i, 3] = Console.ReadLine();

                    Console.Write("PROGRAM STUDI : ");
                    info[i, 4] = Console.ReadLine();

                    Console.Write("KELAS : ");
                    info[i, 5] = Console.ReadLine();

                    Console.WriteLine();
                }

                Console.Write("PRINT HASIL ? (y/n)");
                string print = Console.ReadLine();

                while(print != "y" && print != "n")
                {
                    Console.Write("PRINT HASIL ? (y/n)");
                    print = Console.ReadLine();
                }
                if(print == "y")
                {
                    Console.Clear();
                    var sb = new System.Text.StringBuilder();
                    sb.Append(String.Format("{0,-4} | {1,-5} | {2,-20} | {3,15} | {4, 20} | {5, 12} | {6, 4}", "NO",
                    "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS\n"));
                    Console.WriteLine();

                    for (int i = 0; i < data; i++)
                    {
                        sb.Append(String.Format("{0,-4} | {1,-5} | {2,-20} | {3,15} | {4, 20},| {5, 12} | {6, 4}", (i + status),
                        info[i,0],info[i,1], info[i,2], info[i,3], info[i,4], info[i,5] + "\n"));
                    }
                    Console.Write(sb);

                    Console.Write("Tambah data? (y/n) ... ");
                    string ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        status++;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                        repeat = false;
                    }
                }
                else if(print == "n")
                {
                    Console.Clear();
                    break;
                    repeat = false;
                }
            }
        }
    }
}
