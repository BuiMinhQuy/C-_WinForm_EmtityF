using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuCung
{
    class ChamSocHo : ThuCungQLModel
    {
        public void setTongChiPhi (int soNgay)
        {
            base.TongChiPhi = soNgay * 200000;
        }
        public double getTongChiPhi()
        {
            return base.TongChiPhi;
        }
    }
}
