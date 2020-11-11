using System;
using System.Collections.Generic;
using System.Text;

namespace doan.Business.Service_Interface
{
    class INhanVienBLL
    {
        public interface INhanvienBLL
        {
            List<Nhanvien> GetAllData();
            void Insert(NhanVien hs);
            void Delete(int mahs);
            List<NhanVien> TimHocSinh(NhanVien hs);
            List<NhanVien> TimHocSinh20();
        }
    }
}
