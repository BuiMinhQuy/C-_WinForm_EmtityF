using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPVien
{
    class SoGio :PhongVienBase
    {
        public void setLuong (int sogio)
        {
            base.Luong = 1200000+ (100000 * (150 / 100) * sogio);
        }
        public double getLuong()
        {
            return base.Luong;
        }
    }
}
