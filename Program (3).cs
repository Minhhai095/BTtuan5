using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinhvien sv = new Sinhvien();
            Sinhvien sv1 = new Sinhvien();
            Sinhvien sv2 = new Sinhvien();

            Console.WriteLine("Nhap thong tin cua sinh vien");
            Sinhvien DTB = new Sinhvien();
            DTB = Sinhvien.DiemTB();
            DTB.XuatTT();
            Console.WriteLine("Nhap thong tin sinh vien thu hai");
            sv2.NhapTT();
            Console.WriteLine("Nhap ho ten:");
        }
    }
}
