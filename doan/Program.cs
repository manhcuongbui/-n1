using System;

namespace doan
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("PHAM MEM QUAN LY CUA HANG BAN THIET BI DIEN TU!");
                string[] mn ={
                            " PHAM MEM QUAN LY CUA HANG BAN THIET BI DIEN TU!",
                            " 1.Nhap danh sach nhan vien ",
                            " 2.Tim nhan vien trong cua hang  ",
                            " 3.Xoa thong tin nhanvien ",
                            " 4.Hien thi cac nhan vien trong cua hang ",
                            " 5.Ket thuc "
                        };
                doan.Presenation.menuchinh = new doan.Presenation.menuchinh (mn);
                doan.HienMeNu(10, 10, ConsoleColor.Black, ConsoleColor.White, ConsoleColor.DarkBlue, ConsoleColor.White);
            }
        }
    }

}
