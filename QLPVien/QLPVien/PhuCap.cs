using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPVien
{
    class PhuCap : PhongVienBase
    {
        public void setLuong (double phucap)
        {
            base.Luong = 1200000 + phuCap;
        }
        public double getLuong()
        {
            return base.Luong;
        }
    }
}
