
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagers
{
    class Program
    {
        public static List<SinhVien> List = new List<SinhVien>();
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("1.Nhap sinh vien ");
            Console.WriteLine("2.Xuat sinh vien ");
            Console.WriteLine("3.Tim Kiem sinh vien ");
            Console.WriteLine("4.Xoa sinh vien ");
            Console.WriteLine("5.Sua sinh vien ");
            Console.WriteLine("6.thoat ");
            Console.Write("Bam Chon :");
            int luachon = int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1: nhapds(); menu(); break;
                case 2: xuatds(); menu(); break;
                case 3: timkiem(); menu(); break;
                case 4: xoa(); menu(); break;
                case 5: sua(); menu(); break;
                case 6: break;
            }
        }
        public static void nhapds()
        {
            Console.WriteLine("nhap vao so sinh vien :");
            int sosv = int.Parse(Console.ReadLine());
            for (int i = 0; i < sosv; i++)
            {
                SinhVien sv = new SinhVien();
                sv.nhap();
                List.Add(sv);
            }
        }
        public static void xuatds()
        {
            SinhVien.xuatTD();
            for (int i = 0; i < List.Count; i++)
            {
                List[i].xuat();

            }
        }
        public static void timkiem()
        {
            Console.Write("Nhap vao ma:");
            string ma = Console.ReadLine();
            SinhVien.xuatTD();
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Masv == ma)
                {
                    List[i].xuat();
                }

            }
        }
        public static void xoa()
        {
            Console.Write("Nhap vao ma:");
            string ma = Console.ReadLine();
            SinhVien.xuatTD();
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Masv == ma)
                {
                    List.RemoveAt(i);
                }

            }
            xuatds();

        }
        public static void sua()
        {
            Console.Write("Nhap vao ma:");
            string ma = Console.ReadLine();
            SinhVien.xuatTD();
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Masv == ma)
                {
                    List[i].nhap();
                }

            }
            SinhVien.xuatTD();
            xuatds();

        }

    }
}