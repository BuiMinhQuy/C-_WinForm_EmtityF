using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuCung
{
    class ThuCungQLModel
    {
        private string maDon;
        private string tenthuCung;
        private string chungLoai;
        private int canNang;
        private DateTime ngayNhan;
        private string tinhTrang;
        private string dichVu;
        private int soNgay;
        private double chiPhiThuoc;
        private double tongChiPhi;

        public string MaDon
        {
            get { return maDon; }
            set { maDon = value; }
        }
        public string TenThuCung
        {
            get { return tenthuCung; }
            set { tenthuCung = value; }
        }
        public string ChungLoai
        {
            get { return chungLoai; }
            set { chungLoai = value; }
        }
        public int CanNang
        {
            get { return canNang; }
            set { canNang = value; }
        }
        public DateTime NgayNhan
        {
            get { return ngayNhan; }
            set { ngayNhan = value; }
        }
        public string TinhTrang
        {
            get {return tinhTrang; }
            set { tinhTrang = value; }
        }
        public string DichVu
        {
            get { return dichVu; }
            set { dichVu = value; }
        }
        public int SoNgay
        {
            get { return soNgay; }
            set { soNgay = value; }
        }
        public double ChiPhiThuoc
        {
            get { return chiPhiThuoc; }
            set { chiPhiThuoc = value; }
        }
        public double TongChiPhi
        {
            get { return tongChiPhi; }
            set { tongChiPhi = value; }
        }
    }
}
