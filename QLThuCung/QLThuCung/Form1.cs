using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLThuCung
{
    public partial class Form1 : Form
    {
        QLTCEntities1 db = new QLTCEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // Tạo form closing , đáng ct thông báo
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoat chuong trinh" , "Thong Bao" ,MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        // tạo form load dữ liệu từ db lên lv khi mới vào chương trình
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbChuaBenh.Checked = true;
            dtp_NgayNhan.Value = DateTime.Now;

            var tc = db.ThuCungs.Select(model => model).ToList();

            foreach ( var ThuC in tc )
            {
                string[] data =
                {
                    ThuC.MaDon ,
                    ThuC.TenThuCung ,
                    ThuC.ChungLoai ,
                    ThuC.NgayNhan.Value.ToShortDateString()
                };
                Add_Data_Lv(data);
            }
        }
        // click chọn trong bảng lv , xử lý dữ liệu khi click chọn là phải hiển thị bên các textbox
        private void lvDSTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSTC.SelectedItems.Count > 0)
            {
                var item = lvDSTC.SelectedItems[0];
                var model = db.ThuCungs.Find(item.Text);

                txtMaDon.Text = model.MaDon;
                txtTenTc.Text = model.TenThuCung;
                txtChungloai.Text = model.ChungLoai;
                txtCanNang.Text = model.CanNang.ToString();
                dtp_NgayNhan.Value = (DateTime)model.NgayNhan;
                txtTinhTrang.Text = model.TinhTrang;
                if (model.DichVu.Equals("Chữa Bệnh"))
                {
                    rdbChuaBenh.Checked = true;
                    rdbChamSocHo.Checked = false;
                    txtChiPhiThuoc.Text = model.ChiPhiThuoc.ToString();
                } 
                else if (model.DichVu.Equals("Chăm Sóc Hộ"))
                {
                    rdbChamSocHo.Checked = true;
                    rdbChuaBenh.Checked = false;
                    txtSoNgay.Text = model.SoNgay.ToString();
                }
            }
        }
        // Kiểm tra trường hợp rdb nào được chọn
        private void rdbChuaBenh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbChuaBenh.Checked)
            {
                lblChiPhiThuoc.Visible = true;
                txtChiPhiThuoc.Visible = true;
                lblSoNgay.Visible = false;
                txtSoNgay.Visible = false;
            }
            else if (rdbChamSocHo.Checked)
            {
                lblChiPhiThuoc.Visible = false;
                txtChiPhiThuoc.Visible = false;
                lblSoNgay.Visible = true;
                txtSoNgay.Visible = true;
            }
        }
        // tạo hàm reset để cho các textbox nhập dữ liệu về trống
        private void reset()
        {
            txtMaDon.Clear();
            txtTenTc.Clear();
            txtChungloai.Clear();
            txtCanNang.Clear();
            dtp_NgayNhan.Value = DateTime.Now;
            txtChiPhiThuoc.Clear();
            txtTinhTrang.Clear();
            txtSoNgay.Clear();
        }
        // nút thêm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            txtMaDon.Focus();
        }
        // hàm xử lý thêm dữ liệu từ db vào lv thông qua string data khởi tạo / var tc = db.ThuCungs.Select().toList();
        private void Add_Data_Lv(string[] data)
        {
            ListViewItem item = new ListViewItem(data);
            //item.BackColor = Color.Yellow;
            lvDSTC.Items.Add(item);
        }
        // Thêm dữ liệu vào trong cls Chữa Bệnh để đảy vào db
        private void AddChuaBenh(ChuaBenh chuaBenh)
        {
            QLThuCung.ThuCung model = new ThuCung()
            {
                MaDon = chuaBenh.MaDon,
                TenThuCung = chuaBenh.TenThuCung ,
                ChungLoai = chuaBenh.ChungLoai ,
                CanNang = chuaBenh.CanNang ,
                NgayNhan = chuaBenh.NgayNhan ,
                TinhTrang = chuaBenh.TinhTrang ,
                DichVu = chuaBenh.DichVu ,
                ChiPhiThuoc = chuaBenh.ChiPhiThuoc ,
                TongChiPhi =chuaBenh .TongChiPhi
            };
            db.ThuCungs.Add(model);
            db.SaveChanges();
        }
        // Thêm dữ liệu vào trong cls Chăm sóc hộ để đảy vào db
        private void AddChamSocHo(ChamSocHo chamSocHo)
        {
            QLThuCung.ThuCung model = new ThuCung()
            {
                MaDon = chamSocHo.MaDon,
                TenThuCung = chamSocHo.TenThuCung,
                ChungLoai = chamSocHo.ChungLoai,
                CanNang = chamSocHo.CanNang,
                NgayNhan = chamSocHo.NgayNhan,
                TinhTrang = chamSocHo.TinhTrang,
                DichVu = chamSocHo.DichVu,
                SoNgay = chamSocHo.SoNgay,
                TongChiPhi = chamSocHo.TongChiPhi
            };
            db.ThuCungs.Add(model);
            db.SaveChanges();
        }
        // Hàm check rdb nào được chọn , sau đó thêm dữ liệu theo nút rdb được chọn
        private void AddThuCungToListView()
        {
            if (rdbChuaBenh.Checked)
            {
                double cpt = 0;
                cpt = Convert.ToDouble(txtChiPhiThuoc.Text);
                ChuaBenh tc = new ChuaBenh()
                {
                    MaDon = txtMaDon.Text,
                    TenThuCung = txtTenTc.Text,
                    ChungLoai = txtChungloai.Text,
                    CanNang = Convert.ToInt32( txtCanNang.Text),
                    NgayNhan = dtp_NgayNhan.Value,
                    TinhTrang = txtTinhTrang.Text,
                    DichVu = rdbChuaBenh.Checked == true ? rdbChuaBenh.Text : rdbChamSocHo.Text ,
                    ChiPhiThuoc = Convert.ToDouble(txtChiPhiThuoc.Text)
                };
                tc.setTongChiPhi(cpt);

                string[] data =
                {
                    tc.MaDon ,
                    tc.TenThuCung ,
                    tc.ChungLoai ,
                    tc.NgayNhan.ToShortDateString()
                };
                Add_Data_Lv(data);
                AddChuaBenh(tc);

            } else if (rdbChamSocHo.Checked)
            {
                int sn = 0;
                sn = Convert.ToInt32(txtSoNgay.Text);
                ChamSocHo tc = new ChamSocHo()
                {
                    MaDon = txtMaDon.Text,
                    TenThuCung = txtTenTc.Text,
                    ChungLoai = txtChungloai.Text,
                    CanNang = Convert.ToInt32(txtCanNang.Text),
                    NgayNhan = dtp_NgayNhan.Value,
                    TinhTrang = txtTinhTrang.Text ,
                    DichVu = rdbChamSocHo.Checked == true ? rdbChamSocHo.Text : rdbChuaBenh.Text,
                    SoNgay = Convert.ToInt32(txtSoNgay.Text)
                };
                tc.setTongChiPhi(sn);
                string[] data =
                {
                    tc.MaDon ,
                    tc.TenThuCung ,
                    tc.ChungLoai ,
                    tc.NgayNhan.ToShortDateString()
                };
                Add_Data_Lv(data);
                AddChamSocHo(tc);
            }
        }
        // Check điều kiên khi nhập dữ liệu cho textbox trông hay đã có dữ liệu trươc khi lưu
        public bool Validate()
        {
            if (string.IsNullOrEmpty(txtMaDon.Text) || string.IsNullOrEmpty(txtTenTc.Text) || string.IsNullOrEmpty(txtChungloai.Text) || string.IsNullOrEmpty(txtCanNang.Text) || string.IsNullOrEmpty(txtTinhTrang.Text) || (string.IsNullOrEmpty(txtChiPhiThuoc.Text) && rdbChuaBenh.Checked) || (string.IsNullOrEmpty(txtSoNgay.Text) && rdbChamSocHo.Checked))
            {
                MessageBox.Show("Thong tin dien vao chua day du ", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtp_NgayNhan.Value > DateTime.Now)
            {
                MessageBox.Show("Ngay nhap vao phai nho hon ngay hien tai", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                MessageBox.Show("Da nhap thanh cong ", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddThuCungToListView();
            }
        }
        // nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoa dong nay" , "Co chac chua" ,MessageBoxButtons.OKCancel ,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (lvDSTC.SelectedItems.Count > 0)
                {
                    var item = lvDSTC.SelectedItems[0];
                    var model = db.ThuCungs.Find(item.Text);
                    lvDSTC.Items.Remove(item);
                    db.ThuCungs.Remove(model);
                    db.SaveChanges();

                    reset();
                }
            }
        }
        // nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDSTC.SelectedItems.Count > 0)
            {
                string MaDonID = lvDSTC.SelectedItems[0].SubItems[0].Text;
                var model = db.ThuCungs.FirstOrDefault(a => a.MaDon.Equals(MaDonID));

                if (rdbChuaBenh.Checked)
                {
                    double cpt = 0;
                    cpt = Convert.ToDouble(txtChiPhiThuoc.Text);

                    if (model != null)
                    {
                        model.MaDon = txtMaDon.Text;
                        model.TenThuCung = txtTenTc.Text;
                        model.ChungLoai = txtChungloai.Text;
                        model.CanNang = Convert.ToInt32(txtCanNang.Text);
                        model.NgayNhan = dtp_NgayNhan.Value;
                        model.TinhTrang = txtTinhTrang.Text;
                        model.DichVu = rdbChuaBenh.Checked == true ? rdbChuaBenh.Text : rdbChamSocHo.Text;
                        model.ChiPhiThuoc = cpt;


                        lvDSTC.Items.Clear();
                        db.SaveChanges();
                    }
                } 
                else if (rdbChamSocHo.Checked)
                {
                    int sn = 0;
                    sn = Convert.ToInt32(txtSoNgay.Text);

                    if (model != null)
                    {
                        model.MaDon = txtMaDon.Text;
                        model.TenThuCung = txtTenTc.Text;
                        model.ChungLoai = txtChungloai.Text;
                        model.CanNang = Convert.ToInt32(txtCanNang.Text);
                        model.NgayNhan = dtp_NgayNhan.Value;
                        model.TinhTrang = txtTinhTrang.Text;
                        model.DichVu = rdbChamSocHo.Checked == true ? rdbChamSocHo.Text : rdbChuaBenh.Text;
                        model.SoNgay = sn;

                        lvDSTC.Items.Clear();
                        db.SaveChanges();
                    }
                }


                var tc = db.ThuCungs.OrderBy(a => a.MaDon).ToList();
                foreach (var t in tc)
                {
                    string[] data =
                    {
                        t.MaDon ,
                        t.TenThuCung,
                        t.ChungLoai ,
                        t.NgayNhan.Value.ToShortDateString()
                    };

                    Add_Data_Lv(data);
                }
                reset();
            }
        }
        // nút sắp xếp
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            var tc = db.ThuCungs.OrderByDescending(a => a.MaDon).ToList();

            lvDSTC.Items.Clear();

            foreach (var t in tc)
            {
                string[] data =
                {
                    t.MaDon ,
                    t.TenThuCung ,
                    t.ChungLoai ,
                    t.NgayNhan.Value.ToShortDateString()
                };

                Add_Data_Lv(data);
            }
        }
        // nút thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var tc = db.ThuCungs.ToList();
            int SLDonChuaBenh = 0;
            int SLDonChamSocHo = 0;

            foreach(var item in tc)
            {
                if (item.DichVu.Equals("Chữa Bệnh"))
                {
                    SLDonChuaBenh++;
                } else if (item.DichVu.Equals("Chăm Sóc Hộ"))
                {
                    SLDonChamSocHo++;
                }
            }
            double? tongDoanhThuCB = tc.Where(p => p.DichVu == "Chữa Bệnh").Sum(p => p.TongChiPhi);
            double? tongDoanhThuCSH = tc.Where(p => p.DichVu == "Chăm Sóc Hộ").Sum(p => p.TongChiPhi);

            MessageBox.Show($"So luong don chua benh thu cung : {SLDonChuaBenh}\n\n" +
                            $"So luong don cham soc ho thu cung : {SLDonChamSocHo}\n\n" + 
                            $"Doanh so chua benh : {tongDoanhThuCB}\n\n" + 
                            $"Doanh so cham soc ho : {tongDoanhThuCSH}\n\n" , "Bang Thong Ke", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }
        // nút xuất excel
        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet excelWs = excelWb.Worksheets[1];

            Excel.Range excelRanga = excelWs.Cells[1,1];
            excelRanga.Font.Size = 16;
            excelRanga.Font.Bold = true;
            excelRanga.Font.Color = Color.Blue;
            excelRanga.Value = "Danh Sach Thu Cung";

            int row = 2;

            var tc = db.ThuCungs.Select(p => p).ToList();
            foreach(var t in tc)
            {
                excelWs.Range["A" + row].Value = t.MaDon;
                excelWs.Range["B" + row].Value = t.TenThuCung;
                excelWs.Range["C" + row].Value = t.ChungLoai;
                excelWs.Range["D" + row].Value = t.CanNang;
                excelWs.Range["E" + row].Value = t.NgayNhan;
                excelWs.Range["F" + row].Value = t.TinhTrang;
                excelWs.Range["G" + row].Value = t.DichVu;
                excelWs.Range["H" + row].Value = t.ChiPhiThuoc;
                excelWs.Range["I" + row].Value = t.SoNgay;
                excelWs.Range["J" + row].Value = t.TongChiPhi;
                row++;
            }

            excelWs.Name = "Danh Sach Thu Cung";
            excelWb.Activate();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelWb.SaveAs(saveFileDialog.FileName);
            }
            
            excelApp.Quit();
            if (MessageBox.Show("Xuat excel thanh cong " , "Thong Bao" ,MessageBoxButtons.OK ,MessageBoxIcon.Information) == DialogResult.OK){};
        }
        
    }
}
