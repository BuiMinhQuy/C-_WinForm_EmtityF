
namespace QLPVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQLPV = new System.Windows.Forms.Label();
            this.grbTTPV = new System.Windows.Forms.GroupBox();
            this.grbTacVu = new System.Windows.Forms.GroupBox();
            this.grbDSPV = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblLoaiPV = new System.Windows.Forms.Label();
            this.lblSoGio = new System.Windows.Forms.Label();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSoGio = new System.Windows.Forms.TextBox();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.pnlLoaiPV = new System.Windows.Forms.Panel();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbTaiToaSoan = new System.Windows.Forms.RadioButton();
            this.rdbThuongTru = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXuatEx = new System.Windows.Forms.Button();
            this.lvDSPV = new System.Windows.Forms.ListView();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayVaoLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTPV.SuspendLayout();
            this.grbTacVu.SuspendLayout();
            this.grbDSPV.SuspendLayout();
            this.pnlGioiTinh.SuspendLayout();
            this.pnlLoaiPV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQLPV
            // 
            this.lblQLPV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQLPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLPV.Location = new System.Drawing.Point(5, 4);
            this.lblQLPV.Name = "lblQLPV";
            this.lblQLPV.Size = new System.Drawing.Size(795, 46);
            this.lblQLPV.TabIndex = 0;
            this.lblQLPV.Text = "QUẢN LÝ PHÓNG VIÊN";
            this.lblQLPV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTTPV
            // 
            this.grbTTPV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTTPV.Controls.Add(this.dtp_NgayVaoLam);
            this.grbTTPV.Controls.Add(this.pnlLoaiPV);
            this.grbTTPV.Controls.Add(this.pnlGioiTinh);
            this.grbTTPV.Controls.Add(this.txtPhuCap);
            this.grbTTPV.Controls.Add(this.txtSoGio);
            this.grbTTPV.Controls.Add(this.txtSDT);
            this.grbTTPV.Controls.Add(this.txtHoTen);
            this.grbTTPV.Controls.Add(this.lblPhuCap);
            this.grbTTPV.Controls.Add(this.lblSoGio);
            this.grbTTPV.Controls.Add(this.lblLoaiPV);
            this.grbTTPV.Controls.Add(this.lblNgayVaoLam);
            this.grbTTPV.Controls.Add(this.lblSDT);
            this.grbTTPV.Controls.Add(this.lblGioiTinh);
            this.grbTTPV.Controls.Add(this.lblHoTen);
            this.grbTTPV.Controls.Add(this.lblMaNV);
            this.grbTTPV.Controls.Add(this.txtMaNV);
            this.grbTTPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTPV.Location = new System.Drawing.Point(-1, 59);
            this.grbTTPV.Name = "grbTTPV";
            this.grbTTPV.Size = new System.Drawing.Size(601, 348);
            this.grbTTPV.TabIndex = 1;
            this.grbTTPV.TabStop = false;
            this.grbTTPV.Text = "Thông Tin Phóng Viên";
            // 
            // grbTacVu
            // 
            this.grbTacVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTacVu.Controls.Add(this.btnXuatEx);
            this.grbTacVu.Controls.Add(this.btnThongKe);
            this.grbTacVu.Controls.Add(this.btnSapXep);
            this.grbTacVu.Controls.Add(this.btnSua);
            this.grbTacVu.Controls.Add(this.btnLuu);
            this.grbTacVu.Controls.Add(this.btnXoa);
            this.grbTacVu.Controls.Add(this.btnThem);
            this.grbTacVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTacVu.Location = new System.Drawing.Point(606, 59);
            this.grbTacVu.Name = "grbTacVu";
            this.grbTacVu.Size = new System.Drawing.Size(194, 348);
            this.grbTacVu.TabIndex = 2;
            this.grbTacVu.TabStop = false;
            this.grbTacVu.Text = "Tác Vụ";
            // 
            // grbDSPV
            // 
            this.grbDSPV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbDSPV.Controls.Add(this.lvDSPV);
            this.grbDSPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSPV.Location = new System.Drawing.Point(-1, 413);
            this.grbDSPV.Name = "grbDSPV";
            this.grbDSPV.Size = new System.Drawing.Size(801, 139);
            this.grbDSPV.TabIndex = 2;
            this.grbDSPV.TabStop = false;
            this.grbDSPV.Text = "Danh Sách Phóng Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(226, 43);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(369, 24);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(13, 38);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(118, 29);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã NV :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(13, 77);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(118, 29);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên :";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(13, 129);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(118, 29);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới Tính :";
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(13, 168);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(118, 29);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "SĐT :";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.Location = new System.Drawing.Point(13, 219);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(151, 29);
            this.lblNgayVaoLam.TabIndex = 6;
            this.lblNgayVaoLam.Text = "Ngày Vào Làm :";
            // 
            // lblLoaiPV
            // 
            this.lblLoaiPV.Location = new System.Drawing.Point(13, 260);
            this.lblLoaiPV.Name = "lblLoaiPV";
            this.lblLoaiPV.Size = new System.Drawing.Size(118, 29);
            this.lblLoaiPV.TabIndex = 7;
            this.lblLoaiPV.Text = "Loại PV :";
            // 
            // lblSoGio
            // 
            this.lblSoGio.Location = new System.Drawing.Point(13, 304);
            this.lblSoGio.Name = "lblSoGio";
            this.lblSoGio.Size = new System.Drawing.Size(185, 29);
            this.lblSoGio.TabIndex = 8;
            this.lblSoGio.Text = "Số Giờ Làm Thêm :";
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.Location = new System.Drawing.Point(13, 322);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(118, 29);
            this.lblPhuCap.TabIndex = 9;
            this.lblPhuCap.Text = "Phụ Cấp :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(226, 77);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(369, 24);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(226, 165);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(369, 24);
            this.txtSDT.TabIndex = 11;
            // 
            // txtSoGio
            // 
            this.txtSoGio.Location = new System.Drawing.Point(226, 297);
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(369, 24);
            this.txtSoGio.TabIndex = 12;
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(226, 322);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(369, 24);
            this.txtPhuCap.TabIndex = 13;
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.rdbNu);
            this.pnlGioiTinh.Controls.Add(this.rdbNam);
            this.pnlGioiTinh.Location = new System.Drawing.Point(230, 120);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(365, 28);
            this.pnlGioiTinh.TabIndex = 14;
            // 
            // pnlLoaiPV
            // 
            this.pnlLoaiPV.Controls.Add(this.rdbThuongTru);
            this.pnlLoaiPV.Controls.Add(this.rdbTaiToaSoan);
            this.pnlLoaiPV.Location = new System.Drawing.Point(226, 260);
            this.pnlLoaiPV.Name = "pnlLoaiPV";
            this.pnlLoaiPV.Size = new System.Drawing.Size(365, 28);
            this.pnlLoaiPV.TabIndex = 15;
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(228, 225);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(367, 24);
            this.dtp_NgayVaoLam.TabIndex = 16;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(3, 4);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(63, 24);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(146, 4);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(49, 24);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbTaiToaSoan
            // 
            this.rdbTaiToaSoan.AutoSize = true;
            this.rdbTaiToaSoan.Checked = true;
            this.rdbTaiToaSoan.Location = new System.Drawing.Point(4, 1);
            this.rdbTaiToaSoan.Name = "rdbTaiToaSoan";
            this.rdbTaiToaSoan.Size = new System.Drawing.Size(133, 24);
            this.rdbTaiToaSoan.TabIndex = 1;
            this.rdbTaiToaSoan.TabStop = true;
            this.rdbTaiToaSoan.Text = "Tại Tòa Soạn";
            this.rdbTaiToaSoan.UseVisualStyleBackColor = true;
            this.rdbTaiToaSoan.CheckedChanged += new System.EventHandler(this.rdbTaiToaSoan_CheckedChanged);
            // 
            // rdbThuongTru
            // 
            this.rdbThuongTru.Location = new System.Drawing.Point(184, 1);
            this.rdbThuongTru.Name = "rdbThuongTru";
            this.rdbThuongTru.Size = new System.Drawing.Size(159, 24);
            this.rdbThuongTru.TabIndex = 2;
            this.rdbThuongTru.TabStop = true;
            this.rdbThuongTru.Text = "Thường Trú";
            this.rdbThuongTru.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(50, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(50, 132);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 30);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(50, 83);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(50, 211);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(95, 30);
            this.btnSapXep.TabIndex = 4;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(50, 254);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 30);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.Location = new System.Drawing.Point(36, 294);
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.Size = new System.Drawing.Size(111, 30);
            this.btnXuatEx.TabIndex = 6;
            this.btnXuatEx.Text = "Xuất Excel";
            this.btnXuatEx.UseVisualStyleBackColor = true;
            this.btnXuatEx.Click += new System.EventHandler(this.btnXuatEx_Click);
            // 
            // lvDSPV
            // 
            this.lvDSPV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.HoTen,
            this.GioiTinh,
            this.NgayVaoLam});
            this.lvDSPV.FullRowSelect = true;
            this.lvDSPV.GridLines = true;
            this.lvDSPV.HideSelection = false;
            this.lvDSPV.Location = new System.Drawing.Point(0, 23);
            this.lvDSPV.Name = "lvDSPV";
            this.lvDSPV.Size = new System.Drawing.Size(801, 116);
            this.lvDSPV.TabIndex = 0;
            this.lvDSPV.UseCompatibleStateImageBehavior = false;
            this.lvDSPV.View = System.Windows.Forms.View.Details;
            this.lvDSPV.SelectedIndexChanged += new System.EventHandler(this.lvDSPV_SelectedIndexChanged);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.Width = 200;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.Width = 270;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới Tính";
            this.GioiTinh.Width = 150;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.Text = "Ngày Vào Làm";
            this.NgayVaoLam.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.grbDSPV);
            this.Controls.Add(this.grbTacVu);
            this.Controls.Add(this.grbTTPV);
            this.Controls.Add(this.lblQLPV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbTTPV.ResumeLayout(false);
            this.grbTTPV.PerformLayout();
            this.grbTacVu.ResumeLayout(false);
            this.grbDSPV.ResumeLayout(false);
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            this.pnlLoaiPV.ResumeLayout(false);
            this.pnlLoaiPV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQLPV;
        private System.Windows.Forms.GroupBox grbTTPV;
        private System.Windows.Forms.GroupBox grbTacVu;
        private System.Windows.Forms.GroupBox grbDSPV;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.Label lblSoGio;
        private System.Windows.Forms.Label lblLoaiPV;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoLam;
        private System.Windows.Forms.Panel pnlLoaiPV;
        private System.Windows.Forms.Panel pnlGioiTinh;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.TextBox txtSoGio;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdbThuongTru;
        private System.Windows.Forms.RadioButton rdbTaiToaSoan;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Button btnXuatEx;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lvDSPV;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader NgayVaoLam;
    }
}

