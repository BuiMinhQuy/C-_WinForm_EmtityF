using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuCung
{
    class ChuaBenh : ThuCungQLModel
    {
        public void setTongChiPhi(double chiPhiThuoc)
        {
            base.TongChiPhi = 100000 + chiPhiThuoc;
        }
        public double getTongChiPhi()
        {
            return base.TongChiPhi;
        }
    }
}
