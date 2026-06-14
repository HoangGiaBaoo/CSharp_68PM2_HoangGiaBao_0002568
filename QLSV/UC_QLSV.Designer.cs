namespace QLSV
{
    partial class UC_QLSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_soBanGhi = new System.Windows.Forms.Label();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.lb_trang = new System.Windows.Forms.Label();
            this.lb_trangLabel = new System.Windows.Forms.Label();
            this.btn_trangCuoi = new System.Windows.Forms.Button();
            this.btn_trangSau = new System.Windows.Forms.Button();
            this.btn_trangTruoc = new System.Windows.Forms.Button();
            this.btn_trangDau = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_xemDanhSach = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.lb_thongTin = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbo_lop = new System.Windows.Forms.ComboBox();
            this.cbo_gioiTinh = new System.Windows.Forms.ComboBox();
            this.lb_lop = new System.Windows.Forms.Label();
            this.lb_gioiTinh = new System.Windows.Forms.Label();
            this.lb_ngaySinh = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.lb_maSV = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_maID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_soBanGhi
            // 
            this.lb_soBanGhi.AutoSize = true;
            this.lb_soBanGhi.Location = new System.Drawing.Point(725, 713);
            this.lb_soBanGhi.Name = "lb_soBanGhi";
            this.lb_soBanGhi.Size = new System.Drawing.Size(74, 20);
            this.lb_soBanGhi.TabIndex = 55;
            this.lb_soBanGhi.Text = "2 bản ghi";
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AllowUserToAddRows = false;
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Location = new System.Drawing.Point(422, 111);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.ReadOnly = true;
            this.dgv_DSSV.RowHeadersVisible = false;
            this.dgv_DSSV.RowHeadersWidth = 62;
            this.dgv_DSSV.RowTemplate.Height = 28;
            this.dgv_DSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSV.Size = new System.Drawing.Size(747, 542);
            this.dgv_DSSV.TabIndex = 48;
            this.dgv_DSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSV_CellClick);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_timKiem.Location = new System.Drawing.Point(900, 47);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(177, 57);
            this.btn_timKiem.TabIndex = 47;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(422, 62);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(451, 26);
            this.txt_timKiem.TabIndex = 46;
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Location = new System.Drawing.Point(418, 23);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(243, 20);
            this.lb_timKiem.TabIndex = 45;
            this.lb_timKiem.Text = "Tìm kiếm (Mã ID/ Mã lớp/ Tên lớp)";
            // 
            // lb_trang
            // 
            this.lb_trang.AutoSize = true;
            this.lb_trang.Location = new System.Drawing.Point(678, 713);
            this.lb_trang.Name = "lb_trang";
            this.lb_trang.Size = new System.Drawing.Size(31, 20);
            this.lb_trang.TabIndex = 54;
            this.lb_trang.Text = "1/1";
            // 
            // lb_trangLabel
            // 
            this.lb_trangLabel.AutoSize = true;
            this.lb_trangLabel.Location = new System.Drawing.Point(631, 713);
            this.lb_trangLabel.Name = "lb_trangLabel";
            this.lb_trangLabel.Size = new System.Drawing.Size(50, 20);
            this.lb_trangLabel.TabIndex = 53;
            this.lb_trangLabel.Text = "Trang";
            // 
            // btn_trangCuoi
            // 
            this.btn_trangCuoi.Location = new System.Drawing.Point(916, 684);
            this.btn_trangCuoi.Name = "btn_trangCuoi";
            this.btn_trangCuoi.Size = new System.Drawing.Size(84, 78);
            this.btn_trangCuoi.TabIndex = 52;
            this.btn_trangCuoi.Text = ">>";
            this.btn_trangCuoi.UseVisualStyleBackColor = true;
            this.btn_trangCuoi.Click += new System.EventHandler(this.btn_trangCuoi_Click);
            // 
            // btn_trangSau
            // 
            this.btn_trangSau.Location = new System.Drawing.Point(826, 684);
            this.btn_trangSau.Name = "btn_trangSau";
            this.btn_trangSau.Size = new System.Drawing.Size(84, 78);
            this.btn_trangSau.TabIndex = 51;
            this.btn_trangSau.Text = ">";
            this.btn_trangSau.UseVisualStyleBackColor = true;
            this.btn_trangSau.Click += new System.EventHandler(this.btn_trangSau_Click);
            // 
            // btn_trangTruoc
            // 
            this.btn_trangTruoc.Location = new System.Drawing.Point(531, 684);
            this.btn_trangTruoc.Name = "btn_trangTruoc";
            this.btn_trangTruoc.Size = new System.Drawing.Size(84, 78);
            this.btn_trangTruoc.TabIndex = 50;
            this.btn_trangTruoc.Text = "<";
            this.btn_trangTruoc.UseVisualStyleBackColor = true;
            this.btn_trangTruoc.Click += new System.EventHandler(this.btn_trangTruoc_Click);
            // 
            // btn_trangDau
            // 
            this.btn_trangDau.Location = new System.Drawing.Point(441, 684);
            this.btn_trangDau.Name = "btn_trangDau";
            this.btn_trangDau.Size = new System.Drawing.Size(84, 78);
            this.btn_trangDau.TabIndex = 49;
            this.btn_trangDau.Text = "<<";
            this.btn_trangDau.UseVisualStyleBackColor = true;
            this.btn_trangDau.Click += new System.EventHandler(this.btn_trangDau_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(20, 596);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(177, 57);
            this.btn_xoa.TabIndex = 42;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_xemDanhSach
            // 
            this.btn_xemDanhSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xemDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemDanhSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xemDanhSach.Location = new System.Drawing.Point(20, 684);
            this.btn_xemDanhSach.Name = "btn_xemDanhSach";
            this.btn_xemDanhSach.Size = new System.Drawing.Size(374, 57);
            this.btn_xemDanhSach.TabIndex = 44;
            this.btn_xemDanhSach.Text = "Xem danh sách sinh viên";
            this.btn_xemDanhSach.UseVisualStyleBackColor = false;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_lamMoi.Location = new System.Drawing.Point(217, 596);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(177, 57);
            this.btn_lamMoi.TabIndex = 43;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = false;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // lb_thongTin
            // 
            this.lb_thongTin.AutoSize = true;
            this.lb_thongTin.Location = new System.Drawing.Point(24, 23);
            this.lb_thongTin.Name = "lb_thongTin";
            this.lb_thongTin.Size = new System.Drawing.Size(140, 20);
            this.lb_thongTin.TabIndex = 38;
            this.lb_thongTin.Text = "Thông tin sinh viên";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Location = new System.Drawing.Point(217, 514);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(177, 57);
            this.btn_sua.TabIndex = 41;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(20, 514);
            this.btn_them.Name = "btn_them";
            this.btn_them.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_them.Size = new System.Drawing.Size(177, 57);
            this.btn_them.TabIndex = 40;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ngaySinh);
            this.panel1.Controls.Add(this.cbo_lop);
            this.panel1.Controls.Add(this.cbo_gioiTinh);
            this.panel1.Controls.Add(this.lb_lop);
            this.panel1.Controls.Add(this.lb_gioiTinh);
            this.panel1.Controls.Add(this.lb_ngaySinh);
            this.panel1.Controls.Add(this.lb_hoTen);
            this.panel1.Controls.Add(this.lb_maSV);
            this.panel1.Controls.Add(this.txt_hoTen);
            this.panel1.Controls.Add(this.txt_maID);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(20, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 451);
            this.panel1.TabIndex = 39;
            // 
            // ngaySinh
            // 
            this.ngaySinh.CustomFormat = "dd/MM/yyyy";
            this.ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaySinh.Location = new System.Drawing.Point(34, 207);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(296, 26);
            this.ngaySinh.TabIndex = 12;
            // 
            // cbo_lop
            // 
            this.cbo_lop.FormattingEnabled = true;
            this.cbo_lop.Location = new System.Drawing.Point(34, 361);
            this.cbo_lop.Name = "cbo_lop";
            this.cbo_lop.Size = new System.Drawing.Size(296, 28);
            this.cbo_lop.TabIndex = 11;
            // 
            // cbo_gioiTinh
            // 
            this.cbo_gioiTinh.FormattingEnabled = true;
            this.cbo_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbo_gioiTinh.Location = new System.Drawing.Point(34, 283);
            this.cbo_gioiTinh.Name = "cbo_gioiTinh";
            this.cbo_gioiTinh.Size = new System.Drawing.Size(296, 28);
            this.cbo_gioiTinh.TabIndex = 10;
            // 
            // lb_lop
            // 
            this.lb_lop.AutoSize = true;
            this.lb_lop.Location = new System.Drawing.Point(30, 338);
            this.lb_lop.Name = "lb_lop";
            this.lb_lop.Size = new System.Drawing.Size(40, 20);
            this.lb_lop.TabIndex = 8;
            this.lb_lop.Text = "Lớp:";
            // 
            // lb_gioiTinh
            // 
            this.lb_gioiTinh.AutoSize = true;
            this.lb_gioiTinh.Location = new System.Drawing.Point(30, 259);
            this.lb_gioiTinh.Name = "lb_gioiTinh";
            this.lb_gioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lb_gioiTinh.TabIndex = 7;
            this.lb_gioiTinh.Text = "Giới tính:";
            // 
            // lb_ngaySinh
            // 
            this.lb_ngaySinh.AutoSize = true;
            this.lb_ngaySinh.Location = new System.Drawing.Point(30, 184);
            this.lb_ngaySinh.Name = "lb_ngaySinh";
            this.lb_ngaySinh.Size = new System.Drawing.Size(82, 20);
            this.lb_ngaySinh.TabIndex = 6;
            this.lb_ngaySinh.Text = "Ngày sinh:";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Location = new System.Drawing.Point(30, 105);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(81, 20);
            this.lb_hoTen.TabIndex = 5;
            this.lb_hoTen.Text = "Họ và tên:";
            // 
            // lb_maSV
            // 
            this.lb_maSV.AutoSize = true;
            this.lb_maSV.Location = new System.Drawing.Point(30, 28);
            this.lb_maSV.Name = "lb_maSV";
            this.lb_maSV.Size = new System.Drawing.Size(100, 20);
            this.lb_maSV.TabIndex = 4;
            this.lb_maSV.Text = "Mã sinh viên:";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(34, 128);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(296, 26);
            this.txt_hoTen.TabIndex = 1;
            // 
            // txt_maID
            // 
            this.txt_maID.AcceptsTab = true;
            this.txt_maID.Location = new System.Drawing.Point(34, 51);
            this.txt_maID.Name = "txt_maID";
            this.txt_maID.Size = new System.Drawing.Size(296, 26);
            this.txt_maID.TabIndex = 0;
            // 
            // UC_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_soBanGhi);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.lb_timKiem);
            this.Controls.Add(this.lb_trang);
            this.Controls.Add(this.lb_trangLabel);
            this.Controls.Add(this.btn_trangCuoi);
            this.Controls.Add(this.btn_trangSau);
            this.Controls.Add(this.btn_trangTruoc);
            this.Controls.Add(this.btn_trangDau);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xemDanhSach);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.lb_thongTin);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.panel1);
            this.Name = "UC_QLSV";
            this.Size = new System.Drawing.Size(1192, 791);
            this.Load += new System.EventHandler(this.UC_QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_soBanGhi;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Label lb_timKiem;
        private System.Windows.Forms.Label lb_trang;
        private System.Windows.Forms.Label lb_trangLabel;
        private System.Windows.Forms.Button btn_trangCuoi;
        private System.Windows.Forms.Button btn_trangSau;
        private System.Windows.Forms.Button btn_trangTruoc;
        private System.Windows.Forms.Button btn_trangDau;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xemDanhSach;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Label lb_thongTin;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker ngaySinh;
        private System.Windows.Forms.ComboBox cbo_lop;
        private System.Windows.Forms.ComboBox cbo_gioiTinh;
        private System.Windows.Forms.Label lb_lop;
        private System.Windows.Forms.Label lb_gioiTinh;
        private System.Windows.Forms.Label lb_ngaySinh;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label lb_maSV;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_maID;
    }
}
