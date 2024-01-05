using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPVien
{
    class PhongVienBase
    {
        public string maPV;
        public string hoTen;
        public string gioiTinh;
        public string sDT;
        public DateTime ngayVaoLam;
        public string loaiPV;
        public double phuCap;
        public int soGioLam;
        public double luong;

        public string MaPV { get { return maPV; } set { maPV = value; }}
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public string GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public string SDT { get { return sDT; } set { sDT = value; } }
        public DateTime NgayVaoLam { get { return ngayVaoLam; } set { ngayVaoLam = value; } }
        public string LoaiPV { get { return loaiPV; } set { loaiPV = value; } }
        public double PhuCap { get { return phuCap; } set { phuCap = value; } }
        public int SoGioLam { get { return soGioLam; } set { soGioLam = value; } }
        public double Luong { get { return luong; } set { luong = value; } }
    }
}
