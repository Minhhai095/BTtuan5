using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhanvien
{
    internal class Nhanvien
    {
        private string hoten;
        private int namsinh;
        private string diachi;
        private double lcb;
        private float hsl;
        private double pc;
        private double tl;
        public Nhanvien()
        {
        }
        public void Nhapnhanvien()
        {
            Nhanvien nv = new Nhanvien();
            Console.Write("Ho va ten cua NV:");
            nv.hoten = Convert.ToString(Console.ReadLine());

            Console.Write("Nam sinh cua NV:");
            nv.namsinh = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Dia chi cua NV:");
            nv.diachi = Convert.ToString(Console.ReadLine());

            Console.Write("Luong co ban:");
            nv.lcb = Convert.ToDouble(Console.ReadLine());

            Console.Write("He so luong:");
            nv.hsl = Convert.ToSingle(Console.ReadLine());

            Console.Write("Phu cap cua NV:");
            nv.pc = Convert.ToDouble(Console.ReadLine());
        }
        static public double Tinhluong(Nhanvien nv)
        {
            double Tinhluong = nv.tl;
            Tinhluong = (nv.lcb * nv.hsl) + nv.pc;
            return Tinhluong;
        }
        public void Innhanvien()
        {
            Console.WriteLine("Thong tin cua nhan vien do la: {0}, {1}, {2}, {3}", hoten, namsinh, diachi, tl);
        }
    }
    
}
