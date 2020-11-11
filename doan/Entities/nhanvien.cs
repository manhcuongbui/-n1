using System;
using System.Collections.Generic;
using System.Text;

namespace doan.Entities
{
    public class nhanvien
    {
        #region Các thành phần dữ liệu
        private int manv;
        private string hoten;
        private string quequan;
        #endregion

        #region Các thuộc tính
        public int MaSv
        {
            get { return MaSv; }
            set
            {
                if (value >= 1)
                    manv = value;
            }
        }
        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (value != "")
                    hoten = value;
            }
        }
        public string QueQuan
        {
            get { return quequan; }
            set
            {
                if (value != "")
                    quequan = value;
            }
        }
        #endregion

        #region Các thương thức             
        public nhanvien() { }
        //Phương thức thiết lập sao chép
        public nhanvien(nhanvien nv)
        {
            this.manv = nv.manv;
            this.Hoten = string.Copy(nv.Hoten);
            this.quequan = string.Copy(nv.quequan);
        }
        public nhanvien(int mahs, string hoten, string quequan)
        {
            this.manv = mahs;
            this.hoten = hoten;
            this.quequan = quequan;
        }
    }
}
