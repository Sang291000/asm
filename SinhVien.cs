using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagers
{
    class SinhVien
    {
        private string masv;
        private string tensv;
        private int Tuoi;
        private string Email;
        private string Quequan;


        public string Masv
        {
            get
            {
                return masv;
            }
            set
            {
                masv = value;
            }
        }
        public string Tensv
        {
            get
            {
                return tensv;
            }
            set
            {
                tensv = value;
            }

        }
        public string tuoi
        {
            get
            {
                return tuoi;
            }
            set
            {
                tuoi = value;
            }
        }
        public string email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string quequan
        {
            get
            {
                return quequan;
            }
            set
            {
                quequan = value;
            }
        }
        public SinhVien() { }
        public SinhVien(string masv, string tensv, int tuoi,string email, string quequan)
        {
            this.masv = masv;
            this.Tensv = tensv;
            this.Tuoi = tuoi;
            this.Email = email;
            this.Quequan = quequan;

        }
        public void nhap()
        {
            Console.Write("Nhap masv :");
            this.Masv = Console.ReadLine();
            Console.Write("Nhap tensv :");
            this.Tensv = Console.ReadLine();
            Console.Write("Nhap tuoi :");
            this.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap email :");
            this.Email = Console.ReadLine();
            Console.Write("Nhap quequan :");
            this.Quequan = Console.ReadLine();
        }
        public void xuat()
        {
            string chuoi = string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}", this.Masv, this.Tensv, this.Tuoi, this.Email, this.Quequan);
            Console.WriteLine(chuoi);

        }
        public static void xuatTD()
        {
            string chuoi = string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}", "Ma Sinh Vien", "Ten Sinh Vien", "Tuoi", "Email", "Que Quan");
            Console.WriteLine(chuoi);

        }
    }
}  
