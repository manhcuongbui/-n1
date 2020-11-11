using System;
using System.Collections.Generic;
using System.Text;
using doan.Utility;

namespace Demo.Presenation
{
    //Trình bày dữ liệu cho đẹp
    public class menuchinh : Menu
    {
        public menuchinh(string[] mn) : base(mn) { }
        public override void ThucHien(int vitri)
        {
            FormNhanVien nhanvien = new FormNhanVien();
            switch (vitri)
            {
                case 0:
                    nhanvien.NhapNv();
                    break;
                case 1:
                    nhanvien.TimNv();
                    break;
                case 2:
                    nhanvien.XoaNv();
                    break;
                case 3:
                    nhanvien.Hien();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
