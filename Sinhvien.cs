using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{ 

    internal class Sinhvien
    {
        private string MSV;
        private string Hoten;
        private int Namsinh;
        private double Diemlt;
        private double Diemcsdl;
        private double DTB;
        private string Quequan;
        public Sinhvien()
        {
        }
        public Sinhvien( string hoten, int namsinh, string quequan, double diemlt, double dcsdl)
        {
            this.Hoten = Hoten;
            this.Namsinh = Namsinh;
            this.Quequan = Quequan;
            this.Diemlt = Diemlt;
            this.Diemcsdl = Diemcsdl;
        }
        public void NhapTT()
        {
            Console.WriteLine("Nhap ho ten:");
            Hoten = Convert.ToString(Hoten);
            Console.WriteLine("Nhap ma sinh vien:");
            MSV = Convert.ToString(MSV);
            Console.WriteLine("Nhap nam sinh:");
            Namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh:");
            Diemlt = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Nhap diem co so du lieu:");
            Diemcsdl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh:");
            DTB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
        }
        public void DiemTB(Sinhvien sv)
        {
            double DTB = (Diemlt + Diemcsdl) / 2;
        }
        public void XuatTT()
        {
            Console.WriteLine("Thong tin sinh vien la:{0}, {1}, {2},{3},{4},{5},{6}", Hoten, MSV, Namsinh, Diemlt, Diemcsdl, DTB);
        }
    }
}
