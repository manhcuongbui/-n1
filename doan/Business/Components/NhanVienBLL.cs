using doan.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace doan.Business.Components
{
    class NhanVienBLL
    {
        public class NhanVienBLL : INhanVienBLL
        {
            private INhanvienDAL hsDA = new NhanvienDAL();
            //Thực thi các yêu cầu
            public List<NhanVien> GetAllData()
            {
                return hsDA.GetAllData();
            }
            public void Insert(NhanVien nv)
            {
                if (nv.Hoten != "" && nv.QueQuan != "")
                {
                    nv.Hoten = doan.Utility.CongCu.ChuanHoaXau(nv.Hoten);
                    nv.QueQuan = doan.Utility.CongCu.ChuanHoaXau(nv.QueQuan);
                    hsDA.Insert(nv);
                }
                else
                    throw new Exception("Du lieu sai");
            }
            public void Delete(int MaSv)
            {
                if (KiemTraMaHS(MaSv))
                    hsDA.Delete(MaSv);
                else
                    throw new Exception("Khong ton tai ma nay");
            }
            public List<nhanvien> TimHocSinh(nhanvien nv)
            {
                List<nhanvien> list = hsDA.GetAllData();
                List<nhanvien> kq = new List<nhanvien>();
                //Voi gai tri ngam dinh ban dau
                if (nv.Hoten == null && nv.QueQuan == null && nv.MaSv == 0)
                {
                    kq = list;
                }
                //Tim theo ho ten
                if (nv.Hoten != null && nv.QueQuan == null && nv.MaSv == 0)
                {
                    foreach (nhanvien nhanvien in list)
                        if (nhanvien.Hoten.IndexOf(nv.Hoten) >= 0)
                        {
                            kq.Add(new nhanvien(nhanvien));
                        }
                }
                // Tim theo que quan
                else if (nv.Hoten == null && nv.QueQuan != null && nv.MaSv == 0)
                {
                    foreach (nhanvien nhanvien in list)
                        if (nhanvien.QueQuan.IndexOf(nv.QueQuan) >= 0)
                        {
                            kq.Add(new nhanvien(nhanvien));
                        }
                }
                //Tim theo ma
                else if (nv.Hoten == null && nv.QueQuan == null && nv.MaSv != 0)
                {
                    foreach (nhanvien nhanvien in list)
                        if (nhanvien.MaSv == nv.MaSv)
                        {
                            kq.Add(new nhanvien(nhanvien));
                        }
                }
                //Tim ket hop giua ho ten va que quan
                else if (nv.Hoten != null && nv.QueQuan != null && nv.MaSv == 0)
                {
                    foreach (nhanvien nhanvien in list)
                        if (nhanvien.Hoten.IndexOf(nv.Hoten) >= 0 && nhanvien.QueQuan.IndexOf(hs.QueQuan) >= 0)
                        {
                            kq.Add(new nhanvien(nhanvien));
                        }
                }
            }
            public List<nhanvien> TimNhanVien()
            {
                List<nhanvien> list = hsDA.GetAllData();
                List<nhanvien> kq = new List<nhanvien>();
                for (int i = 0; i < list.Count; ++i)
                    return kq;
            }
            //Các phương thức hỗ trợ cho việc thực thi các yêu cầu
            public bool KiemTraMaHS(int mahs)
            {

            }
        }
    }
}
