using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhanvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nhanvien nv = new Nhanvien();
            Nhanvien nv1 = new Nhanvien();
            Nhanvien nv2 = new Nhanvien();

            Console.WriteLine("Nhap thong tin nhan vien 1");
            nv1.Nhapnhanvien();
            Console.Write("Tong tien cua nhan vien la:{0}", Nhanvien.Tinhluong(nv));
            nv1.Innhanvien();

            Console.WriteLine("Nhap thong tin nhan vien 2");
            nv2.Nhapnhanvien();
            Console.Write("Tong tien cua nhan vien la:{0}", Nhanvien.Tinhluong(nv));
            nv2.Innhanvien();

            Console.ReadLine();

        }
    }
}
