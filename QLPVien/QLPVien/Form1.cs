using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLPVien
{
    public partial class Form1 : Form
    {
        QLPVEntities db = new QLPVEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoat Chuong Trinh" , "Thong Bao" , MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void rdbTaiToaSoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTaiToaSoan.Checked)
            {
                lblSoGio.Visible = true;
                txtSoGio.Visible = true;
                lblPhuCap.Visible = false;
                txtPhuCap.Visible = false;
            } else if (rdbThuongTru.Checked)
            {
                lblSoGio.Visible = false;
                txtSoGio.Visible = false;
                lblPhuCap.Visible = true;
                txtPhuCap.Visible = true;
            }
        }

        public void AddItemToLV(string[] data)
        {
            ListViewItem item = new ListViewItem(data);
            lvDSPV.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbNam.Checked = true;
            dtp_NgayVaoLam.Value = DateTime.Now;

            var pv = db.PhongViens.Select(p => p).ToList();
            foreach (var PhongVien in pv)
            {
                string[] data = { 
                    PhongVien.MaPV ,
                    PhongVien.HoTen ,
                    PhongVien.GioiTinh ,
                    PhongVien.NgayVaoLam.Value.ToShortDateString()
                };

                AddItemToLV(data);
            }
        }

        private void lvDSPV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSPV.SelectedItems.Count > 0)
            {
                var item = lvDSPV.SelectedItems[0];
                var model = db.PhongViens.Find(item.Text);

                txtMaNV.Text = model.MaPV;
                txtHoTen.Text = model.HoTen;
                if (model.GioiTinh.Equals("Nam"))
                {
                    rdbNam.Checked = true;
                    rdbNu.Checked = false;
                } else if (model.GioiTinh.Equals("Nữ"))
                {
                    rdbNu.Checked = true;
                    rdbNam.Checked = false;
                }
                txtSDT.Text = model.SDT;
                dtp_NgayVaoLam.Value = (DateTime)model.NgayVaoLam;
                if (model.LoaiPV.Equals("Tại Tòa Soạn"))
                {
                    rdbTaiToaSoan.Checked = true;
                    rdbThuongTru.Checked = false;
                    txtSoGio.Text = model.SoGioLam.ToString();
                } else if (model.LoaiPV.Equals("Thường Trú"))
                {
                    rdbThuongTru.Checked = true;
                    rdbTaiToaSoan.Checked = false;
                    txtPhuCap.Text = model.PhuCap.ToString();
                }
            }
        }

        public void reset()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            dtp_NgayVaoLam.Value = DateTime.Now;
            txtPhuCap.Clear();
            txtSoGio.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            txtMaNV.Focus();
        }

        private void AddSoGio(SoGio sogio)
        {
            QLPVien.PhongVien model = new PhongVien() { 
                MaPV = sogio.MaPV ,
                HoTen = sogio.HoTen ,
                GioiTinh = sogio.gioiTinh, 
                SDT = sogio.sDT ,
                NgayVaoLam = sogio.ngayVaoLam ,
                LoaiPV = sogio.loaiPV ,
                SoGioLam = sogio.soGioLam ,
                Luong = sogio.luong
            };
            db.PhongViens.Add(model);
            db.SaveChanges();
        }

        private void AddPhuCap(PhuCap phucap)
        {
            QLPVien.PhongVien model = new PhongVien() { 
                MaPV = phucap.maPV ,
                HoTen = phucap.hoTen ,
                GioiTinh = phucap.gioiTinh ,
                SDT = phucap.sDT ,
                NgayVaoLam = phucap.ngayVaoLam,
                LoaiPV = phucap.LoaiPV ,
                PhuCap = phucap.PhuCap ,
                Luong = phucap.Luong
            };
            db.PhongViens.Add(model);
            db.SaveChanges();
        }

        private void AddDataVaoListView()
        {
            if (rdbTaiToaSoan.Checked)
            {
                int sg1 = 0;
                sg1 = Convert.ToInt32(txtSoGio.Text);
                SoGio sg = new SoGio() {
                    MaPV = txtMaNV.Text,
                    HoTen = txtHoTen.Text,
                    GioiTinh = rdbNam.Checked == true ? rdbNam.Text : rdbNu.Text,
                    SDT = txtSDT.Text ,
                    NgayVaoLam = dtp_NgayVaoLam.Value,
                    LoaiPV = rdbTaiToaSoan.Checked == true ? rdbTaiToaSoan.Text : rdbThuongTru.Text , 
                    SoGioLam = Convert.ToInt32(txtSoGio.Text)

                };
                sg.setLuong(sg1);

                string[] data = { 
                    sg.MaPV ,
                    sg.HoTen ,
                    sg.GioiTinh ,
                    sg.NgayVaoLam.ToShortDateString()
                };
                AddItemToLV(data);
                AddSoGio(sg);
            } else if (rdbThuongTru.Checked)
            {
                double pc1 = 0;
                pc1 = Convert.ToDouble(txtPhuCap.Text);
                PhuCap pc = new PhuCap() {
                    MaPV = txtMaNV.Text,
                    HoTen = txtHoTen.Text,
                    GioiTinh = rdbNam.Checked == true ? rdbNam.Text : rdbNu.Text,
                    SDT = txtSDT.Text,
                    NgayVaoLam = dtp_NgayVaoLam.Value,
                    LoaiPV = rdbThuongTru.Checked == true ? rdbThuongTru.Text : rdbTaiToaSoan.Text,
                    PhuCap = Convert.ToDouble(txtPhuCap.Text)


                };
                pc.setLuong(pc1);

                string[] data = {
                    pc.maPV ,
                    pc.hoTen , 
                    pc.gioiTinh ,
                    pc.NgayVaoLam.ToShortDateString()
                };

                AddItemToLV(data);
                AddPhuCap(pc);
            }
        }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || (string.IsNullOrEmpty(txtSoGio.Text) && rdbTaiToaSoan.Checked) || (string.IsNullOrEmpty(txtPhuCap.Text) && rdbThuongTru.Checked))
            {
                MessageBox.Show("Chua nhap day du thong tin", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtp_NgayVaoLam.Value > DateTime.Now)
            {
                MessageBox.Show("Ngay vao lam phai nho hon hien tai", "Canh Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                AddDataVaoListView();
                MessageBox.Show("Them Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoa dong nay" ,"Thong Bao" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (lvDSPV.SelectedItems.Count > 0)
                {
                    var item = lvDSPV.SelectedItems[0];
                    var model = db.PhongViens.Find(item.Text);
                    lvDSPV.Items.Remove(item);
                    db.PhongViens.Remove(model);
                    db.SaveChanges();

                    reset();
                }
            }
        }



        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDSPV.SelectedItems.Count >0)
            {
                string maDonID = lvDSPV.SelectedItems[0].Text;
                var model = db.PhongViens.Find(maDonID);

                if (rdbTaiToaSoan.Checked)
                {
                    int sg =0 ;
                    sg = Convert.ToInt32(txtSoGio.Text);
                    if (model != null)
                    {
                        model.MaPV = txtMaNV.Text;
                        model.HoTen = txtHoTen.Text;
                        model.GioiTinh = rdbNam.Checked == true ? rdbNam.Text : rdbNu.Text;
                        model.SDT = txtSDT.Text;
                        model.NgayVaoLam = dtp_NgayVaoLam.Value;
                        model.LoaiPV = rdbTaiToaSoan.Checked == true ? rdbTaiToaSoan.Text: rdbThuongTru.Text;
                        model.SoGioLam = sg;

                        lvDSPV.Items.Clear();
                        db.SaveChanges();
                    }
                } else if (rdbThuongTru.Checked)
                {
                    double pcl = 0;
                    pcl = Convert.ToDouble(txtPhuCap.Text);
                    if (model != null)
                    {
                        model.MaPV = txtMaNV.Text;
                        model.HoTen = txtHoTen.Text;
                        model.GioiTinh = rdbNam.Checked == true ? rdbNam.Text: rdbNu.Text;
                        model.SDT = txtSDT.Text;
                        model.NgayVaoLam = dtp_NgayVaoLam.Value;
                        model.LoaiPV = rdbThuongTru.Checked == true ?rdbThuongTru.Text :rdbTaiToaSoan.Text ;
                        model.PhuCap = pcl;

                        lvDSPV.Items.Clear();
                        db.SaveChanges();
                    }

                }
                var pc = db.PhongViens.OrderBy(p => p.MaPV).ToList();
                foreach(var PhongVien in pc)
                {
                    string[] data = { 
                        PhongVien.MaPV , 
                        PhongVien.HoTen , 
                        PhongVien.GioiTinh , 
                        PhongVien.NgayVaoLam.Value.ToShortDateString()
                    };

                    AddItemToLV(data);
                }
                reset();
            }


        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            var pv = db.PhongViens.OrderByDescending(p => p.MaPV).ToList();
            lvDSPV.Items.Clear();
            foreach(var PhongVien in pv)
            {
                string[] data =
                {
                    PhongVien.MaPV , 
                    PhongVien.HoTen , PhongVien.GioiTinh , PhongVien.NgayVaoLam.Value.ToShortDateString()
                };

                AddItemToLV(data);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var pv = db.PhongViens.ToList();
            int SLpvTS = 0;
            int SLpcTT = 0;
            foreach(var PhongVien in pv)
            {
                if (PhongVien.LoaiPV.Equals("Tại Tòa Soạn"))
                {
                    SLpvTS++;
                } else if (PhongVien.LoaiPV.Equals("Thường Trú"))
                {
                    SLpcTT++;
                }
            }
            double? tongLuongPVTS = pv.Where(p => p.LoaiPV == "Tại Tòa Soạn").Sum(p => p.Luong);
            double? tongLuongPVTT = pv.Where(p => p.LoaiPV == "Thường Trú").Sum(p => p.Luong);

            MessageBox.Show($"SL pv tại tòa soạn : {SLpvTS} \n"+
                            $"SL pc thường trú : {SLpcTT} \n"+
                            $"Tổng Lương pv TS : {tongLuongPVTS} \n"+
                            $"Tổng Lương pv TT : {tongLuongPVTT} \n"
                            , "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet excelWs = excelWb.Worksheets[1];

            Excel.Range excelRanga = excelWs.Cells.Cells[1, 1];
            excelRanga.Font.Size = 16;
            excelRanga.Font.Bold = true;
            excelRanga.Font.Color = Color.Red;
            excelRanga.Value = "Danh Sach Phong Vien";

            int row = 2;
            var pv = db.PhongViens.Select(p => p).ToList();
            foreach(var PhongVien in pv)
            {
                excelWs.Range["A" + row].Value = PhongVien.MaPV;
                excelWs.Range["B" + row].Value = PhongVien.HoTen;
                excelWs.Range["C" + row].Value = PhongVien.GioiTinh;
                excelWs.Range["D" + row].Value = PhongVien.SDT;
                excelWs.Range["E" + row].Value = PhongVien.NgayVaoLam;
                excelWs.Range["F" + row].Value = PhongVien.LoaiPV;
                excelWs.Range["G" + row].Value = PhongVien.SoGioLam;
                excelWs.Range["H" + row].Value = PhongVien.PhuCap;
            }

            excelWs.Name = "Danh Sach Phong Vien";
            excelWb.Activate();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excelWb.SaveAs(saveFileDialog.FileName);
            }

            excelApp.Quit();
            MessageBox.Show("Xuat excel thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
